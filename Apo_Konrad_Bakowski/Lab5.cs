using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apo_Konrad_Bakowski
{
    public class Lab5
    {
        public static Bitmap Region_Merge(Bitmap image, int t, int regmax, int n1, int m1, int n2, int m2)
        {
            Bitmap result = new Bitmap(image);
            int nmax = n2 + 1;
            int mmax = m2 + 1;

            int[,] xc = new int[nmax, mmax];

            int[] np = new int[regmax];
            int[] me = new int[regmax];
            int[] s = new int[regmax];
            int x, y, dy, dx, nubs, merge, ml;
            int m, c, i, dmin, cmin, min;

            try
            {
                if (regmax < 1) return image;

                for (y = m1; y < m2; y++)
                    for (x = n1; x < n2; x++)
                    {
                        result.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                        xc[x, y] = 0;
                    }

                for (i = 0; i < regmax; i++)
                {
                    np[i] = 0;
                    me[i] = 0;
                    s[i] = 0;
                }

                nubs = 1;
                merge = 0;

                i = 0;
                for (y = m1 + 1; y < m2 - 1; y++)
                    for (x = n1 + 1; x < n2 - 1; x++)
                    {
                        if (x == 1 && y == 1)
                        {
                            xc[x, y] = 1;
                            result.SetPixel(x, y, Color.FromArgb(nubs, nubs, nubs));
                            np[nubs - 1] = 1;
                            s[nubs - 1] = (image.GetPixel(x, y).R);
                            me[nubs - 1] = (image.GetPixel(x, y).R);
                        }
                        else
                        {
                            dmin = Math.Abs((image.GetPixel(x, y).R) - me[0]);
                            min = 1;
                            for (dy = -1; dy <= 0; dy++)
                                for (dx = -1; dx <= 1; dx++)
                                    if ((x + dx != x || y + dy != y) && (y + dy != y || x + dx != x + 1))
                                        if (xc[x + dx, y + dy] != 0)
                                        {
                                            c = Math.Abs((image.GetPixel(x, y).R) - me[xc[dx + x, y + dy] - 1]);
                                            if (c < t)
                                            {
                                                merge = 1;
                                                if (c < dmin)
                                                {
                                                    dmin = c; min = xc[x + dx, y + dy];
                                                }
                                            }
                                        }
                            if (merge == 1)
                            {
                                m = min; xc[x, y] = m;
                                result.SetPixel(x, y, Color.FromArgb(m, m, m));
                                np[m - 1]++; s[m - 1] += (image.GetPixel(x, y).R);
                                me[m - 1] = (s[m - 1] / np[m - 1]);
                            }

                            if (merge == 0)
                            {
                                cmin = 255; ml = 1;
                                for (m = 1; m <= nubs; m++)
                                {
                                    c = Math.Abs((image.GetPixel(x, y).R) - me[m - 1]);
                                    if (c < cmin) { cmin = c; ml = m; }
                                    if (c < t)
                                    {
                                        merge = 1;
                                        xc[x, y] = ml;
                                        result.SetPixel(x, y, Color.FromArgb(ml, ml, ml));
                                        np[ml - 1]++; s[ml - 1] += (image.GetPixel(x, y).R);
                                        me[ml - 1] = (s[ml - 1] / np[ml - 1]);
                                    }
                                }
                                if (merge == 0 && nubs < regmax)
                                {
                                    nubs++; xc[x, y] = nubs; result.SetPixel(x, y, Color.FromArgb(nubs, nubs, nubs));
                                    np[nubs - 1] = 1; s[nubs - 1] = (image.GetPixel(x, y).R);
                                    me[nubs - 1] = (image.GetPixel(x, y).R);
                                }
                                else merge = 0;
                            }
                            else merge = 0;

                        }
                    }
                for (y = m1; y < m2; y++)
                    for (x = n1; x < n2; x++)
                        for (i = 1; i < regmax; i++)
                            if (i == (result.GetPixel(x, y).R)) result.SetPixel(x, y, Color.FromArgb(me[i - 1], me[i - 1], me[i - 1]));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            return Lab2.Negacja(Lab2.Thresholding(result, 1));
        }

    }

    public class ImageAnalysis
    {
        public int ImagePixels;
        public int BackgroundPixels;
        public int ObjectArea;
        public int obkectPerimeter;
        public string CenterOfMass;
        public double W1;
        public double W2;
        public double W3;
        public double W4;
        public double W8;
        public double W9;
        public long m00;
        public long m01;
        public long m10;
        public long m11;
        public long cm10;
        public long cm01;
        public long cm11;

    }
}
