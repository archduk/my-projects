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
    public partial class frmbookauthor : Form
    {
        public frmbookauthor()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void plMain_Paint(object sender, PaintEventArgs e)
        {
            plMain.Left = (this.Width - plMain.Width) / 2;
            plMain.Top = (this.Height - plMain.Height) / 2;
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtbaid.Text = "";
            cbookid.Text = "";
            txtaid.Text = "";
        }



        private void btnsave_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtbaid.Text == "")
                {
                    MessageBox.Show("Ensure all fields are filled", "BIMS Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtbaid.Focus();
                }
                else if (cbookid.Text == "")
                {
                    MessageBox.Show("Ensure all fields are filled", "BIMS Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cbookid.Focus();
                }
                else if (txtaid.Text == "")
                {
                    MessageBox.Show("Ensure all fields are filled", "BIMS Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtaid.Focus();
                }
                else
                {
                    String query = "INSERT INTO book_author(book_author_id, book_id, author_id) VALUES('" + txtbaid.Text.ToString() + "','" + cbookid.Text.ToString() + "', '" + txtaid.Text.ToString() + "')";
                    Conn connect = new Conn();
                    if (connect.OpenConnection() == true)
                    {
                        MySqlCommand cmd = new MySqlCommand(query, connect.connection);
                        cmd.ExecuteNonQuery();
                        txtbaid.Text = "";
                        cbookid.Text = "";
                        txtaid.Text = "";
                        txtbaid.Focus();
                        MessageBox.Show("Records Successfully saved", "BIMS mESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex, "BIMS Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void getBookID()
        {
            Conn connect = new Conn();
            String query = " SELECT * FROM book ORDER By book_id ASC";
            if (connect.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connect.connection);
                MySqlDataReader datareader = cmd.ExecuteReader();
                this.cbookid.Items.Clear();
                while (datareader.Read())
                { 
                    this.cbookid.Items.Add(datareader["book_id"] .ToString());
                }
                datareader.Close();
                connect.CloseConnection();
            }
        }

        private void frmbookauthor_Load(object sender, EventArgs e)
        {
            getBookID();
        }
    }
}