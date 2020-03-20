using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace kafe
{
    public partial class AddPost2 : Form
    {
        public AddPost2()
        {
            InitializeComponent();
        }
        
        private void AddPost2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form frm = Application.OpenForms[0];
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection(@"DataSource=Kafe.db;Version=3;");
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandText = "Select count(*) from Должность" +
                " WHERE наименование = '" + textBox1.Text + "'";
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Reset();
            if (i == 0)
            {
                cmd.CommandText = "insert into Должность (наименование) values('"+textBox1+"')";
            }
            

            conn.Close();
        }
    }
}
