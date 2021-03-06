﻿using System;
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

        private void button2_Click(object sender, EventArgs e)
        {
            Form kub = new Kubiki();
            kub.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form X0 = new X0();
            X0.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form admin = new admin();
            admin.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form DFG = new DataGrid();
            DFG.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form game = new Game();
            game.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form graf = new Grafika();
            graf.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form tasks = new Tasks();
            tasks.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form tet = new BoxTet();
            tet.Show();
            this.Hide();
        }

        private void MainWindows_Load(object sender, EventArgs e)
        {
            if (priv == "a")
                button1.Visible = true;
            label1.Text = "Добро пожаловать, " + name;

        }
    }
}
