using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chto_to_tam_je_hz
{
    public partial class Grafika : Form
    {
        public Grafika()
        {
            InitializeComponent();
        }

        private void Grafika_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form fmr = Application.OpenForms[1];
            fmr.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(pictureBox1.Width,pictureBox1.Height);
            Graphics graf = Graphics.FromImage(pictureBox1.Image);
            graf.DrawLine(Pens.LightPink, 10, 10, 50, 50);
            graf.DrawLine(Pens.Teal, 100, 10, 150, 50);
            graf.DrawEllipse(Pens.WhiteSmoke, 100, 100, 250, 250);
            graf.FillEllipse(Brushes.YellowGreen, 101, 101, 248, 248);
            Point[] pt = new Point[3];
            pt[0] = new Point(50, 300);
            pt[1] = new Point(50, 250);
            pt[2] = new Point(20, 100);
            Random R = new Random();
            int a = R.Next(0, 256),
                r = R.Next(0, 256),
                g = R.Next(0, 256),
                b = R.Next(0, 256);
            Brush brush = new SolidBrush(Color.FromArgb(a,r,g,b));
            graf.FillPolygon(brush, pt);
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics gr = Graphics.FromImage(pictureBox1.Image);
            Random R = new Random();
            int Count = R.Next(0, 256);

            for (int i = 0; i < Count; i++)
            {
                int a = R.Next(0, 256),
                    r = R.Next(0, 256),
                    g = R.Next(0, 256),
                    b = R.Next(0, 256),
                    x = R.Next(0, 600),
                    y = R.Next(0, 290);
                GraphicsPath path = new GraphicsPath();
                path.AddEllipse(x, y, 100, 100);
                PathGradientBrush PGB = new PathGradientBrush(path);
                PGB.CenterColor = Color.FromArgb(a, r, g, b);
                a = R.Next(0, 256);
                r = R.Next(0, 256);
                g = R.Next(0, 256);
                b = R.Next(0, 256);
                Color[] colors = { Color.FromArgb(a, r, g, b) };
                PGB.SurroundColors = colors;
                gr.FillEllipse(PGB, x, y, 100, 100);
            }
            

            //930; 449
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics graf = Graphics.FromImage(pictureBox1.Image);
            Random R = new Random();
            int a = R.Next(0, 256),
                   r = R.Next(0, 256),
                   g = R.Next(0, 256),
                   b = R.Next(0, 256);
           GraphicsPath path = new GraphicsPath();
            path.AddEllipse(20, 20, 300, 300);
            PathGradientBrush PGB = new PathGradientBrush(path);
            PGB.CenterColor = Color.FromArgb(a, r, g, b);
            Color[] colors = { Color.Red, Color.Thistle};
            PGB.SurroundColors = colors;
            graf.FillEllipse(PGB, 20, 20, 300, 300);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics gr = Graphics.FromImage(pictureBox1.Image);
            LinearGradientBrush Linear = new LinearGradientBrush(
                new Point(20, 20),
                new Point(320, 320),
                Color.Thistle,
                Color.Black);
            Rectangle rec = new Rectangle(20, 20, 300, 300);
            gr.FillRectangle(Linear, rec);

            LinearGradientBrush Linear2 = new LinearGradientBrush(
                new Point(350, 20),
                new Point(550, 20),
                Color.Black,
                Color.Thistle);
            Rectangle rec2 = new Rectangle(350, 20, 200, 200);
            gr.FillRectangle(Linear2, rec2);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics gr = Graphics.FromImage(pictureBox1.Image);
            Brush br = new SolidBrush(Color.MediumVioletRed);
            Point[] points = { new Point(300,100),
            new Point(400,200), new Point(350,300),
            new Point(250,300), new Point(200,200)};
            gr.FillPolygon(br, points);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics gr = Graphics.FromImage(pictureBox1.Image);
            Brush br = new SolidBrush(Color.MediumVioletRed);
            Point[] points = { new Point(10,40),
            new Point(30,50), new Point(30,70),
            new Point(40,50), new Point(60,60),
            new Point(50,40),new Point(60,30),
            new Point(40,30), new Point(30,10),
            new Point(30,30)};
            gr.FillPolygon(br, points);
        }
    }
}
