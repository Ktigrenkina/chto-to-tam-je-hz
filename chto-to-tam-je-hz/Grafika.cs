using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
                    x = R.Next(0, 670),
                    y = R.Next(0, 360);
                Brush br = new SolidBrush(Color.FromArgb(a, r, g, b));
                gr.FillEllipse(br, x, y, 30, 30);
            }
            //930; 449
        }
    }
}
