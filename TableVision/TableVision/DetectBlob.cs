using System;
using System.Collections.Generic;
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
        private bool send;
        private Image<Gray, byte> simage;

        public DetectBlob()
        {
            this.detector = new CvBlobDetector();
            this.blobs = new CvBlobs();
            this.tracks = new CvTracks();
            this.time = new TuioTime(DateTime.Now.Millisecond);
            this.server = new TuioServer();
            this.server.initFrame(time);
            this.send = false;
        }

        private void updateTrack(CvTrack track, int width, int height)
        {
            TuioCursor cur = server.getTuioCursor(track.Id);
            if (cur != null)
            {
                server.updateTuioCursor(cur, (float)(track.Centroid.X / width), (float)(track.Centroid.Y / height));
            }
            else
            {
                server.addTuioCursor((float)(track.Centroid.X / width), (float)(track.Centroid.Y / height));
            }
        }

        public void detectBlobs(Image<Gray, byte> image, int Min_area, int Max_area)
        {
            this.detector.Detect(image, blobs);/// detect
            this.blobs.FilterByArea(Min_area, Max_area); ///filter blob's area
            this.tracks.Update(blobs, 2, 10, 5); /// 30 Fps
            this.simage = image;
        }

        public PointF[] getBlob()
        {
            IEnumerator<KeyValuePair<uint, CvBlob>> iterator = this.blobs.GetEnumerator();
            PointF[] points = new PointF[blobs.Count];
            while (iterator.MoveNext())
            {
                CvBlob blob = iterator.Current.Value;
                points[iterator.Current.Key-1] = blob.Centroid;
            }
            return points;
        }

        public Image<Bgr, byte> detectImage()
        {
            Image<Bgr, byte> result = simage.Convert<Bgr, byte>();
            if (blobs.Count != 0) /// Empty?
            {
                time = new TuioTime(DateTime.Now.Millisecond);
                server.initFrame(time); /// send time
                IEnumerator<KeyValuePair<uint, CvTrack>> iterator = this.tracks.GetEnumerator();
                while (iterator.MoveNext())
                {
                    CvTrack t = iterator.Current.Value;
                    result.Draw(t.BoundingBox, new Bgr(0, 0, 255), 1);
                    //result.Draw()
                    result.Draw("ID : " + t.Id.ToString()+" POS: "+((int)t.Inactive).ToString()+","+ ((int)t.Active).ToString(), new Point((int)t.MaxX,(int)t.MaxY), FontFace.HersheyPlain, 0.5, new Bgr(0, 255, 0)); /// draw ID
                    if(this.send)
                        updateTrack(t, result.Width, result.Height);
                }
            }

            server.commitFrame();
            //server.stopUntouchedMovingCursors();
            //server.removeUntouchedStoppedCursors();

            return result;
        }

        public bool sendTuioMessange(){
          if (!this.send)
            this.send=true;
            return this.send;
        }
        public void stopTuioMessange(){
            server.Clear();
            this.send = false;
        }

        public bool hasBlob()
        {
          if(this.blobs.Count>0)
          {
            return true;
          }else{
            return false;
          }
        }

        public int countBlobs()
        {
            return blobs.Count;
        }
        //*TODO callibration : first detect 4 point Rigth-Bottom,Rigth-Top,Left-Bottom,Left-Top*//
        //*state 1 : Left-Top -> hasBlob? if blob>1 return again else to state 2*//
        /*public void callibration(){
          int state
        }*/
    }
}
