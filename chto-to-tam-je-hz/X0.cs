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
    public partial class X0 : Form
    {
        public X0()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        int Hod = 1, EndOfGame = 0, cliks = 0;
        public int Proverochka(string znak)
        {
            int end = 0;//проверка всех лейблов
            if (lb1.Text == znak && lb2.Text == znak && lb3.Text == znak)
            {
                end = 1;
            }
            else if (lb4.Text == znak && lb5.Text == znak && lb6.Text == znak)
            {
                end = 1;
            }
            else if (lb7.Text == znak && lb8.Text == znak && lb9.Text == znak)
            {
                end = 1;
            }
            else if (lb1.Text == znak && lb4.Text == znak && lb7.Text == znak)
            {
                end = 1;
            }
            else if (lb2.Text == znak && lb5.Text == znak && lb8.Text == znak)
            {
                end = 1;
            }
            else if (lb3.Text == znak && lb6.Text == znak && lb9.Text == znak)
            {
                end = 1;
            }
            else if (lb1.Text == znak && lb5.Text == znak && lb9.Text == znak)
            {
                end = 1;
            }
            else if (lb3.Text == znak && lb5.Text == znak && lb7.Text == znak)
            {
                end = 1;
            }
            if (znak == "O" && end == 1) MessageBox.Show("Победил 1 игрок");
            else if(znak == "X" && end == 1)MessageBox.Show("Победил 2 игрок");
            return end;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hod = 1;
            EndOfGame = 0;
            cliks = 0;
            label1.Text = "Ходит 1 игрок (      )";
            label2.Text = "O";
            label2.ForeColor = Color.MidnightBlue;
            for (int i = 1; i < 10; i++)
            {
                Controls["lb" + i].Text = "";
            }
        }

       

        private void lb_click(object sender, EventArgs e)
        {
            Label lb = sender as Label;
            if (lb.Text == "" && EndOfGame == 0)
            {
                if (Hod == 1)
                {
                    lb.Text = "O";
                    lb.ForeColor = Color.MidnightBlue;
                    EndOfGame = Proverochka("O");
                    label1.Text = "Ходит 2 игрок (      )";
                    label2.Text = "X";
                    label2.ForeColor = Color.Indigo;
                    Hod = 2;
                    if (radioButton2.Checked && cliks != 8)
                    {
                        Random r = new Random();
                        while (true) //for(;;) //бесконечный цикл
                        {
                            lb = Controls["lb" + r.Next(1, 10)] as Label;//рандомное число в пустом лейбле
                            if (lb.Text == "")//в пустом лейбле
                            {
                                lb_click(lb, e); // потому что событие вызывает саму себя 
                                break;
                            }
                        }
                    }
                }
                else 
                {
                    lb.Text = "X";
                    lb.ForeColor = Color.Indigo;
                    EndOfGame = Proverochka("X");
                    label1.Text = "Ходит 1 игрок (      )";
                    label2.Text = "O";
                    label2.ForeColor = Color.MidnightBlue;
                    Hod = 1;
                }
                cliks++;
            }
            if (cliks == 9 && EndOfGame == 0)
            {
                label1.Text = "Игра окончена";
                label2.Text = "";
                MessageBox.Show("Ничья");
            }
            if (EndOfGame == 1)
            {
                label1.Text = "Игра окончена";
                label2.Text = "";
            }
            
        }

        private void X0_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form frm = Application.OpenForms[1];
            frm.Show();
        }
    }
}
