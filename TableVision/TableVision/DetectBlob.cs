using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;
using Emgu.CV.Cvb;
using Emgu.CV.Structure;
using TUIO;
using System.Drawing;
using Emgu.CV.CvEnum;

namespace TableVision
{
    class DetectBlob
    {
        private CvBlobDetector detector;
        private CvBlobs blobs;
        private CvTracks tracks;
        private TuioServer server;
        private TuioTime time;


        public DetectBlob()
        {
            this.detector = new CvBlobDetector();
            this.blobs = new CvBlobs();
            this.tracks = new CvTracks();
            this.time = new TuioTime(DateTime.Now.Millisecond);
            this.server = new TuioServer();
            this.server.initFrame(time);
        }

        public Image<Bgr, byte> detect(Image<Gray, byte> image,int Min_area, int Max_area)
        {
            Image<Bgr, byte> result = image.Convert<Bgr, byte>();
             this.detector.Detect(image, blobs);
            this.blobs.FilterByArea(Min_area, Max_area);
            this.tracks.Update(blobs, 10, 25, 20);
            IEnumerator<KeyValuePair<uint, CvTrack>> iterator = this.tracks.GetEnumerator();
            while (iterator.MoveNext())
            {
                CvTrack t = iterator.Current.Value;
                result.Draw(t.BoundingBox, new Bgr(0, 0, 255), 1);
                result.Draw("ID : " + t.Id.ToString(), new Point((int)t.MaxX, (int)t.MinY), FontFace.HersheyPlain, 1, new Bgr(0, 255, 0)); /// draw ID
                sendTrack(t, result.Width, result.Height);
            }
            return result;
        }

        private void sendTrack(CvTrack track,int width,int height)
        {
            time = new TuioTime(DateTime.Now.Millisecond);
            server.initFrame(time); /// send time
            TuioCursor cur = server.getTuioCursor(track.Id);
            if (cur != null)
            {
                server.updateTuioCursor(cur, (float)(track.Centroid.X / width), (float)(track.Centroid.Y /height));
            }
            else
            {
                server.addTuioCursor((float)(track.Centroid.X / width), (float)(track.Centroid.Y / height));
            }
            server.stopUntouchedMovingCursors();
            server.removeUntouchedStoppedCursors();
            server.commitFrame();
        }
    }
}
