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
    public partial class frmauthor : Form
    {
        public frmauthor()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            plMain.Left = (this.Width - plMain.Width) / 2;
            plMain.Top = (this.Height - plMain.Height) / 2;
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtaid.Text = "";
            txtfname.Text = "";
            txtlname.Text = "";
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtaid.Text == "") {
                MessageBox.Show("Ensure all fields are filled", "BIMS Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtaid.Focus();
            }
            else if (txtfname.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled", "BIMS Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtfname.Focus();
            }
            else if (txtlname.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled", "BIMS Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtlname.Focus();
            }
                else
                {
                    String query = "INSERT INTO author(author_id, first_name, last_name) VALUES('" + txtaid.Text.ToString() + "','" + txtfname.Text.ToString() + "', '" + txtlname.Text.ToString() + "')";
                    Conn connect = new Conn();
                    if (connect.OpenConnection() == true)
                    {
                        MySqlCommand cmd = new MySqlCommand(query, connect.connection);
                        cmd.ExecuteNonQuery();
                        txtaid.Text = "";
                        txtfname.Text = "";
                        txtlname.Text = "";
                        txtaid.Focus();
                        MessageBox.Show("Records Successfully saved", "BIMS mESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex, "BIMS Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}