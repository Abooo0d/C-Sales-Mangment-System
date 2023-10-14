namespace Sales_v3.Forms
{
    partial class SalePointForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalePointForm));
            this.pnltop = new System.Windows.Forms.Panel();
            this.btnresize = new AboodTools_v5.AboodButton();
            this.btnrestart = new AboodTools_v5.AboodButton();
            this.btnexit = new AboodTools_v5.AboodButton();
            this.lbltitle = new System.Windows.Forms.Label();
            this.btnlogout = new AboodTools_v5.AboodButton();
            this.pnldgvsales = new System.Windows.Forms.Panel();
            this.dgvsales = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.colnum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colsubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlmats = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlnumbers = new System.Windows.Forms.Panel();
            this.btnenter = new AboodTools_v5.AboodButton();
            this.btnclearall = new AboodTools_v5.AboodButton();
            this.btncuma = new AboodTools_v5.AboodButton();
            this.btn3 = new AboodTools_v5.AboodButton();
            this.btn6 = new AboodTools_v5.AboodButton();
            this.btn9 = new AboodTools_v5.AboodButton();
            this.btn00 = new AboodTools_v5.AboodButton();
            this.btn2 = new AboodTools_v5.AboodButton();
            this.btn5 = new AboodTools_v5.AboodButton();
            this.btn8 = new AboodTools_v5.AboodButton();
            this.btn0 = new AboodTools_v5.AboodButton();
            this.btn1 = new AboodTools_v5.AboodButton();
            this.btn4 = new AboodTools_v5.AboodButton();
            this.btn7 = new AboodTools_v5.AboodButton();
            this.btnclear = new AboodTools_v5.AboodButton();
            this.txtnumbers = new AboodTools_v5.AboodTextBox();
            this.pnlcontainernums = new System.Windows.Forms.Panel();
            this.pnlcontainermats = new System.Windows.Forms.Panel();
            this.pnlcontainertools = new System.Windows.Forms.Panel();
            this.pnltools = new System.Windows.Forms.Panel();
            this.btnclearerror = new AboodTools_v5.AboodButton();
            this.btnprint = new AboodTools_v5.AboodButton();
            this.btndeleteorder = new AboodTools_v5.AboodButton();
            this.btndeletemat = new AboodTools_v5.AboodButton();
            this.btnediteprice = new AboodTools_v5.AboodButton();
            this.btneditqty = new AboodTools_v5.AboodButton();
            this.btnsavesales = new AboodTools_v5.AboodButton();
            this.btnsales = new AboodTools_v5.AboodButton();
            this.lbltotaltitle = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.lblcustomer = new System.Windows.Forms.Label();
            this.lblcustomertitle = new System.Windows.Forms.Label();
            this.lblusername = new System.Windows.Forms.Label();
            this.pnlcontainercustomer = new System.Windows.Forms.Panel();
            this.pnlcustomers = new System.Windows.Forms.Panel();
            this.btncustomer4 = new AboodTools_v5.AboodButton();
            this.btncustomer2 = new AboodTools_v5.AboodButton();
            this.btncustomer3 = new AboodTools_v5.AboodButton();
            this.btncustomer1 = new AboodTools_v5.AboodButton();
            this.lblerror = new System.Windows.Forms.Label();
            this.lblordernumbertitle = new System.Windows.Forms.Label();
            this.lblordernumber = new System.Windows.Forms.Label();
            this.printdocument = new System.Drawing.Printing.PrintDocument();
            this.backworker = new System.ComponentModel.BackgroundWorker();
            this.pnlnav = new System.Windows.Forms.Panel();
            this.btnshowsearch = new AboodTools_v5.AboodButton();
            this.btnshowtoolspnl = new AboodTools_v5.AboodButton();
            this.lbltime = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.lbltimetitle = new System.Windows.Forms.Label();
            this.lbldatetitle = new System.Windows.Forms.Label();
            this.pnlsidenav = new System.Windows.Forms.Panel();
            this.pnlpicnav = new System.Windows.Forms.Panel();
            this.picnav = new AboodTools_v5.AboodPictureBox();
            this.btnwarnings = new AboodTools_v5.AboodButton();
            this.timernav = new System.Windows.Forms.Timer(this.components);
            this.btnnavoutside = new AboodTools_v5.AboodButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnsearch = new AboodTools_v5.AboodButton();
            this.txtsearch = new AboodTools_v5.AboodTextBox();
            this.printpreview = new System.Windows.Forms.PrintPreviewDialog();
            this.pnltop.SuspendLayout();
            this.pnldgvsales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsales)).BeginInit();
            this.pnlnumbers.SuspendLayout();
            this.pnlcontainernums.SuspendLayout();
            this.pnlcontainermats.SuspendLayout();
            this.pnlcontainertools.SuspendLayout();
            this.pnltools.SuspendLayout();
            this.pnlcontainercustomer.SuspendLayout();
            this.pnlcustomers.SuspendLayout();
            this.pnlnav.SuspendLayout();
            this.pnlpicnav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picnav)).BeginInit();
            this.SuspendLayout();
            // 
            // pnltop
            // 
            this.pnltop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.pnltop.Controls.Add(this.btnresize);
            this.pnltop.Controls.Add(this.btnrestart);
            this.pnltop.Controls.Add(this.btnexit);
            this.pnltop.Controls.Add(this.lbltitle);
            this.pnltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnltop.Location = new System.Drawing.Point(0, 0);
            this.pnltop.Name = "pnltop";
            this.pnltop.Size = new System.Drawing.Size(900, 35);
            this.pnltop.TabIndex = 0;
            this.pnltop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnltop_MouseDown);
            this.pnltop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnltop_MouseMove);
            this.pnltop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnltop_MouseUp);
            // 
            // btnresize
            // 
            this.btnresize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnresize.BackColor = System.Drawing.Color.Transparent;
            this.btnresize.BackGraundColor = System.Drawing.Color.Transparent;
            this.btnresize.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnresize.BorderRadius = 10;
            this.btnresize.BorderSize = 0;
            this.btnresize.FlatAppearance.BorderSize = 0;
            this.btnresize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnresize.ForeColor = System.Drawing.Color.White;
            this.btnresize.Location = new System.Drawing.Point(824, 1);
            this.btnresize.Name = "btnresize";
            this.btnresize.Size = new System.Drawing.Size(33, 33);
            this.btnresize.TabIndex = 17;
            this.btnresize.Text = "M";
            this.btnresize.TextColor = System.Drawing.Color.White;
            this.btnresize.UseVisualStyleBackColor = false;
            this.btnresize.Click += new System.EventHandler(this.btnresize_Click);
            // 
            // btnrestart
            // 
            this.btnrestart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnrestart.BackColor = System.Drawing.Color.Transparent;
            this.btnrestart.BackGraundColor = System.Drawing.Color.Transparent;
            this.btnrestart.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnrestart.BorderRadius = 10;
            this.btnrestart.BorderSize = 0;
            this.btnrestart.FlatAppearance.BorderSize = 0;
            this.btnrestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrestart.ForeColor = System.Drawing.Color.White;
            this.btnrestart.Location = new System.Drawing.Point(786, 1);
            this.btnrestart.Name = "btnrestart";
            this.btnrestart.Size = new System.Drawing.Size(33, 33);
            this.btnrestart.TabIndex = 3;
            this.btnrestart.Text = "R";
            this.btnrestart.TextColor = System.Drawing.Color.White;
            this.btnrestart.UseVisualStyleBackColor = false;
            this.btnrestart.Click += new System.EventHandler(this.btnrestart_Click);
            // 
            // btnexit
            // 
            this.btnexit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnexit.BackColor = System.Drawing.Color.Transparent;
            this.btnexit.BackGraundColor = System.Drawing.Color.Transparent;
            this.btnexit.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnexit.BorderRadius = 10;
            this.btnexit.BorderSize = 0;
            this.btnexit.FlatAppearance.BorderSize = 0;
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexit.ForeColor = System.Drawing.Color.White;
            this.btnexit.Location = new System.Drawing.Point(862, 1);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(33, 33);
            this.btnexit.TabIndex = 1;
            this.btnexit.Text = "X";
            this.btnexit.TextColor = System.Drawing.Color.White;
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbltitle.ForeColor = System.Drawing.Color.White;
            this.lbltitle.Location = new System.Drawing.Point(7, 8);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(81, 20);
            this.lbltitle.TabIndex = 0;
            this.lbltitle.Tag = "نقطة البيع";
            this.lbltitle.Text = "Sale Point";
            // 
            // btnlogout
            // 
            this.btnlogout.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnlogout.BackColor = System.Drawing.Color.Crimson;
            this.btnlogout.BackGraundColor = System.Drawing.Color.Crimson;
            this.btnlogout.BorderColor = System.Drawing.Color.Black;
            this.btnlogout.BorderRadius = 0;
            this.btnlogout.BorderSize = 0;
            this.btnlogout.FlatAppearance.BorderSize = 0;
            this.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnlogout.ForeColor = System.Drawing.Color.White;
            this.btnlogout.Location = new System.Drawing.Point(2, 575);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(208, 40);
            this.btnlogout.TabIndex = 2;
            this.btnlogout.Tag = "تسجيل خروج";
            this.btnlogout.Text = "Log Out";
            this.btnlogout.TextColor = System.Drawing.Color.White;
            this.btnlogout.UseVisualStyleBackColor = false;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // pnldgvsales
            // 
            this.pnldgvsales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnldgvsales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.pnldgvsales.Controls.Add(this.dgvsales);
            this.pnldgvsales.Location = new System.Drawing.Point(497, 47);
            this.pnldgvsales.Name = "pnldgvsales";
            this.pnldgvsales.Padding = new System.Windows.Forms.Padding(3);
            this.pnldgvsales.Size = new System.Drawing.Size(377, 239);
            this.pnldgvsales.TabIndex = 1;
            this.pnldgvsales.Visible = false;
            // 
            // dgvsales
            // 
            this.dgvsales.AllowUserToAddRows = false;
            this.dgvsales.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvsales.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvsales.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvsales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvsales.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvsales.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvsales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvsales.ColumnHeadersHeight = 30;
            this.dgvsales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colnum,
            this.colname,
            this.colqty,
            this.colprice,
            this.colsubtotal});
            this.dgvsales.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvsales.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvsales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvsales.DoubleBuffered = true;
            this.dgvsales.EnableHeadersVisualStyles = false;
            this.dgvsales.GridColor = System.Drawing.Color.Silver;
            this.dgvsales.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.dgvsales.HeaderForeColor = System.Drawing.Color.White;
            this.dgvsales.Location = new System.Drawing.Point(3, 3);
            this.dgvsales.MultiSelect = false;
            this.dgvsales.Name = "dgvsales";
            this.dgvsales.ReadOnly = true;
            this.dgvsales.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvsales.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvsales.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvsales.RowHeadersVisible = false;
            this.dgvsales.RowTemplate.Height = 23;
            this.dgvsales.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvsales.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvsales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvsales.Size = new System.Drawing.Size(371, 233);
            this.dgvsales.TabIndex = 0;
            // 
            // colnum
            // 
            this.colnum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colnum.HeaderText = "Num";
            this.colnum.Name = "colnum";
            this.colnum.ReadOnly = true;
            // 
            // colname
            // 
            this.colname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colname.FillWeight = 230F;
            this.colname.HeaderText = "Material Name";
            this.colname.Name = "colname";
            this.colname.ReadOnly = true;
            // 
            // colqty
            // 
            this.colqty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colqty.HeaderText = "Qty";
            this.colqty.Name = "colqty";
            this.colqty.ReadOnly = true;
            // 
            // colprice
            // 
            this.colprice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colprice.FillWeight = 120F;
            this.colprice.HeaderText = "Price";
            this.colprice.Name = "colprice";
            this.colprice.ReadOnly = true;
            // 
            // colsubtotal
            // 
            this.colsubtotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colsubtotal.FillWeight = 170F;
            this.colsubtotal.HeaderText = "Sub Total";
            this.colsubtotal.Name = "colsubtotal";
            this.colsubtotal.ReadOnly = true;
            // 
            // pnlmats
            // 
            this.pnlmats.AutoScroll = true;
            this.pnlmats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.pnlmats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlmats.Location = new System.Drawing.Point(3, 3);
            this.pnlmats.Name = "pnlmats";
            this.pnlmats.Size = new System.Drawing.Size(304, 263);
            this.pnlmats.TabIndex = 2;
            // 
            // pnlnumbers
            // 
            this.pnlnumbers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.pnlnumbers.Controls.Add(this.btnenter);
            this.pnlnumbers.Controls.Add(this.btnclearall);
            this.pnlnumbers.Controls.Add(this.btncuma);
            this.pnlnumbers.Controls.Add(this.btn3);
            this.pnlnumbers.Controls.Add(this.btn6);
            this.pnlnumbers.Controls.Add(this.btn9);
            this.pnlnumbers.Controls.Add(this.btn00);
            this.pnlnumbers.Controls.Add(this.btn2);
            this.pnlnumbers.Controls.Add(this.btn5);
            this.pnlnumbers.Controls.Add(this.btn8);
            this.pnlnumbers.Controls.Add(this.btn0);
            this.pnlnumbers.Controls.Add(this.btn1);
            this.pnlnumbers.Controls.Add(this.btn4);
            this.pnlnumbers.Controls.Add(this.btn7);
            this.pnlnumbers.Controls.Add(this.btnclear);
            this.pnlnumbers.Controls.Add(this.txtnumbers);
            this.pnlnumbers.Location = new System.Drawing.Point(3, 3);
            this.pnlnumbers.Name = "pnlnumbers";
            this.pnlnumbers.Size = new System.Drawing.Size(325, 275);
            this.pnlnumbers.TabIndex = 3;
            // 
            // btnenter
            // 
            this.btnenter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnenter.BackGraundColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnenter.BorderColor = System.Drawing.Color.White;
            this.btnenter.BorderRadius = 15;
            this.btnenter.BorderSize = 0;
            this.btnenter.FlatAppearance.BorderSize = 0;
            this.btnenter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnenter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.btnenter.Location = new System.Drawing.Point(236, 162);
            this.btnenter.Name = "btnenter";
            this.btnenter.Size = new System.Drawing.Size(82, 105);
            this.btnenter.TabIndex = 39;
            this.btnenter.Tag = "";
            this.btnenter.Text = "Enter";
            this.btnenter.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.btnenter.UseVisualStyleBackColor = false;
            this.btnenter.Click += new System.EventHandler(this.btnenter_Click);
            // 
            // btnclearall
            // 
            this.btnclearall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnclearall.BackGraundColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnclearall.BorderColor = System.Drawing.Color.White;
            this.btnclearall.BorderRadius = 15;
            this.btnclearall.BorderSize = 0;
            this.btnclearall.FlatAppearance.BorderSize = 0;
            this.btnclearall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclearall.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnclearall.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.btnclearall.Location = new System.Drawing.Point(236, 107);
            this.btnclearall.Name = "btnclearall";
            this.btnclearall.Size = new System.Drawing.Size(82, 50);
            this.btnclearall.TabIndex = 38;
            this.btnclearall.Text = "CA";
            this.btnclearall.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.btnclearall.UseVisualStyleBackColor = false;
            this.btnclearall.Click += new System.EventHandler(this.btnclearall_Click);
            // 
            // btncuma
            // 
            this.btncuma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btncuma.BackGraundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btncuma.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.btncuma.BorderRadius = 15;
            this.btncuma.BorderSize = 0;
            this.btncuma.FlatAppearance.BorderSize = 0;
            this.btncuma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btncuma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.btncuma.Location = new System.Drawing.Point(164, 217);
            this.btncuma.Name = "btncuma";
            this.btncuma.Size = new System.Drawing.Size(70, 50);
            this.btncuma.TabIndex = 37;
            this.btncuma.Tag = ".";
            this.btncuma.Text = ".";
            this.btncuma.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.btncuma.UseVisualStyleBackColor = false;
            this.btncuma.Click += new System.EventHandler(this.NumbersEvent);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn3.BackGraundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.btn3.BorderRadius = 15;
            this.btn3.BorderSize = 0;
            this.btn3.FlatAppearance.BorderSize = 0;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btn3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.btn3.Location = new System.Drawing.Point(164, 162);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(70, 50);
            this.btn3.TabIndex = 36;
            this.btn3.Tag = "3";
            this.btn3.Text = "3";
            this.btn3.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.NumbersEvent);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn6.BackGraundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.btn6.BorderRadius = 15;
            this.btn6.BorderSize = 0;
            this.btn6.FlatAppearance.BorderSize = 0;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btn6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.btn6.Location = new System.Drawing.Point(164, 107);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(70, 50);
            this.btn6.TabIndex = 35;
            this.btn6.Tag = "6";
            this.btn6.Text = "6";
            this.btn6.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.NumbersEvent);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn9.BackGraundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.btn9.BorderRadius = 15;
            this.btn9.BorderSize = 0;
            this.btn9.FlatAppearance.BorderSize = 0;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btn9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.btn9.Location = new System.Drawing.Point(164, 52);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(70, 50);
            this.btn9.TabIndex = 34;
            this.btn9.Tag = "9";
            this.btn9.Text = "9";
            this.btn9.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.NumbersEvent);
            // 
            // btn00
            // 
            this.btn00.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn00.BackGraundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn00.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.btn00.BorderRadius = 15;
            this.btn00.BorderSize = 0;
            this.btn00.FlatAppearance.BorderSize = 0;
            this.btn00.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn00.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btn00.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.btn00.Location = new System.Drawing.Point(88, 217);
            this.btn00.Name = "btn00";
            this.btn00.Size = new System.Drawing.Size(70, 50);
            this.btn00.TabIndex = 33;
            this.btn00.Tag = "00";
            this.btn00.Text = "00";
            this.btn00.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.btn00.UseVisualStyleBackColor = false;
            this.btn00.Click += new System.EventHandler(this.NumbersEvent);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn2.BackGraundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.btn2.BorderRadius = 15;
            this.btn2.BorderSize = 0;
            this.btn2.FlatAppearance.BorderSize = 0;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btn2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.btn2.Location = new System.Drawing.Point(88, 162);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(70, 50);
            this.btn2.TabIndex = 32;
            this.btn2.Tag = "2";
            this.btn2.Text = "2";
            this.btn2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.NumbersEvent);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn5.BackGraundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.btn5.BorderRadius = 15;
            this.btn5.BorderSize = 0;
            this.btn5.FlatAppearance.BorderSize = 0;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btn5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.btn5.Location = new System.Drawing.Point(88, 107);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(70, 50);
            this.btn5.TabIndex = 31;
            this.btn5.Tag = "5";
            this.btn5.Text = "5";
            this.btn5.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.NumbersEvent);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn8.BackGraundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.btn8.BorderRadius = 15;
            this.btn8.BorderSize = 0;
            this.btn8.FlatAppearance.BorderSize = 0;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btn8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.btn8.Location = new System.Drawing.Point(88, 52);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(70, 50);
            this.btn8.TabIndex = 30;
            this.btn8.Tag = "8";
            this.btn8.Text = "8";
            this.btn8.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.NumbersEvent);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn0.BackGraundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn0.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.btn0.BorderRadius = 15;
            this.btn0.BorderSize = 0;
            this.btn0.FlatAppearance.BorderSize = 0;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btn0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.btn0.Location = new System.Drawing.Point(11, 217);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(70, 50);
            this.btn0.TabIndex = 29;
            this.btn0.Tag = "0";
            this.btn0.Text = "0";
            this.btn0.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.NumbersEvent);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn1.BackGraundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.btn1.BorderRadius = 15;
            this.btn1.BorderSize = 0;
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btn1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.btn1.Location = new System.Drawing.Point(11, 162);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(70, 50);
            this.btn1.TabIndex = 28;
            this.btn1.Tag = "1";
            this.btn1.Text = "1";
            this.btn1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.NumbersEvent);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn4.BackGraundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.btn4.BorderRadius = 15;
            this.btn4.BorderSize = 0;
            this.btn4.FlatAppearance.BorderSize = 0;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btn4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.btn4.Location = new System.Drawing.Point(11, 107);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(70, 50);
            this.btn4.TabIndex = 27;
            this.btn4.Tag = "4";
            this.btn4.Text = "4";
            this.btn4.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.NumbersEvent);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn7.BackGraundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.btn7.BorderRadius = 15;
            this.btn7.BorderSize = 0;
            this.btn7.FlatAppearance.BorderSize = 0;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btn7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.btn7.Location = new System.Drawing.Point(11, 52);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(70, 50);
            this.btn7.TabIndex = 26;
            this.btn7.Tag = "7";
            this.btn7.Text = "7";
            this.btn7.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.NumbersEvent);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnclear.BackGraundColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnclear.BorderColor = System.Drawing.Color.White;
            this.btnclear.BorderRadius = 15;
            this.btnclear.BorderSize = 0;
            this.btnclear.FlatAppearance.BorderSize = 0;
            this.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnclear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.btnclear.Location = new System.Drawing.Point(236, 52);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(82, 50);
            this.btnclear.TabIndex = 1;
            this.btnclear.Text = "C";
            this.btnclear.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // txtnumbers
            // 
            this.txtnumbers._Text = "";
            this.txtnumbers.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtnumbers.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtnumbers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtnumbers.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.txtnumbers.BorderSize = 5;
            this.txtnumbers.FocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.txtnumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtnumbers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.txtnumbers.Location = new System.Drawing.Point(11, 5);
            this.txtnumbers.MultiLine = false;
            this.txtnumbers.Name = "txtnumbers";
            this.txtnumbers.Padding = new System.Windows.Forms.Padding(7);
            this.txtnumbers.PasswordChar = false;
            this.txtnumbers.Size = new System.Drawing.Size(302, 41);
            this.txtnumbers.TabIndex = 0;
            this.txtnumbers.UnderLinedStyle = true;
            this.txtnumbers.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnumbers_KeyPress);
            // 
            // pnlcontainernums
            // 
            this.pnlcontainernums.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlcontainernums.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.pnlcontainernums.Controls.Add(this.pnlnumbers);
            this.pnlcontainernums.Location = new System.Drawing.Point(12, 115);
            this.pnlcontainernums.Name = "pnlcontainernums";
            this.pnlcontainernums.Size = new System.Drawing.Size(331, 281);
            this.pnlcontainernums.TabIndex = 4;
            this.pnlcontainernums.Visible = false;
            // 
            // pnlcontainermats
            // 
            this.pnlcontainermats.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlcontainermats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.pnlcontainermats.Controls.Add(this.pnlmats);
            this.pnlcontainermats.Location = new System.Drawing.Point(446, 367);
            this.pnlcontainermats.Name = "pnlcontainermats";
            this.pnlcontainermats.Padding = new System.Windows.Forms.Padding(3);
            this.pnlcontainermats.Size = new System.Drawing.Size(310, 269);
            this.pnlcontainermats.TabIndex = 5;
            this.pnlcontainermats.Visible = false;
            // 
            // pnlcontainertools
            // 
            this.pnlcontainertools.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlcontainertools.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.pnlcontainertools.Controls.Add(this.pnltools);
            this.pnlcontainertools.Location = new System.Drawing.Point(11, 407);
            this.pnlcontainertools.Name = "pnlcontainertools";
            this.pnlcontainertools.Padding = new System.Windows.Forms.Padding(3);
            this.pnlcontainertools.Size = new System.Drawing.Size(331, 176);
            this.pnlcontainertools.TabIndex = 6;
            this.pnlcontainertools.Visible = false;
            // 
            // pnltools
            // 
            this.pnltools.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.pnltools.Controls.Add(this.btnclearerror);
            this.pnltools.Controls.Add(this.btnprint);
            this.pnltools.Controls.Add(this.btndeleteorder);
            this.pnltools.Controls.Add(this.btndeletemat);
            this.pnltools.Controls.Add(this.btnediteprice);
            this.pnltools.Controls.Add(this.btneditqty);
            this.pnltools.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnltools.Location = new System.Drawing.Point(3, 3);
            this.pnltools.Name = "pnltools";
            this.pnltools.Size = new System.Drawing.Size(325, 170);
            this.pnltools.TabIndex = 0;
            // 
            // btnclearerror
            // 
            this.btnclearerror.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(90)))));
            this.btnclearerror.BackGraundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(90)))));
            this.btnclearerror.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnclearerror.BorderRadius = 15;
            this.btnclearerror.BorderSize = 0;
            this.btnclearerror.FlatAppearance.BorderSize = 0;
            this.btnclearerror.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclearerror.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnclearerror.ForeColor = System.Drawing.Color.White;
            this.btnclearerror.Location = new System.Drawing.Point(165, 6);
            this.btnclearerror.Name = "btnclearerror";
            this.btnclearerror.Size = new System.Drawing.Size(155, 50);
            this.btnclearerror.TabIndex = 8;
            this.btnclearerror.Tag = "إلغاء الخطاء";
            this.btnclearerror.Text = "Clear Error";
            this.btnclearerror.TextColor = System.Drawing.Color.White;
            this.btnclearerror.UseVisualStyleBackColor = false;
            this.btnclearerror.Click += new System.EventHandler(this.btnclearerror_Click);
            // 
            // btnprint
            // 
            this.btnprint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(90)))));
            this.btnprint.BackGraundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(90)))));
            this.btnprint.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnprint.BorderRadius = 15;
            this.btnprint.BorderSize = 0;
            this.btnprint.FlatAppearance.BorderSize = 0;
            this.btnprint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnprint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnprint.ForeColor = System.Drawing.Color.White;
            this.btnprint.Location = new System.Drawing.Point(5, 6);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(155, 50);
            this.btnprint.TabIndex = 7;
            this.btnprint.Tag = "طباعة";
            this.btnprint.Text = "Print";
            this.btnprint.TextColor = System.Drawing.Color.White;
            this.btnprint.UseVisualStyleBackColor = false;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // btndeleteorder
            // 
            this.btndeleteorder.BackColor = System.Drawing.Color.Crimson;
            this.btndeleteorder.BackGraundColor = System.Drawing.Color.Crimson;
            this.btndeleteorder.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btndeleteorder.BorderRadius = 15;
            this.btndeleteorder.BorderSize = 0;
            this.btndeleteorder.FlatAppearance.BorderSize = 0;
            this.btndeleteorder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndeleteorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btndeleteorder.ForeColor = System.Drawing.Color.White;
            this.btndeleteorder.Location = new System.Drawing.Point(165, 115);
            this.btndeleteorder.Name = "btndeleteorder";
            this.btndeleteorder.Size = new System.Drawing.Size(155, 50);
            this.btndeleteorder.TabIndex = 6;
            this.btndeleteorder.Tag = "حذف الطلب";
            this.btndeleteorder.Text = "Delete Order";
            this.btndeleteorder.TextColor = System.Drawing.Color.White;
            this.btndeleteorder.UseVisualStyleBackColor = false;
            this.btndeleteorder.Click += new System.EventHandler(this.btndeleteorder_Click);
            // 
            // btndeletemat
            // 
            this.btndeletemat.BackColor = System.Drawing.Color.Crimson;
            this.btndeletemat.BackGraundColor = System.Drawing.Color.Crimson;
            this.btndeletemat.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btndeletemat.BorderRadius = 15;
            this.btndeletemat.BorderSize = 0;
            this.btndeletemat.FlatAppearance.BorderSize = 0;
            this.btndeletemat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndeletemat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btndeletemat.ForeColor = System.Drawing.Color.White;
            this.btndeletemat.Location = new System.Drawing.Point(5, 115);
            this.btndeletemat.Name = "btndeletemat";
            this.btndeletemat.Size = new System.Drawing.Size(155, 50);
            this.btndeletemat.TabIndex = 5;
            this.btndeletemat.Tag = "حذف مادة ";
            this.btndeletemat.Text = "Delete Material";
            this.btndeletemat.TextColor = System.Drawing.Color.White;
            this.btndeletemat.UseVisualStyleBackColor = false;
            this.btndeletemat.Click += new System.EventHandler(this.btndeletemat_Click);
            // 
            // btnediteprice
            // 
            this.btnediteprice.BackColor = System.Drawing.Color.DarkOrange;
            this.btnediteprice.BackGraundColor = System.Drawing.Color.DarkOrange;
            this.btnediteprice.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnediteprice.BorderRadius = 15;
            this.btnediteprice.BorderSize = 0;
            this.btnediteprice.FlatAppearance.BorderSize = 0;
            this.btnediteprice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnediteprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnediteprice.ForeColor = System.Drawing.Color.White;
            this.btnediteprice.Location = new System.Drawing.Point(5, 62);
            this.btnediteprice.Name = "btnediteprice";
            this.btnediteprice.Size = new System.Drawing.Size(155, 50);
            this.btnediteprice.TabIndex = 4;
            this.btnediteprice.Tag = "تعديل السعر";
            this.btnediteprice.Text = "Edite Price";
            this.btnediteprice.TextColor = System.Drawing.Color.White;
            this.btnediteprice.UseVisualStyleBackColor = false;
            this.btnediteprice.Click += new System.EventHandler(this.btnediteprice_Click);
            // 
            // btneditqty
            // 
            this.btneditqty.BackColor = System.Drawing.Color.DarkOrange;
            this.btneditqty.BackGraundColor = System.Drawing.Color.DarkOrange;
            this.btneditqty.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btneditqty.BorderRadius = 15;
            this.btneditqty.BorderSize = 0;
            this.btneditqty.FlatAppearance.BorderSize = 0;
            this.btneditqty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneditqty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btneditqty.ForeColor = System.Drawing.Color.White;
            this.btneditqty.Location = new System.Drawing.Point(165, 61);
            this.btneditqty.Name = "btneditqty";
            this.btneditqty.Size = new System.Drawing.Size(155, 50);
            this.btneditqty.TabIndex = 3;
            this.btneditqty.Tag = "تعديل الكمية ";
            this.btneditqty.Text = "Edite QTY";
            this.btneditqty.TextColor = System.Drawing.Color.White;
            this.btneditqty.UseVisualStyleBackColor = false;
            this.btneditqty.Click += new System.EventHandler(this.btneditqty_Click);
            // 
            // btnsavesales
            // 
            this.btnsavesales.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnsavesales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.btnsavesales.BackGraundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.btnsavesales.BorderColor = System.Drawing.Color.White;
            this.btnsavesales.BorderRadius = 10;
            this.btnsavesales.BorderSize = 0;
            this.btnsavesales.FlatAppearance.BorderSize = 0;
            this.btnsavesales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsavesales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnsavesales.ForeColor = System.Drawing.Color.White;
            this.btnsavesales.Location = new System.Drawing.Point(19, 190);
            this.btnsavesales.Name = "btnsavesales";
            this.btnsavesales.Size = new System.Drawing.Size(170, 40);
            this.btnsavesales.TabIndex = 10;
            this.btnsavesales.Tag = "حفظ المبيعات";
            this.btnsavesales.Text = "Save Sales";
            this.btnsavesales.TextColor = System.Drawing.Color.White;
            this.btnsavesales.UseVisualStyleBackColor = false;
            this.btnsavesales.Click += new System.EventHandler(this.btnsavesales_Click);
            // 
            // btnsales
            // 
            this.btnsales.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnsales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.btnsales.BackGraundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.btnsales.BorderColor = System.Drawing.Color.White;
            this.btnsales.BorderRadius = 10;
            this.btnsales.BorderSize = 0;
            this.btnsales.FlatAppearance.BorderSize = 0;
            this.btnsales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnsales.ForeColor = System.Drawing.Color.White;
            this.btnsales.Location = new System.Drawing.Point(19, 147);
            this.btnsales.Name = "btnsales";
            this.btnsales.Size = new System.Drawing.Size(170, 40);
            this.btnsales.TabIndex = 9;
            this.btnsales.Tag = "المبيعات";
            this.btnsales.Text = "Sales";
            this.btnsales.TextColor = System.Drawing.Color.White;
            this.btnsales.UseVisualStyleBackColor = false;
            this.btnsales.Click += new System.EventHandler(this.btnsales_Click);
            // 
            // lbltotaltitle
            // 
            this.lbltotaltitle.AutoSize = true;
            this.lbltotaltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbltotaltitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.lbltotaltitle.Location = new System.Drawing.Point(260, 45);
            this.lbltotaltitle.Name = "lbltotaltitle";
            this.lbltotaltitle.Size = new System.Drawing.Size(44, 20);
            this.lbltotaltitle.TabIndex = 7;
            this.lbltotaltitle.Tag = "المجموع";
            this.lbltotaltitle.Text = "Total";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbltotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(90)))));
            this.lbltotal.Location = new System.Drawing.Point(291, 67);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(18, 20);
            this.lbltotal.TabIndex = 8;
            this.lbltotal.Text = "0";
            // 
            // lblcustomer
            // 
            this.lblcustomer.AutoSize = true;
            this.lblcustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblcustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.lblcustomer.Location = new System.Drawing.Point(98, 9);
            this.lblcustomer.Name = "lblcustomer";
            this.lblcustomer.Size = new System.Drawing.Size(18, 20);
            this.lblcustomer.TabIndex = 10;
            this.lblcustomer.Text = "1";
            // 
            // lblcustomertitle
            // 
            this.lblcustomertitle.AutoSize = true;
            this.lblcustomertitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblcustomertitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.lblcustomertitle.Location = new System.Drawing.Point(9, 9);
            this.lblcustomertitle.Name = "lblcustomertitle";
            this.lblcustomertitle.Size = new System.Drawing.Size(78, 20);
            this.lblcustomertitle.TabIndex = 9;
            this.lblcustomertitle.Tag = "الزبون";
            this.lblcustomertitle.Text = "Customer";
            // 
            // lblusername
            // 
            this.lblusername.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblusername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.lblusername.Location = new System.Drawing.Point(85, 109);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(0, 18);
            this.lblusername.TabIndex = 12;
            // 
            // pnlcontainercustomer
            // 
            this.pnlcontainercustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlcontainercustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.pnlcontainercustomer.Controls.Add(this.pnlcustomers);
            this.pnlcontainercustomer.Location = new System.Drawing.Point(759, 367);
            this.pnlcontainercustomer.Name = "pnlcontainercustomer";
            this.pnlcontainercustomer.Size = new System.Drawing.Size(129, 268);
            this.pnlcontainercustomer.TabIndex = 13;
            this.pnlcontainercustomer.Visible = false;
            // 
            // pnlcustomers
            // 
            this.pnlcustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlcustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.pnlcustomers.Controls.Add(this.btncustomer4);
            this.pnlcustomers.Controls.Add(this.btncustomer2);
            this.pnlcustomers.Controls.Add(this.btncustomer3);
            this.pnlcustomers.Controls.Add(this.lblcustomer);
            this.pnlcustomers.Controls.Add(this.btncustomer1);
            this.pnlcustomers.Controls.Add(this.lblcustomertitle);
            this.pnlcustomers.Location = new System.Drawing.Point(3, 3);
            this.pnlcustomers.Name = "pnlcustomers";
            this.pnlcustomers.Size = new System.Drawing.Size(123, 262);
            this.pnlcustomers.TabIndex = 0;
            // 
            // btncustomer4
            // 
            this.btncustomer4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.btncustomer4.BackGraundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.btncustomer4.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btncustomer4.BorderRadius = 15;
            this.btncustomer4.BorderSize = 0;
            this.btncustomer4.FlatAppearance.BorderSize = 0;
            this.btncustomer4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncustomer4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btncustomer4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btncustomer4.Location = new System.Drawing.Point(4, 206);
            this.btncustomer4.Name = "btncustomer4";
            this.btncustomer4.Size = new System.Drawing.Size(114, 50);
            this.btncustomer4.TabIndex = 6;
            this.btncustomer4.Tag = "3";
            this.btncustomer4.Text = "Customer4";
            this.btncustomer4.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btncustomer4.UseVisualStyleBackColor = false;
            this.btncustomer4.Click += new System.EventHandler(this.MoveBetweenCustomer);
            // 
            // btncustomer2
            // 
            this.btncustomer2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.btncustomer2.BackGraundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.btncustomer2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btncustomer2.BorderRadius = 15;
            this.btncustomer2.BorderSize = 0;
            this.btncustomer2.FlatAppearance.BorderSize = 0;
            this.btncustomer2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncustomer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btncustomer2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btncustomer2.Location = new System.Drawing.Point(4, 94);
            this.btncustomer2.Name = "btncustomer2";
            this.btncustomer2.Size = new System.Drawing.Size(114, 50);
            this.btncustomer2.TabIndex = 4;
            this.btncustomer2.Tag = "1";
            this.btncustomer2.Text = "Customer2";
            this.btncustomer2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btncustomer2.UseVisualStyleBackColor = false;
            this.btncustomer2.Click += new System.EventHandler(this.MoveBetweenCustomer);
            // 
            // btncustomer3
            // 
            this.btncustomer3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.btncustomer3.BackGraundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.btncustomer3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btncustomer3.BorderRadius = 15;
            this.btncustomer3.BorderSize = 0;
            this.btncustomer3.FlatAppearance.BorderSize = 0;
            this.btncustomer3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncustomer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btncustomer3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btncustomer3.Location = new System.Drawing.Point(4, 150);
            this.btncustomer3.Name = "btncustomer3";
            this.btncustomer3.Size = new System.Drawing.Size(114, 50);
            this.btncustomer3.TabIndex = 5;
            this.btncustomer3.Tag = "2";
            this.btncustomer3.Text = "Customer3";
            this.btncustomer3.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btncustomer3.UseVisualStyleBackColor = false;
            this.btncustomer3.Click += new System.EventHandler(this.MoveBetweenCustomer);
            // 
            // btncustomer1
            // 
            this.btncustomer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.btncustomer1.BackGraundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.btncustomer1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btncustomer1.BorderRadius = 15;
            this.btncustomer1.BorderSize = 0;
            this.btncustomer1.FlatAppearance.BorderSize = 0;
            this.btncustomer1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncustomer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btncustomer1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btncustomer1.Location = new System.Drawing.Point(4, 38);
            this.btncustomer1.Name = "btncustomer1";
            this.btncustomer1.Size = new System.Drawing.Size(114, 50);
            this.btncustomer1.TabIndex = 3;
            this.btncustomer1.Tag = "0";
            this.btncustomer1.Text = "Customer1";
            this.btncustomer1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btncustomer1.UseVisualStyleBackColor = false;
            this.btncustomer1.Click += new System.EventHandler(this.MoveBetweenCustomer);
            // 
            // lblerror
            // 
            this.lblerror.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblerror.AutoSize = true;
            this.lblerror.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblerror.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.lblerror.Location = new System.Drawing.Point(390, 335);
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(0, 13);
            this.lblerror.TabIndex = 14;
            // 
            // lblordernumbertitle
            // 
            this.lblordernumbertitle.AutoSize = true;
            this.lblordernumbertitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblordernumbertitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.lblordernumbertitle.Location = new System.Drawing.Point(8, 47);
            this.lblordernumbertitle.Name = "lblordernumbertitle";
            this.lblordernumbertitle.Size = new System.Drawing.Size(109, 20);
            this.lblordernumbertitle.TabIndex = 15;
            this.lblordernumbertitle.Tag = "رقم الطلب";
            this.lblordernumbertitle.Text = "Order Number";
            // 
            // lblordernumber
            // 
            this.lblordernumber.AutoSize = true;
            this.lblordernumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblordernumber.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblordernumber.Location = new System.Drawing.Point(120, 67);
            this.lblordernumber.Name = "lblordernumber";
            this.lblordernumber.Size = new System.Drawing.Size(18, 20);
            this.lblordernumber.TabIndex = 16;
            this.lblordernumber.Text = "1";
            // 
            // printdocument
            // 
            this.printdocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintFirstPart);
            // 
            // backworker
            // 
            this.backworker.WorkerReportsProgress = true;
            this.backworker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backworker_DoWork);
            this.backworker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backworker_RunWorkerCompleted);
            // 
            // pnlnav
            // 
            this.pnlnav.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlnav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.pnlnav.Controls.Add(this.btnshowsearch);
            this.pnlnav.Controls.Add(this.btnshowtoolspnl);
            this.pnlnav.Controls.Add(this.lbltime);
            this.pnlnav.Controls.Add(this.lbldate);
            this.pnlnav.Controls.Add(this.lbltimetitle);
            this.pnlnav.Controls.Add(this.lbldatetitle);
            this.pnlnav.Controls.Add(this.btnsales);
            this.pnlnav.Controls.Add(this.btnsavesales);
            this.pnlnav.Controls.Add(this.pnlsidenav);
            this.pnlnav.Controls.Add(this.pnlpicnav);
            this.pnlnav.Controls.Add(this.btnwarnings);
            this.pnlnav.Controls.Add(this.btnlogout);
            this.pnlnav.Location = new System.Drawing.Point(900, 35);
            this.pnlnav.Name = "pnlnav";
            this.pnlnav.Size = new System.Drawing.Size(210, 615);
            this.pnlnav.TabIndex = 17;
            // 
            // btnshowsearch
            // 
            this.btnshowsearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnshowsearch.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnshowsearch.BackGraundColor = System.Drawing.Color.DarkMagenta;
            this.btnshowsearch.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnshowsearch.BorderRadius = 10;
            this.btnshowsearch.BorderSize = 0;
            this.btnshowsearch.FlatAppearance.BorderSize = 0;
            this.btnshowsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnshowsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnshowsearch.ForeColor = System.Drawing.Color.White;
            this.btnshowsearch.Location = new System.Drawing.Point(19, 290);
            this.btnshowsearch.Name = "btnshowsearch";
            this.btnshowsearch.Size = new System.Drawing.Size(170, 40);
            this.btnshowsearch.TabIndex = 30;
            this.btnshowsearch.Tag = "إظهار مربع البحث";
            this.btnshowsearch.Text = "Show Search Box";
            this.btnshowsearch.TextColor = System.Drawing.Color.White;
            this.btnshowsearch.UseVisualStyleBackColor = false;
            this.btnshowsearch.Click += new System.EventHandler(this.btnshowsearch_Click);
            // 
            // btnshowtoolspnl
            // 
            this.btnshowtoolspnl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnshowtoolspnl.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnshowtoolspnl.BackGraundColor = System.Drawing.Color.DarkMagenta;
            this.btnshowtoolspnl.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnshowtoolspnl.BorderRadius = 10;
            this.btnshowtoolspnl.BorderSize = 0;
            this.btnshowtoolspnl.FlatAppearance.BorderSize = 0;
            this.btnshowtoolspnl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnshowtoolspnl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnshowtoolspnl.ForeColor = System.Drawing.Color.White;
            this.btnshowtoolspnl.Location = new System.Drawing.Point(19, 333);
            this.btnshowtoolspnl.Name = "btnshowtoolspnl";
            this.btnshowtoolspnl.Size = new System.Drawing.Size(170, 40);
            this.btnshowtoolspnl.TabIndex = 29;
            this.btnshowtoolspnl.Tag = "إظهار قائمة المواد";
            this.btnshowtoolspnl.Text = "Show Tools Panel";
            this.btnshowtoolspnl.TextColor = System.Drawing.Color.White;
            this.btnshowtoolspnl.UseVisualStyleBackColor = false;
            this.btnshowtoolspnl.Click += new System.EventHandler(this.btnshowtoolspnl_Click);
            // 
            // lbltime
            // 
            this.lbltime.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbltime.AutoSize = true;
            this.lbltime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbltime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lbltime.Location = new System.Drawing.Point(62, 536);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(0, 17);
            this.lbltime.TabIndex = 28;
            // 
            // lbldate
            // 
            this.lbldate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbldate.AutoSize = true;
            this.lbldate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbldate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lbldate.Location = new System.Drawing.Point(62, 506);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(0, 17);
            this.lbldate.TabIndex = 27;
            // 
            // lbltimetitle
            // 
            this.lbltimetitle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbltimetitle.AutoSize = true;
            this.lbltimetitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbltimetitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lbltimetitle.Location = new System.Drawing.Point(12, 536);
            this.lbltimetitle.Name = "lbltimetitle";
            this.lbltimetitle.Size = new System.Drawing.Size(38, 15);
            this.lbltimetitle.TabIndex = 26;
            this.lbltimetitle.Tag = "الوقت";
            this.lbltimetitle.Text = "Time:";
            // 
            // lbldatetitle
            // 
            this.lbldatetitle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbldatetitle.AutoSize = true;
            this.lbldatetitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbldatetitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lbldatetitle.Location = new System.Drawing.Point(12, 505);
            this.lbldatetitle.Name = "lbldatetitle";
            this.lbldatetitle.Size = new System.Drawing.Size(36, 15);
            this.lbldatetitle.TabIndex = 25;
            this.lbldatetitle.Tag = "التاريخ";
            this.lbldatetitle.Text = "Date:";
            // 
            // pnlsidenav
            // 
            this.pnlsidenav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.pnlsidenav.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlsidenav.Location = new System.Drawing.Point(0, 0);
            this.pnlsidenav.Name = "pnlsidenav";
            this.pnlsidenav.Size = new System.Drawing.Size(2, 615);
            this.pnlsidenav.TabIndex = 24;
            // 
            // pnlpicnav
            // 
            this.pnlpicnav.BackColor = System.Drawing.Color.Transparent;
            this.pnlpicnav.Controls.Add(this.picnav);
            this.pnlpicnav.Controls.Add(this.lblusername);
            this.pnlpicnav.Location = new System.Drawing.Point(2, 0);
            this.pnlpicnav.Name = "pnlpicnav";
            this.pnlpicnav.Size = new System.Drawing.Size(208, 140);
            this.pnlpicnav.TabIndex = 23;
            // 
            // picnav
            // 
            this.picnav.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picnav.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.picnav.BorderColor1 = System.Drawing.Color.RoyalBlue;
            this.picnav.BorderColor2 = System.Drawing.Color.HotPink;
            this.picnav.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.picnav.BorderSize = 0;
            this.picnav.GradiantAngle = 50F;
            this.picnav.Image = global::Sales_v3.Properties.Resources.SalesLogo;
            this.picnav.Location = new System.Drawing.Point(53, 3);
            this.picnav.Name = "picnav";
            this.picnav.Size = new System.Drawing.Size(100, 100);
            this.picnav.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picnav.TabIndex = 20;
            this.picnav.TabStop = false;
            // 
            // btnwarnings
            // 
            this.btnwarnings.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnwarnings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.btnwarnings.BackGraundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.btnwarnings.BorderColor = System.Drawing.Color.White;
            this.btnwarnings.BorderRadius = 10;
            this.btnwarnings.BorderSize = 0;
            this.btnwarnings.FlatAppearance.BorderSize = 0;
            this.btnwarnings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnwarnings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnwarnings.ForeColor = System.Drawing.Color.White;
            this.btnwarnings.Location = new System.Drawing.Point(19, 233);
            this.btnwarnings.Name = "btnwarnings";
            this.btnwarnings.Size = new System.Drawing.Size(170, 40);
            this.btnwarnings.TabIndex = 22;
            this.btnwarnings.Tag = "الإنذارات";
            this.btnwarnings.Text = "Warnings";
            this.btnwarnings.TextColor = System.Drawing.Color.White;
            this.btnwarnings.UseVisualStyleBackColor = false;
            this.btnwarnings.Click += new System.EventHandler(this.btnwarning_Click);
            // 
            // timernav
            // 
            this.timernav.Interval = 1;
            this.timernav.Tick += new System.EventHandler(this.tiemrnav_Tick);
            // 
            // btnnavoutside
            // 
            this.btnnavoutside.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnnavoutside.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.btnnavoutside.BackGraundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.btnnavoutside.BorderColor = System.Drawing.Color.White;
            this.btnnavoutside.BorderRadius = 15;
            this.btnnavoutside.BorderSize = 2;
            this.btnnavoutside.FlatAppearance.BorderSize = 0;
            this.btnnavoutside.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnavoutside.ForeColor = System.Drawing.Color.White;
            this.btnnavoutside.Location = new System.Drawing.Point(880, 162);
            this.btnnavoutside.Name = "btnnavoutside";
            this.btnnavoutside.Size = new System.Drawing.Size(40, 73);
            this.btnnavoutside.TabIndex = 18;
            this.btnnavoutside.Text = "||";
            this.btnnavoutside.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnnavoutside.TextColor = System.Drawing.Color.White;
            this.btnnavoutside.UseVisualStyleBackColor = false;
            this.btnnavoutside.Click += new System.EventHandler(this.btnnavoutside_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btnsearch
            // 
            this.btnsearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.btnsearch.BackGraundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.btnsearch.BorderColor = System.Drawing.Color.White;
            this.btnsearch.BorderRadius = 10;
            this.btnsearch.BorderSize = 0;
            this.btnsearch.FlatAppearance.BorderSize = 0;
            this.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsearch.ForeColor = System.Drawing.Color.White;
            this.btnsearch.Location = new System.Drawing.Point(497, 292);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(46, 41);
            this.btnsearch.TabIndex = 20;
            this.btnsearch.Tag = "S";
            this.btnsearch.Text = "S";
            this.btnsearch.TextColor = System.Drawing.Color.White;
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Visible = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // txtsearch
            // 
            this.txtsearch._Text = "";
            this.txtsearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtsearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtsearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.txtsearch.BorderColor = System.Drawing.Color.Silver;
            this.txtsearch.BorderSize = 5;
            this.txtsearch.FocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.txtsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtsearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.txtsearch.Location = new System.Drawing.Point(551, 293);
            this.txtsearch.MultiLine = false;
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Padding = new System.Windows.Forms.Padding(7);
            this.txtsearch.PasswordChar = false;
            this.txtsearch.Size = new System.Drawing.Size(323, 39);
            this.txtsearch.TabIndex = 21;
            this.txtsearch.UnderLinedStyle = true;
            this.txtsearch.Visible = false;
            // 
            // printpreview
            // 
            this.printpreview.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printpreview.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printpreview.ClientSize = new System.Drawing.Size(400, 300);
            this.printpreview.Document = this.printdocument;
            this.printpreview.Enabled = true;
            this.printpreview.Icon = ((System.Drawing.Icon)(resources.GetObject("printpreview.Icon")));
            this.printpreview.Name = "printpreview";
            this.printpreview.Visible = false;
            // 
            // SalePointForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(900, 650);
            this.Controls.Add(this.pnlnav);
            this.Controls.Add(this.btnnavoutside);
            this.Controls.Add(this.lblordernumber);
            this.Controls.Add(this.lblordernumbertitle);
            this.Controls.Add(this.lblerror);
            this.Controls.Add(this.pnlcontainercustomer);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.lbltotaltitle);
            this.Controls.Add(this.pnlcontainertools);
            this.Controls.Add(this.pnlcontainermats);
            this.Controls.Add(this.pnlcontainernums);
            this.Controls.Add(this.pnldgvsales);
            this.Controls.Add(this.pnltop);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.btnsearch);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SalePointForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalePointForm";
            this.Load += new System.EventHandler(this.SalePointForm_Load);
            this.pnltop.ResumeLayout(false);
            this.pnltop.PerformLayout();
            this.pnldgvsales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvsales)).EndInit();
            this.pnlnumbers.ResumeLayout(false);
            this.pnlcontainernums.ResumeLayout(false);
            this.pnlcontainermats.ResumeLayout(false);
            this.pnlcontainertools.ResumeLayout(false);
            this.pnltools.ResumeLayout(false);
            this.pnlcontainercustomer.ResumeLayout(false);
            this.pnlcustomers.ResumeLayout(false);
            this.pnlcustomers.PerformLayout();
            this.pnlnav.ResumeLayout(false);
            this.pnlnav.PerformLayout();
            this.pnlpicnav.ResumeLayout(false);
            this.pnlpicnav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picnav)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnltop;
        private AboodTools_v5.AboodButton btnexit;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Panel pnldgvsales;
        private System.Windows.Forms.FlowLayoutPanel pnlmats;
        private System.Windows.Forms.Panel pnlnumbers;
        private AboodTools_v5.AboodTextBox txtnumbers;
        private AboodTools_v5.AboodButton btnclear;
        private AboodTools_v5.AboodButton btncuma;
        private AboodTools_v5.AboodButton btn3;
        private AboodTools_v5.AboodButton btn6;
        private AboodTools_v5.AboodButton btn9;
        private AboodTools_v5.AboodButton btn00;
        private AboodTools_v5.AboodButton btn2;
        private AboodTools_v5.AboodButton btn5;
        private AboodTools_v5.AboodButton btn8;
        private AboodTools_v5.AboodButton btn0;
        private AboodTools_v5.AboodButton btn1;
        private AboodTools_v5.AboodButton btn4;
        private AboodTools_v5.AboodButton btn7;
        private System.Windows.Forms.Panel pnlcontainernums;
        private System.Windows.Forms.Panel pnlcontainermats;
        public  Bunifu.Framework.UI.BunifuCustomDataGrid dgvsales;
        private AboodTools_v5.AboodButton btnenter;
        private AboodTools_v5.AboodButton btnclearall;
        private System.Windows.Forms.Panel pnlcontainertools;
        private System.Windows.Forms.Panel pnltools;
        private AboodTools_v5.AboodButton btndeleteorder;
        private AboodTools_v5.AboodButton btndeletemat;
        private AboodTools_v5.AboodButton btnediteprice;
        private AboodTools_v5.AboodButton btneditqty;
        private System.Windows.Forms.Label lbltotaltitle;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label lblcustomer;
        private System.Windows.Forms.Label lblcustomertitle;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Panel pnlcontainercustomer;
        private System.Windows.Forms.Panel pnlcustomers;
        private AboodTools_v5.AboodButton btncustomer4;
        private AboodTools_v5.AboodButton btncustomer2;
        private AboodTools_v5.AboodButton btncustomer3;
        private AboodTools_v5.AboodButton btncustomer1;
        private AboodTools_v5.AboodButton btnsales;
        private AboodTools_v5.AboodButton btnclearerror;
        private AboodTools_v5.AboodButton btnprint;
        private System.Windows.Forms.Label lblerror;
        private System.Windows.Forms.Label lblordernumbertitle;
        private System.Windows.Forms.Label lblordernumber;
        private System.Drawing.Printing.PrintDocument printdocument;
        private AboodTools_v5.AboodButton btnsavesales;
        private AboodTools_v5.AboodButton btnlogout;
        private AboodTools_v5.AboodButton btnrestart;
        private System.Windows.Forms.DataGridViewTextBoxColumn colnum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colname;
        private System.Windows.Forms.DataGridViewTextBoxColumn colqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colsubtotal;
        private System.ComponentModel.BackgroundWorker backworker;
        private AboodTools_v5.AboodButton btnresize;
        private System.Windows.Forms.Panel pnlnav;
        private System.Windows.Forms.Timer timernav;
        private AboodTools_v5.AboodButton btnnavoutside;
        private AboodTools_v5.AboodPictureBox picnav;
        private System.Windows.Forms.Panel pnlpicnav;
        private AboodTools_v5.AboodButton btnwarnings;
        private System.Windows.Forms.Panel pnlsidenav;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label lbldatetitle;
        private System.Windows.Forms.Label lbltimetitle;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Label lbldate;
        private AboodTools_v5.AboodButton btnshowsearch;
        private AboodTools_v5.AboodButton btnshowtoolspnl;
        private AboodTools_v5.AboodButton btnsearch;
        private AboodTools_v5.AboodTextBox txtsearch;
        private System.Windows.Forms.PrintPreviewDialog printpreview;
    }
}
