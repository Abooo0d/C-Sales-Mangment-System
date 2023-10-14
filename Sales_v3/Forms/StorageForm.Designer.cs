namespace Sales_v3.Forms
{
    partial class StorageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StorageForm));
            this.pnltop = new System.Windows.Forms.Panel();
            this.btnrestart = new AboodTools_v5.AboodButton();
            this.lbltitle = new System.Windows.Forms.Label();
            this.btnexit = new AboodTools_v5.AboodButton();
            this.pnlcontainer = new System.Windows.Forms.Panel();
            this.pnltools = new System.Windows.Forms.Panel();
            this.btnaddqty = new AboodTools_v5.AboodButton();
            this.btnclear = new AboodTools_v5.AboodButton();
            this.btnadd = new AboodTools_v5.AboodButton();
            this.lblwarning = new System.Windows.Forms.Label();
            this.togglewarning = new AboodTools_v5.AboodToggleButton();
            this.btndelete = new AboodTools_v5.AboodButton();
            this.txtaddedqty = new AboodTools_v5.AboodTextBox();
            this.lbladdedqty = new System.Windows.Forms.Label();
            this.btnedite = new AboodTools_v5.AboodButton();
            this.btnlastone = new AboodTools_v5.AboodButton();
            this.btnnext = new AboodTools_v5.AboodButton();
            this.btnback = new AboodTools_v5.AboodButton();
            this.btnfirstone = new AboodTools_v5.AboodButton();
            this.txtprice = new AboodTools_v5.AboodTextBox();
            this.lblprice = new System.Windows.Forms.Label();
            this.txtqty = new AboodTools_v5.AboodTextBox();
            this.lblqty = new System.Windows.Forms.Label();
            this.txtmatrialname = new AboodTools_v5.AboodTextBox();
            this.lblmatrialname = new System.Windows.Forms.Label();
            this.pnldgvsales = new System.Windows.Forms.Panel();
            this.dgvsales = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.colname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.aboodPictureBox1 = new AboodTools_v5.AboodPictureBox();
            this.lblerror = new System.Windows.Forms.Label();
            this.backworker = new System.ComponentModel.BackgroundWorker();
            this.pnltop.SuspendLayout();
            this.pnlcontainer.SuspendLayout();
            this.pnltools.SuspendLayout();
            this.pnldgvsales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aboodPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnltop
            // 
            this.pnltop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.pnltop.Controls.Add(this.btnrestart);
            this.pnltop.Controls.Add(this.lbltitle);
            this.pnltop.Controls.Add(this.btnexit);
            this.pnltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnltop.Location = new System.Drawing.Point(0, 0);
            this.pnltop.Name = "pnltop";
            this.pnltop.Size = new System.Drawing.Size(600, 35);
            this.pnltop.TabIndex = 0;
            this.pnltop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnltop_MouseDown);
            this.pnltop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnltop_MouseMove);
            this.pnltop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnltop_MouseUp);
            // 
            // btnrestart
            // 
            this.btnrestart.BackColor = System.Drawing.Color.Transparent;
            this.btnrestart.BackGraundColor = System.Drawing.Color.Transparent;
            this.btnrestart.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnrestart.BorderRadius = 15;
            this.btnrestart.BorderSize = 0;
            this.btnrestart.FlatAppearance.BorderSize = 0;
            this.btnrestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrestart.ForeColor = System.Drawing.Color.White;
            this.btnrestart.Location = new System.Drawing.Point(524, 1);
            this.btnrestart.Name = "btnrestart";
            this.btnrestart.Size = new System.Drawing.Size(33, 33);
            this.btnrestart.TabIndex = 2;
            this.btnrestart.Tag = "R";
            this.btnrestart.Text = "R";
            this.btnrestart.TextColor = System.Drawing.Color.White;
            this.btnrestart.UseVisualStyleBackColor = false;
            this.btnrestart.Click += new System.EventHandler(this.btnrestart_Click);
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbltitle.ForeColor = System.Drawing.Color.White;
            this.lbltitle.Location = new System.Drawing.Point(12, 8);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(66, 20);
            this.lbltitle.TabIndex = 1;
            this.lbltitle.Tag = "المخزن";
            this.lbltitle.Text = "Storage";
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Transparent;
            this.btnexit.BackGraundColor = System.Drawing.Color.Transparent;
            this.btnexit.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnexit.BorderRadius = 15;
            this.btnexit.BorderSize = 0;
            this.btnexit.FlatAppearance.BorderSize = 0;
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexit.ForeColor = System.Drawing.Color.White;
            this.btnexit.Location = new System.Drawing.Point(562, 1);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(33, 33);
            this.btnexit.TabIndex = 0;
            this.btnexit.Tag = "X";
            this.btnexit.Text = "X";
            this.btnexit.TextColor = System.Drawing.Color.White;
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // pnlcontainer
            // 
            this.pnlcontainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.pnlcontainer.Controls.Add(this.pnltools);
            this.pnlcontainer.Location = new System.Drawing.Point(12, 180);
            this.pnlcontainer.Name = "pnlcontainer";
            this.pnlcontainer.Size = new System.Drawing.Size(576, 441);
            this.pnlcontainer.TabIndex = 1;
            this.pnlcontainer.Visible = false;
            // 
            // pnltools
            // 
            this.pnltools.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.pnltools.Controls.Add(this.btnaddqty);
            this.pnltools.Controls.Add(this.btnclear);
            this.pnltools.Controls.Add(this.btnadd);
            this.pnltools.Controls.Add(this.lblwarning);
            this.pnltools.Controls.Add(this.togglewarning);
            this.pnltools.Controls.Add(this.btndelete);
            this.pnltools.Controls.Add(this.txtaddedqty);
            this.pnltools.Controls.Add(this.lbladdedqty);
            this.pnltools.Controls.Add(this.btnedite);
            this.pnltools.Controls.Add(this.btnlastone);
            this.pnltools.Controls.Add(this.btnnext);
            this.pnltools.Controls.Add(this.btnback);
            this.pnltools.Controls.Add(this.btnfirstone);
            this.pnltools.Controls.Add(this.txtprice);
            this.pnltools.Controls.Add(this.lblprice);
            this.pnltools.Controls.Add(this.txtqty);
            this.pnltools.Controls.Add(this.lblqty);
            this.pnltools.Controls.Add(this.txtmatrialname);
            this.pnltools.Controls.Add(this.lblmatrialname);
            this.pnltools.Controls.Add(this.pnldgvsales);
            this.pnltools.Location = new System.Drawing.Point(3, 3);
            this.pnltools.Name = "pnltools";
            this.pnltools.Size = new System.Drawing.Size(570, 435);
            this.pnltools.TabIndex = 0;
            // 
            // btnaddqty
            // 
            this.btnaddqty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(0)))));
            this.btnaddqty.BackGraundColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(0)))));
            this.btnaddqty.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnaddqty.BorderRadius = 15;
            this.btnaddqty.BorderSize = 0;
            this.btnaddqty.FlatAppearance.BorderSize = 0;
            this.btnaddqty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaddqty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnaddqty.ForeColor = System.Drawing.Color.White;
            this.btnaddqty.Location = new System.Drawing.Point(10, 248);
            this.btnaddqty.Name = "btnaddqty";
            this.btnaddqty.Size = new System.Drawing.Size(102, 50);
            this.btnaddqty.TabIndex = 35;
            this.btnaddqty.Tag = "إضافة الكنية";
            this.btnaddqty.Text = "Add QTY";
            this.btnaddqty.TextColor = System.Drawing.Color.White;
            this.btnaddqty.UseVisualStyleBackColor = false;
            this.btnaddqty.Visible = false;
            this.btnaddqty.Click += new System.EventHandler(this.btnaddqty_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.btnclear.BackGraundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.btnclear.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnclear.BorderRadius = 15;
            this.btnclear.BorderSize = 0;
            this.btnclear.FlatAppearance.BorderSize = 0;
            this.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnclear.ForeColor = System.Drawing.Color.White;
            this.btnclear.Location = new System.Drawing.Point(230, 372);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(102, 50);
            this.btnclear.TabIndex = 34;
            this.btnclear.Tag = "إذالة المعلومات";
            this.btnclear.Text = "Clear";
            this.btnclear.TextColor = System.Drawing.Color.White;
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Visible = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.Crimson;
            this.btnadd.BackGraundColor = System.Drawing.Color.Crimson;
            this.btnadd.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnadd.BorderRadius = 15;
            this.btnadd.BorderSize = 0;
            this.btnadd.FlatAppearance.BorderSize = 0;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnadd.ForeColor = System.Drawing.Color.White;
            this.btnadd.Location = new System.Drawing.Point(342, 372);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(102, 50);
            this.btnadd.TabIndex = 30;
            this.btnadd.Tag = "إضافة مادة";
            this.btnadd.Text = "Add New Item ";
            this.btnadd.TextColor = System.Drawing.Color.White;
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Visible = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // lblwarning
            // 
            this.lblwarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblwarning.ForeColor = System.Drawing.Color.Fuchsia;
            this.lblwarning.Location = new System.Drawing.Point(461, 311);
            this.lblwarning.Name = "lblwarning";
            this.lblwarning.Size = new System.Drawing.Size(96, 58);
            this.lblwarning.TabIndex = 33;
            this.lblwarning.Tag = "تنبيه عند الكمية المنخفضة";
            this.lblwarning.Text = "Warning At Low QTY";
            this.lblwarning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // togglewarning
            // 
            this.togglewarning.Location = new System.Drawing.Point(464, 375);
            this.togglewarning.MinimumSize = new System.Drawing.Size(45, 22);
            this.togglewarning.Name = "togglewarning";
            this.togglewarning.OffBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.togglewarning.OffToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.togglewarning.OnBackColor = System.Drawing.Color.Fuchsia;
            this.togglewarning.OnToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.togglewarning.Size = new System.Drawing.Size(90, 39);
            this.togglewarning.TabIndex = 32;
            this.togglewarning.UseVisualStyleBackColor = true;
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Crimson;
            this.btndelete.BackGraundColor = System.Drawing.Color.Crimson;
            this.btndelete.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btndelete.BorderRadius = 15;
            this.btndelete.BorderSize = 0;
            this.btndelete.FlatAppearance.BorderSize = 0;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btndelete.ForeColor = System.Drawing.Color.White;
            this.btndelete.Location = new System.Drawing.Point(340, 315);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(102, 50);
            this.btndelete.TabIndex = 31;
            this.btndelete.Tag = "حذف";
            this.btndelete.Text = "Delete";
            this.btndelete.TextColor = System.Drawing.Color.White;
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Visible = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // txtaddedqty
            // 
            this.txtaddedqty._Text = "";
            this.txtaddedqty.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtaddedqty.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtaddedqty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtaddedqty.BorderColor = System.Drawing.Color.Silver;
            this.txtaddedqty.BorderSize = 5;
            this.txtaddedqty.FocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(0)))));
            this.txtaddedqty.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddedqty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(0)))));
            this.txtaddedqty.Location = new System.Drawing.Point(181, 260);
            this.txtaddedqty.MultiLine = false;
            this.txtaddedqty.Name = "txtaddedqty";
            this.txtaddedqty.Padding = new System.Windows.Forms.Padding(7);
            this.txtaddedqty.PasswordChar = false;
            this.txtaddedqty.Size = new System.Drawing.Size(178, 41);
            this.txtaddedqty.TabIndex = 5;
            this.txtaddedqty.UnderLinedStyle = true;
            this.txtaddedqty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtaddedqty_KeyPress);
            // 
            // lbladdedqty
            // 
            this.lbladdedqty.AutoSize = true;
            this.lbladdedqty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbladdedqty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(0)))));
            this.lbladdedqty.Location = new System.Drawing.Point(143, 239);
            this.lbladdedqty.Name = "lbladdedqty";
            this.lbladdedqty.Size = new System.Drawing.Size(92, 20);
            this.lbladdedqty.TabIndex = 29;
            this.lbladdedqty.Tag = "الكمية المضافة";
            this.lbladdedqty.Text = "Added QTY";
            // 
            // btnedite
            // 
            this.btnedite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.btnedite.BackGraundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.btnedite.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnedite.BorderRadius = 15;
            this.btnedite.BorderSize = 0;
            this.btnedite.FlatAppearance.BorderSize = 0;
            this.btnedite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnedite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnedite.ForeColor = System.Drawing.Color.White;
            this.btnedite.Location = new System.Drawing.Point(230, 315);
            this.btnedite.Name = "btnedite";
            this.btnedite.Size = new System.Drawing.Size(102, 50);
            this.btnedite.TabIndex = 10;
            this.btnedite.Tag = "تعديل";
            this.btnedite.Text = "Edite";
            this.btnedite.TextColor = System.Drawing.Color.White;
            this.btnedite.UseVisualStyleBackColor = false;
            this.btnedite.Visible = false;
            this.btnedite.Click += new System.EventHandler(this.btnedite_Click);
            // 
            // btnlastone
            // 
            this.btnlastone.BackColor = System.Drawing.Color.DarkOrange;
            this.btnlastone.BackGraundColor = System.Drawing.Color.DarkOrange;
            this.btnlastone.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnlastone.BorderRadius = 15;
            this.btnlastone.BorderSize = 0;
            this.btnlastone.FlatAppearance.BorderSize = 0;
            this.btnlastone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlastone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnlastone.ForeColor = System.Drawing.Color.White;
            this.btnlastone.Location = new System.Drawing.Point(10, 315);
            this.btnlastone.Name = "btnlastone";
            this.btnlastone.Size = new System.Drawing.Size(102, 50);
            this.btnlastone.TabIndex = 9;
            this.btnlastone.Tag = "الأخير";
            this.btnlastone.Text = "Last";
            this.btnlastone.TextColor = System.Drawing.Color.White;
            this.btnlastone.UseVisualStyleBackColor = false;
            this.btnlastone.Visible = false;
            this.btnlastone.Click += new System.EventHandler(this.btnlastone_Click);
            // 
            // btnnext
            // 
            this.btnnext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(90)))));
            this.btnnext.BackGraundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(90)))));
            this.btnnext.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnnext.BorderRadius = 15;
            this.btnnext.BorderSize = 0;
            this.btnnext.FlatAppearance.BorderSize = 0;
            this.btnnext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnnext.ForeColor = System.Drawing.Color.White;
            this.btnnext.Location = new System.Drawing.Point(121, 372);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(102, 50);
            this.btnnext.TabIndex = 8;
            this.btnnext.Tag = "التالي";
            this.btnnext.Text = "Next";
            this.btnnext.TextColor = System.Drawing.Color.White;
            this.btnnext.UseVisualStyleBackColor = false;
            this.btnnext.Visible = false;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(90)))));
            this.btnback.BackGraundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(90)))));
            this.btnback.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnback.BorderRadius = 15;
            this.btnback.BorderSize = 0;
            this.btnback.FlatAppearance.BorderSize = 0;
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnback.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnback.ForeColor = System.Drawing.Color.White;
            this.btnback.Location = new System.Drawing.Point(121, 315);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(102, 50);
            this.btnback.TabIndex = 7;
            this.btnback.Tag = "السابق";
            this.btnback.Text = "Back";
            this.btnback.TextColor = System.Drawing.Color.White;
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Visible = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnfirstone
            // 
            this.btnfirstone.BackColor = System.Drawing.Color.DarkOrange;
            this.btnfirstone.BackGraundColor = System.Drawing.Color.DarkOrange;
            this.btnfirstone.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnfirstone.BorderRadius = 15;
            this.btnfirstone.BorderSize = 0;
            this.btnfirstone.FlatAppearance.BorderSize = 0;
            this.btnfirstone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfirstone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnfirstone.ForeColor = System.Drawing.Color.White;
            this.btnfirstone.Location = new System.Drawing.Point(10, 372);
            this.btnfirstone.Name = "btnfirstone";
            this.btnfirstone.Size = new System.Drawing.Size(102, 50);
            this.btnfirstone.TabIndex = 6;
            this.btnfirstone.Tag = "الأول";
            this.btnfirstone.Text = "First";
            this.btnfirstone.TextColor = System.Drawing.Color.White;
            this.btnfirstone.UseVisualStyleBackColor = false;
            this.btnfirstone.Visible = false;
            this.btnfirstone.Click += new System.EventHandler(this.btnfirstone_Click);
            // 
            // txtprice
            // 
            this.txtprice._Text = "";
            this.txtprice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtprice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtprice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtprice.BorderColor = System.Drawing.Color.Silver;
            this.txtprice.BorderSize = 5;
            this.txtprice.FocusColor = System.Drawing.Color.Crimson;
            this.txtprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprice.ForeColor = System.Drawing.Color.Crimson;
            this.txtprice.Location = new System.Drawing.Point(47, 187);
            this.txtprice.MultiLine = false;
            this.txtprice.Name = "txtprice";
            this.txtprice.Padding = new System.Windows.Forms.Padding(7);
            this.txtprice.PasswordChar = false;
            this.txtprice.Size = new System.Drawing.Size(312, 41);
            this.txtprice.TabIndex = 4;
            this.txtprice.UnderLinedStyle = true;
            this.txtprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprice_KeyPress);
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblprice.ForeColor = System.Drawing.Color.Crimson;
            this.lblprice.Location = new System.Drawing.Point(12, 167);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(48, 20);
            this.lblprice.TabIndex = 22;
            this.lblprice.Tag = "السعر";
            this.lblprice.Text = "Price:";
            // 
            // txtqty
            // 
            this.txtqty._Text = "";
            this.txtqty.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtqty.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtqty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtqty.BorderColor = System.Drawing.Color.Silver;
            this.txtqty.BorderSize = 5;
            this.txtqty.FocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(91)))));
            this.txtqty.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(91)))));
            this.txtqty.Location = new System.Drawing.Point(47, 110);
            this.txtqty.MultiLine = false;
            this.txtqty.Name = "txtqty";
            this.txtqty.Padding = new System.Windows.Forms.Padding(7);
            this.txtqty.PasswordChar = false;
            this.txtqty.Size = new System.Drawing.Size(312, 41);
            this.txtqty.TabIndex = 3;
            this.txtqty.UnderLinedStyle = true;
            this.txtqty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtqty_KeyPress);
            // 
            // lblqty
            // 
            this.lblqty.AutoSize = true;
            this.lblqty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblqty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(91)))));
            this.lblqty.Location = new System.Drawing.Point(12, 85);
            this.lblqty.Name = "lblqty";
            this.lblqty.Size = new System.Drawing.Size(33, 20);
            this.lblqty.TabIndex = 18;
            this.lblqty.Tag = "الكمية";
            this.lblqty.Text = "Qty";
            // 
            // txtmatrialname
            // 
            this.txtmatrialname._Text = "";
            this.txtmatrialname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtmatrialname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtmatrialname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtmatrialname.BorderColor = System.Drawing.Color.Silver;
            this.txtmatrialname.BorderSize = 5;
            this.txtmatrialname.FocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.txtmatrialname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmatrialname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.txtmatrialname.Location = new System.Drawing.Point(47, 36);
            this.txtmatrialname.MultiLine = false;
            this.txtmatrialname.Name = "txtmatrialname";
            this.txtmatrialname.Padding = new System.Windows.Forms.Padding(7);
            this.txtmatrialname.PasswordChar = false;
            this.txtmatrialname.Size = new System.Drawing.Size(312, 41);
            this.txtmatrialname.TabIndex = 2;
            this.txtmatrialname.UnderLinedStyle = true;
            // 
            // lblmatrialname
            // 
            this.lblmatrialname.AutoSize = true;
            this.lblmatrialname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblmatrialname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.lblmatrialname.Location = new System.Drawing.Point(12, 12);
            this.lblmatrialname.Name = "lblmatrialname";
            this.lblmatrialname.Size = new System.Drawing.Size(102, 20);
            this.lblmatrialname.TabIndex = 16;
            this.lblmatrialname.Tag = "اسم المادة";
            this.lblmatrialname.Text = "Matrial Name";
            // 
            // pnldgvsales
            // 
            this.pnldgvsales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnldgvsales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.pnldgvsales.Controls.Add(this.dgvsales);
            this.pnldgvsales.Location = new System.Drawing.Point(407, 12);
            this.pnldgvsales.Name = "pnldgvsales";
            this.pnldgvsales.Size = new System.Drawing.Size(150, 289);
            this.pnldgvsales.TabIndex = 13;
            // 
            // dgvsales
            // 
            this.dgvsales.AllowUserToAddRows = false;
            this.dgvsales.AllowUserToDeleteRows = false;
            this.dgvsales.AllowUserToResizeColumns = false;
            this.dgvsales.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvsales.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvsales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.colname});
            this.dgvsales.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvsales.DefaultCellStyle = dataGridViewCellStyle3;
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
            this.dgvsales.Size = new System.Drawing.Size(144, 283);
            this.dgvsales.TabIndex = 0;
            this.dgvsales.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvsales_CellClick);
            // 
            // colname
            // 
            this.colname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colname.FillWeight = 250F;
            this.colname.HeaderText = "Material Name";
            this.colname.Name = "colname";
            this.colname.ReadOnly = true;
            this.colname.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // aboodPictureBox1
            // 
            this.aboodPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.aboodPictureBox1.BorderColor1 = System.Drawing.Color.RoyalBlue;
            this.aboodPictureBox1.BorderColor2 = System.Drawing.Color.HotPink;
            this.aboodPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.aboodPictureBox1.BorderSize = 0;
            this.aboodPictureBox1.GradiantAngle = 50F;
            this.aboodPictureBox1.Image = global::Sales_v3.Properties.Resources.SalesLogo;
            this.aboodPictureBox1.Location = new System.Drawing.Point(250, 58);
            this.aboodPictureBox1.Name = "aboodPictureBox1";
            this.aboodPictureBox1.Size = new System.Drawing.Size(100, 100);
            this.aboodPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.aboodPictureBox1.TabIndex = 12;
            this.aboodPictureBox1.TabStop = false;
            // 
            // lblerror
            // 
            this.lblerror.AutoSize = true;
            this.lblerror.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblerror.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.lblerror.Location = new System.Drawing.Point(12, 626);
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(0, 17);
            this.lblerror.TabIndex = 30;
            // 
            // backworker
            // 
            this.backworker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backworker_DoWork);
            // 
            // StorageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(600, 655);
            this.Controls.Add(this.lblerror);
            this.Controls.Add(this.aboodPictureBox1);
            this.Controls.Add(this.pnlcontainer);
            this.Controls.Add(this.pnltop);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StorageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StorageForm";
            this.Load += new System.EventHandler(this.StorageForm_Load);
            this.pnltop.ResumeLayout(false);
            this.pnltop.PerformLayout();
            this.pnlcontainer.ResumeLayout(false);
            this.pnltools.ResumeLayout(false);
            this.pnltools.PerformLayout();
            this.pnldgvsales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvsales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aboodPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnltop;
        private System.Windows.Forms.Label lbltitle;
        private AboodTools_v5.AboodButton btnexit;
        private System.Windows.Forms.Panel pnlcontainer;
        private System.Windows.Forms.Panel pnltools;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel pnldgvsales;
        public Bunifu.Framework.UI.BunifuCustomDataGrid dgvsales;
        private AboodTools_v5.AboodTextBox txtqty;
        private System.Windows.Forms.Label lblqty;
        private AboodTools_v5.AboodTextBox txtmatrialname;
        private System.Windows.Forms.Label lblmatrialname;
        private AboodTools_v5.AboodTextBox txtprice;
        private System.Windows.Forms.Label lblprice;
        private AboodTools_v5.AboodButton btnedite;
        private AboodTools_v5.AboodButton btnlastone;
        private AboodTools_v5.AboodButton btnnext;
        private AboodTools_v5.AboodButton btnback;
        private AboodTools_v5.AboodButton btnfirstone;
        private AboodTools_v5.AboodTextBox txtaddedqty;
        private System.Windows.Forms.Label lbladdedqty;
        private AboodTools_v5.AboodButton btnadd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colname;
        private AboodTools_v5.AboodButton btnclear;
        private System.Windows.Forms.Label lblwarning;
        private AboodTools_v5.AboodToggleButton togglewarning;
        private AboodTools_v5.AboodButton btndelete;
        private AboodTools_v5.AboodButton btnaddqty;
        private AboodTools_v5.AboodPictureBox aboodPictureBox1;
        private System.Windows.Forms.Label lblerror;
        private AboodTools_v5.AboodButton btnrestart;
        private System.ComponentModel.BackgroundWorker backworker;
    }
}