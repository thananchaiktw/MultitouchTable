using Emgu.CV;
using Emgu.CV.Structure;


namespace TableVision
{
    class Filter
    {
        public Image<Gray,byte> Subtract(Image<Gray, byte> img1, Image<Gray, byte> img2)
        {
            //Image<Gray, byte> result = new Image<Gray, byte>(img1.Width,img1.Height);
            //CvInvoke.FastNlMeansDenoising(img1, result);
            
            return img1.Sub(img2);
        }

        public Image<Gray, byte> Gaussian(Image<Gray, byte> source,int ksize)
        {

            return source.SmoothBlur(ksize, ksize);
        }

        public Image<Gray, byte> HighPass(Image<Gray, byte> source,int size,int ksize)
        {
            Image<Gray, byte> result;
            result = source.SmoothGaussian(size);
            result = source.Sub(result);
            result = result.SmoothBlur(ksize, ksize);
            //result = result.Erode(1);
            //result.Dilate(3);
            return result;
        }

        public Image<Gray, byte> Amplifly(Image<Gray, byte> source, double scale)
        {
            return source/*.InRange(new Gray(100), new Gray(255))*/.Mul(scale);
        }

        public Image<Gray, byte> Threshold(Image<Gray, byte> source,int min)
        {
            return source.ThresholdBinary(new Gray(min), new Gray(255));/*source.ThresholdAdaptive(new Gray(255), Emgu.CV.CvEnum.AdaptiveThresholdType.MeanC, Emgu.CV.CvEnum.ThresholdType.Binary, bsize,new Gray(param));*/
        }

    }
}
