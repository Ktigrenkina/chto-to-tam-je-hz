using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kafe
{
    public partial class AddStaff3 : Form
    {
        public AddStaff3()
        {
            InitializeComponent();
        }

        private void AddStaff3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form frm = Application.OpenForms[0];
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
