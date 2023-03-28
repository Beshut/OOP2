using System;
using System.Windows.Forms;

namespace Lab10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Calc_Click(object sender, EventArgs e)
        {
            double Xmin = double.Parse(textBoxXmin.Text);
            double Xmax = double.Parse(textBoxXmax.Text);
            double Step = double.Parse(textBoxStep.Text);
            const double a = 0.41;

            int count = (int)Math.Ceiling((Xmax - Xmin) / Step) + 1;
            double[] x = new double[count];

            double[] y1 = new double[count];
            double[] y2 = new double[count];

            for (int i = 0; i < count; i++)
            { 
                x[i] = Xmin + Step * i; 
                y1[i] = a + Math.Pow(x[i], 2 / 3) * Math.Cos(x[i] + Math.Pow(Math.E, x[i]));
                y2[i] = Math.Cos(x[i]);
            }

            chart1.ChartAreas[0].AxisX.Minimum = Xmin;
            chart1.ChartAreas[0].AxisX.Maximum = Xmax;

            chart1.ChartAreas[0].AxisX.MajorGrid.Interval = Step;

            chart1.Series[0].Points.DataBindXY(x, y1);
            chart1.Series[1].Points.DataBindXY(x, y2);
        }
    }
}
