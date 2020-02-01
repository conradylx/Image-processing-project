namespace Apo_Konrad_Bakowski
{
    partial class MaskCreator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.divisorBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.mask7Box = new System.Windows.Forms.TextBox();
            this.mask8Box = new System.Windows.Forms.TextBox();
            this.mask9Box = new System.Windows.Forms.TextBox();
            this.mask4Box = new System.Windows.Forms.TextBox();
            this.mask5Box = new System.Windows.Forms.TextBox();
            this.mask6Box = new System.Windows.Forms.TextBox();
            this.mask3Box = new System.Windows.Forms.TextBox();
            this.mask2Box = new System.Windows.Forms.TextBox();
            this.mask1Box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(84, 175);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(47, 17);
            this.checkBox1.TabIndex = 27;
            this.checkBox1.Text = "auto";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // divisorBox
            // 
            this.divisorBox.Enabled = false;
            this.divisorBox.Location = new System.Drawing.Point(44, 172);
            this.divisorBox.Name = "divisorBox";
            this.divisorBox.Size = new System.Drawing.Size(25, 20);
            this.divisorBox.TabIndex = 26;
            this.divisorBox.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Divisor:";
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(196, 178);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(48, 23);
            this.buttonCancel.TabIndex = 24;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(153, 179);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(37, 23);
            this.buttonOK.TabIndex = 23;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // mask7Box
            // 
            this.mask7Box.Location = new System.Drawing.Point(84, 126);
            this.mask7Box.Name = "mask7Box";
            this.mask7Box.Size = new System.Drawing.Size(25, 20);
            this.mask7Box.TabIndex = 20;
            this.mask7Box.Text = "1";
            this.mask7Box.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // mask8Box
            // 
            this.mask8Box.Location = new System.Drawing.Point(132, 126);
            this.mask8Box.Name = "mask8Box";
            this.mask8Box.Size = new System.Drawing.Size(25, 20);
            this.mask8Box.TabIndex = 21;
            this.mask8Box.Text = "1";
            this.mask8Box.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // mask9Box
            // 
            this.mask9Box.Location = new System.Drawing.Point(180, 126);
            this.mask9Box.Name = "mask9Box";
            this.mask9Box.Size = new System.Drawing.Size(25, 20);
            this.mask9Box.TabIndex = 22;
            this.mask9Box.Text = "1";
            this.mask9Box.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // mask4Box
            // 
            this.mask4Box.Location = new System.Drawing.Point(84, 92);
            this.mask4Box.Name = "mask4Box";
            this.mask4Box.Size = new System.Drawing.Size(25, 20);
            this.mask4Box.TabIndex = 17;
            this.mask4Box.Text = "1";
            this.mask4Box.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // mask5Box
            // 
            this.mask5Box.Location = new System.Drawing.Point(132, 92);
            this.mask5Box.Name = "mask5Box";
            this.mask5Box.Size = new System.Drawing.Size(25, 20);
            this.mask5Box.TabIndex = 18;
            this.mask5Box.Text = "1";
            this.mask5Box.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // mask6Box
            // 
            this.mask6Box.Location = new System.Drawing.Point(180, 92);
            this.mask6Box.Name = "mask6Box";
            this.mask6Box.Size = new System.Drawing.Size(25, 20);
            this.mask6Box.TabIndex = 19;
            this.mask6Box.Text = "1";
            this.mask6Box.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // mask3Box
            // 
            this.mask3Box.Location = new System.Drawing.Point(180, 58);
            this.mask3Box.Name = "mask3Box";
            this.mask3Box.Size = new System.Drawing.Size(25, 20);
            this.mask3Box.TabIndex = 16;
            this.mask3Box.Text = "1";
            this.mask3Box.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // mask2Box
            // 
            this.mask2Box.Location = new System.Drawing.Point(132, 58);
            this.mask2Box.Name = "mask2Box";
            this.mask2Box.Size = new System.Drawing.Size(25, 20);
            this.mask2Box.TabIndex = 15;
            this.mask2Box.Text = "1";
            this.mask2Box.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // mask1Box
            // 
            this.mask1Box.Location = new System.Drawing.Point(84, 58);
            this.mask1Box.Name = "mask1Box";
            this.mask1Box.Size = new System.Drawing.Size(25, 20);
            this.mask1Box.TabIndex = 14;
            this.mask1Box.Text = "1";
            this.mask1Box.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // MaskCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.divisorBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.mask7Box);
            this.Controls.Add(this.mask8Box);
            this.Controls.Add(this.mask9Box);
            this.Controls.Add(this.mask4Box);
            this.Controls.Add(this.mask5Box);
            this.Controls.Add(this.mask6Box);
            this.Controls.Add(this.mask3Box);
            this.Controls.Add(this.mask2Box);
            this.Controls.Add(this.mask1Box);
            this.Name = "MaskCreator";
            this.Text = "MaskCreator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox divisorBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.TextBox mask7Box;
        private System.Windows.Forms.TextBox mask8Box;
        private System.Windows.Forms.TextBox mask9Box;
        private System.Windows.Forms.TextBox mask4Box;
        private System.Windows.Forms.TextBox mask5Box;
        private System.Windows.Forms.TextBox mask6Box;
        private System.Windows.Forms.TextBox mask3Box;
        private System.Windows.Forms.TextBox mask2Box;
        private System.Windows.Forms.TextBox mask1Box;
    }
}