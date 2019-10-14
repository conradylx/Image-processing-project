using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;

namespace APO_16035
{
    public partial class Main : Form
    {
        internal static Image<Bgr, byte> imgInput2;

        public Main()
        {
            InitializeComponent();
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog file = new OpenFileDialog();
                file.Filter = "JPEG|*.jpg|Bitmaps|*.bmp";
                if (file.ShowDialog() == DialogResult.OK)
                {
                    Image<Bgr, byte> imgInput = new Image<Bgr, byte>(file.FileName);
                    pictureBox1.Image = imgInput.Bitmap;
                    imgInput2 = imgInput;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void histogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Histogram histogram = new Histogram();
            histogram.Show();
        }
    }
}
