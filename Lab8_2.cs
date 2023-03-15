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
            Close();
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

        static void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

        static void InsertionSort(int[] inArray)
        {
            int x;
            int j;
            for (int i = 1; i < inArray.Length; i++)
            {
                x = inArray[i];
                j = i;
                while (j > 0 && inArray[j - 1] > x)
                {
                    Swap(inArray, j, j - 1);
                    j -= 1;
                }
                inArray[j] = x;
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            for(int i=0; i<Arr.Length; i++)
            {
                InsertionSort(Arr);
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
