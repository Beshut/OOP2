using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Lab12
{
    public partial class Form1 : Form
    {
        float angle;
        int x;
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint, true);
        }

        void DrawWheelty(Graphics gr)
        {
            gr.SmoothingMode = SmoothingMode.HighQuality;
            //радиус колеса
            var r = 30;
            //спицы
            using (var pen = new Pen(Color.Black, 2))
                for (int a = 0; a < 360; a += 45)
                {
                    gr.DrawLine(pen, 0, 0, r, 0);
                    gr.RotateTransform(45);
                }
            //шина
            using (var pen1 = new Pen(Color.Black, 3))
            using (var pen2 = new Pen(Color.DimGray, 8))
            {
                gr.DrawEllipse(pen2, -r + 5, -r + 5, r * 2 - 10, r * 2 - 10);
                gr.DrawEllipse(pen1, -r, -r, r * 2, r * 2);
                gr.DrawEllipse(pen1, -r + 10, -r + 10, r * 2 - 20, r * 2 - 20);
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            angle += 5f;
            x += 5;
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            SolidBrush myBrush = new SolidBrush(Color.DeepSkyBlue);
            Rectangle myRect = new Rectangle(x - 20, 177, 200, 100);
            g.FillRegion(myBrush, new Region(myRect));

            SolidBrush myBrush1 = new SolidBrush(Color.LightCyan);
            Rectangle myRect1 = new Rectangle(x + 90, 190, 70, 40);
            g.FillRegion(myBrush1, new Region(myRect1));

            g.TranslateTransform(x, 270);
            g.RotateTransform(angle);
            DrawWheelty(g);
            g.RotateTransform(-angle);

            g.TranslateTransform(150, 0);
            g.RotateTransform(angle);
            DrawWheelty(g);
        }
    }
}
