using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BIMS
{
    public partial class frmbookbundle : Form
    {
        public frmbookbundle()
        {
            InitializeComponent();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtbbid.Text = "";
            txtbid.Text = "";
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtbbid.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled", "BIMS Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtbbid.Focus();
            }
            else if (txtbid.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled", "BIMS Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtbid.Focus();
            }     
        }
    }
}
