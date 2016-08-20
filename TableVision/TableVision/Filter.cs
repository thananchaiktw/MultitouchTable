using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            
            return source.SmoothGaussian(ksize);
        }

        public Image<Gray, byte> HighPass(Image<Gray, byte> source,int size,int ksize)
        {
            Image<Gray, byte> result;
            result = source.SmoothBlur(size,size);
            result = source.Sub(result);
            result = result.SmoothGaussian(ksize);
            result = result.SmoothMedian(ksize);
            //result.Dilate(3);
            return result;
        }

        public Image<Gray, byte> Amplifly(Image<Gray, byte> source, double scale)
        {
            return source.ConvertScale<byte>(0.04,0).Mul(scale).SmoothBlur(3,3);
        }

        public Image<Gray, byte> Threshold(Image<Gray, byte> source,int bsize,int param)
        {
            return source.ThresholdAdaptive(new Gray(255), Emgu.CV.CvEnum.AdaptiveThresholdType.MeanC, Emgu.CV.CvEnum.ThresholdType.Binary, bsize,new Gray(param));
        }

    }
}
