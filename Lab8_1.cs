using System;
using System.Windows.Forms;

namespace Lesson_Lab8_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int[] Arr = new int[10];
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNewArr_Click(object sender, EventArgs e)
        {
            ClearFields();
            int n = 10;
            int a = int.Parse(txtMin.Text);
            int b = int.Parse(txtMax.Text);
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                Arr[i] = r.Next(a,b);
                lblArr.Text += Arr[i];
                if (i != 9) lblArr.Text += ", ";
            }
            btnSort.Enabled = true;
        }

        private int MinNumber(int[] x, int m)
        {
            int min = x[m];
            int MinN = m;
            for  (int i = m; i<x.Length; i++)
            {
                if (x[i] < min)
                {
                    min = x[i];
                    MinN = i;
                }
            }
            return MinN;
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            int k, t;
            for(int i=0; i<Arr.Length; i++)
            {
                k = MinNumber(Arr, i);
                t = Arr[i];
                Arr[i] = Arr[k];
                Arr[k] = t;
                lblResult.Text += Arr[i];
                if (i != Arr.Length - 1)
                {
                    lblResult.Text += ", ";
                }
            }
            btnSort.Enabled = true;
        }

        private void ClearFields()
        {
            lblArr.Text = String.Empty;
            lblResult.Text = String.Empty;
            btnSort.Enabled = false;
        }

        private void txtMin_TextChanged(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void txtMax_TextChanged(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
