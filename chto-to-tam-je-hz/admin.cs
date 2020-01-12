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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        public void FillDataGrid() //Заполняем датагрид датами из файлов
        {
            using (StreamReader sr = new StreamReader("users/UserInfo.txt"))
            {
                int CurrewRow = 0;
                while (!sr.EndOfStream)
                {
                    string[] tmp = sr.ReadLine().Split(',');
                    for (int i = 0; i < 5; i++)
                    {
                        if (i < 4)
                            dataGridView1[i, CurrewRow].Value = tmp[i];

                        else
                        {
                            if (tmp[4] == "b")
                                dataGridView1[i, CurrewRow].Value = true;
                            else
                                dataGridView1[i, CurrewRow].Value = false;
                        }

                    }
                    CurrewRow++;
                }
            }
        }

        private void admin_Load(object sender, EventArgs e) //
        {
            using (StreamReader sr = new StreamReader("users/UserInfo.txt"))
            {
                while (!sr.EndOfStream)
                {
                    sr.ReadLine();
                    dataGridView1.Rows.Add();
                }


            }
        }

        private void admin_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Form frm = Application.OpenForms[1];
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e) //Сохранить изменения 
        {
            string ToFile = "";
            int RowsCount = dataGridView1.Rows.Count;
            for (int i = 0; i < RowsCount; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (j != 4)
                        ToFile += dataGridView1[j, i].Value + ",";
                    else
                    {
                        ToFile += dataGridView1[j, i].Value + "\n";
                    }
                }

            }
            using (StreamWriter sw = new StreamWriter("users/UserInfo.txt", false))
            {
                string[] tmp = ToFile.Split('\n');
                for (int i = 0; i < tmp.Length - 1; i++)
                {
                    sw.WriteLine(tmp[i]);
                }
            }
            MessageBox.Show("Изменения успешно сохранены");
        }



        private void button1_Click(object sender, EventArgs e)
        {
            FillDataGrid();
        }

    }
}