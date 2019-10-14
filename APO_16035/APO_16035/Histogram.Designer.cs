namespace APO_16035
{
    partial class Histogram
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
            this.components = new System.ComponentModel.Container();
            this.imageBox2 = new Emgu.CV.UI.ImageBox();
            this.imageBox3 = new Emgu.CV.UI.ImageBox();
            this.histogramBox1 = new Emgu.CV.UI.HistogramBox();
            this.histogramBox2 = new Emgu.CV.UI.HistogramBox();
            this.histogramBox3 = new Emgu.CV.UI.HistogramBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageBox2
            // 
            this.imageBox2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.imageBox2.Location = new System.Drawing.Point(431, 47);
            this.imageBox2.Name = "imageBox2";
            this.imageBox2.Size = new System.Drawing.Size(392, 237);
            this.imageBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox2.TabIndex = 2;
            this.imageBox2.TabStop = false;
            // 
            // imageBox3
            // 
            this.imageBox3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.imageBox3.Location = new System.Drawing.Point(838, 37);
            this.imageBox3.Name = "imageBox3";
            this.imageBox3.Size = new System.Drawing.Size(397, 247);
            this.imageBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox3.TabIndex = 2;
            this.imageBox3.TabStop = false;
            // 
            // histogramBox1
            // 
            this.histogramBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.histogramBox1.Location = new System.Drawing.Point(13, 304);
            this.histogramBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.histogramBox1.Name = "histogramBox1";
            this.histogramBox1.Size = new System.Drawing.Size(402, 318);
            this.histogramBox1.TabIndex = 3;
            // 
            // histogramBox2
            // 
            this.histogramBox2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.histogramBox2.Location = new System.Drawing.Point(431, 304);
            this.histogramBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.histogramBox2.Name = "histogramBox2";
            this.histogramBox2.Size = new System.Drawing.Size(392, 318);
            this.histogramBox2.TabIndex = 4;
            // 
            // histogramBox3
            // 
            this.histogramBox3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.histogramBox3.Location = new System.Drawing.Point(838, 304);
            this.histogramBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.histogramBox3.Name = "histogramBox3";
            this.histogramBox3.Size = new System.Drawing.Size(397, 318);
            this.histogramBox3.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(367, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(551, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // imageBox1
            // 
            this.imageBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.imageBox1.Location = new System.Drawing.Point(13, 47);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(402, 237);
            this.imageBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            // 
            // Histogram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 627);
            this.Controls.Add(this.imageBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.histogramBox3);
            this.Controls.Add(this.histogramBox2);
            this.Controls.Add(this.histogramBox1);
            this.Controls.Add(this.imageBox3);
            this.Controls.Add(this.imageBox2);
            this.Name = "Histogram";
            this.Text = "Histogram";
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Emgu.CV.UI.ImageBox imageBox2;
        private Emgu.CV.UI.ImageBox imageBox3;
        private Emgu.CV.UI.HistogramBox histogramBox1;
        private Emgu.CV.UI.HistogramBox histogramBox2;
        private Emgu.CV.UI.HistogramBox histogramBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private Emgu.CV.UI.ImageBox imageBox1;
    }
}