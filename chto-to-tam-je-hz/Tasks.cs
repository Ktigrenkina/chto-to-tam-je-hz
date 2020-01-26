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
    public partial class Tasks : Form
    {
        public Tasks()
        {
            InitializeComponent();
        }

        private void Tasks_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form fmr = Application.OpenForms[1];
            fmr.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            try
            {
                int chi = Convert.ToInt32(textBox1.Text),
                    chi2 = Convert.ToInt32(textBox2.Text);
                int sum = 0;
                if(chi < chi2)
                {
                    for (int i = chi; i <= chi2; i++) 
                    {
                        //richTextBox1.Text += i + "\n"; //числа от 1 текстбокса до чисел во 2
                        sum += i;
                        label1.Text += i + "\n";//диапозон
                    }
                }
                else
                {
                    for (int j = chi; j >= chi2; j--)
                    {
                        sum += j;
                        richTextBox1.Text += j + "\n";
                        //обратный диапозон
                    }
                }
                    MessageBox.Show(sum.ToString());
                //мы показываем ответ сумму чисел
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            } 

        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            Random R = new Random();
            int[] tea = new int[50];
            int min = 100, max = -100, a = 0;
            for (int i = 0; i < 50; i++)
            {
                tea[i] = R.Next(-100, 100);
                richTextBox1.Text += "mass[" + i.ToString() + "]=" +
                    tea[i].ToString() + "\n";
                if (tea[i] > max)
                {
                    max = tea[i];
                }
                if(tea[i] < min)
                {
                    min = tea[i];
                }
                
            }
            richTextBox1.Text = max + "\n";
            richTextBox1.Text = min + "\n";
        }
    }
}
