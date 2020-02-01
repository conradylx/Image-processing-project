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
    public partial class ValuePickerForm : Form
    {

        Bitmap bmp;
        public ValuePickerForm(Bitmap b)
        {
            bmp = b;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int t = Int32.Parse(textBox1.Text);
            var regmax = Int32.Parse(textBox2.Text);
            var result = Lab5.Region_Merge(bmp, t, regmax, 0, 0, bmp.Width, bmp.Height);
            ImageForm f = new ImageForm(new Image<Bgr, byte>(result));
            f.Show();
        }
    }
}
