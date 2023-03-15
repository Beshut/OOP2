using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            file1.Filter = "(*.jpg) |*.jpg";
        }

        private void btn_Click(object sender, EventArgs e)
        {
            string fname;
            file1.ShowDialog();
            fname = file1.FileName;
            pct.Image = Image.FromFile(fname);
            txt.Text = fname;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            pct.Image.Save(saveFileDialog1.FileName);
        }
    }
}
