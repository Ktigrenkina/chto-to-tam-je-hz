using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace chto_to_tam_je_hz
{
    
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void tb_Leave(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb.Text == "" && tb.Name == "textBox1")
            {
                tb.Text = "Login";
                tb.ForeColor = Color.DimGray;
            }
            else if (tb.Text == "" && tb.Name == "textBox2")
            {
                tb.Text = "Password";
                tb.PasswordChar = '\0';
                tb.ForeColor = Color.DimGray;
            }


        }

        private void tb_Enter(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb.Text == "Login" || tb.Text == "Password")
            {
                tb.ForeColor = Color.Black;
                tb.Text = string.Empty;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '\0')
                textBox2.PasswordChar = '*';
            else if (textBox2.PasswordChar == '*')
                textBox2.PasswordChar = '\0';
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string User_Login = textBox1.Text,
                User_Password = textBox2.Text;
            StreamReader sr = new StreamReader("users/UserInfo.txt");
            bool Aser = false;
            while (!sr.EndOfStream)
            {
                string[] info = sr.ReadLine().Split('.');
                if (info[0] == User_Login && info[1] == User_Password)
                {
                    Aser = true;
                    MessageBox.Show("Вы успешно авторизовались",
                        "Успешный вход", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    Form MW = new MainWindows(info[0],info[2]);
                    MW.Show();
                    this.Hide();
                    break;
                }
            }
            sr.Close();
            if (!Aser)
            {
                MessageBox.Show("Неверный логин или пароль",
                  "Ошибка входа", MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form MW = new MainWindows("Мини-Хацкер!","a");
            MW.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form2 = new SignUp();
            form2.Show();
            this.Hide();
        }
    }
}