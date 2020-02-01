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
    public partial class SharpeningForm : Form
    {
        Image<Bgr, byte> imgt;
        ImageForm form;

        Matrix<float> Kernel = new Matrix<float>(
        new float[,] {
                {1.0f, 2.0f, 1.0f},
                {2.0f, 4.0f, 2.0f},
                {1.0f, 2.0f, 1.0f}
        }
    );

        Matrix<float> mask1 = new Matrix<float>(new float[3, 3] { { 1, -2, 1 }, { -2, 5, -2 }, { 1, -2, 1 } });
        Matrix<float> mask2 = new Matrix<float>(new float[3, 3] { { -1, -1, -1 }, { -1, 8, -1 }, { -1, -1, -1 } });
        Matrix<float> mask3 = new Matrix<float>(new float[3, 3] { { 0, -1, 0 }, { -1, 5, -1 }, { 0, -1, 0 } });
        Image<Gray, float> img;
        Image<Gray, float> defaultImg;

        void CreateMatrixTable(Matrix<float> mask, ref TableLayoutPanel t, bool IsKParameter)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (IsKParameter && i == 1 && j == 1)
                        t.Controls.Add(new Label() { Text = "k" }, j, i);
                    else
                        t.Controls.Add(new Label() { Text = mask[i, j].ToString() }, j, i);
                }
            }
        }


        public SharpeningForm(Bitmap bmp)
        {
            InitializeComponent();
            CreateMatrixTable(mask1, ref tableLayoutPanel1, false);
            CreateMatrixTable(mask2, ref tableLayoutPanel2, false);
            CreateMatrixTable(mask3, ref tableLayoutPanel3, false);
            img = new Image<Gray, float>(bmp);
            form = new ImageForm();
            form.Show();

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mat kernel;

            Image<Gray, float> grayImage = new Image<Gray, float>(img.Bitmap);


            if (radioButton1.Checked)
            {
                //kernel = new Matrix<float>(mask1);
                kernel = mask1.Mat;
            }
            else if (radioButton2.Checked)
            {
                kernel = mask2.Mat;
            }
            else
            {
                kernel = mask3.Mat;
            }

            Point anchor = new Point(-1, -1);
            Mat srcImg = grayImage.Mat;
            Mat imgDst = grayImage.Mat;

            Mat m = new Mat();
            kernel.ConvertTo(m, Emgu.CV.CvEnum.DepthType.Cv8S);


            CvInvoke.Filter2D(srcImg, imgDst, m, anchor);
            var img3 = imgDst;
            CvInvoke.ConvertScaleAbs(imgDst, img3, 1, 0);

            img = new Image<Gray, float>(img3.Bitmap);
            imgt = new Image<Bgr, byte>(img3.Bitmap);

            form.SetImage(new Image<Bgr, byte>(img3.Bitmap));
            form.Refresh();
        }

        private float[,] GetMatrixByKValue(int k)
        {
            return new float[3, 3] { { 1, 1, 1 }, { 1, k, 1 }, { 1, 1, 1 } };
        }
        
    }
}
