using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            SolidBrush myBrush = new SolidBrush(Color.MediumTurquoise);
            Rectangle myRect = new Rectangle(0, 0, 500, 500);
            g.FillRegion(myBrush, new Region(myRect));

            SolidBrush myBrush1 = new SolidBrush(Color.LightSeaGreen);
            Rectangle myRect1 = new Rectangle(75, 75, 350, 350);
            g.FillRegion(myBrush1, new Region(myRect1));

            Pen p = new Pen(Color.DarkTurquoise, 5);
            Point p1 = new Point(75, 75);
            Point p2 = new Point(425, 425);
            g.DrawLine(p, p1, p2);

            Pen p3 = new Pen(Color.DarkTurquoise, 5);
            Point p4 = new Point(425, 75);
            Point p5 = new Point(75, 425);
            g.DrawLine(p3, p4, p5);

            SolidBrush myBrush2 = new SolidBrush(Color.MediumSlateBlue);
            Graphics formGraphics = this.CreateGraphics();
            formGraphics.FillEllipse(myBrush2, new Rectangle(155, 155, 200, 200));
            myBrush.Dispose();
            formGraphics.Dispose();

            Pen p6 = new Pen(Color.Lime, 5);
            Point p7 = new Point(220, 245);
            Point p8 = new Point(250, 282);
            g.DrawLine(p6, p7, p8);

            Pen p12 = new Pen(Color.Green, 5);
            Point p13 = new Point(228, 255);
            Point p14 = new Point(240, 270);
            g.DrawLine(p12, p13, p14);

            Pen p9 = new Pen(Color.Lime, 5);
            Point p10 = new Point(250, 282);
            Point p11 = new Point(310, 220);
            g.DrawLine(p9, p10, p11);

            Pen p15 = new Pen(Color.Green, 5);
            Point p16 = new Point(260, 272);
            Point p17 = new Point(290, 240);
            g.DrawLine(p15, p16, p17);

            g.DrawEllipse(new Pen(Color.Aqua, 5), new Rectangle(155, 155, 200, 200));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
