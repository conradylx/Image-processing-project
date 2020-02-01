namespace Apo_Konrad_Bakowski
{
    partial class MainWindow
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lab1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lab2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tresholdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayLevelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.basicTresholdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.strechingToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.posterizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lab3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medianFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smoothingToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sharpeningToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.edgeDetectionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.directionalEdgeDetectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobelToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.robertsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.prewittToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lab4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skeletizationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dylationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fourConsistentToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eightConsistentToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.erosionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fourConsistentToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.eightConsistentToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fourConsistentToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.eightConsistentToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fourConsistentToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.eightConsistentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.twoStepsNeighbourOperationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lab5ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.imageAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regionMergeSegmentationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.universalNeighbourOperationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.lab1ToolStripMenuItem,
            this.lab2ToolStripMenuItem,
            this.lab3ToolStripMenuItem,
            this.lab4ToolStripMenuItem,
            this.lab5ToolStripMenuItem1,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1251, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // lab1ToolStripMenuItem
            // 
            this.lab1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.histogramToolStripMenuItem1});
            this.lab1ToolStripMenuItem.Name = "lab1ToolStripMenuItem";
            this.lab1ToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.lab1ToolStripMenuItem.Text = "Lab1";
            // 
            // histogramToolStripMenuItem1
            // 
            this.histogramToolStripMenuItem1.Name = "histogramToolStripMenuItem1";
            this.histogramToolStripMenuItem1.Size = new System.Drawing.Size(162, 26);
            this.histogramToolStripMenuItem1.Text = "Histogram";
            this.histogramToolStripMenuItem1.Click += new System.EventHandler(this.histogramToolStripMenuItem1_Click);
            // 
            // lab2ToolStripMenuItem
            // 
            this.lab2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.negationToolStripMenuItem1,
            this.tresholdToolStripMenuItem,
            this.strechingToolStripMenuItem1,
            this.posterizeToolStripMenuItem});
            this.lab2ToolStripMenuItem.Name = "lab2ToolStripMenuItem";
            this.lab2ToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.lab2ToolStripMenuItem.Text = "Lab2";
            // 
            // negationToolStripMenuItem1
            // 
            this.negationToolStripMenuItem1.Name = "negationToolStripMenuItem1";
            this.negationToolStripMenuItem1.Size = new System.Drawing.Size(154, 26);
            this.negationToolStripMenuItem1.Text = "Negation";
            this.negationToolStripMenuItem1.Click += new System.EventHandler(this.negationToolStripMenuItem1_Click);
            // 
            // tresholdToolStripMenuItem
            // 
            this.tresholdToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.grayLevelToolStripMenuItem,
            this.basicTresholdToolStripMenuItem});
            this.tresholdToolStripMenuItem.Name = "tresholdToolStripMenuItem";
            this.tresholdToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.tresholdToolStripMenuItem.Text = "Treshold";
            // 
            // grayLevelToolStripMenuItem
            // 
            this.grayLevelToolStripMenuItem.Name = "grayLevelToolStripMenuItem";
            this.grayLevelToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.grayLevelToolStripMenuItem.Text = "Gray level";
            this.grayLevelToolStripMenuItem.Click += new System.EventHandler(this.grayLevelToolStripMenuItem_Click);
            // 
            // basicTresholdToolStripMenuItem
            // 
            this.basicTresholdToolStripMenuItem.Name = "basicTresholdToolStripMenuItem";
            this.basicTresholdToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.basicTresholdToolStripMenuItem.Text = "Basic treshold";
            this.basicTresholdToolStripMenuItem.Click += new System.EventHandler(this.basicTresholdToolStripMenuItem_Click);
            // 
            // strechingToolStripMenuItem1
            // 
            this.strechingToolStripMenuItem1.Name = "strechingToolStripMenuItem1";
            this.strechingToolStripMenuItem1.Size = new System.Drawing.Size(154, 26);
            this.strechingToolStripMenuItem1.Text = "Streching";
            this.strechingToolStripMenuItem1.Click += new System.EventHandler(this.strechingToolStripMenuItem1_Click);
            // 
            // posterizeToolStripMenuItem
            // 
            this.posterizeToolStripMenuItem.Name = "posterizeToolStripMenuItem";
            this.posterizeToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.posterizeToolStripMenuItem.Text = "Posterize";
            this.posterizeToolStripMenuItem.Click += new System.EventHandler(this.posterizeToolStripMenuItem_Click);
            // 
            // lab3ToolStripMenuItem
            // 
            this.lab3ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.medianFilterToolStripMenuItem,
            this.smoothingToolStripMenuItem1,
            this.sharpeningToolStripMenuItem1,
            this.edgeDetectionToolStripMenuItem1,
            this.directionalEdgeDetectionToolStripMenuItem});
            this.lab3ToolStripMenuItem.Name = "lab3ToolStripMenuItem";
            this.lab3ToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.lab3ToolStripMenuItem.Text = "Lab3";
            // 
            // medianFilterToolStripMenuItem
            // 
            this.medianFilterToolStripMenuItem.Name = "medianFilterToolStripMenuItem";
            this.medianFilterToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.medianFilterToolStripMenuItem.Text = "Median filter";
            this.medianFilterToolStripMenuItem.Click += new System.EventHandler(this.medianFilterToolStripMenuItem_Click);
            // 
            // smoothingToolStripMenuItem1
            // 
            this.smoothingToolStripMenuItem1.Name = "smoothingToolStripMenuItem1";
            this.smoothingToolStripMenuItem1.Size = new System.Drawing.Size(270, 26);
            this.smoothingToolStripMenuItem1.Text = "Smoothing";
            this.smoothingToolStripMenuItem1.Click += new System.EventHandler(this.smoothingToolStripMenuItem1_Click);
            // 
            // sharpeningToolStripMenuItem1
            // 
            this.sharpeningToolStripMenuItem1.Name = "sharpeningToolStripMenuItem1";
            this.sharpeningToolStripMenuItem1.Size = new System.Drawing.Size(270, 26);
            this.sharpeningToolStripMenuItem1.Text = "Sharpening";
            this.sharpeningToolStripMenuItem1.Click += new System.EventHandler(this.sharpeningToolStripMenuItem1_Click);
            // 
            // edgeDetectionToolStripMenuItem1
            // 
            this.edgeDetectionToolStripMenuItem1.Name = "edgeDetectionToolStripMenuItem1";
            this.edgeDetectionToolStripMenuItem1.Size = new System.Drawing.Size(270, 26);
            this.edgeDetectionToolStripMenuItem1.Text = "Edge Detection";
            this.edgeDetectionToolStripMenuItem1.Click += new System.EventHandler(this.edgeDetectionToolStripMenuItem1_Click);
            // 
            // directionalEdgeDetectionToolStripMenuItem
            // 
            this.directionalEdgeDetectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobelToolStripMenuItem1,
            this.robertsToolStripMenuItem1,
            this.prewittToolStripMenuItem1});
            this.directionalEdgeDetectionToolStripMenuItem.Name = "directionalEdgeDetectionToolStripMenuItem";
            this.directionalEdgeDetectionToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.directionalEdgeDetectionToolStripMenuItem.Text = "Directional edge detection";
            // 
            // sobelToolStripMenuItem1
            // 
            this.sobelToolStripMenuItem1.Name = "sobelToolStripMenuItem1";
            this.sobelToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.sobelToolStripMenuItem1.Text = "Sobel";
            this.sobelToolStripMenuItem1.Click += new System.EventHandler(this.sobelToolStripMenuItem1_Click);
            // 
            // robertsToolStripMenuItem1
            // 
            this.robertsToolStripMenuItem1.Name = "robertsToolStripMenuItem1";
            this.robertsToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.robertsToolStripMenuItem1.Text = "Roberts";
            this.robertsToolStripMenuItem1.Click += new System.EventHandler(this.robertsToolStripMenuItem1_Click);
            // 
            // prewittToolStripMenuItem1
            // 
            this.prewittToolStripMenuItem1.Name = "prewittToolStripMenuItem1";
            this.prewittToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.prewittToolStripMenuItem1.Text = "Prewitt";
            this.prewittToolStripMenuItem1.Click += new System.EventHandler(this.prewittToolStripMenuItem1_Click);
            // 
            // lab4ToolStripMenuItem
            // 
            this.lab4ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.skeletizationToolStripMenuItem,
            this.dylationToolStripMenuItem,
            this.erosionToolStripMenuItem,
            this.openToolStripMenuItem1,
            this.closeToolStripMenuItem1,
            this.twoStepsNeighbourOperationToolStripMenuItem,
            this.universalNeighbourOperationToolStripMenuItem});
            this.lab4ToolStripMenuItem.Name = "lab4ToolStripMenuItem";
            this.lab4ToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.lab4ToolStripMenuItem.Text = "Lab4";
            // 
            // skeletizationToolStripMenuItem
            // 
            this.skeletizationToolStripMenuItem.Name = "skeletizationToolStripMenuItem";
            this.skeletizationToolStripMenuItem.Size = new System.Drawing.Size(301, 26);
            this.skeletizationToolStripMenuItem.Text = "Skeletization";
            this.skeletizationToolStripMenuItem.Click += new System.EventHandler(this.skeletizationToolStripMenuItem_Click);
            // 
            // dylationToolStripMenuItem
            // 
            this.dylationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fourConsistentToolStripMenuItem1,
            this.eightConsistentToolStripMenuItem2});
            this.dylationToolStripMenuItem.Name = "dylationToolStripMenuItem";
            this.dylationToolStripMenuItem.Size = new System.Drawing.Size(301, 26);
            this.dylationToolStripMenuItem.Text = "Dylation";
            // 
            // fourConsistentToolStripMenuItem1
            // 
            this.fourConsistentToolStripMenuItem1.Name = "fourConsistentToolStripMenuItem1";
            this.fourConsistentToolStripMenuItem1.Size = new System.Drawing.Size(196, 26);
            this.fourConsistentToolStripMenuItem1.Text = "Four consistent";
            this.fourConsistentToolStripMenuItem1.Click += new System.EventHandler(this.fourConsistentToolStripMenuItem1_Click);
            // 
            // eightConsistentToolStripMenuItem2
            // 
            this.eightConsistentToolStripMenuItem2.Name = "eightConsistentToolStripMenuItem2";
            this.eightConsistentToolStripMenuItem2.Size = new System.Drawing.Size(196, 26);
            this.eightConsistentToolStripMenuItem2.Text = "Eight consistent";
            this.eightConsistentToolStripMenuItem2.Click += new System.EventHandler(this.eightConsistentToolStripMenuItem2_Click);
            // 
            // erosionToolStripMenuItem
            // 
            this.erosionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fourConsistentToolStripMenuItem2,
            this.eightConsistentToolStripMenuItem3});
            this.erosionToolStripMenuItem.Name = "erosionToolStripMenuItem";
            this.erosionToolStripMenuItem.Size = new System.Drawing.Size(301, 26);
            this.erosionToolStripMenuItem.Text = "Erosion";
            // 
            // fourConsistentToolStripMenuItem2
            // 
            this.fourConsistentToolStripMenuItem2.Name = "fourConsistentToolStripMenuItem2";
            this.fourConsistentToolStripMenuItem2.Size = new System.Drawing.Size(196, 26);
            this.fourConsistentToolStripMenuItem2.Text = "Four consistent";
            this.fourConsistentToolStripMenuItem2.Click += new System.EventHandler(this.fourConsistentToolStripMenuItem2_Click);
            // 
            // eightConsistentToolStripMenuItem3
            // 
            this.eightConsistentToolStripMenuItem3.Name = "eightConsistentToolStripMenuItem3";
            this.eightConsistentToolStripMenuItem3.Size = new System.Drawing.Size(196, 26);
            this.eightConsistentToolStripMenuItem3.Text = "Eight consistent";
            this.eightConsistentToolStripMenuItem3.Click += new System.EventHandler(this.eightConsistentToolStripMenuItem3_Click);
            // 
            // openToolStripMenuItem1
            // 
            this.openToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fourConsistentToolStripMenuItem3,
            this.eightConsistentToolStripMenuItem4});
            this.openToolStripMenuItem1.Name = "openToolStripMenuItem1";
            this.openToolStripMenuItem1.Size = new System.Drawing.Size(301, 26);
            this.openToolStripMenuItem1.Text = "Open";
            // 
            // fourConsistentToolStripMenuItem3
            // 
            this.fourConsistentToolStripMenuItem3.Name = "fourConsistentToolStripMenuItem3";
            this.fourConsistentToolStripMenuItem3.Size = new System.Drawing.Size(196, 26);
            this.fourConsistentToolStripMenuItem3.Text = "Four consistent";
            this.fourConsistentToolStripMenuItem3.Click += new System.EventHandler(this.fourConsistentToolStripMenuItem3_Click);
            // 
            // eightConsistentToolStripMenuItem4
            // 
            this.eightConsistentToolStripMenuItem4.Name = "eightConsistentToolStripMenuItem4";
            this.eightConsistentToolStripMenuItem4.Size = new System.Drawing.Size(196, 26);
            this.eightConsistentToolStripMenuItem4.Text = "Eight consistent";
            this.eightConsistentToolStripMenuItem4.Click += new System.EventHandler(this.eightConsistentToolStripMenuItem4_Click);
            // 
            // closeToolStripMenuItem1
            // 
            this.closeToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fourConsistentToolStripMenuItem4,
            this.eightConsistentToolStripMenuItem});
            this.closeToolStripMenuItem1.Name = "closeToolStripMenuItem1";
            this.closeToolStripMenuItem1.Size = new System.Drawing.Size(301, 26);
            this.closeToolStripMenuItem1.Text = "Close";
            // 
            // fourConsistentToolStripMenuItem4
            // 
            this.fourConsistentToolStripMenuItem4.Name = "fourConsistentToolStripMenuItem4";
            this.fourConsistentToolStripMenuItem4.Size = new System.Drawing.Size(196, 26);
            this.fourConsistentToolStripMenuItem4.Text = "Four consistent";
            this.fourConsistentToolStripMenuItem4.Click += new System.EventHandler(this.fourConsistentToolStripMenuItem4_Click);
            // 
            // eightConsistentToolStripMenuItem
            // 
            this.eightConsistentToolStripMenuItem.Name = "eightConsistentToolStripMenuItem";
            this.eightConsistentToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.eightConsistentToolStripMenuItem.Text = "Eight consistent";
            this.eightConsistentToolStripMenuItem.Click += new System.EventHandler(this.eightConsistentToolStripMenuItem_Click);
            // 
            // twoStepsNeighbourOperationToolStripMenuItem
            // 
            this.twoStepsNeighbourOperationToolStripMenuItem.Name = "twoStepsNeighbourOperationToolStripMenuItem";
            this.twoStepsNeighbourOperationToolStripMenuItem.Size = new System.Drawing.Size(301, 26);
            this.twoStepsNeighbourOperationToolStripMenuItem.Text = "Two steps Neighbour operation";
            this.twoStepsNeighbourOperationToolStripMenuItem.Click += new System.EventHandler(this.twoStepsNeighbourOperationToolStripMenuItem_Click);
            // 
            // lab5ToolStripMenuItem1
            // 
            this.lab5ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imageAnalysisToolStripMenuItem,
            this.regionMergeSegmentationToolStripMenuItem});
            this.lab5ToolStripMenuItem1.Name = "lab5ToolStripMenuItem1";
            this.lab5ToolStripMenuItem1.Size = new System.Drawing.Size(55, 24);
            this.lab5ToolStripMenuItem1.Text = "Lab5";
            // 
            // imageAnalysisToolStripMenuItem
            // 
            this.imageAnalysisToolStripMenuItem.Name = "imageAnalysisToolStripMenuItem";
            this.imageAnalysisToolStripMenuItem.Size = new System.Drawing.Size(281, 26);
            this.imageAnalysisToolStripMenuItem.Text = "Image analysis";
            this.imageAnalysisToolStripMenuItem.Click += new System.EventHandler(this.imageAnalysisToolStripMenuItem_Click);
            // 
            // regionMergeSegmentationToolStripMenuItem
            // 
            this.regionMergeSegmentationToolStripMenuItem.Name = "regionMergeSegmentationToolStripMenuItem";
            this.regionMergeSegmentationToolStripMenuItem.Size = new System.Drawing.Size(281, 26);
            this.regionMergeSegmentationToolStripMenuItem.Text = "Region merge segmentation";
            this.regionMergeSegmentationToolStripMenuItem.Click += new System.EventHandler(this.regionMergeSegmentationToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 33);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1235, 695);
            this.panel1.TabIndex = 1;
            // 
            // universalNeighbourOperationToolStripMenuItem
            // 
            this.universalNeighbourOperationToolStripMenuItem.Name = "universalNeighbourOperationToolStripMenuItem";
            this.universalNeighbourOperationToolStripMenuItem.Size = new System.Drawing.Size(301, 26);
            this.universalNeighbourOperationToolStripMenuItem.Text = "Universal neighbour operation";
            this.universalNeighbourOperationToolStripMenuItem.Click += new System.EventHandler(this.universalNeighbourOperationToolStripMenuItem_Click_2);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 773);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem lab1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lab2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lab3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lab4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lab5ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem histogramToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem negationToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tresholdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grayLevelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem basicTresholdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem strechingToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem posterizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medianFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smoothingToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sharpeningToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem edgeDetectionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem directionalEdgeDetectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobelToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem robertsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem prewittToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem skeletizationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dylationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fourConsistentToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem eightConsistentToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem erosionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fourConsistentToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem eightConsistentToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fourConsistentToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem eightConsistentToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fourConsistentToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem eightConsistentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem twoStepsNeighbourOperationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageAnalysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regionMergeSegmentationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem universalNeighbourOperationToolStripMenuItem;
    }
}

