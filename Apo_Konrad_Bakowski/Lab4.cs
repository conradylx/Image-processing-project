using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apo_Konrad_Bakowski
{
    public class Lab4
    {
        public enum Spojnosc
        {
            Czterospojne,
            Osmiospojne
        }

        public static FastBitmap Szkieletyzacja(FastBitmap bmp)
        {
            int[] dx = { 0, 1, 1, 1, 0, -1, -1, -1 };
            int[] dy = { 1, 1, 0, -1, -1, -1, 0, 1 };

            bool[,] img = new bool[bmp.Width, bmp.Height];
            int W = bmp.Width;
            int H = bmp.Height;
            for (int i = 0; i < bmp.Width; ++i)
            {
                for (int j = 0; j < bmp.Height; ++j)
                {
                    img[i, j] = bmp[i, j].B < 128;
                }
            }


            bool pass = false;
            LinkedList<Point> list;
            do
            {
                pass = !pass;
                list = new LinkedList<Point>();

                for (int x = 1; x < W - 1; ++x)
                {
                    for (int y = 1; y < H - 1; ++y)
                    {
                        if (img[x, y])
                        {
                            int cnt = 0;
                            int hm = 0;
                            bool prev = img[x - 1, y + 1];
                            for (int i = 0; i < 8; ++i)
                            {
                                bool cur = img[x + dx[i], y + dy[i]];
                                hm += cur ? 1 : 0;
                                if (prev && !cur) ++cnt;
                                prev = cur;
                            }
                            if (hm > 1 && hm < 7 && cnt == 1)
                            {
                                if (pass && (!img[x + 1, y] || !img[x, y + 1] || !img[x, y - 1] && !img[x - 1, y]))
                                {
                                    list.AddLast(new Point(x, y));
                                }
                                if (!pass && (!img[x - 1, y] || !img[x, y - 1] || !img[x, y + 1] && !img[x + 1, y]))
                                {
                                    list.AddLast(new Point(x, y));
                                }
                            }
                        }

                    }
                }
                foreach (Point p in list)
                {
                    img[p.X, p.Y] = false;
                }
            } while (list.Count != 0);

            for (int x = 0; x < W; ++x)
            {
                for (int y = 0; y < H; ++y)
                {
                    bmp[x, y] = img[x, y] ? Color.Black : Color.White;
                }
            }

            return bmp;
        }

        public static Bitmap Skelatanize(Bitmap image2)
        {
            Bitmap image = new Bitmap(image2);
            for (int y = 0; (y <= (image.Height - 1)); y++)
            {
                for (int x = 0; (x <= (image.Width - 1)); x++)
                {
                    Color inv = image.GetPixel(x, y);
                    inv = Color.FromArgb(255, (255 - inv.R), (255 - inv.G), (255 - inv.B));
                    image.SetPixel(x, y, inv);
                }
            }

            Image<Gray, byte> imgOld = new Image<Gray, byte>(image);
            Image<Gray, byte> img2 = (new Image<Gray, byte>(imgOld.Width, imgOld.Height, new Gray(255))).Sub(imgOld);
            Image<Gray, byte> eroded = new Image<Gray, byte>(img2.Size);
            Image<Gray, byte> temp = new Image<Gray, byte>(img2.Size);
            Image<Gray, byte> skel = new Image<Gray, byte>(img2.Size);
            skel.SetValue(0);
            CvInvoke.Threshold(img2, img2, 127, 255, 0);
            var element = CvInvoke.GetStructuringElement(ElementShape.Cross, new Size(3, 3), new Point(-1, -1));
            bool done = false;

            while (!done)
            {
                CvInvoke.Erode(img2, eroded, element, new Point(-1, -1), 1, BorderType.Reflect, default(MCvScalar));
                CvInvoke.Dilate(eroded, temp, element, new Point(-1, -1), 1, BorderType.Reflect, default(MCvScalar));
                CvInvoke.Subtract(img2, temp, temp);
                CvInvoke.BitwiseOr(skel, temp, skel);
                eroded.CopyTo(img2);
                if (CvInvoke.CountNonZero(img2) == 0) done = true;
            }

            Bitmap image3 = new Bitmap(skel.Bitmap);
            for (int y = 0; (y <= (image.Height - 1)); y++)
            {
                for (int x = 0; (x <= (image.Width - 1)); x++)
                {
                    Color inv = image.GetPixel(x, y);
                    inv = Color.FromArgb(255, (255 - inv.R), (255 - inv.G), (255 - inv.B));
                    image.SetPixel(x, y, inv);
                }
            }


            return image3;
        }


        public static FastBitmap Erozja(FastBitmap bmp, Spojnosc spojnosc)
        {
            int i, j, pam;
            int[,] erode = new int[bmp.Width, bmp.Height];
            int[,] tab = new int[bmp.Width, bmp.Height];

            for (int y = 0; y < bmp.Height; y++)
                for (int x = 0; x < bmp.Width; x++)
                    tab[x, y] = bmp[x, y].R;

            for (i = 1; i < bmp.Height - 1; i++)
            {
                for (j = 1; j < bmp.Width - 1; j++)
                {
                    pam = tab[j, i];

                    if (spojnosc == Spojnosc.Osmiospojne)
                    {
                        if (pam > tab[j + 1, i]) pam = tab[j + 1, i];
                        if (pam > tab[j + 1, i + 1]) pam = tab[j + 1, i + 1];
                        if (pam > tab[j, i + 1]) pam = tab[j, i + 1];
                        if (pam > tab[j - 1, i + 1]) pam = tab[j - 1, i + 1];
                        if (pam > tab[j - 1, i]) pam = tab[j - 1, i];
                        if (pam > tab[j - 1, i - 1]) pam = tab[j - 1, i - 1];
                        if (pam > tab[j, i - 1]) pam = tab[j, i - 1];
                        if (pam > tab[j + 1, i - 1]) pam = tab[j + 1, i - 1];
                    }
                    else if (spojnosc == Spojnosc.Czterospojne)
                    {
                        if (pam > tab[j + 1, i]) pam = tab[j + 1, i];
                        if (pam > tab[j, i + 1]) pam = tab[j, i + 1];
                        if (pam > tab[j - 1, i]) pam = tab[j - 1, i];
                        if (pam > tab[j, i - 1]) pam = tab[j, i - 1];
                    }

                    erode[j, i] = pam;
                }
            }

            for (i = 0; i < bmp.Height; i++)
                for (j = 0; j < bmp.Width; j++)
                    bmp[j, i] = Color.FromArgb(erode[j, i], erode[j, i], erode[j, i]);

            return bmp;
        }


        public static FastBitmap Dylatacja(FastBitmap bmp, Spojnosc spojnosc)
        {
            int i, j, pam;
            int[,] dilate = new int[bmp.Width, bmp.Height];
            int[,] tab = new int[bmp.Width, bmp.Height];

            for (int y = 0; y < bmp.Height; y++)
                for (int x = 0; x < bmp.Width; x++)
                    tab[x, y] = bmp[x, y].R;

            for (i = 1; i < bmp.Height - 1; i++)
            {
                for (j = 1; j < bmp.Width - 1; j++)
                {
                    pam = tab[j, i];

                    if (spojnosc == Spojnosc.Osmiospojne)
                    {
                        if (pam <= tab[j + 1, i]) pam = tab[j + 1, i];
                        if (pam <= tab[j + 1, i + 1]) pam = tab[j + 1, i + 1];
                        if (pam <= tab[j, i + 1]) pam = tab[j, i + 1];
                        if (pam <= tab[j - 1, i + 1]) pam = tab[j - 1, i + 1];
                        if (pam <= tab[j - 1, i]) pam = tab[j - 1, i];
                        if (pam <= tab[j - 1, i - 1]) pam = tab[j - 1, i - 1];
                        if (pam <= tab[j, i - 1]) pam = tab[j, i - 1];
                        if (pam <= tab[j + 1, i - 1]) pam = tab[j + 1, i - 1];
                    }
                    else if (spojnosc == Spojnosc.Czterospojne)
                    {
                        if (pam <= tab[j + 1, i]) pam = tab[j + 1, i];
                        if (pam <= tab[j, i + 1]) pam = tab[j, i + 1];
                        if (pam <= tab[j - 1, i]) pam = tab[j - 1, i];
                        if (pam <= tab[j, i - 1]) pam = tab[j, i - 1];
                    }

                    dilate[j, i] = pam;
                }
            }

            for (i = 0; i < bmp.Height; i++)
                for (j = 0; j < bmp.Width; j++)
                    bmp[j, i] = Color.FromArgb(dilate[j, i], dilate[j, i], dilate[j, i]);

            return bmp;
        }



        public static Bitmap Dylatacja(Image<Bgr, byte> bmp, int spojnosc)
        {
            Mat sourceCode = bmp.Mat;
            Mat destMat = bmp.Copy().Mat;

            CvInvoke.Dilate(sourceCode
                             , destMat
                             , null
                             , new Point(-1, -1)
                             , spojnosc
                             , BorderType.Constant
                             , new MCvScalar(255, 255, 255));
            return destMat.Bitmap;


        }
    }
}
