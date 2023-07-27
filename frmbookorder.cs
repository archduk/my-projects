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
    public partial class frmbookorder : Form
    {
        public frmbookorder()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtreset_Click(object sender, EventArgs e)
        {
            txtcid.Text = "";
            txtboid.Text = "";
        }

        private void txtsave_Click(object sender, EventArgs e)
        {
            if (txtcid.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled", "BIMS Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtcid.Focus();
            }
            else if (txtboid.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled", "BIMS Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtboid.Focus();
            }
        }
    }
}
