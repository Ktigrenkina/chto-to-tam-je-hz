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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection(@"DataSource=Kafe.db;Version=3;");
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandText = "Select ФИО from Сотрудники";
            SQLiteDataReader Reader = cmd.ExecuteReader();
            while(Reader.Read())
            {
                comboBox1.Items.Add(Reader.GetValue(0));
            }
            cmd.Reset();

            cmd.CommandText = "";
            int rez = Convert.ToInt32(cmd.ExecuteScalar());
            if(rez == 0)
            {
                cmd.CommandText;
                    

            }

            conn.Close();

        }

        
    }
}
