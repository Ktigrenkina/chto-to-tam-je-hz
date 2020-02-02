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
            int min = 100, max = -100;
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

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = ""; richTextBox1.Text = ""; richTextBox3.Text = "";
            Random r = new Random();
            int[] teak = new int[50];
            for (int j = 0; j < 50; j++)
            {
                teak[j] = r.Next(-100, 100);
                richTextBox1.Text += "mass[" + j.ToString() + "]=" +
                    teak[j].ToString() + "\n";
                if (teak[j] > 0)
                {
                    richTextBox2.Text += teak[j] + "\n";
                }
                if(teak[j] % 3 == 0)
                {
                    richTextBox3.Text += teak[j] + "\n";
                }
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = ""; richTextBox1.Text = ""; richTextBox3.Text = "";
            int[] kofe = new int[10];
            Random r = new Random();
            for(int k = 0; k < 10; k++)
            {
                kofe[k] = r.Next(10, 100);
                richTextBox2.Text += kofe[k].ToString() + "\n";
            }
            for (int u = 0; u < 9; u++)
            {
                for (int l = 0; l < 9; l++)
                {
                    if (kofe[l] < kofe[l + 1])
                    {
                        int tmp = kofe[l];
                        kofe[l] = kofe[l + 1];
                        kofe[l + 1] = tmp;
                    }
                }
            }
            for (int k = 0; k < 10; k++)
            {
                richTextBox3.Text += kofe[k].ToString() + "\n";
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = ""; richTextBox1.Text = "";
            Random r = new Random();
            List<int> list = new List<int>();
            for (int i = 0; i < 20; i++)
            {
                list.Add(r.Next(-1000, 1000));
                richTextBox1.Text += list[i] + "\n";
            }
            for(int i = 0; i < list.Count; i++)
            {
                if(list[i] >= -99 && list[i] <= -10 
                    || list[i] <= 99 && list[i] >= 10)
                {
                    list.RemoveAt(i);
                }
            }
            for (int i = 0; i < list.Count; i++)
            {
                richTextBox2.Text += list[i] + "\n";
            }
        }
    }
}
