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
        private Image<Gray, byte> background;
        private Image<Gray, byte> highpass;
        private Image<Gray, byte> lowpass;
        private Image<Gray, byte> subtract;
        private Image<Gray, byte> amp;
        private Image<Gray, byte> threshold;
        private Image<Bgr, byte> output;
        private Capture camera;
        private Filter filter;
        private DetectBlob detector;
        private int lp;
        private int hp;
        private int hp_ksize;
        private int mul;
        private int thd;
        private int min;
        private int max;
        private bool _capture;
        public VisionFrom()
        {
            
            InitializeComponent();
            lp = lptrackBar.Value * 2 + 1;
            hp = hptrackBar.Value * 2 + 1;
            hp_ksize = noisetrackBar.Value * 2 + 1;
            mul = AmptrackBar.Value * 2 + 1;
            thd = ThresholdtrackBar.Value;
            min = mintrackBar.Value;
            max = maxtrackBar.Value;
            detector = new DetectBlob();
            filter = new Filter();
            camera = new Capture();
            _capture = true;
            //camera.ImageGrabbed += ProcessFrame;
            frame = new Mat();
            //camera.Start();

            Application.Idle += ProcessFrame;
        }

        public void ProcessFrame(object sender, EventArgs args)
        {
            this.frame = camera.QuerySmallFrame();
            //camera.Retrieve(this.frame);
            Image<Gray, byte> gray = this.frame.ToImage<Gray, byte>();
            
            if(background == null)
            {
                this.background=gray.Copy();
            }
            //this.frame.c
            
            this.subtract = filter.Subtract(gray, this.background.Copy());
            this.lowpass = filter.Gaussian(this.subtract.Copy(), lp);
            this.highpass = filter.HighPass(this.lowpass.Copy(), hp, hp_ksize);
            this.amp = filter.Amplifly(this.highpass.Copy(), mul*2+1);
            this.threshold = filter.Threshold(this.amp, thd*2+1, -5);
            this.output = detector.detect(this.threshold.Copy(), min,max);
            sourceImg.Image = gray.Resize(sourceImg.Width,sourceImg.Height,Inter.Nearest);
            backgroundImg.Image = this.background.Copy().Resize(backgroundImg.Width,backgroundImg.Height,Inter.Nearest);
            subtractImg.Image = this.subtract.Resize(subtractImg.Width, subtractImg.Height, Inter.Nearest);
            lpImg.Image = this.lowpass.Resize(lpImg.Width, lpImg.Height, Inter.Nearest);
            hpImg.Image = this.highpass.Resize(hpImg.Width, hpImg.Height, Inter.Nearest);
            bpImg.Image = this.amp.Resize(bpImg.Width, bpImg.Height, Inter.Nearest);
            outputImg.Image = this.output.Resize(outputImg.Width, outputImg.Height, Inter.Nearest);
            //Console.WriteLine(camera.GetCaptureProperty(CapProp.Fps));
        }
        private void button1_Click(object sender, EventArgs e)
        {
            _capture = !_capture;
           if (_capture)
           {
                camera.Start();
                button1.Text = "Pause";
           }
            else
           {
                camera.Stop();
                button1.Text = "Start";
           }
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
            this.mul = AmptrackBar.Value * 2 + 1;
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
