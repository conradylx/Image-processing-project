using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apo_Konrad_Bakowski
{
    public class Lab3
    {
        public static FastBitmap ApplyMask(FastBitmap bmp, int[,] mask, int divisor)
        {
            FastBitmap bitmap = new FastBitmap((Bitmap)bmp.Bitmap.Clone());

            if (divisor == 0)
                divisor = 1;

            int size = mask.GetLength(0) / 2;
            Point[,] temp = new Point[mask.GetLength(0), mask.GetLength(0)];

            for (int i = -size; i <= size; ++i)
                for (int j = -size; j <= size; ++j)
                    temp[i + size, j + size] = new Point(i, j);

            for (int i = size; i < bmp.Width - size; ++i)
            {
                for (int j = size; j < bmp.Height - size; ++j)
                {
                    int newColor = 0;
                    for (int k = 0; k < mask.GetLength(0); ++k)
                    {
                        for (int l = 0; l < mask.GetLength(0); ++l)
                        {
                            Color color = bmp[i + temp[k, l].X, j + temp[k, l].Y];
                            newColor += mask[k, l] * color.R;
                        }
                    }
                    newColor /= divisor;

                    newColor = Math.Max(0, Math.Min(newColor, 255));
                    bitmap[i, j] = Color.FromArgb(255, newColor, newColor, newColor);
                }
            }

            return bitmap;
        }
    }
}
