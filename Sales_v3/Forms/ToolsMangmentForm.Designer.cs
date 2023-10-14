namespace Sales_v3.Forms
{
    partial class ToolsMangmentForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolsMangmentForms));
            this.pnltop = new System.Windows.Forms.Panel();
            this.btnrestart = new AboodTools_v5.AboodButton();
            this.lbltitle = new System.Windows.Forms.Label();
            this.btnexit = new AboodTools_v5.AboodButton();
            this.pnlcontainer = new System.Windows.Forms.Panel();
            this.pnltools = new System.Windows.Forms.Panel();
            this.numtoolorder = new System.Windows.Forms.NumericUpDown();
            this.lbltoolorder = new System.Windows.Forms.Label();
            this.lblpreview = new System.Windows.Forms.Label();
            this.pnlbordercolor = new System.Windows.Forms.Panel();
            this.pnlcolor = new System.Windows.Forms.Panel();
            this.btnpreview = new AboodTools_v5.AboodButton();
            this.cbxbordercolor = new System.Windows.Forms.ComboBox();
            this.lblbordercolor = new System.Windows.Forms.Label();
            this.toggleborder = new AboodTools_v5.AboodToggleButton();
            this.togglebutton = new AboodTools_v5.AboodToggleButton();
            this.lblborder = new System.Windows.Forms.Label();
            this.lblbutton = new System.Windows.Forms.Label();
            this.btnedite = new AboodTools_v5.AboodButton();
            this.btnlastone = new AboodTools_v5.AboodButton();
            this.btnnext = new AboodTools_v5.AboodButton();
            this.btnback = new AboodTools_v5.AboodButton();
            this.btnfirstone = new AboodTools_v5.AboodButton();
            this.pnldgvsales = new System.Windows.Forms.Panel();
            this.dgvsales = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.colname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbxcolor = new System.Windows.Forms.ComboBox();
            this.lblcolor = new System.Windows.Forms.Label();
            this.txtprice = new AboodTools_v5.AboodTextBox();
            this.lblprice = new System.Windows.Forms.Label();
            this.txtmatrial = new AboodTools_v5.AboodTextBox();
            this.lblmatrialname = new System.Windows.Forms.Label();
            this.txtid = new AboodTools_v5.AboodTextBox();
            this.lblid = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.aboodPictureBox1 = new AboodTools_v5.AboodPictureBox();
            this.lblerror = new System.Windows.Forms.Label();
            this.backworker = new System.ComponentModel.BackgroundWorker();
            this.pnltop.SuspendLayout();
            this.pnlcontainer.SuspendLayout();
            this.pnltools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numtoolorder)).BeginInit();
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
            this.pnltop.Size = new System.Drawing.Size(730, 35);
            this.pnltop.TabIndex = 0;
            this.pnltop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnltop_MouseDown);
            this.pnltop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnltop_MouseMove);
            this.pnltop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnltop_MouseUp);
            // 
            // btnrestart
            // 
            this.btnrestart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnrestart.BackColor = System.Drawing.Color.Transparent;
            this.btnrestart.BackGraundColor = System.Drawing.Color.Transparent;
            this.btnrestart.BorderColor = System.Drawing.Color.Transparent;
            this.btnrestart.BorderRadius = 10;
            this.btnrestart.BorderSize = 0;
            this.btnrestart.FlatAppearance.BorderSize = 0;
            this.btnrestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrestart.ForeColor = System.Drawing.Color.White;
            this.btnrestart.Location = new System.Drawing.Point(654, 1);
            this.btnrestart.Name = "btnrestart";
            this.btnrestart.Size = new System.Drawing.Size(33, 33);
            this.btnrestart.TabIndex = 13;
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
            this.lbltitle.Location = new System.Drawing.Point(10, 9);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(127, 20);
            this.lbltitle.TabIndex = 1;
            this.lbltitle.Text = "Tools Mangment";
            // 
            // btnexit
            // 
            this.btnexit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnexit.BackColor = System.Drawing.Color.Transparent;
            this.btnexit.BackGraundColor = System.Drawing.Color.Transparent;
            this.btnexit.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnexit.BorderRadius = 15;
            this.btnexit.BorderSize = 0;
            this.btnexit.FlatAppearance.BorderSize = 0;
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexit.ForeColor = System.Drawing.Color.White;
            this.btnexit.Location = new System.Drawing.Point(692, 1);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(33, 33);
            this.btnexit.TabIndex = 0;
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
            this.pnlcontainer.Padding = new System.Windows.Forms.Padding(3);
            this.pnlcontainer.Size = new System.Drawing.Size(706, 388);
            this.pnlcontainer.TabIndex = 1;
            this.pnlcontainer.Visible = false;
            // 
            // pnltools
            // 
            this.pnltools.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.pnltools.Controls.Add(this.numtoolorder);
            this.pnltools.Controls.Add(this.lbltoolorder);
            this.pnltools.Controls.Add(this.lblpreview);
            this.pnltools.Controls.Add(this.pnlbordercolor);
            this.pnltools.Controls.Add(this.pnlcolor);
            this.pnltools.Controls.Add(this.btnpreview);
            this.pnltools.Controls.Add(this.cbxbordercolor);
            this.pnltools.Controls.Add(this.lblbordercolor);
            this.pnltools.Controls.Add(this.toggleborder);
            this.pnltools.Controls.Add(this.togglebutton);
            this.pnltools.Controls.Add(this.lblborder);
            this.pnltools.Controls.Add(this.lblbutton);
            this.pnltools.Controls.Add(this.btnedite);
            this.pnltools.Controls.Add(this.btnlastone);
            this.pnltools.Controls.Add(this.btnnext);
            this.pnltools.Controls.Add(this.btnback);
            this.pnltools.Controls.Add(this.btnfirstone);
            this.pnltools.Controls.Add(this.pnldgvsales);
            this.pnltools.Controls.Add(this.cbxcolor);
            this.pnltools.Controls.Add(this.lblcolor);
            this.pnltools.Controls.Add(this.txtprice);
            this.pnltools.Controls.Add(this.lblprice);
            this.pnltools.Controls.Add(this.txtmatrial);
            this.pnltools.Controls.Add(this.lblmatrialname);
            this.pnltools.Controls.Add(this.txtid);
            this.pnltools.Controls.Add(this.lblid);
            this.pnltools.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnltools.Location = new System.Drawing.Point(3, 3);
            this.pnltools.Name = "pnltools";
            this.pnltools.Size = new System.Drawing.Size(700, 382);
            this.pnltools.TabIndex = 0;
            // 
            // numtoolorder
            // 
            this.numtoolorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.numtoolorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numtoolorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numtoolorder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.numtoolorder.Location = new System.Drawing.Point(275, 47);
            this.numtoolorder.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numtoolorder.Name = "numtoolorder";
            this.numtoolorder.Size = new System.Drawing.Size(82, 26);
            this.numtoolorder.TabIndex = 30;
            this.numtoolorder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numtoolorder.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numtoolorder.ValueChanged += new System.EventHandler(this.numtoolorder_ValueChanged);
            // 
            // lbltoolorder
            // 
            this.lbltoolorder.AutoSize = true;
            this.lbltoolorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbltoolorder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.lbltoolorder.Location = new System.Drawing.Point(242, 12);
            this.lbltoolorder.Name = "lbltoolorder";
            this.lbltoolorder.Size = new System.Drawing.Size(83, 20);
            this.lbltoolorder.TabIndex = 28;
            this.lbltoolorder.Tag = "ترتيب الأداة";
            this.lbltoolorder.Text = "Tool Order";
            // 
            // lblpreview
            // 
            this.lblpreview.AutoSize = true;
            this.lblpreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblpreview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.lblpreview.Location = new System.Drawing.Point(395, 281);
            this.lblpreview.Name = "lblpreview";
            this.lblpreview.Size = new System.Drawing.Size(63, 20);
            this.lblpreview.TabIndex = 27;
            this.lblpreview.Tag = "معاينة";
            this.lblpreview.Text = "Preview";
            // 
            // pnlbordercolor
            // 
            this.pnlbordercolor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlbordercolor.Location = new System.Drawing.Point(225, 290);
            this.pnlbordercolor.Name = "pnlbordercolor";
            this.pnlbordercolor.Size = new System.Drawing.Size(160, 16);
            this.pnlbordercolor.TabIndex = 26;
            // 
            // pnlcolor
            // 
            this.pnlcolor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlcolor.Location = new System.Drawing.Point(39, 290);
            this.pnlcolor.Name = "pnlcolor";
            this.pnlcolor.Size = new System.Drawing.Size(160, 16);
            this.pnlcolor.TabIndex = 25;
            // 
            // btnpreview
            // 
            this.btnpreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.btnpreview.BackGraundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.btnpreview.BorderColor = System.Drawing.Color.Transparent;
            this.btnpreview.BorderRadius = 15;
            this.btnpreview.BorderSize = 0;
            this.btnpreview.FlatAppearance.BorderSize = 0;
            this.btnpreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnpreview.ForeColor = System.Drawing.Color.White;
            this.btnpreview.Location = new System.Drawing.Point(404, 307);
            this.btnpreview.Name = "btnpreview";
            this.btnpreview.Size = new System.Drawing.Size(150, 60);
            this.btnpreview.TabIndex = 24;
            this.btnpreview.Tag = "معاينة";
            this.btnpreview.Text = "Preview";
            this.btnpreview.TextColor = System.Drawing.Color.White;
            this.btnpreview.UseVisualStyleBackColor = false;
            // 
            // cbxbordercolor
            // 
            this.cbxbordercolor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbxbordercolor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxbordercolor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.cbxbordercolor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxbordercolor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.cbxbordercolor.FormattingEnabled = true;
            this.cbxbordercolor.Location = new System.Drawing.Point(225, 256);
            this.cbxbordercolor.Name = "cbxbordercolor";
            this.cbxbordercolor.Size = new System.Drawing.Size(160, 24);
            this.cbxbordercolor.TabIndex = 22;
            this.cbxbordercolor.SelectedIndexChanged += new System.EventHandler(this.cbxbordercolor_SelectedIndexChanged);
            // 
            // lblbordercolor
            // 
            this.lblbordercolor.AutoSize = true;
            this.lblbordercolor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblbordercolor.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblbordercolor.Location = new System.Drawing.Point(256, 224);
            this.lblbordercolor.Name = "lblbordercolor";
            this.lblbordercolor.Size = new System.Drawing.Size(98, 20);
            this.lblbordercolor.TabIndex = 23;
            this.lblbordercolor.Tag = "لون الإطار";
            this.lblbordercolor.Text = "Border Color";
            // 
            // toggleborder
            // 
            this.toggleborder.Location = new System.Drawing.Point(259, 334);
            this.toggleborder.MinimumSize = new System.Drawing.Size(45, 22);
            this.toggleborder.Name = "toggleborder";
            this.toggleborder.OffBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.toggleborder.OffToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.toggleborder.OnBackColor = System.Drawing.Color.DarkOrange;
            this.toggleborder.OnToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.toggleborder.Size = new System.Drawing.Size(92, 35);
            this.toggleborder.TabIndex = 21;
            this.toggleborder.UseVisualStyleBackColor = true;
            this.toggleborder.CheckedChanged += new System.EventHandler(this.toggleborder_CheckedChanged);
            // 
            // togglebutton
            // 
            this.togglebutton.Location = new System.Drawing.Point(74, 332);
            this.togglebutton.MinimumSize = new System.Drawing.Size(45, 22);
            this.togglebutton.Name = "togglebutton";
            this.togglebutton.OffBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.togglebutton.OffToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.togglebutton.OnBackColor = System.Drawing.Color.Crimson;
            this.togglebutton.OnToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.togglebutton.Size = new System.Drawing.Size(90, 35);
            this.togglebutton.TabIndex = 20;
            this.togglebutton.UseVisualStyleBackColor = true;
            this.togglebutton.CheckedChanged += new System.EventHandler(this.togglbutton_CheckedChanged);
            // 
            // lblborder
            // 
            this.lblborder.AutoSize = true;
            this.lblborder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblborder.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblborder.Location = new System.Drawing.Point(260, 312);
            this.lblborder.Name = "lblborder";
            this.lblborder.Size = new System.Drawing.Size(90, 20);
            this.lblborder.TabIndex = 19;
            this.lblborder.Tag = "إضافة إطار";
            this.lblborder.Text = "Add Border";
            // 
            // lblbutton
            // 
            this.lblbutton.AutoSize = true;
            this.lblbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblbutton.ForeColor = System.Drawing.Color.Crimson;
            this.lblbutton.Location = new System.Drawing.Point(74, 312);
            this.lblbutton.Name = "lblbutton";
            this.lblbutton.Size = new System.Drawing.Size(90, 20);
            this.lblbutton.TabIndex = 18;
            this.lblbutton.Tag = "إضافة أداة";
            this.lblbutton.Text = "Add Button";
            // 
            // btnedite
            // 
            this.btnedite.BackColor = System.Drawing.Color.Crimson;
            this.btnedite.BackGraundColor = System.Drawing.Color.Crimson;
            this.btnedite.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnedite.BorderRadius = 15;
            this.btnedite.BorderSize = 0;
            this.btnedite.FlatAppearance.BorderSize = 0;
            this.btnedite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnedite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnedite.ForeColor = System.Drawing.Color.White;
            this.btnedite.Location = new System.Drawing.Point(566, 305);
            this.btnedite.Name = "btnedite";
            this.btnedite.Size = new System.Drawing.Size(125, 60);
            this.btnedite.TabIndex = 17;
            this.btnedite.Tag = "تعديل";
            this.btnedite.Text = "Edite";
            this.btnedite.TextColor = System.Drawing.Color.White;
            this.btnedite.UseVisualStyleBackColor = false;
            this.btnedite.Visible = false;
            this.btnedite.Click += new System.EventHandler(this.btnedite_Click);
            // 
            // btnlastone
            // 
            this.btnlastone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(90)))));
            this.btnlastone.BackGraundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(90)))));
            this.btnlastone.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnlastone.BorderRadius = 15;
            this.btnlastone.BorderSize = 0;
            this.btnlastone.FlatAppearance.BorderSize = 0;
            this.btnlastone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlastone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnlastone.ForeColor = System.Drawing.Color.White;
            this.btnlastone.Location = new System.Drawing.Point(566, 232);
            this.btnlastone.Name = "btnlastone";
            this.btnlastone.Size = new System.Drawing.Size(125, 60);
            this.btnlastone.TabIndex = 16;
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
            this.btnnext.Location = new System.Drawing.Point(566, 159);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(125, 60);
            this.btnnext.TabIndex = 15;
            this.btnnext.Tag = "التالي";
            this.btnnext.Text = "Next";
            this.btnnext.TextColor = System.Drawing.Color.White;
            this.btnnext.UseVisualStyleBackColor = false;
            this.btnnext.Visible = false;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.DarkOrange;
            this.btnback.BackGraundColor = System.Drawing.Color.DarkOrange;
            this.btnback.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnback.BorderRadius = 15;
            this.btnback.BorderSize = 0;
            this.btnback.FlatAppearance.BorderSize = 0;
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnback.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnback.ForeColor = System.Drawing.Color.White;
            this.btnback.Location = new System.Drawing.Point(566, 86);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(125, 60);
            this.btnback.TabIndex = 14;
            this.btnback.Tag = "اسابق";
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
            this.btnfirstone.Location = new System.Drawing.Point(566, 13);
            this.btnfirstone.Name = "btnfirstone";
            this.btnfirstone.Size = new System.Drawing.Size(125, 60);
            this.btnfirstone.TabIndex = 13;
            this.btnfirstone.Tag = "الأول";
            this.btnfirstone.Text = "First";
            this.btnfirstone.TextColor = System.Drawing.Color.White;
            this.btnfirstone.UseVisualStyleBackColor = false;
            this.btnfirstone.Visible = false;
            this.btnfirstone.Click += new System.EventHandler(this.btnfirstone_Click);
            // 
            // pnldgvsales
            // 
            this.pnldgvsales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnldgvsales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.pnldgvsales.Controls.Add(this.dgvsales);
            this.pnldgvsales.Location = new System.Drawing.Point(410, 11);
            this.pnldgvsales.Name = "pnldgvsales";
            this.pnldgvsales.Padding = new System.Windows.Forms.Padding(3);
            this.pnldgvsales.Size = new System.Drawing.Size(147, 267);
            this.pnldgvsales.TabIndex = 12;
            // 
            // dgvsales
            // 
            this.dgvsales.AllowUserToAddRows = false;
            this.dgvsales.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
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
            this.dgvsales.Size = new System.Drawing.Size(141, 261);
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
            // 
            // cbxcolor
            // 
            this.cbxcolor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbxcolor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxcolor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.cbxcolor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxcolor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.cbxcolor.FormattingEnabled = true;
            this.cbxcolor.Location = new System.Drawing.Point(39, 256);
            this.cbxcolor.Name = "cbxcolor";
            this.cbxcolor.Size = new System.Drawing.Size(160, 24);
            this.cbxcolor.TabIndex = 5;
            this.cbxcolor.SelectedIndexChanged += new System.EventHandler(this.cbxcolor_SelectedIndexChanged);
            // 
            // lblcolor
            // 
            this.lblcolor.AutoSize = true;
            this.lblcolor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblcolor.ForeColor = System.Drawing.Color.Crimson;
            this.lblcolor.Location = new System.Drawing.Point(96, 224);
            this.lblcolor.Name = "lblcolor";
            this.lblcolor.Size = new System.Drawing.Size(46, 20);
            this.lblcolor.TabIndex = 8;
            this.lblcolor.Tag = "اللون";
            this.lblcolor.Text = "Color";
            // 
            // txtprice
            // 
            this.txtprice._Text = "";
            this.txtprice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtprice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtprice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtprice.BorderColor = System.Drawing.Color.Silver;
            this.txtprice.BorderSize = 5;
            this.txtprice.FocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(0)))));
            this.txtprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(0)))));
            this.txtprice.Location = new System.Drawing.Point(55, 165);
            this.txtprice.MultiLine = false;
            this.txtprice.Name = "txtprice";
            this.txtprice.Padding = new System.Windows.Forms.Padding(7);
            this.txtprice.PasswordChar = false;
            this.txtprice.Size = new System.Drawing.Size(319, 41);
            this.txtprice.TabIndex = 4;
            this.txtprice.UnderLinedStyle = true;
            this.txtprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtid_KeyPress);
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblprice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(0)))));
            this.lblprice.Location = new System.Drawing.Point(24, 146);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(44, 20);
            this.lblprice.TabIndex = 6;
            this.lblprice.Tag = "السعر";
            this.lblprice.Text = "Price";
            // 
            // txtmatrial
            // 
            this.txtmatrial._Text = "";
            this.txtmatrial.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtmatrial.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtmatrial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtmatrial.BorderColor = System.Drawing.Color.Silver;
            this.txtmatrial.BorderSize = 5;
            this.txtmatrial.FocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(90)))));
            this.txtmatrial.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmatrial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(90)))));
            this.txtmatrial.Location = new System.Drawing.Point(55, 100);
            this.txtmatrial.MultiLine = false;
            this.txtmatrial.Name = "txtmatrial";
            this.txtmatrial.Padding = new System.Windows.Forms.Padding(7);
            this.txtmatrial.PasswordChar = false;
            this.txtmatrial.Size = new System.Drawing.Size(319, 41);
            this.txtmatrial.TabIndex = 2;
            this.txtmatrial.UnderLinedStyle = true;
            this.txtmatrial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtid_KeyPress);
            // 
            // lblmatrialname
            // 
            this.lblmatrialname.AutoSize = true;
            this.lblmatrialname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblmatrialname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(90)))));
            this.lblmatrialname.Location = new System.Drawing.Point(24, 78);
            this.lblmatrialname.Name = "lblmatrialname";
            this.lblmatrialname.Size = new System.Drawing.Size(102, 20);
            this.lblmatrialname.TabIndex = 2;
            this.lblmatrialname.Tag = "اسم المادة";
            this.lblmatrialname.Text = "Matrial Name";
            // 
            // txtid
            // 
            this.txtid._Text = "";
            this.txtid.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtid.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtid.BorderColor = System.Drawing.Color.Silver;
            this.txtid.BorderSize = 5;
            this.txtid.FocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.txtid.Location = new System.Drawing.Point(55, 35);
            this.txtid.MultiLine = false;
            this.txtid.Name = "txtid";
            this.txtid.Padding = new System.Windows.Forms.Padding(7);
            this.txtid.PasswordChar = false;
            this.txtid.Size = new System.Drawing.Size(138, 41);
            this.txtid.TabIndex = 1;
            this.txtid.UnderLinedStyle = true;
            this.txtid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtid_KeyPress);
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.lblid.Location = new System.Drawing.Point(24, 12);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(23, 20);
            this.lblid.TabIndex = 0;
            this.lblid.Tag = "الرقم";
            this.lblid.Text = "Id";
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
            this.aboodPictureBox1.Location = new System.Drawing.Point(315, 58);
            this.aboodPictureBox1.Name = "aboodPictureBox1";
            this.aboodPictureBox1.Size = new System.Drawing.Size(100, 100);
            this.aboodPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.aboodPictureBox1.TabIndex = 14;
            this.aboodPictureBox1.TabStop = false;
            // 
            // lblerror
            // 
            this.lblerror.AutoSize = true;
            this.lblerror.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.lblerror.Location = new System.Drawing.Point(10, 575);
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(0, 17);
            this.lblerror.TabIndex = 15;
            // 
            // backworker
            // 
            this.backworker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backworker_DoWork);
            // 
            // ToolsMangmentForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(730, 600);
            this.Controls.Add(this.lblerror);
            this.Controls.Add(this.aboodPictureBox1);
            this.Controls.Add(this.pnlcontainer);
            this.Controls.Add(this.pnltop);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ToolsMangmentForms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StorageForm";
            this.Load += new System.EventHandler(this.ToolsMangmentForms_Load);
            this.pnltop.ResumeLayout(false);
            this.pnltop.PerformLayout();
            this.pnlcontainer.ResumeLayout(false);
            this.pnltools.ResumeLayout(false);
            this.pnltools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numtoolorder)).EndInit();
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
        private System.Windows.Forms.Label lblid;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private AboodTools_v5.AboodTextBox txtid;
        private System.Windows.Forms.Label lblcolor;
        private AboodTools_v5.AboodTextBox txtmatrial;
        private System.Windows.Forms.Label lblmatrialname;
        private System.Windows.Forms.ComboBox cbxcolor;
        private AboodTools_v5.AboodToggleButton toggleborder;
        private AboodTools_v5.AboodToggleButton togglebutton;
        private System.Windows.Forms.Label lblborder;
        private System.Windows.Forms.Label lblbutton;
        private AboodTools_v5.AboodButton btnedite;
        private AboodTools_v5.AboodButton btnlastone;
        private AboodTools_v5.AboodButton btnnext;
        private AboodTools_v5.AboodButton btnback;
        private AboodTools_v5.AboodButton btnfirstone;
        private System.Windows.Forms.Panel pnldgvsales;
        public Bunifu.Framework.UI.BunifuCustomDataGrid dgvsales;
        private AboodTools_v5.AboodButton btnpreview;
        private System.Windows.Forms.ComboBox cbxbordercolor;
        private System.Windows.Forms.Label lblbordercolor;
        private System.Windows.Forms.Panel pnlbordercolor;
        private System.Windows.Forms.Panel pnlcolor;
        private AboodTools_v5.AboodTextBox txtprice;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colname;
        private System.Windows.Forms.Label lbltoolorder;
        private System.Windows.Forms.NumericUpDown numtoolorder;
        private AboodTools_v5.AboodPictureBox aboodPictureBox1;
        private AboodTools_v5.AboodButton btnrestart;
        private System.Windows.Forms.Label lblerror;
        private System.ComponentModel.BackgroundWorker backworker;
        private System.Windows.Forms.Label lblpreview;
    }
}