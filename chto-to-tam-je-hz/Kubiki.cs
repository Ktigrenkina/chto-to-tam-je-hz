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
    public partial class Kubiki : Form
    {
        public Kubiki()
        {
            InitializeComponent();
        }
        int Count = 5, UserScore = 0, KompScore = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (Count > 0)
            {

                Random R = new Random();
                int UserCube = R.Next(1, 7),
                    KompCube = R.Next(1, 7);
                UserScore += UserCube;
                KompScore += KompCube;
                kot(UserCube, pictureBox1);
                kot(UserCube, groupBox1.Controls ["pbUser" + Count] as PictureBox);
                kot(KompCube, pictureBox2);
                kot(KompCube, groupBox1.Controls ["pbKomp" + Count] as PictureBox);
                Count--;
                label5.Text = "Твои попытки будут уменьшаться: " + Count;
                label3.Text = "Игрок" + UserScore;
                label4.Text = "Компьтер" + KompScore;
            }
            else
            {
                DialogResult rezult =
                MessageBox.Show("Попытки закончились\n" +
                    "Хотите ли начать новую игру?",
                    "Бросок кубика невозможен",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (rezult == DialogResult.Yes)
                {
                    button2.PerformClick();
                }
            }
            if(Count == 0)
            {
                if(UserScore > KompScore)
                {

                    MessageBox.Show("Выиграл игрок\n" +
                        "Счет игрока" + UserScore + 
                        "\nСчет компухтера" + KompScore ,
                        "Результат игры",
                        MessageBoxButtons.OK);
                }
                else if (KompScore > UserScore)
                {
                    MessageBox.Show("Выиграл Компухтер\n" +
                        "Счет игрока" + UserScore +
                        "\nСчет компухтера" + KompScore,
                        "Результат игры",
                        MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Ничья\n" +
                        "Счет игрока" + UserScore +
                        "\nСчет компухтера" + KompScore,
                        "Результат игры",
                        MessageBoxButtons.OK);
                }

            }
        }
        public void kot(int Cube, PictureBox pb)
        {

            switch (Cube)
            {
                case 1:
                    pb.Image = Image.FromFile("Image/1.png");
                    break;
                case 2:
                    pb.Image = Image.FromFile("Image/2.png");
                    break;
                case 3:
                    pb.Image = Image.FromFile("Image/3.png");
                    break;
                case 4:
                    pb.Image = Image.FromFile("Image/4.png");
                    break;
                case 5:
                    pb.Image = Image.FromFile("Image/5.png");
                    break;
                case 6:
                    pb.Image = Image.FromFile("Image/6.png");
                    break;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Count = 5;
            label5.Text = "Твои попытки будут уменьшаться: " + Count;
            KompScore = 0; UserScore = 0;
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            label3.Text = "Игрок: 0";
            label4.Text = "Компьтер: 0";
            for(int i = 1; i < 6; i++)
            {
                PictureBox pb = groupBox1.Controls["pbUser" + i] as PictureBox;
                pb.Image = null;
                pb = groupBox1.Controls["pbKomp" + i] as PictureBox;
                pb.Image = null;
            }
        }
        

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void Kubiki_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form frm = Application.OpenForms[1];
            frm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
