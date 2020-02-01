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
    public partial class PosterizationForm : Form
    {
        ImageForm form;

        public PosterizationForm()
        {
            InitializeComponent();
            form = new ImageForm();
            form.Show();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            MainWindow mw = (MainWindow)Application.OpenForms[0];
            int value = this.trackBar1.Value;
            var image = mw.GetImage();
            Lab2.Posterize(image, value);
            form.SetImage(new Image<Bgr, byte>(image));
            form.Refresh();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            this.label3.Text = this.trackBar1.Value.ToString();
        }
    }
}
