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
using Emgu.CV.CvEnum;
using System.Threading;
using Emgu.CV.Structure;
using Emgu.CV.Cvb;
using TUIO;
using Emgu.CV.Util;
using DirectShowLib;

namespace TableVision
{
    public partial class VisionFrom : Form
    {
        #region Image variable

        private Mat frame;
        private Image<Gray, byte> background; // background image
        private Image<Gray, byte> highpass; // highpass filter image
        private Image<Gray, byte> lowpass; // lowpass filter image
        private Image<Gray, byte> subtract; // background subtraction image
        private Image<Gray, byte> amp; // amp mul
        private Image<Gray, byte> threshold; // threshold image
        private Image<Bgr, byte> output; // result
        
        #endregion

        #region Value

        private int lp; // low pass
        private int hp; // high pass
        private int hp_ksize; // kernel size
        private int mul; // multiply value
        private int thd; // thresh value
        private int min; // blob min size
        private int max; // blob max size

        #endregion

        private Capture camera;
        private Filter filter;
        private DetectBlob detector;
        private int index = 0;

        private DsDevice[] cam_device;

        private bool calibrate_mode;
        private Mat matrix;
        VectorOfPointF srcs;
        private VectorOfPointF calibrate_point;
        PointF[] point = new PointF[4];

        public VisionFrom()
        {
            cam_device = DsDevice.GetDevicesOfCat(FilterCategory.VideoInputDevice);

            InitializeComponent();
            
            #region Trackbar variable

            lp = lptrackBar.Value * 2 + 1; /// lowpass value
            hp = hptrackBar.Value * 2 + 1; /// highpass value
            hp_ksize = noisetrackBar.Value * 2 + 1; /// highpass kernel size value
            mul = AmptrackBar.Value; /// multiply value
            thd = ThresholdtrackBar.Value; /// threshold value
            min = mintrackBar.Value; /// min blob area
            max = maxtrackBar.Value; /// max blob area

            #endregion

            
            Console.WriteLine(cam_device[0].Name);
            detector = new DetectBlob();
            filter = new Filter();
            camera = new Capture(0);
            frame = new Mat();
            calibrate_mode = false;

            Application.Idle += ProcessFrame;
            
            
        }

        int count = 0;
        PointF[] s = new PointF[4];

        public void drawCircle(Image<Bgr, byte> img,float xpos,float ypos,float rd, Bgr color)
        {
            img.Draw(new CircleF(new PointF(xpos, ypos), rd), color,2);
        }

        public void ProcessFrame(object sender, EventArgs args)
        {
            this.frame = camera.QuerySmallFrame();
        
            s[0] = new PointF(0, 0);
            s[1] = new PointF(this.frame.Width, 0);
            s[2] = new PointF(0, this.frame.Height);
            s[3] = new PointF(this.frame.Width, this.frame.Height);
            srcs = new VectorOfPointF(s);

            calibrate();

            Image<Gray, byte> gray = this.frame.ToImage<Gray, byte>();

            if (background == null)
            {
                this.background=gray;
            }
            double amp = mul/6.0f;
            this.subtract = filter.Subtract(gray, this.background);            
            this.lowpass = filter.Gaussian(this.subtract, lp);
            this.highpass = filter.HighPass(this.lowpass, hp, hp_ksize);
            this.amp = filter.Amplifly(this.highpass, amp);
            this.threshold = filter.Threshold(this.amp, thd);
            this.detector.detectBlobs(this.threshold, this.min, this.max);

            if (calibrate_mode)
            {
                
                if (index < 4)
                {
                    drawCircle(this.output, s[index].X, s[index].Y, 10, new Bgr(0, 0, 255));
                    
                    if (this.detector.countBlobs() == 1)
                    {
                        count++;
                        if (count > 10 && point[index] != null)
                        {
                            point[index] = this.detector.getBlob()[0];
                        }
                    }
                    else if (this.detector.countBlobs() == 0 && count > 10)
                    { 
                            index++;
                            this.output = this.output.CopyBlank();
                            count = 0;
                            Console.WriteLine(index);
                    }
                    
                }
                else if (index == 4)
                {
                    calibrate_point.Clear();
                    calibrate_point.Push(point);
                    calibrate_mode = false;
                    index = 0;
                    point = new PointF[4];
                }
            }
            else
            {
                this.detector.sendTuioMessange();
                this.output = detector.detectImage();
            }


            sourceImg.Image = gray.Resize(sourceImg.Width,sourceImg.Height,Inter.Nearest);
            backgroundImg.Image = this.background.Resize(backgroundImg.Width,backgroundImg.Height,Inter.Nearest);
            subtractImg.Image = this.subtract.Resize(subtractImg.Width, subtractImg.Height, Inter.Nearest);
            lpImg.Image = this.lowpass.Resize(lpImg.Width, lpImg.Height, Inter.Nearest);
            hpImg.Image = this.highpass.Resize(hpImg.Width, hpImg.Height, Inter.Nearest);
            bpImg.Image = this.amp.Resize(bpImg.Width, bpImg.Height, Inter.Nearest);
            outputImg.Image = this.output.Resize(outputImg.Width, outputImg.Height, Inter.Nearest);
            //Console.WriteLine(camera.GetCaptureProperty(CapProp.Fps));
        }

        private void calibrate()
        {
            if (calibrate_point == null || calibrate_mode)
            {
                calibrate_point = srcs;
            }
            this.matrix = CvInvoke.GetPerspectiveTransform(calibrate_point, srcs);
            CvInvoke.WarpPerspective(this.frame, this.frame, this.matrix, this.frame.Size);
           
        }

        private void calibrateButton_Click(object sender, EventArgs e)
        {
            calibrate_mode = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            background = null;
        }

        private void noisetrackBar_Scroll(object sender, EventArgs e)
        {
            nvalue.Text = (noisetrackBar.Value).ToString();
            this.hp_ksize = noisetrackBar.Value * 2 + 1;

        }

        private void AmptrackBar_Scroll(object sender, EventArgs e)
        {
            tvalue.Text = (AmptrackBar.Value).ToString();
            this.mul = AmptrackBar.Value;
        }

        private void hptrackBar_Scroll(object sender, EventArgs e)
        {
            bvalue.Text = (hptrackBar.Value).ToString();
            this.hp = hptrackBar.Value * 2 + 1;
        }
        private void lptrackBar_Scroll(object sender, EventArgs e)
        {
            svalue.Text = (lptrackBar.Value).ToString();
            this.lp = lptrackBar.Value * 2 + 1;
        }

        private void ThresholdtrackBar_Scroll(object sender, EventArgs e)
        {
            thresholdvalue.Text = (ThresholdtrackBar.Value).ToString();
            this.thd = ThresholdtrackBar.Value ;
        }

        private void mintrackBar_Scroll(object sender, EventArgs e)
        {
            int value = mintrackBar.Value;
            if (value >= this.max)
            {
                value = this.max;
            }
            minlabel.Text = value.ToString();
            mintrackBar.Value = value;
            this.min = value;
        }

        private void maxtrackBar_Scroll(object sender, EventArgs e)
        {
            int value = maxtrackBar.Value;
            if (value <= this.min)
            {
                value = this.min;
            }
            maxlabel.Text = value.ToString();
            maxtrackBar.Value = value;
            this.max = value;

        }

    }
}
