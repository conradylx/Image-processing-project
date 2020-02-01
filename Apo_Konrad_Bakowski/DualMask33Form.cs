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
    public partial class DualMask33Form : Form
    {
        private int[,] mask1;
        int divisor1;

        public int[,] Mask1
        {
            get { return mask1; }
        }

        public int Divisor1
        {
            get { return divisor1; }
        }

        private int[,] mask2;
        int divisor2;

        public int[,] Mask2
        {
            get { return mask2; }
        }

        public int Divisor2
        {
            get { return divisor2; }
        }

        private int[,] mask3;
        int divisor3;

        public int[,] Mask3
        {
            get { return mask3; }
        }

        public int Divisor3
        {
            get { return divisor3; }
        }

        public bool Use5x5
        {
            get { return radioButton2.Checked; }
        }

        public DualMask33Form()
        {
            mask1 = new int[3, 3];
            mask2 = new int[3, 3];
            mask3 = new int[5, 5];
            InitializeComponent();
            RecalculateMask1();
            RecalculateMask2();
            RecalculateMask3();
        }

        private void RecalculateMask1()
        {
            mask1[0, 0] = ParseOrZero(mask1Box.Text);
            mask1[0, 1] = ParseOrZero(mask2Box.Text);
            mask1[0, 2] = ParseOrZero(mask3Box.Text);
            mask1[1, 0] = ParseOrZero(mask4Box.Text);
            mask1[1, 1] = ParseOrZero(mask5Box.Text);
            mask1[1, 2] = ParseOrZero(mask6Box.Text);
            mask1[2, 0] = ParseOrZero(mask7Box.Text);
            mask1[2, 1] = ParseOrZero(mask8Box.Text);
            mask1[2, 2] = ParseOrZero(mask9Box.Text);

            if (!checkBox1.Checked)
                divisor1 = Math.Max(ParseOrZero(divisorBox.Text), 1);
            else
            {
                divisor1 = 0;
                foreach (int value in mask1)
                {
                    divisor1 += value;
                }
                divisor1 = Math.Max(divisor1, 1);
                divisorBox.Text = divisor1.ToString();
            }
        }

        private void RecalculateMask2()
        {
            mask2[0, 0] = ParseOrZero(mask2_1Box.Text);
            mask2[0, 1] = ParseOrZero(mask2_2Box.Text);
            mask2[0, 2] = ParseOrZero(mask2_3Box.Text);
            mask2[1, 0] = ParseOrZero(mask2_4Box.Text);
            mask2[1, 1] = ParseOrZero(mask2_5Box.Text);
            mask2[1, 2] = ParseOrZero(mask2_6Box.Text);
            mask2[2, 0] = ParseOrZero(mask2_7Box.Text);
            mask2[2, 1] = ParseOrZero(mask2_8Box.Text);
            mask2[2, 2] = ParseOrZero(mask2_9Box.Text);

            if (!checkBox2.Checked)
                divisor2 = Math.Max(ParseOrZero(divisor2Box.Text), 1);
            else
            {
                divisor2 = 0;
                foreach (int value in mask2)
                {
                    divisor2 += value;
                }
                divisor2 = Math.Max(divisor2, 1);
                divisor2Box.Text = divisor2.ToString();
            }
        }

        private void RecalculateMask3()
        {
            for (int i = 0; i < 5; ++i)
            {
                for (int j = 0; j < 5; ++j)
                {
                    mask3[i, j] = 0;
                    for (int k = -1; k < 2; ++k)
                    {
                        for (int l = -1; l < 2; ++l)
                        {
                            if (i + k - 1 >= 0 && i + k - 1 < 3 && j + l - 1 >= 0 && j + l - 1 < 3)
                                mask3[i, j] += mask1[i + k - 1, j + l - 1] * mask2[1 + k, 1 + l];
                        }
                    }
                }
            }

            

            mask3_0_0Box.Text = mask3[0, 0].ToString();
            mask3_0_1Box.Text = mask3[0, 1].ToString();
            mask3_0_2Box.Text = mask3[0, 2].ToString();
            mask3_0_3Box.Text = mask3[0, 3].ToString();
            mask3_0_4Box.Text = mask3[0, 4].ToString();

            mask3_1_0Box.Text = mask3[1, 0].ToString();
            mask3_1_1Box.Text = mask3[1, 1].ToString();
            mask3_1_2Box.Text = mask3[1, 2].ToString();
            mask3_1_3Box.Text = mask3[1, 3].ToString();
            mask3_1_4Box.Text = mask3[1, 4].ToString();

            mask3_2_0Box.Text = mask3[2, 0].ToString();
            mask3_2_1Box.Text = mask3[2, 1].ToString();
            mask3_2_2Box.Text = mask3[2, 2].ToString();
            mask3_2_3Box.Text = mask3[2, 3].ToString();
            mask3_2_4Box.Text = mask3[2, 4].ToString();

            mask3_3_0Box.Text = mask3[3, 0].ToString();
            mask3_3_1Box.Text = mask3[3, 1].ToString();
            mask3_3_2Box.Text = mask3[3, 2].ToString();
            mask3_3_3Box.Text = mask3[3, 3].ToString();
            mask3_3_4Box.Text = mask3[3, 4].ToString();

            mask3_4_0Box.Text = mask3[4, 0].ToString();
            mask3_4_1Box.Text = mask3[4, 1].ToString();
            mask3_4_2Box.Text = mask3[4, 2].ToString();
            mask3_4_3Box.Text = mask3[4, 3].ToString();
            mask3_4_4Box.Text = mask3[4, 4].ToString();

            divisor3 = divisor1 * divisor2;
            divisor3Label.Text = divisor3.ToString();
        }

        private int ParseOrZero(string s)
        {
            try
            {
                return Int32.Parse(s);
            }
            catch
            {
                return 0;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == false)
                divisor2Box.Enabled = true;
            else
                divisor2Box.Enabled = false;
            RecalculateMask2();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                RecalculateMask1();
                RecalculateMask2();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void mask1Box_TextChanged(object sender, EventArgs e)
        {
            RecalculateMask1();
            RecalculateMask3();
        }

        private void mask2Box_TextChanged(object sender, EventArgs e)
        {
            RecalculateMask1();
            RecalculateMask3();
        }

        private void mask3Box_TextChanged(object sender, EventArgs e)
        {
            RecalculateMask1();
            RecalculateMask3();
        }

        private void mask4Box_TextChanged(object sender, EventArgs e)
        {
            RecalculateMask1();
            RecalculateMask3();
        }

        private void mask5Box_TextChanged(object sender, EventArgs e)
        {
            RecalculateMask1();
            RecalculateMask3();
        }

        private void mask6Box_TextChanged(object sender, EventArgs e)
        {
            RecalculateMask1();
            RecalculateMask3();
        }

        private void mask7Box_TextChanged(object sender, EventArgs e)
        {
            RecalculateMask1();
            RecalculateMask3();
        }

        private void mask8Box_TextChanged(object sender, EventArgs e)
        {
            RecalculateMask1();
            RecalculateMask3();
        }

        private void mask9Box_TextChanged(object sender, EventArgs e)
        {
            RecalculateMask1();
            RecalculateMask3();
        }







        private void mask2_1Box_TextChanged(object sender, EventArgs e)
        {
            RecalculateMask2();
            RecalculateMask3();
        }

        private void mask2_2Box_TextChanged(object sender, EventArgs e)
        {
            RecalculateMask2();
            RecalculateMask3();
        }

        private void mask2_3Box_TextChanged(object sender, EventArgs e)
        {
            RecalculateMask2();
            RecalculateMask3();
        }

        private void mask2_4Box_TextChanged(object sender, EventArgs e)
        {
            RecalculateMask2();
            RecalculateMask3();
        }

        private void mask2_5Box_TextChanged(object sender, EventArgs e)
        {
            RecalculateMask2();
            RecalculateMask3();
        }

        private void mask2_6Box_TextChanged(object sender, EventArgs e)
        {
            RecalculateMask2();
            RecalculateMask3();
        }

        private void mask2_7Box_TextChanged(object sender, EventArgs e)
        {
            RecalculateMask2();
            RecalculateMask3();
        }

        private void mask2_8Box_TextChanged(object sender, EventArgs e)
        {
            RecalculateMask2();
            RecalculateMask3();
        }

        private void mask2_9Box_TextChanged(object sender, EventArgs e)
        {
            RecalculateMask2();
            RecalculateMask3();
        }
    }
}

