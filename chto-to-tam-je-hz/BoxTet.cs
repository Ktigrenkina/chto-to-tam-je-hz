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
    public partial class BoxTet : Form
    {
        public BoxTet()
        {
            InitializeComponent();
        }

        private void BoxTet_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form frm = Application.OpenForms[1];
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int  N = Convert.ToInt32(textBox1.Text), V = Convert.ToInt32(textBox1.Text), S = Convert.ToInt32(textBox1.Text);
            double dsch = Convert.ToDouble(textBox1.Text), z;
            Random r = new Random();
            for(int i = 1; i <= 10; i++)
            {
                z = r.NextDouble();
                if(z < dsch)
                {
                    V += S;
                }
            }
        }
    }
}
