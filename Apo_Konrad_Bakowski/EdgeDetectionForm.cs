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
    public partial class EdgeDetectionForm : Form
    {
        ImageForm form;

        //float[,] mask1 = new float[3, 3] { { 0, -1, 0 }, { -1, 4, -1 }, { 0, -1, 0 } };
        //float[,] mask2 = new float[3, 3] { { -1, -1, -1 }, { -1, 8, -1 }, { -1, -1, -1 } };
        //float[,] mask3 = new float[3, 3] { { 1, -2, 1 }, { -2, 4, -2 }, { 1, -2, 1 } };

        float[,] mask1 = new float[3, 3] { { 1, -2, 1 }, { -2, 5, -2 }, { 1, -2, 1 } };
        float[,] mask2 = new float[3, 3] { { -1, -1, -1 }, { -1, 9, -1 }, { -1, -1, -1 } };
        float[,] mask3 = new float[3, 3] { { 0, -1, 0 }, { -1, 5, -1 }, { 0, -1, 0 } };

        Image<Bgr, float> img;


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


        public EdgeDetectionForm(Bitmap bmp)
        {
            InitializeComponent();
            CreateMatrixTable(mask1, ref tableLayoutPanel1, false);
            CreateMatrixTable(mask2, ref tableLayoutPanel2, false);
            CreateMatrixTable(mask3, ref tableLayoutPanel3, false);
            img = new Image<Bgr, float>(bmp);
            form = new ImageForm();
            form.Show();

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float[,] kernel;
            Image<Gray, float> B = img[2];
            Image<Gray, float> G = img[1];
            Image<Gray, float> R = img[0];


            if (radioButton1.Checked)
            {
                kernel = mask1;
            }
            else if (radioButton2.Checked)
            {
                kernel = mask2;
            }
            else
            {
                kernel = mask3;
            }


            ConvolutionKernelF ker = new ConvolutionKernelF(kernel);

            Image<Gray, float> convolutedR = R * ker;
            Image<Gray, float> convolutedG = G * ker;
            Image<Gray, float> convolutedB = B * ker;

            Image<Bgr, float> afterSharpening = img;
            afterSharpening[0] = convolutedR;
            afterSharpening[1] = convolutedG;
            afterSharpening[2] = convolutedB;
            
            form.SetImage(new Image<Bgr, byte>(afterSharpening.Bitmap));
            form.Refresh();
        }
    }
}
