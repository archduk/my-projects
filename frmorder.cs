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
    public partial class frmorder : Form
    {
        public frmorder()
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
    }
}
