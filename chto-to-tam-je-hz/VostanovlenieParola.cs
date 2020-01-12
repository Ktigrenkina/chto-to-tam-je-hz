using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.IO;

namespace chto_to_tam_je_hz
{
    public partial class VostanovlenieParola : Form
    {
        public VostanovlenieParola()
        {
            InitializeComponent();
        }
        int time, kot = 0, kod;
        string UserPassword = "";
        private void button1_Click(object sender, EventArgs e)
        {
            
            bool IsExist = false;
            StreamReader sr = new StreamReader("users/UserInfo.txt");
            {
                while (!sr.EndOfStream)
                {
                    string[] tmp = sr.ReadLine().Split(',');
                    if(tmp[2] == textBox1.Text)
                    {
                        UserPassword = tmp[1];
                        try
                        {

                            MailAddress from = new MailAddress("SigmaGroup3Reports@mail.ru", "Тигрёнка");
                            MailAddress to = new MailAddress(textBox1.Text);
                            MailMessage m = new MailMessage(from, to);
                            m.Subject = "Восстановление пароля";
                            Random R = new Random();
                            kod = R.Next();
                            m.Body = "Код для восстановления вашего пароля<br>" +
                                "<p style=\"font-size:20px;\"><b>" + kod + "</b></p>";
                            m.IsBodyHtml = true;
                            SmtpClient smtp = new SmtpClient("smtp.mail.ru", 587);
                            smtp.Credentials = new NetworkCredential("SigmaGroup3Reports@mail.ru", "Komsomolskiy");
                            smtp.EnableSsl = true;
                            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                            smtp.Send(m);
                            time = 60;
                            button1.Enabled = false;
                            timer1.Enabled = true;
                            label1.Visible = true;
                        }
                        catch
                        {
                            MessageBox.Show("Введеный адрес электроной почты указан не верно",
                                "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }
                        IsExist = true;
                        break;
                    }
                }
            }
            



            if (!IsExist)
            {
                DialogResult rezult = MessageBox.Show("Данный электронный адрес не зарегистрирован.\n"+
                    "Хотите ли вы перейти на окно регистрации?", "Возникла проблема с отправкой кода",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(rezult == DialogResult.Yes)
                {
                    kot = 1;
                    Form SU = new SignUp();
                    SU.Show();
                    this.Close();
                }
                //Если пойчта не зарегана то высветитс сообщение с просьбой про ти регистрацию
            }
        }

        private void VostanovlenieParola_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form frm = Application.OpenForms[0];
            frm.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if(textBox2.Text == kod.ToString())
            {
                MessageBox.Show( "Ваш пароль: " + UserPassword, "Восстановление пароля",
                    MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            //
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time--;
            label1.Text = "Перед отправкой следущего кода подождите " + time + "сек.";
            if(time == 0)
            {
                button1.Enabled = true;
                timer1.Enabled = false;
                label1.Text = "Код можно отправить повторно";

            }


        }
    }
}
