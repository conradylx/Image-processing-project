using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu;
using Emgu.CV;
using Emgu.CV.Structure;

namespace APO_16035
{
    public partial class Histogram : Form
    {
        Image<Bgr, byte> imgInput;
        Image<Gray, byte> R;
        Image<Gray, byte> G;
        Image<Gray, byte> B;

        public Histogram()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string filename = "C:/Camera/a.jpg";
            imgInput = new Image<Bgr, byte>(filename);

            B = imgInput[0];
            G = imgInput[1];
            R = imgInput[2];

            imageBox1.Image = R;
            imageBox2.Image = G;
            imageBox3.Image = B;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (imgInput == null)
            {
                MessageBox.Show("Wybierz obraz");
                return;
            }

            histogramBox1.ClearHistogram();
            histogramBox2.ClearHistogram();
            histogramBox3.ClearHistogram();

            histogramBox1.GenerateHistograms(R,256);
            histogramBox2.GenerateHistograms(G, 256);
            histogramBox3.GenerateHistograms(B, 256);

            histogramBox1.Refresh();
            histogramBox2.Refresh();
            histogramBox3.Refresh();


        }
    }
}
