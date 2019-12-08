﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO;

namespace chto_to_tam_je_hz
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
            Form form1 = Application.OpenForms[0];
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string UserLogin = textBox1.Text, 
                UserPassword = textBox2.Text;
            bool IsFounded = true;
            StreamReader sr = new StreamReader("users/UserInfo.txt");
            while (!sr.EndOfStream)
            {
                string[] info = sr.ReadLine().Split('.');
                if (info[0] == UserLogin)
                {
                    IsFounded = false;
                    label1.Visible = true;
                    break;
                }
            }
            sr.Close();
            if (IsFounded)
            {
                StreamWriter swinfo = new StreamWriter("users/UserInfo.txt", true);
                swinfo.WriteLine(UserLogin + "."+UserPassword+".u");
                swinfo.Close();
                MessageBox.Show("Вы успешно зарегистрировались",
                  "Успешная регистрация", MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '\0')
                textBox2.PasswordChar = '*';
            else if (textBox2.PasswordChar == '*')
                textBox2.PasswordChar = '\0';
        }

        private void SignUp_Leave(object sender, EventArgs e)
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
    }
}
