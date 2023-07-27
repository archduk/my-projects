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
    public partial class frmSplash : Form
    {
        private int flag;
        public frmSplash()
        {
            InitializeComponent();
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {
            plMain.Left = (this.Width - plMain.Width) / 2;
            plMain.Top = (this.Height - plMain.Height) / 2;
            flag=0;
        }

        private void lab_Click(object sender, EventArgs e)
        {

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value == 100 && flag == 0) {

                frmlogin lg = new frmlogin();
                lg.Visible = true;
                this.Hide();
                flag++;
            }
            if (progressBar1.Value<100)

            progressBar1.Value = progressBar1.Value + 10;
            label2.Text = "progress..." + progressBar1.Value + "%";

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
