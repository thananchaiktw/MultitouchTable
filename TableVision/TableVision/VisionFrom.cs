using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Cuda;
using Emgu.CV.CvEnum;
using System.Threading;
using Emgu.CV.Structure;
using Emgu.CV.Cvb;
using TUIO;

namespace TableVision
{
    public partial class VisionFrom : Form
    {
        private Mat frame;
        private Mat gray;
        private Mat background;
        private Mat highpass;
        private Mat lowpass;
        private Mat subtract;
        private Mat bandpass;
        private Mat threshold;
        private Image<Bgr, byte> output;
        private Capture camera;
        private TuioServer server;
        private TuioTime time;
        private CvBlobs blobs;
        private CvTracks track;
        public VisionFrom()
        {
            time = new TuioTime(DateTime.Now.Millisecond);
            server = new TuioServer();
            server.initFrame(time);
            blobs = new CvBlobs();
            track = new CvTracks();
            //sever.updateTuioCursor(new TuioCursor())
            //camera = new Capture("C:\\Users\\tae\\Desktop\\pic senior project\\out.avi");
            camera = new Capture(0);
            frame = new Mat();
            gray = new Mat();
            background = new Mat();
            highpass = new Mat();
            lowpass = new Mat();
            subtract = new Mat();
            bandpass = new Mat();
            threshold = new Mat();
            //output = Image<Bgr, byte>;
            InitializeComponent();
            Application.Idle += ProcessFrame;
        }

        public void ProcessFrame(object sender, EventArgs args)
        {
            //Thread.Sleep(5000 / (int)camera.GetCaptureProperty(CapProp.Fps));
            if (this.background.IsEmpty)
            {
                this.background = camera.QueryFrame();
                this.background = toGray(this.background);
            }
            this.frame = camera.QueryFrame();
            this.frame = toGray(this.frame);
            this.subtract = subtraction(this.frame, this.background);
            this.lowpass = GussianBlur(this.subtract, lptrackBar.Value * 2 + 1, 1.5);
            this.highpass = Highpass(this.lowpass, hptrackBar.Value * 2 + 1, noisetrackBar.Value * 2 + 1);
            this.bandpass = Amplifiler(this.highpass, AmptrackBar.Value);
            this.threshold = Threshold(this.bandpass, ThresholdtrackBar.Value*2 +1, -7);
            DetectBlob(this.threshold);
            sourceImg.Image = this.frame.ToImage<Gray, byte>().Resize(480, 304, Inter.Nearest);
            backgroundImg.Image = this.background.ToImage<Gray, byte>().Resize(190, 166, Inter.Nearest);
            subtractImg.Image = subtract.ToImage<Gray, byte>().Resize(190, 166, Inter.Nearest);
            lpImg.Image = lowpass.ToImage<Gray, byte>().Resize(190, 166, Inter.Nearest);
            hpImg.Image = highpass.ToImage<Gray, byte>().Resize(190, 166, Inter.Nearest);
            bpImg.Image = bandpass.ToImage<Gray, byte>().Resize(190, 166, Inter.Nearest);
            outputImg.Image = output;
        }

        private Mat subtraction(Mat source, Mat backgroud)
        {
            Mat output = new Mat();
            CvInvoke.Subtract(source, backgroud, output);
            output.ConvertTo(output, DepthType.Cv8U, 0.1, 0);
            return output;
        }

        private Mat toGray(Mat soucre)
        {
            Mat output = new Mat();
            CvInvoke.CvtColor(soucre, output, ColorConversion.Bgr2Gray);
            return output;
        }
        private Mat GussianBlur(Mat source, int size, double sigma)
        {
            Mat output = new Mat();
            CvInvoke.GaussianBlur(source, output, new Size(size, size), sigma, sigma);
            return output;
        }
        private Mat Diff(Mat source1, Mat source2)
        {
            Mat output = new Mat();
            CvInvoke.AbsDiff(source1, source2, output);
            return output;
        }
        private Mat Threshold(Mat source, int blockSize, double param)
        {
            Mat output = new Mat();
            CvInvoke.AdaptiveThreshold(source, output, 255, AdaptiveThresholdType.MeanC, ThresholdType.Binary, blockSize, param);
            return output;
        }

        public Mat Highpass(Mat source, int blur1, int blur2)
        {

            Mat output = new Mat();
            CvInvoke.Blur(source, output, new Size(blur1, blur1), new Point(-1, -1));
            CvInvoke.Subtract(source, output, output);
            CvInvoke.Blur(output, output, new Size(blur2, blur2), new Point(-1, -1));
            return output;
        }

        public void DetectBlob(Mat source)
        {
            Image<Gray, byte> img = source.ToImage<Gray, byte>(); /// convert to Image for use in method detect
            //CvTracks track = new CvTracks();
            CvBlobDetector detector = new CvBlobDetector();
            detector.Detect(img, blobs); /// detect blob
            //blobs.FilterByArea(20, 500); /// filter area
            track.Update(blobs, 100, 17, 11); /// tracking blob
            //Console.WriteLine(track.Count);
            Image<Bgr, byte> img_detect = source.ToImage<Bgr, byte>();
            IEnumerator<KeyValuePair<uint,CvTrack>> iterator = track.GetEnumerator();
            while (iterator.MoveNext())
            {
                CvTrack t = iterator.Current.Value;
                if (t.Id > 50)
                {
                    track.Clear();
                    server.getTuioCursors().Clear();
                    break;
                }
                SendBlobs(t);
                img_detect.Draw(t.BoundingBox, new Bgr(0, 0, 255), 1); /// draw rectangle
                img_detect.Draw("ID : "+t.Id.ToString(), new Point((int)t.MaxX, (int)t.MinY), FontFace.HersheyPlain, 1, new Bgr(0, 255, 0)); /// draw ID
            }
            this.output = img_detect.Resize(480, 304, Inter.Nearest);
            
        }

        private void SendBlobs(CvTrack t)
        {
            time = new TuioTime(DateTime.Now.Millisecond); 
            server.initFrame(time); /// send time
            TuioCursor cur = server.getTuioCursor(t.Id);
            if (cur != null)
            {
                server.updateTuioCursor(cur, (float)(t.Centroid.X/threshold.Width), (float)(t.Centroid.Y/threshold.Height));
            }else
            {
                server.addTuioCursor((float)(t.Centroid.X / threshold.Width), (float)(t.Centroid.Y / threshold.Height));
            }
            server.commitFrame();
        }

        public Mat Amplifiler(Mat source, int lvl)
        {

            Mat output = new Mat();
            CvInvoke.Multiply(source, source, output, lvl / 128.0f);
            return output;
        }

        private void noisetrackBar_Scroll(object sender, EventArgs e)
        {
            nvalue.Text = (noisetrackBar.Value * 2 + 1).ToString();
        }

        private void AmptrackBar_Scroll(object sender, EventArgs e)
        {
            tvalue.Text = (AmptrackBar.Value * 2 + 1).ToString();
        }

        private void hptrackBar_Scroll(object sender, EventArgs e)
        {
            bvalue.Text = (hptrackBar.Value * 2 + 1).ToString();
        }
        private void lptrackBar_Scroll(object sender, EventArgs e)
        {
            svalue.Text = (lptrackBar.Value * 2 + 1).ToString();
        }

        private void ThresholdtrackBar_Scroll(object sender, EventArgs e)
        {
            thresholdvalue.Text = (ThresholdtrackBar.Value * 2 + 1).ToString();
        }
    }
}
