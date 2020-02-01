using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apo_Konrad_Bakowski
{
    static class Lab2
    {
        //negacja
        //Progowanie
        //progowanie z zachowaniem poziomów szarości, 
        //redukcja poziomów szarości przez posteryzację,
        //rozciąganie z zakresu p1-p2 do zakresu q3-q4,w szczególności gdy q3=0, q4=Lmax

        public static Bitmap Negacja(Bitmap bmp)
        {
            //    for (int x = 0; x < bmp.Width; x++)
            //        for (int y = 0; y < bmp.Height; y++)
            //            bmp[x, y] = (byte)(bmp.Levels - 1 - bmp[x, y]);
            //    return bmp;
            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    //get pixel value
                    Color p = bmp.GetPixel(x, y);

                    //extract ARGB value from p
                    int a = p.A;
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;

                    //find negative value
                    r = 255 - r;
                    g = 255 - g;
                    b = 255 - b;

                    //set new ARGB value in pixel
                    bmp.SetPixel(x, y, Color.FromArgb(a, r, g, b));
                }
            }
            return bmp;
        }

        public static Bitmap Thresholding(Bitmap bmp, int value)
        {
            var grayscale = BitmapHelper.ToGrayscale(bmp);
            for (int x = 0; x < grayscale.Width; x++)
                for (int y = 0; y < grayscale.Height; y++)
                    if (grayscale.GetPixel(x, y).R <= value)
                        grayscale.SetPixel(x, y, Color.FromArgb(0, 0, 0, 0));
                    else
                        grayscale.SetPixel(x, y, Color.FromArgb(255, 255, 255, 255));
            return grayscale;
        }

        public static void ApplyThreshold(ref Bitmap bmp, short thresholdValue)
        {
            int MaxVal = 768;

            if (thresholdValue < 0) return;
            else if (thresholdValue > MaxVal) return;

            BitmapData bmpData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            unsafe
            {
                int TotalRGB;

                byte* ptr = (byte*)bmpData.Scan0.ToPointer();
                int stopAddress = (int)ptr + bmpData.Stride * bmpData.Height;

                while ((int)ptr != stopAddress)
                {
                    TotalRGB = ptr[0] + ptr[1] + ptr[2];

                    if (TotalRGB <= thresholdValue)
                    {
                        ptr[2] = 0;
                        ptr[1] = 0;
                        ptr[0] = 0;
                    }
                    else
                    {
                        ptr[2] = 255;
                        ptr[1] = 255;
                        ptr[0] = 255;
                    }

                    ptr += 3;
                }
            }

            bmp.UnlockBits(bmpData);
        }

        public static Bitmap ThresholdingWithGrayScaleLevel(Bitmap bmp, int p1, int p2)
        {
            var grayscale = BitmapHelper.ToGrayscale(bmp);
            for (int x = 0; x < grayscale.Width; x++)
                for (int y = 0; y < grayscale.Height; y++)
                    if (grayscale.GetPixel(x, y).R <= p1 || grayscale.GetPixel(x, y).R >= p2)
                        grayscale.SetPixel(x, y, Color.FromArgb(0, 0, 0, 0));
            return grayscale;
        }


        public static void ApplyThresholdWithGrayScaleLevel(ref Bitmap bmp, short thresholdValue, short p1, short p2)
        {
            int MaxVal = 768;

            if (thresholdValue < 0) return;
            else if (thresholdValue > MaxVal) return;

            BitmapData bmpData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            unsafe
            {
                int TotalRGB;

                byte* ptr = (byte*)bmpData.Scan0.ToPointer();
                int stopAddress = (int)ptr + bmpData.Stride * bmpData.Height;

                while ((int)ptr != stopAddress)
                {
                    TotalRGB = ptr[0] + ptr[1] + ptr[2];

                    if (TotalRGB <= thresholdValue)
                    {
                        ptr[2] = 0;
                        ptr[1] = 0;
                        ptr[0] = 0;
                    }
                    else
                    {
                        ptr[2] = 255;
                        ptr[1] = 255;
                        ptr[0] = 255;
                    }

                    ptr += 3;
                }
            }

            bmp.UnlockBits(bmpData);
        }


        public static Bitmap Rozciaganie(Bitmap b, int p1, int p2)
        {
            var bmp = BitmapHelper.ToGrayscale(b);
            for (int x = 0; x < bmp.Width; x++)
                for (int y = 0; y < bmp.Height; y++)
                //if (p1 < p2)
                {
                    if (bmp.GetPixel(x, y).R > p1 && bmp.GetPixel(x, y).R <= p2)
                    {
                        var av = ((bmp.GetPixel(x, y).R - p1) * ((256 - 1) / (p2 - p1)));
                        bmp.SetPixel(x, y, Color.FromArgb(bmp.GetPixel(x, y).A, av, av, av));
                    }
                }
            //else bmp[x, y] = 0;
            return bmp;
        }

        public static void Posterize(Bitmap bmp, int value)
        {
            byte[] upo = new byte[256];
            float param1 = 255.0f / (value - 1);
            float param2 = 256.0f / (value);
            for (int i = 0; i < 256; ++i)
            {
                upo[i] = (byte)((byte)(i / param2) * param1);
            }
            ApplyUPO(bmp, upo);
        }

        public static void ApplyUPO(Bitmap bmp, byte[] lut)
        {
            for (int i = 0; i < bmp.Size.Width; ++i)
            {
                for (int j = 0; j < bmp.Size.Height; ++j)
                {
                    Color color = bmp.GetPixel(i, j);
                    byte newColor = lut[color.R];
                    bmp.SetPixel(i, j, Color.FromArgb(color.A, newColor, newColor, newColor));
                }
            }
        }
    }
}
