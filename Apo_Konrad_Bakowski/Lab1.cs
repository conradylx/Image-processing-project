using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apo_Konrad_Bakowski
{
    public static class Lab1
    {
        public enum Metody
        {
            Srednich,
            Losowa,
            Sasiedztwa,
            Wlasna,
            Wlasna2
        }

        //wyrownywanie
        //rozciaganie

        public static Bitmap Equalization(Bitmap image)
        {
            // Convert a BGR image to HLS range
            Emgu.CV.Image<Hls, Byte> imageHsi = new Image<Hls, Byte>(image);

            // Equalize the Intensity Channel
            Image<Gray, Byte> imageL = imageHsi[1];
            imageL._EqualizeHist();
            imageHsi[1] = imageL;

            // Convert the image back to BGR range
            Emgu.CV.Image<Bgr, Byte> imageBgr = imageHsi.Convert<Bgr, Byte>();

            return imageBgr.ToBitmap();
        }
    }
}
