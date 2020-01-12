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
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }

        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form fmr = Application.OpenForms[1];
            fmr.Show();//Переход в меню
        }

        private void label59_MouseEnter(object sender, EventArgs e)
        {
            Cursor.Position = new Point(lbStart.Location.X + 
                this.Location.X + 40, lbStart.Location.Y + this.Location.Y + 30);
            //Ставим позицию старта
        }

        private void lbFinish_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Поздравляем! Вы смогли пройти лабиринт!");//Сообщение с поздравлениями
        }

        
    }
}
