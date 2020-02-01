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
    public partial class MedianFilteringValueForm : Form
    {
        private int oldValue;
        private bool evenOnly = false;
        private bool oddOnly = false;

        public int Value
        {
            get { return (int)numericUpDown1.Value; }
        }

        public MedianFilteringValueForm(int min, int max, string text, bool evenOnly, bool oddOnly)
        {
            InitializeComponent();
            numericUpDown1.Minimum = min;
            numericUpDown1.Maximum = max;
            label1.Text = text;
            this.evenOnly = evenOnly;
            this.oddOnly = oddOnly;
        }

        public MedianFilteringValueForm(int min, int max, string text) : this(min, max, text, false, false) { }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if ((oddOnly && numericUpDown1.Value % 2 == 0) || (evenOnly && numericUpDown1.Value % 2 == 1))
            {
                if (numericUpDown1.Value > oldValue)
                    numericUpDown1.Value = Math.Min(numericUpDown1.Value + 1, numericUpDown1.Maximum);
                else
                    numericUpDown1.Value = Math.Max(numericUpDown1.Value - 1, numericUpDown1.Minimum);
            }
            oldValue = (int)numericUpDown1.Value;
        }
    }
}
