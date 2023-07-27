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
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            panel1.Left = (this.Width - panel1.Width) / 2;
            panel1.Top = (this.Height - panel1.Height) / 2;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtUsername.Focus();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

            if (txtUsername.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled", "BIMS Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
            }

            
                else if(txtPassword.Text == "")
                {
                    MessageBox.Show("Ensure all fields are filled", "BIMS Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Focus();
                }
                        
                else
                {
                    Conn connect = new Conn();
                    String query = "SELECT * FROM user WHERE username = '" + txtUsername.Text.ToString() + "' AND passsword='" + txtPassword.Text.ToString() + "' AND Status=1";
                    if (connect.OpenConnection() == true)
                     {
                        MySqlCommand cmd = new MySqlCommand(query, connect.connection);
                        MySqlDataReader dataReader = cmd.ExecuteReader();
                        if (dataReader.Read())
                        {
                    MDIParent1 mdi = new MDIParent1();
                    mdi.Visible = true;
                    this.Hide();
                }
                        else
                        {
                            MessageBox.Show("Invalid Credentials");
                            txtUsername.Text = "";
                            txtPassword.Text = "";
                            txtUsername.Focus();
                        }

                          dataReader.Close();
                        connect.CloseConnection();
            }
        }
    }
            catch (MySqlException ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void frmlogin_Load(object sender, EventArgs e)
        {

        }
    }
}
