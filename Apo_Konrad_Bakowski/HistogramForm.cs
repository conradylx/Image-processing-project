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
using System.Windows.Forms.DataVisualization.Charting;

namespace Apo_Konrad_Bakowski
{
    public partial class HistogramForm : Form
    {
        public HistogramForm(Image<Bgr, byte> img)
        {
            InitializeComponent();

            var r = InitHistogram(img[0], "Red");
            var g = InitHistogram(img[1], "Green");
            var b = InitHistogram(img[2], "Blue");

            chart1.Series.Clear();
            Series series = new Series();
            series.ChartType = SeriesChartType.Column;
            series.Name = "Red";
            series.Color = Color.Red;
            chart1.Series.Add(series);

            for (int i = 0; i < r.Length; i++)
            {
                chart1.Series["Red"].Points.AddXY(i, r[i]);
            }

            chart2.Series.Clear();
            Series series2 = new Series();
            series2.ChartType = SeriesChartType.Column;
            series2.Name = "Green";
            series2.Color = Color.Green;
            chart2.Series.Add(series2);

            for (int i = 0; i < g.Length; i++)
            {
                chart2.Series["Green"].Points.AddXY(i, g[i]);
            }

            chart3.Series.Clear();
            Series series3 = new Series();
            series3.ChartType = SeriesChartType.Column;
            series3.Name = "Blue";
            series3.Color = Color.Blue;
            chart3.Series.Add(series3);

            for (int i = 0; i < b.Length; i++)
            {
                chart3.Series["Blue"].Points.AddXY(i, b[i]);
            }

            chart1.Show();
            chart2.Show();
            chart3.Show();

        }

        public static int[] InitHistogram(Image<Gray, byte> bmp, string channel)
        {
            int[] tab = new int[256];

            for (int i = 0; i < 256; i++)
            {
                tab[i] = 0;
            }
            var matrix = bmp.Data;
            foreach (var i in matrix)
            {
                tab[i]++;
            }

            return tab;
        }
    }
}
