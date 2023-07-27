namespace BIMS
{
    partial class frmbook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.plMain = new System.Windows.Forms.Panel();
            this.pnlsearch = new System.Windows.Forms.Panel();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnfind = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.book_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pub_year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtsearchval = new System.Windows.Forms.TextBox();
            this.cbosearch = new System.Windows.Forms.ComboBox();
            this.lbsv = new System.Windows.Forms.Label();
            this.lbs = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dtpubyear = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.lB3 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.lb4 = new System.Windows.Forms.Label();
            this.lb5 = new System.Windows.Forms.Label();
            this.txtbprice = new System.Windows.Forms.TextBox();
            this.txttitle = new System.Windows.Forms.TextBox();
            this.txtgenre = new System.Windows.Forms.TextBox();
            this.txtbookid = new System.Windows.Forms.TextBox();
            this.lb1 = new System.Windows.Forms.Label();
            this.plMain.SuspendLayout();
            this.pnlsearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // plMain
            // 
            this.plMain.BackColor = System.Drawing.Color.DarkKhaki;
            this.plMain.Controls.Add(this.pnlsearch);
            this.plMain.Controls.Add(this.panel7);
            this.plMain.Location = new System.Drawing.Point(48, 28);
            this.plMain.Name = "plMain";
            this.plMain.Size = new System.Drawing.Size(1022, 443);
            this.plMain.TabIndex = 0;
            this.plMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pnlsearch
            // 
            this.pnlsearch.BackColor = System.Drawing.Color.Beige;
            this.pnlsearch.Controls.Add(this.btnclear);
            this.pnlsearch.Controls.Add(this.btnfind);
            this.pnlsearch.Controls.Add(this.dataGridView1);
            this.pnlsearch.Controls.Add(this.txtsearchval);
            this.pnlsearch.Controls.Add(this.cbosearch);
            this.pnlsearch.Controls.Add(this.lbsv);
            this.pnlsearch.Controls.Add(this.lbs);
            this.pnlsearch.Location = new System.Drawing.Point(190, 43);
            this.pnlsearch.Name = "pnlsearch";
            this.pnlsearch.Size = new System.Drawing.Size(618, 354);
            this.pnlsearch.TabIndex = 2;
            this.pnlsearch.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlsearch_Paint);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(390, 60);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(72, 21);
            this.btnclear.TabIndex = 6;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnfind
            // 
            this.btnfind.Location = new System.Drawing.Point(390, 15);
            this.btnfind.Name = "btnfind";
            this.btnfind.Size = new System.Drawing.Size(72, 21);
            this.btnfind.TabIndex = 5;
            this.btnfind.Text = "Find";
            this.btnfind.UseVisualStyleBackColor = true;
            this.btnfind.Click += new System.EventHandler(this.btnfind_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.book_id,
            this.Titles,
            this.genre,
            this.pub_year});
            this.dataGridView1.Location = new System.Drawing.Point(15, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(589, 260);
            this.dataGridView1.TabIndex = 4;
            // 
            // book_id
            // 
            this.book_id.HeaderText = "book id";
            this.book_id.Name = "book_id";
            // 
            // Titles
            // 
            this.Titles.HeaderText = "Title";
            this.Titles.Name = "Titles";
            // 
            // genre
            // 
            this.genre.HeaderText = "genre";
            this.genre.Name = "genre";
            // 
            // pub_year
            // 
            this.pub_year.HeaderText = "pub year";
            this.pub_year.Name = "pub_year";
            // 
            // txtsearchval
            // 
            this.txtsearchval.Location = new System.Drawing.Point(101, 61);
            this.txtsearchval.Name = "txtsearchval";
            this.txtsearchval.Size = new System.Drawing.Size(255, 20);
            this.txtsearchval.TabIndex = 3;
            this.txtsearchval.Text = "All";
            // 
            // cbosearch
            // 
            this.cbosearch.FormattingEnabled = true;
            this.cbosearch.Items.AddRange(new object[] {
            "Bokid",
            "Title",
            "Genre",
            "Pubyear"});
            this.cbosearch.Location = new System.Drawing.Point(101, 16);
            this.cbosearch.Name = "cbosearch";
            this.cbosearch.Size = new System.Drawing.Size(256, 21);
            this.cbosearch.TabIndex = 2;
            this.cbosearch.Text = "All";
            // 
            // lbsv
            // 
            this.lbsv.Location = new System.Drawing.Point(12, 64);
            this.lbsv.Name = "lbsv";
            this.lbsv.Size = new System.Drawing.Size(83, 17);
            this.lbsv.TabIndex = 1;
            this.lbsv.Text = "Search Value :";
            // 
            // lbs
            // 
            this.lbs.Location = new System.Drawing.Point(12, 19);
            this.lbs.Name = "lbs";
            this.lbs.Size = new System.Drawing.Size(344, 40);
            this.lbs.TabIndex = 0;
            this.lbs.Text = "Search Criteria :";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Beige;
            this.panel7.Controls.Add(this.dtpubyear);
            this.panel7.Controls.Add(this.panel2);
            this.panel7.Controls.Add(this.lB3);
            this.panel7.Controls.Add(this.lb2);
            this.panel7.Controls.Add(this.lb4);
            this.panel7.Controls.Add(this.lb5);
            this.panel7.Controls.Add(this.txtbprice);
            this.panel7.Controls.Add(this.txttitle);
            this.panel7.Controls.Add(this.txtgenre);
            this.panel7.Controls.Add(this.txtbookid);
            this.panel7.Controls.Add(this.lb1);
            this.panel7.Location = new System.Drawing.Point(190, 43);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(618, 357);
            this.panel7.TabIndex = 1;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // dtpubyear
            // 
            this.dtpubyear.Location = new System.Drawing.Point(214, 206);
            this.dtpubyear.Name = "dtpubyear";
            this.dtpubyear.Size = new System.Drawing.Size(195, 20);
            this.dtpubyear.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.btnsearch);
            this.panel2.Controls.Add(this.btnreset);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.btnsave);
            this.panel2.Location = new System.Drawing.Point(35, 265);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(569, 54);
            this.panel2.TabIndex = 15;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(497, 17);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(68, 25);
            this.button7.TabIndex = 6;
            this.button7.Text = "Quit";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(423, 17);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(68, 25);
            this.button6.TabIndex = 5;
            this.button6.Text = "Delete";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(343, 17);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(68, 25);
            this.btnsearch.TabIndex = 4;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btnreset
            // 
            this.btnreset.Location = new System.Drawing.Point(254, 17);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(68, 25);
            this.btnreset.TabIndex = 3;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(169, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(68, 25);
            this.button3.TabIndex = 2;
            this.button3.Text = "New";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(88, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 25);
            this.button2.TabIndex = 1;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(12, 18);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(65, 23);
            this.btnsave.TabIndex = 0;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // lB3
            // 
            this.lB3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lB3.Location = new System.Drawing.Point(54, 117);
            this.lB3.Name = "lB3";
            this.lB3.Size = new System.Drawing.Size(106, 19);
            this.lB3.TabIndex = 14;
            this.lB3.Text = "GENRE :";
            // 
            // lb2
            // 
            this.lb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb2.Location = new System.Drawing.Point(54, 66);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(106, 19);
            this.lb2.TabIndex = 13;
            this.lb2.Text = "TITLE:";
            // 
            // lb4
            // 
            this.lb4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb4.Location = new System.Drawing.Point(54, 165);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(106, 19);
            this.lb4.TabIndex = 12;
            this.lb4.Text = "BOOK PRICE :";
            // 
            // lb5
            // 
            this.lb5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb5.Location = new System.Drawing.Point(54, 210);
            this.lb5.Name = "lb5";
            this.lb5.Size = new System.Drawing.Size(154, 19);
            this.lb5.TabIndex = 11;
            this.lb5.Text = "PUBLICATION YEAR :";
            // 
            // txtbprice
            // 
            this.txtbprice.Location = new System.Drawing.Point(214, 164);
            this.txtbprice.Name = "txtbprice";
            this.txtbprice.Size = new System.Drawing.Size(195, 20);
            this.txtbprice.TabIndex = 8;
            // 
            // txttitle
            // 
            this.txttitle.Location = new System.Drawing.Point(214, 65);
            this.txttitle.Name = "txttitle";
            this.txttitle.Size = new System.Drawing.Size(195, 20);
            this.txttitle.TabIndex = 7;
            // 
            // txtgenre
            // 
            this.txtgenre.Location = new System.Drawing.Point(214, 116);
            this.txtgenre.Name = "txtgenre";
            this.txtgenre.Size = new System.Drawing.Size(195, 20);
            this.txtgenre.TabIndex = 6;
            // 
            // txtbookid
            // 
            this.txtbookid.Location = new System.Drawing.Point(214, 20);
            this.txtbookid.Name = "txtbookid";
            this.txtbookid.Size = new System.Drawing.Size(195, 20);
            this.txtbookid.TabIndex = 5;
            // 
            // lb1
            // 
            this.lb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.Location = new System.Drawing.Point(54, 21);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(106, 19);
            this.lb1.TabIndex = 0;
            this.lb1.Text = "BOOK ID :";
            // 
            // frmbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 494);
            this.Controls.Add(this.plMain);
            this.Name = "frmbook";
            this.Text = "Book";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmbook_Load);
            this.plMain.ResumeLayout(false);
            this.pnlsearch.ResumeLayout(false);
            this.pnlsearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plMain;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtbprice;
        private System.Windows.Forms.TextBox txttitle;
        private System.Windows.Forms.TextBox txtgenre;
        private System.Windows.Forms.TextBox txtbookid;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lB3;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lb4;
        private System.Windows.Forms.Label lb5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.DateTimePicker dtpubyear;
        private System.Windows.Forms.Panel pnlsearch;
        private System.Windows.Forms.Label lbs;
        private System.Windows.Forms.Label lbsv;
        private System.Windows.Forms.Button btnfind;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn book_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titles;
        private System.Windows.Forms.DataGridViewTextBoxColumn genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn pub_year;
        private System.Windows.Forms.TextBox txtsearchval;
        private System.Windows.Forms.ComboBox cbosearch;
        private System.Windows.Forms.Button btnclear;
    }
}