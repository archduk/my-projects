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
    public partial class MDIParent1 : Form
    {
        private int childFormNumber = 0;

        public MDIParent1()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
//toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
       //     statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void MDIParent1_Load(object sender, EventArgs e)
        {
            frmMain fm = new frmMain();
            fm.MdiParent = this;
            fm.Visible = true;
        }

        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmbook b1 = new frmbook();
            b1.MdiParent = this;
            b1.Visible = true;
        }

        private void authorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmauthor au = new frmauthor();
            au.MdiParent = this;
            au.Visible = true;
        }

        private void bookAuthorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmbookauthor ba = new frmbookauthor();
            ba.MdiParent = this;
            ba.Visible = true;
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcustomer c = new frmcustomer();
            c.MdiParent = this;
            c.Visible = true;
        }

        private void orderToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmorder or = new frmorder();
            or.MdiParent = this;
            or.Visible = true;
        }

        private void bookOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmbookorder bo = new frmbookorder();
            bo.MdiParent = this;
            bo.Visible = true;
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmuser u = new frmuser();
            u.MdiParent = this;
            u.Visible = true;
        }
    }
}
