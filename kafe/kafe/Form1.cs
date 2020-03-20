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
        SQLiteDataReader Reader;
        SQLiteConnection conn = new SQLiteConnection(@"DataSource=Kafe.db;Version=3;");
        SQLiteCommand cmd = new SQLiteCommand();
        private void Form1_Load(object sender, EventArgs e)
        {
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandText = "Select ФИО from Сотрудники";
            Reader = cmd.ExecuteReader();
            while(Reader.Read())
            {
                comboBox1.Items.Add(Reader.GetValue(0));
            }
            cmd.Reset();

            

            conn.Close();

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                sotrudnik();
                doljnost();
            }
        }
        public void sotrudnik()
        {
            List<string> st = new List<string>();
            conn.Open();
            cmd.CommandText = "Select * from Сотрудники";
            Reader = cmd.ExecuteReader();
            while(Reader.Read())
            {
                dataGridView1.Rows.Add();
                st.Add(Reader.GetValue(0) + "_" + Reader.GetValue(1) + "_" +
                    Reader.GetValue(2) + "_" + Reader.GetValue(3) + "_" +
                    Reader.GetValue(4) + "_" + Reader.GetValue(5) + "_" +
                    Reader.GetValue(6));
                
            }
            cmd.Reset();
            for(int i = 0; i < st.Count; i++)
            {
                string[] str = st[i].Split('_');
                for(int j = 0; j < str.Length; j++)
                {
                    dataGridView1[j, i].Value = str[j];
                }
            }

            conn.Close();
        }
        public void doljnost()
        {
            List<string> st = new List<string>();
            conn.Open();
            cmd.CommandText = "Select * from Должность";
            Reader = cmd.ExecuteReader();
            while (Reader.Read())
            {
                dataGridView2.Rows.Add();
                st.Add(Reader.GetValue(0) + "_" + Reader.GetValue(1));
            }
            cmd.Reset();
            for (int i = 0; i < st.Count; i++)
            {
                string[] str = st[i].Split('_');
                for(int j = 0; j < str.Length; j++)
                {
                    dataGridView2[j, i].Value = str[j];
                }
            }
            
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form add = new AddPost2();
            add.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form add2 = new AddStaff3();
            add2.Show();
        }
    }
}
