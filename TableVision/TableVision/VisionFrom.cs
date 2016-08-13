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
        public VisionFrom()
        {
            time = new TuioTime(DateTime.Now.Millisecond);
            server = new TuioServer();
            server.initFrame(time);

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
            //this.frame.CopyTo(this.output);
            //this.output = this.frame.;
            this.subtract = subtraction(this.frame, this.background);
            this.lowpass = GussianBlur(this.subtract, lptrackBar.Value * 2 + 1, 1.5);
            this.highpass = Highpass(this.lowpass, hptrackBar.Value * 2 + 1, noisetrackBar.Value * 2 + 1);
            this.bandpass = Amplifiler(this.highpass, AmptrackBar.Value);
            this.threshold = Threshold(this.bandpass, ThresholdtrackBar.Value*2 +1, -5);
            DetectBlob(this.threshold);
            sourceImg.Image = this.frame;
            backgroundImg.Image = this.background;
            subtractImg.Image = subtract;
            lpImg.Image = lowpass;
            hpImg.Image = highpass;
            bpImg.Image = threshold;
            outputImg.Image = output;
        }

        private Mat subtraction(Mat source, Mat backgroud)
        {
            Mat output = new Mat();
            CvInvoke.Subtract(source, backgroud, output);
            output.ConvertTo(output, DepthType.Cv8U, 0.04, 0);
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
            Image<Gray, byte> img = source.ToImage<Gray, byte>();
            CvBlobs blobs = new CvBlobs();
            CvTracks track = new CvTracks();
            CvBlobDetector detector = new CvBlobDetector();
            detector.Detect(img, blobs);
            Image<Bgr, byte> detect = camera.QueryFrame().ToImage<Bgr, byte>();
            detect = detector.DrawBlobs(img, blobs, CvBlobDetector.BlobRenderType.Default, 1);
            SendBlobs(blobs);
            this.output = detect;
            
        }

        private void SendBlobs(CvBlobs blobs)
        {
            time = new TuioTime(DateTime.Now.Millisecond);
            server.initFrame(time);
            for (int i = 0; i < blobs.Count; i++)
            {
                CvBlob b;
                blobs.TryGetValue((uint)i, out b);
                if (b != null)
                {
                    TuioCursor cur = server.getTuioCursor(i);
                    if (cur != (null))
                    {
                        if ((int)b.Label == cur.CursorID)
                        {
                            server.updateTuioCursor(server.getTuioCursor(i), (float)b.Centroid.X / threshold.Width, (float)b.Centroid.Y / threshold.Height);
                        }
                    }
                    else
                    {
                        server.addTuioCursor((float)b.Centroid.X / threshold.Width, (float)b.Centroid.Y / threshold.Height);
                        Console.WriteLine(b.Centroid.X + " , " + b.Centroid.Y);
                    }
                }
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
            nvalue.Text = noisetrackBar.Value.ToString();
        }

        private void AmptrackBar_Scroll(object sender, EventArgs e)
        {
            tvalue.Text = AmptrackBar.Value.ToString();
        }

        private void hptrackBar_Scroll(object sender, EventArgs e)
        {
            bvalue.Text = hptrackBar.Value.ToString();
        }
        private void lptrackBar_Scroll(object sender, EventArgs e)
        {
            svalue.Text = lptrackBar.Value.ToString();
        }

        private void ThresholdtrackBar_Scroll(object sender, EventArgs e)
        {
            thresholdvalue.Text = (ThresholdtrackBar.Value * 2 + 1).ToString();
        }
    }
}
