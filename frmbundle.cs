using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BIMS
{
    public partial class frmbundle : Form
    {
        
        public frmbundle()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtbid.Text = "";
            txtbname.Text = "";
            txttprice.Text = "";
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtbid.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled", "BIMS Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtbid.Focus();
            }
            else if (txttprice.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled", "BIMS Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txttprice.Focus();
            }
            else if (txtbname.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled", "BIMS Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtbname.Focus();
            }
        }
    }
}
