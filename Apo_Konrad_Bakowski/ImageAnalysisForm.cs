using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apo_Konrad_Bakowski
{
    public partial class ImageAnalysisForm : Form
    {
        
        ImageAnalysis imageData;

        public ImageAnalysisForm(FastBitmap bmpperview)
        {
            var img = new Image<Gray, byte>(bmpperview.Unlock());

            FastBitmap bmp = new FastBitmap(img.Bitmap);

            InitializeComponent();

            int perimeter = 0;
            int area = 0;
            int size = bmp.Width * bmp.Height;
            double areaNorm = 0.0;
            int[] r0 = new int[] { 0, 0 };
            long m00 = 0;
            long m10 = 0;
            long m01 = 0;
            long m11 = 0;

            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    int rpixel = bmp[x, y].R;
                    if (rpixel > 0)
                    {
                        area++;
                        m00 += bmp[x, y].R;
                        m10 += x * bmp[x, y].R;
                        m01 += y * bmp[x, y].R;
                        m11 += x * y * bmp[x, y].R;

                        for (int i = -1; i < 2; i++)
                        {
                            for (int j = -1; j < 2; j++)
                            {
                                if ((x + i) >= 0 && (y + j) >= 0 && x < bmp.Width && y < bmp.Height)
                                {
                                    int sasiad = bmp[x + i, y + j].R;
                                    if (sasiad == 0)
                                    {
                                        perimeter++;
                                        r0[0] += x;
                                        r0[1] += y;
                                        goto next;
                                    }
                                }
                            }
                        }
                    }
                    next:;
                }
            }

            if (perimeter > 0)
            {
                r0[0] = r0[0] / perimeter;
                r0[1] = r0[1] / perimeter;
            }
            areaNorm = (double)area / (double)size;
            double W1 = 2.0 * Math.Sqrt((double)area / Math.PI);
            double W2 = (double)perimeter / Math.PI;
            double W3 = (double)perimeter / (2.0 * Math.Sqrt((double)area * Math.PI));
            double W9 = (2.0 * Math.Sqrt((double)area * Math.PI)) / (double)perimeter;
            int minX = -1;
            int maxX = -1;
            int minY = -1;
            int maxY = -1;
            bool isSet = false;
            long sumaOdl = 0;
            long M10 = 0;
            long M01 = 0;
            long M11 = 0;

            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    int rpixel = bmp[x, y].R;
                    if (rpixel > 0)
                    {
                        if (!isSet)
                        {
                            isSet = true;
                            if (minX == -1) minX = x;
                            if (maxX == -1) maxX = x;
                            if (minY == -1) minY = y;
                            if (maxY == -1) maxY = y;
                        }
                        if (x < minX) minX = x;
                        if (x > maxX) maxX = x;
                        if (y < minY) minY = y;
                        if (y > maxY) maxY = y;

                        M10 += (x - r0[0]) * bmp[x, y].R;
                        M01 += (y - r0[1]) * bmp[x, y].R;
                        M11 += (x - r0[0]) * (y - r0[1]) * bmp[x, y].R;
                        sumaOdl += (long)Math.Pow(Math.Sqrt(Math.Pow(x - r0[0], 2) + Math.Pow(y - r0[1], 2)), 2);
                    }
                }
            }
            int gabarytX = maxX - minX;
            int gabarytY = maxY - minY;
            int gabaryt;
            if (gabarytX > gabarytY) gabaryt = gabarytX;
            else gabaryt = gabarytY;
            double W8 = (double)gabaryt / (double)perimeter;
            double W4 = (double)area / Math.Sqrt(2 * Math.PI * sumaOdl);
            
            imageData = new ImageAnalysis()
            {
                ImagePixels = size,
                BackgroundPixels = (size - area),
                ObjectArea = area,
                obkectPerimeter = perimeter,
                CenterOfMass = r0[0] + ", " + r0[1],
                W1 = W1,
                W2 = W2,
                W3 = W3,
                W4 = W4,
                W8 = W8,
                W9 = W9,
                m00 = m00,
                m01 = m01,
                m10 = m10,
                m11 = m11,
                cm01 = M01,
                cm10 = M10,
                cm11 = M11
            };

            label14.Text = imageData.W1.ToString();
            label15.Text = imageData.W2.ToString();
            label16.Text = imageData.W3.ToString();
            label17.Text = imageData.W4.ToString();
            label18.Text = imageData.W8.ToString();
            label19.Text = imageData.W9.ToString();

            label20.Text = imageData.m00.ToString();
            label21.Text = imageData.m01.ToString();
            label22.Text = imageData.m10.ToString();
            label23.Text = imageData.m11.ToString();

            label24.Text = imageData.cm10.ToString();
            label25.Text = imageData.cm01.ToString();
            label26.Text = imageData.cm11.ToString();
        }

        private void label23_Click(object sender, EventArgs e)
        {

        }
        
        private void ImageAnalysisForm_Load(object sender, EventArgs e)
        {

        }
    }
}
