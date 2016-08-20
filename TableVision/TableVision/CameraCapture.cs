using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV.Structure;
using Emgu.CV;
namespace TableVision
{
    class CameraCapture
    {
        private Capture camera;
        private Image<Bgr, byte> frame;
        private bool state;
        public CameraCapture(int device)
        {
            camera = new Capture(0);
            camera.ImageGrabbed += ProcessFrame;
        }

        public event EventHandler grab;

        public void ProcessFrame(object sender, EventArgs args)
        {
            camera.Retrieve(this.frame);
        }

        public void Start()
        {
            camera.Start();
        }

        public Image<Bgr, byte> getFrame
        {
            get { return this.frame; }
        }
    }
}
