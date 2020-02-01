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
    public partial class SmootingFormv2 : Form
    {
        Image<Bgr, byte> imgt;
        ImageForm form;
        Image<Gray, float> img;

        float[,] mask1 = new float[3, 3] {
            { 0, 1, 0 },
            { 1, 4, 1 },
            { 0, 1, 0 }
        };
        float[,] mask2 = new float[3, 3] {
            { 1, 1, 1 },
            { 1, 1, 1 },
            { 1, 1, 1 } };
        float[,] mask3 = new float[3, 3] {
            { 1, 2, 1 },
            { 2, 4, 2 },
            { 1, 2, 1 }
        };


        void CreateMatrixTable(float[,] mask, ref TableLayoutPanel t, bool IsKParameter)
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

        public SmootingFormv2(Bitmap bmp)
        {
            InitializeComponent();
            CreateMatrixTable(mask1, ref tableLayoutPanel1, false);
            CreateMatrixTable(mask2, ref tableLayoutPanel2, false);
            CreateMatrixTable(mask3, ref tableLayoutPanel3, false);
            CreateMatrixTable(GetMatrixByKValue(0), ref tableLayoutPanel4, true);
            InitializeComponent();
            img = new Image<Gray, float>(bmp);
            form = new ImageForm();
            form.Show();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            float[,] kernel;
            Image<Gray, float> _img = img;
            var grayImg = img.Convert<Gray, float>();


                kernel = mask1;
          
            ConvolutionKernelF ker = new ConvolutionKernelF(kernel);

            Image<Gray, float> convoluted = grayImg * ker;


            form.SetImage(new Image<Bgr, byte>(convoluted.Bitmap));
            form.Refresh();
        }

        private float[,] GetMatrixByKValue(int k)
        {
            return new float[3, 3] {
                { 1, 1, 1 },
                { 1, k, 1 },
                { 1, 1, 1 }
            };
        }


        private void button2_Click(object sender, EventArgs e)
        {
            float[,] kernel;
            Image<Gray, float> _img = img;
            var grayImg = img.Convert<Gray, float>();

                kernel = mask2;
            


            ConvolutionKernelF ker = new ConvolutionKernelF(kernel);

            Image<Gray, float> convoluted = grayImg * ker;


            form.SetImage(new Image<Bgr, byte>(convoluted.Bitmap));
            form.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            float[,] kernel;
            Image<Gray, float> _img = img;
            var grayImg = img.Convert<Gray, float>();


                kernel = mask3;
           


            ConvolutionKernelF ker = new ConvolutionKernelF(kernel);

            Image<Gray, float> convoluted = grayImg * ker;


            form.SetImage(new Image<Bgr, byte>(convoluted.Bitmap));
            form.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            float[,] kernel;
            Image<Gray, float> _img = img;
            var grayImg = img.Convert<Gray, float>();

           
            kernel = GetMatrixByKValue((int)numericUpDown1.Value);


            ConvolutionKernelF ker = new ConvolutionKernelF(kernel);

            Image<Gray, float> convoluted = grayImg * ker;


            form.SetImage(new Image<Bgr, byte>(convoluted.Bitmap));
            form.Refresh();
        }
    }
}
