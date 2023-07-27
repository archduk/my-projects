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
    public partial class frmbook : Form
    {
        public frmbook()
        {
            InitializeComponent();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
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
            txtbookid.Text = "";
            txtbprice.Text = "";
            txtgenre.Text = "";
            dtpubyear.Text = "";
            txttitle.Text = "";
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtbookid.Text == "")
                {
                    MessageBox.Show("Ensure all fields are filled", "BIMS Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtbookid.Focus();
                }
                else if (txttitle.Text == "")
                {
                    MessageBox.Show("Ensure all fields are filled", "BIMS Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txttitle.Focus();
                }
                else if (txtgenre.Text == "")
                {
                    MessageBox.Show("Ensure all fields are filled", "BIMS Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtgenre.Focus();
                }
                else if (txtbprice.Text == "")
                {
                    MessageBox.Show("Ensure all fields are filled", "BIMS Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtbprice.Focus();
                }
                else if (dtpubyear.Text == "")
                {
                    MessageBox.Show("Ensure all fields are filled", "BIMS Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dtpubyear.Focus();
                }
                else
                {
                    String query = "INSERT INTO book(book_id, title, genre, book_price, pub_year) VALUES('" + txtbookid.Text.ToString() + "','" + txttitle.Text.ToString() + "', '" + txtgenre.Text.ToString() + "', '" + txtbprice.Text.ToString() + "', '" + dtpubyear.Text.ToString() + "')";
                    Conn connect = new Conn();
                    if (connect.OpenConnection() == true)
                    {
                        MySqlCommand cmd = new MySqlCommand(query, connect.connection);
                        cmd.ExecuteNonQuery();
                        txtbookid.Text = "";
                        txtbprice.Text = "";
                        txtgenre.Text = "";
                        dtpubyear.Text = "";
                        txttitle.Text = "";
                        txtbookid.Focus();
                        MessageBox.Show("Records Successfully saved", "BIMS mESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex, "BIMS Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnfind_Click(object sender, EventArgs e)
        {
            String criteria;
            String searchval;
            String query="";
            if (cbosearch.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled", "BIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbosearch.Focus();
            }
            else if (txtsearchval.Text == "")
            {
                txtsearchval.Focus();
            }
            else
            {
                criteria = cbosearch.Text.ToString();
                searchval = "%" + txtsearchval.Text.ToString() + "%";
                if (criteria == "Book ID")
                {
                    query = "SELECT * FROM book WHERE book_id LIKE '" + searchval + "' ORDER BY book_id ASC";
                }
                else if (criteria == "Title")
                {
                    query = "SELECT * FROM book WHERE title LIKE'" + searchval + "' ORDER BY title ASC";
                }
                else if (criteria == "genre")
                {
                    query = "SELECT * FROM book WHERE genre LIKE'" + searchval + "' ORDER BY genre ASC";
                }
                else if (criteria == "pub year")
                {
                    query = "SELECT * FROM book WHERE pub year LIKE'" + searchval + "' ORDER BY pub year ASC";
                }
                else if (criteria == "All")
                {
                    query = "SELECT * FROM book ORDER BY book_id ASC";
                }
                else
                {
                    MessageBox.Show("Invalid Criteria", "BIMS message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cbosearch.Focus();
                }
                Conn connect = new Conn();
                if (connect.OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connect.connection);
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    this.dataGridView1.Rows.Clear();
                    while (dataReader.Read())
                    {
                        string[] row = new String[] { dataReader["book_id"].ToString(), dataReader["genre"].ToString(), dataReader["Title"].ToString(), dataReader["pub_year"].ToString(), dataReader["book_price"].ToString()};
                        dataGridView1.Rows.Add(row);
                    }
                    connect.CloseConnection();
                    dataReader.Close();
                }
            }
        }

        private void pnlsearch_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            pnlsearch.Visible = true;
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            pnlsearch.Visible = false;
          
        }

        private void frmbook_Load(object sender, EventArgs e)
        {
            pnlsearch.Visible = false;
        }
    }
}
