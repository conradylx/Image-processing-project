using Emgu.CV;
using Emgu.CV.Structure;
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
    public partial class ImageForm : Form
    {
        Image<Bgr, byte> formImage;

        public ImageForm()
        {
            InitializeComponent();

        }

        public ImageForm(Image<Bgr, byte> img)
        {
            InitializeComponent();

            SetImage(img);
        }

        public void SetImage(Image<Bgr, byte> img)
        {
            imageBox1.Image = img;
            formImage = img;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var drawImage = formImage.Bitmap;
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
            dialog.Title = "Save img File";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                switch (dialog.FilterIndex)
                {
                    case 1:
                        drawImage.Save(dialog.FileName, ImageFormat.Jpeg);
                        break;

                    case 2:
                        drawImage.Save(dialog.FileName, ImageFormat.Bmp);
                        break;

                    case 3:
                        drawImage.Save(dialog.FileName, ImageFormat.Gif);
                        break;
                }
                drawImage.Save(dialog.FileName, ImageFormat.Bmp);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HistogramForm form = new HistogramForm(formImage);
            form.Show();

        }
    }
}
