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
    public partial class DataGrid : Form
    {
        public DataGrid()
        {
            InitializeComponent();
        }

        private void DataGrid_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form fmr = Application.OpenForms[1];
            fmr.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked = true)
            {
                dataGridView1.AllowUserToAddRows = false;
            }
            else
            {
                dataGridView1.AllowDrop = true;
                button1.Visible = false;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var CurrentCell = dataGridView1.CurrentCell.Value;
            if(CurrentCell != null)
            MessageBox.Show(CurrentCell.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var CurrentRow = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(CurrentRow);
        }

        private void DataGrid_Load(object sender, EventArgs e)
        {

        }
    }
}
