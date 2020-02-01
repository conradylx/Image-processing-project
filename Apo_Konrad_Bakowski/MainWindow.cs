using Apo_Konrad_Bakowski;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apo_Konrad_Bakowski
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        Image<Bgr, byte> _image;

        private MedianFilteringValueForm valueForm;

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Select a picture";
            openFileDialog1.Filter = "All supported graphics|*.jpg;*.jpeg;*.png;*.jfif;*.bmp|" +
              "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg;|" +
              "Portable Network Graphic (*.png)|*.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Cursor = Cursors.WaitCursor;
                foreach (string filename in openFileDialog1.FileNames)
                {
                    _image = new Image<Bgr, byte>(filename);
                    ImageForm form = new ImageForm(_image);
                    form.TopLevel = false;
                    this.panel1.Controls.Add(form);
                    form.Show();
                }
                Cursor = Cursors.Default;
            }
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void histogramToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (_image != null)
            {
                HistogramForm form = new HistogramForm(_image);
                form.Show();
            }
            else
            {
                MessageBox.Show("Select image first.");
            }
        }

        private void negationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var negatedImage = Lab2.Negacja(GetImage());
            var form = new ImageForm(new Image<Bgr, byte>(negatedImage));
            form.Show();
        }
        

        private void tToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        public Bitmap GetImage()
        {
            ImageForm id = (ImageForm)this.panel1.Controls["ImageForm"];
            ImageBox box = (ImageBox)id.Controls["imageBox1"];
            var image = (Image<Bgr, byte>)box.Image;
            return image.ToBitmap();
        }

        private void basicTresholdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TresholdForm t = new TresholdForm();
            t.Show();
        }

        private void grayLevelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThresholdGrayLevelForm t = new ThresholdGrayLevelForm();
            t.Show();
        }

        private void strechingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            StrechingForm s = new StrechingForm();
            s.Show();
        }

        private void posterizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PosterizationForm pf = new PosterizationForm();
            pf.Show();
        }

        private void medianFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            valueForm = new MedianFilteringValueForm(3, 11, "Type Kernel size", false, true);
            if (valueForm.ShowDialog() == DialogResult.OK)
            {
                Image<Bgr, byte> image = new Image<Bgr, byte>(GetImage());
                ImageForm form = new ImageForm(image.SmoothMedian(valueForm.Value));
                form.Show();
            }
        }
        
        private void smoothingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var SmooththingForm = new SmootingFormv2(GetImage());
            SmooththingForm.Show();

        }

        private void sharpeningToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var sharpeningForm = new SharpeningForm(GetImage());
            sharpeningForm.Show();
        }

        private void edgeDetectionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var edgeDetForm = new EdgeDetectionForm(GetImage());
            edgeDetForm.Show();
        }

        private void universalNeighbourOperationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MaskCreator form = new MaskCreator();
            if (form.ShowDialog() == DialogResult.OK)
            {
                var fastbitmap = new FastBitmap(GetImage());
                var effectImage = Lab3.ApplyMask(fastbitmap, form.Mask, form.Divisor);
                effectImage.Unlock();
                ImageForm imgForm = new ImageForm(new Image<Bgr, byte>(effectImage.Bitmap));
                imgForm.Show();
            }
        }

        /*private void universalNeighbourOperationToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MaskCreator form = new MaskCreator();
            if (form.ShowDialog() == DialogResult.OK)
            {
                var fastbitmap = new FastBitmap(GetImage());
                var effectImage = Lab3.ApplyMask(fastbitmap, form.Mask, form.Divisor);
                effectImage.Unlock();
                ImageForm imgForm = new ImageForm(new Image<Bgr, byte>(effectImage.Bitmap));
                imgForm.Show();
            }
        }*/

        private void universalNeighbourOperationToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            MaskCreator form = new MaskCreator();
            if (form.ShowDialog() == DialogResult.OK)
            {
                var fastbitmap = new FastBitmap(GetImage());
                var effectImage = Lab3.ApplyMask(fastbitmap, form.Mask, form.Divisor);
                effectImage.Unlock();
                ImageForm imgForm = new ImageForm(new Image<Bgr, byte>(effectImage.Bitmap));
                imgForm.Show();
            }
        }

        private void sobelToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var img = GetImage();

            Image<Gray, byte> _imgGray = new Image<Gray, byte>(img);
            Image<Gray, float> _imgSobel = new Image<Gray, float>(img.Width, img.Height);

            _imgSobel = _imgGray.Sobel(1, 1, 3);
            var form = new ImageForm(new Image<Bgr, byte>(_imgSobel.Bitmap));
            form.Show();
        }

        private unsafe void robertsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Bitmap result;
            var grayImg = new Image<Gray, byte>(GetImage());
            lock (grayImg)
            {

                result = grayImg.Bitmap;
                var data = result.LockBits(new Rectangle(0, 0, grayImg.Width, grayImg.Height),
                           ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
                var p = (byte*)data.Scan0.ToPointer();
                var offset = data.Stride - result.Width * 3;
                for (var i = 0; i < result.Height - 1; i++)
                {
                    for (var j = 0; j < result.Width - 1; j++)
                    {
                        var Gx = (int)Math.Pow(p[0] - (p + 3 + data.Stride)[0], 2);
                        var Gy = (int)Math.Pow((p + 3)[0] - (p + data.Stride)[0], 2);
                        var f = Gx + Gy;
                        p[0] = p[1] = p[2] = (byte)f;
                        p += 3;
                    }
                    p += offset;
                }
                result.UnlockBits(data);
            }

            ImageForm form = new ImageForm(new Image<Bgr, byte>(result));
            form.Show();
        }

        private unsafe void prewittToolStripMenuItem1_Click(object sender, EventArgs e)
        {


            int m1w1 = 1;
            int m1w2 = 1;
            int m1w3 = 1;

            int m1w4 = 1;
            int m1w5 = -2;
            int m1w6 = 1;

            int m1w7 = -1;
            int m1w8 = -1;
            int m1w9 = -1;
            //-----maska2 Prewitt S
            int m2w1 = -1;
            int m2w2 = -1;
            int m2w3 = -1;

            int m2w4 = 1;
            int m2w5 = -2;
            int m2w6 = 1;

            int m2w7 = 1;
            int m2w8 = 1;
            int m2w9 = 1;


            Bitmap bitmap = new Image<Gray, byte>(GetImage()).Bitmap;

            FastBitmap bmp = new FastBitmap(bitmap);

            FastBitmap wynik = bmp;
            int x, y;
            float oldmin, oldmax, oldrange, scale;
            float newmin, newmax, newrange;
            float[,] pomtab = new float[bmp.Width, bmp.Height];
            float pom;

            for (x = 0; x < wynik.Width; x++)
            {
                for (y = 0; y < wynik.Height; y++)
                {
                    pom = ((bmp[x - 1, y - 1].R * m1w1 + bmp[x, y - 1].R * m1w2 + bmp[x + 1, y - 1].R * m1w3
                        + bmp[x - 1, y].R * m1w4 + bmp[x, y].R * m1w5 + bmp[x + 1, y].R * m1w6
                        + bmp[x - 1, y + 1].R * m1w7 + bmp[x, y + 1].R * m1w8 + bmp[x + 1, y + 1].R * m1w9) ^ 2

                        + (bmp[x - 1, y - 1].R * m2w1 + bmp[x, y - 1].R * m2w2 + bmp[x + 1, y - 1].R * m2w3
                        + bmp[x - 1, y].R * m2w4 + bmp[x, y].R * m2w5 + bmp[x + 1, y].R * m2w6
                        + bmp[x - 1, y + 1].R * m2w7 + bmp[x, y + 1].R * m2w8 + bmp[x + 1, y + 1].R * m2w9) ^ 2) ^ (1 / 2);
                    pomtab[x, y] = pom;
                }
            }

            //SKALOWANIE
            //1

            oldmin = pomtab[0, 0];
            oldmax = pomtab[0, 0];

            for (x = 0; x < wynik.Width; x++)
            {
                for (y = 0; y < wynik.Height; y++)
                {
                    if (pomtab[x, y] < oldmin) oldmin = pomtab[x, y];
                    if (pomtab[x, y] > oldmax) oldmax = pomtab[x, y];
                }
            }

            oldrange = oldmax - oldmin;
            newmin = 0;
            newmax = 255;
            newrange = newmax - newmin;

            for (x = 0; x < wynik.Width; x++)
            {
                for (y = 0; y < wynik.Height; y++)
                {
                    scale = (pomtab[x, y] - oldmin) / oldrange;
                    wynik[x, y] = Color.FromArgb((int)((newrange * scale) + newmin), (int)((newrange * scale) + newmin), (int)((newrange * scale) + newmin));
                }
            }

            ImageForm from = new ImageForm(new Image<Bgr, byte>(wynik.Unlock()));
            from.Show();
            
        }

        private void skeletizationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fbmp = Lab4.Skelatanize(GetImage());
            var form = new ImageForm(new Image<Bgr, byte>(fbmp));
            form.Show();
        }

        private void fourConsistentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var imageToDisplay = Lab4.Dylatacja(new FastBitmap(GetImage()), Lab4.Spojnosc.Czterospojne);
            var form = new ImageForm(new Image<Bgr, byte>(imageToDisplay.Unlock()));
            form.Show();
        }

        private void eightConsistentToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var imageToDisplay = Lab4.Dylatacja(new FastBitmap(GetImage()), Lab4.Spojnosc.Osmiospojne);
            var form = new ImageForm(new Image<Bgr, byte>(imageToDisplay.Unlock()));
            form.Show();
        }


        private void fourConsistentToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var imageToDisplay = Lab4.Erozja(new FastBitmap(GetImage()), Lab4.Spojnosc.Czterospojne);
            var form = new ImageForm(new Image<Bgr, byte>(imageToDisplay.Unlock()));
            form.Show();
        }

        private void eightConsistentToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            var imageToDisplay = Lab4.Erozja(new FastBitmap(GetImage()), Lab4.Spojnosc.Osmiospojne);
            var form = new ImageForm(new Image<Bgr, byte>(imageToDisplay.Unlock()));
            form.Show();
        }


        private void fourConsistentToolStripMenuItem3_Click(object sender, EventArgs e)
        {

            var imageAfterErosion = Lab4.Erozja(new FastBitmap(GetImage()), Lab4.Spojnosc.Czterospojne);
            var result = Lab4.Dylatacja(new FastBitmap(imageAfterErosion.Unlock()), Lab4.Spojnosc.Czterospojne);
            var form = new ImageForm(new Image<Bgr, byte>(result.Unlock()));
            form.Show();
        }

        private void eightConsistentToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            var imageAfterErosion = Lab4.Erozja(new FastBitmap(GetImage()), Lab4.Spojnosc.Osmiospojne);
            var result = Lab4.Dylatacja(new FastBitmap(imageAfterErosion.Unlock()), Lab4.Spojnosc.Osmiospojne);
            var form = new ImageForm(new Image<Bgr, byte>(result.Unlock()));
            form.Show();
        }

        private void fourConsistentToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            var imageAfterDilation = Lab4.Dylatacja(new FastBitmap(GetImage()), Lab4.Spojnosc.Czterospojne);
            var result = Lab4.Erozja(new FastBitmap(imageAfterDilation.Unlock()), Lab4.Spojnosc.Czterospojne);
            var form = new ImageForm(new Image<Bgr, byte>(result.Unlock()));
            form.Show();
        }

        private void eightConsistentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var imageAfterDilation = Lab4.Dylatacja(new FastBitmap(GetImage()), Lab4.Spojnosc.Osmiospojne);
            var result = Lab4.Erozja(new FastBitmap(imageAfterDilation.Unlock()), Lab4.Spojnosc.Osmiospojne);
            var form = new ImageForm(new Image<Bgr, byte>(result.Unlock()));
            form.Show();
        }

        private void twoStepsNeighbourOperationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dualMask3x3Form = new DualMask33Form();
            if (dualMask3x3Form.ShowDialog() == DialogResult.OK)
            {
                if (dualMask3x3Form.Use5x5)
                {
                    FastBitmap b = Lab3.ApplyMask(new FastBitmap(GetImage()), dualMask3x3Form.Mask3, dualMask3x3Form.Divisor3);
                    new ImageForm(new Image<Bgr, byte>(b.Unlock())).Show();
                }
                else
                {
                    FastBitmap a = Lab3.ApplyMask(new FastBitmap(GetImage()), dualMask3x3Form.Mask3, dualMask3x3Form.Divisor3);
                    new ImageForm(new Image<Bgr, byte>(a.Unlock())).Show();
                    //FastBitmap c = Lab3.ApplyMask(new FastBitmap(GetImage()), dualMask3x3Form.Mask3, dualMask3x3Form.Divisor3);
                    //new ImageForm(new Image<Bgr, byte>(c.Unlock())).Show();
                }
            }
        }
        
        private void regionMergeSegmentationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(GetImage());
            ValuePickerForm f = new ValuePickerForm(GetImage());
            f.Show();
        }

        private void imageAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FastBitmap bmp = new FastBitmap(GetImage());

            var form = new ImageAnalysisForm(bmp);

            form.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new Form1();
            f.Show();
        }


    }
}
