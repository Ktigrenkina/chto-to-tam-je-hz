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
    public partial class MainWindows : Form
    {
        public MainWindows(string UserName, string Priveleges)
        {
            InitializeComponent();
            this.name = UserName;
            this.priv = Priveleges;
        }
        string name, priv;
        

        private void MainWindows_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void MainWindows_Load(object sender, EventArgs e)
        {
            if (priv == "a")
                button1.Visible = true;
            label1.Text = "Добро пожаловать, " + name;

        }
    }
}
