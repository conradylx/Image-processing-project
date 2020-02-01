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
    public partial class StrechingForm : Form
    {
        ImageForm form;

        public StrechingForm()
        {
            InitializeComponent();
            form = new ImageForm();
            form.Show();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            var t1 = this.trackBar1.Value;
            label3.Text = t1.ToString();
            if (t1 >= this.trackBar2.Value)
            {
                trackBar2.Value = t1 + 1;
            }
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {

            var t2 = this.trackBar2.Value;
            label4.Text = t2.ToString();
            if (t2 <= this.trackBar1.Value)
            {
                trackBar1.Value = t2 - 1;
            }
        }

        private void submit_Click(object sender, EventArgs e)
        {
            MainWindow mw = (MainWindow)Application.OpenForms[0];
            int p1 = this.trackBar1.Value;
            int p2 = this.trackBar2.Value;
            var image = mw.GetImage();
            Lab2.Rozciaganie(image, p1, p2);
            form.SetImage(new Image<Bgr, byte>(image));
            form.Refresh();
        }
    }
}
