namespace Sales_v3.Forms
{
    partial class AccountsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountsForm));
            this.pnltop = new System.Windows.Forms.Panel();
            this.lbltitle = new System.Windows.Forms.Label();
            this.btnrestart = new AboodTools_v5.AboodButton();
            this.btnexit = new AboodTools_v5.AboodButton();
            this.pnlcontainer = new System.Windows.Forms.Panel();
            this.pnlmain = new System.Windows.Forms.Panel();
            this.pnlcontainerinfo = new System.Windows.Forms.Panel();
            this.pnlinfo = new System.Windows.Forms.Panel();
            this.btndelete = new AboodTools_v5.AboodButton();
            this.btnclear = new AboodTools_v5.AboodButton();
            this.btnedit = new AboodTools_v5.AboodButton();
            this.btnadd = new AboodTools_v5.AboodButton();
            this.cbxaccounttype = new System.Windows.Forms.ComboBox();
            this.lblaccounttype = new System.Windows.Forms.Label();
            this.cbxname = new System.Windows.Forms.ComboBox();
            this.txtpassword = new AboodTools_v5.AboodTextBox();
            this.lblpassword = new System.Windows.Forms.Label();
            this.txtusername = new AboodTools_v5.AboodTextBox();
            this.lblusername = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.txtid = new AboodTools_v5.AboodTextBox();
            this.lblaccountsinfo = new System.Windows.Forms.Label();
            this.pnlcontaineraccountant = new System.Windows.Forms.Panel();
            this.pnlaccountants = new System.Windows.Forms.Panel();
            this.pnlaccountanttools = new System.Windows.Forms.Panel();
            this.lblaccountants = new System.Windows.Forms.Label();
            this.pnlcontainermanager = new System.Windows.Forms.Panel();
            this.pnlmanagers = new System.Windows.Forms.Panel();
            this.pnlmanagertools = new System.Windows.Forms.Panel();
            this.lblmanagers = new System.Windows.Forms.Label();
            this.lblerror = new System.Windows.Forms.Label();
            this.elipsAccounts = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.aboodPictureBox1 = new AboodTools_v5.AboodPictureBox();
            this.backworker = new System.ComponentModel.BackgroundWorker();
            this.pnltop.SuspendLayout();
            this.pnlcontainer.SuspendLayout();
            this.pnlmain.SuspendLayout();
            this.pnlcontainerinfo.SuspendLayout();
            this.pnlinfo.SuspendLayout();
            this.pnlcontaineraccountant.SuspendLayout();
            this.pnlaccountants.SuspendLayout();
            this.pnlcontainermanager.SuspendLayout();
            this.pnlmanagers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aboodPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnltop
            // 
            this.pnltop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.pnltop.Controls.Add(this.lbltitle);
            this.pnltop.Controls.Add(this.btnrestart);
            this.pnltop.Controls.Add(this.btnexit);
            this.pnltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnltop.Location = new System.Drawing.Point(0, 0);
            this.pnltop.Name = "pnltop";
            this.pnltop.Size = new System.Drawing.Size(939, 35);
            this.pnltop.TabIndex = 0;
            this.pnltop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnltop_MouseDown);
            this.pnltop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnltop_MouseMove);
            this.pnltop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnltop_MouseUp);
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbltitle.ForeColor = System.Drawing.Color.White;
            this.lbltitle.Location = new System.Drawing.Point(9, 9);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(109, 20);
            this.lbltitle.TabIndex = 2;
            this.lbltitle.Text = "Account Form";
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
            this.btnrestart.Location = new System.Drawing.Point(863, 1);
            this.btnrestart.Name = "btnrestart";
            this.btnrestart.Size = new System.Drawing.Size(33, 33);
            this.btnrestart.TabIndex = 10;
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
            this.btnexit.Location = new System.Drawing.Point(901, 1);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(33, 33);
            this.btnexit.TabIndex = 9;
            this.btnexit.Text = "X";
            this.btnexit.TextColor = System.Drawing.Color.White;
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // pnlcontainer
            // 
            this.pnlcontainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.pnlcontainer.Controls.Add(this.pnlmain);
            this.pnlcontainer.Location = new System.Drawing.Point(12, 180);
            this.pnlcontainer.Margin = new System.Windows.Forms.Padding(0);
            this.pnlcontainer.Name = "pnlcontainer";
            this.pnlcontainer.Padding = new System.Windows.Forms.Padding(3);
            this.pnlcontainer.Size = new System.Drawing.Size(915, 452);
            this.pnlcontainer.TabIndex = 1;
            this.pnlcontainer.Visible = false;
            // 
            // pnlmain
            // 
            this.pnlmain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.pnlmain.Controls.Add(this.pnlcontainerinfo);
            this.pnlmain.Controls.Add(this.pnlcontaineraccountant);
            this.pnlmain.Controls.Add(this.pnlcontainermanager);
            this.pnlmain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlmain.Location = new System.Drawing.Point(3, 3);
            this.pnlmain.Name = "pnlmain";
            this.pnlmain.Padding = new System.Windows.Forms.Padding(12);
            this.pnlmain.Size = new System.Drawing.Size(909, 446);
            this.pnlmain.TabIndex = 0;
            // 
            // pnlcontainerinfo
            // 
            this.pnlcontainerinfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.pnlcontainerinfo.Controls.Add(this.pnlinfo);
            this.pnlcontainerinfo.Location = new System.Drawing.Point(473, 12);
            this.pnlcontainerinfo.Name = "pnlcontainerinfo";
            this.pnlcontainerinfo.Padding = new System.Windows.Forms.Padding(3);
            this.pnlcontainerinfo.Size = new System.Drawing.Size(424, 421);
            this.pnlcontainerinfo.TabIndex = 22;
            this.pnlcontainerinfo.Visible = false;
            // 
            // pnlinfo
            // 
            this.pnlinfo.AutoScroll = true;
            this.pnlinfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.pnlinfo.Controls.Add(this.btndelete);
            this.pnlinfo.Controls.Add(this.btnclear);
            this.pnlinfo.Controls.Add(this.btnedit);
            this.pnlinfo.Controls.Add(this.btnadd);
            this.pnlinfo.Controls.Add(this.cbxaccounttype);
            this.pnlinfo.Controls.Add(this.lblaccounttype);
            this.pnlinfo.Controls.Add(this.cbxname);
            this.pnlinfo.Controls.Add(this.txtpassword);
            this.pnlinfo.Controls.Add(this.lblpassword);
            this.pnlinfo.Controls.Add(this.txtusername);
            this.pnlinfo.Controls.Add(this.lblusername);
            this.pnlinfo.Controls.Add(this.lblname);
            this.pnlinfo.Controls.Add(this.lblid);
            this.pnlinfo.Controls.Add(this.txtid);
            this.pnlinfo.Controls.Add(this.lblaccountsinfo);
            this.pnlinfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlinfo.Location = new System.Drawing.Point(3, 3);
            this.pnlinfo.Name = "pnlinfo";
            this.pnlinfo.Size = new System.Drawing.Size(418, 415);
            this.pnlinfo.TabIndex = 18;
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Crimson;
            this.btndelete.BackGraundColor = System.Drawing.Color.Crimson;
            this.btndelete.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btndelete.BorderRadius = 10;
            this.btndelete.BorderSize = 0;
            this.btndelete.FlatAppearance.BorderSize = 0;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btndelete.ForeColor = System.Drawing.Color.White;
            this.btndelete.Location = new System.Drawing.Point(302, 309);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(104, 84);
            this.btndelete.TabIndex = 8;
            this.btndelete.Tag = "حذف";
            this.btndelete.Text = "Delete";
            this.btndelete.TextColor = System.Drawing.Color.White;
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.DarkOrange;
            this.btnclear.BackGraundColor = System.Drawing.Color.DarkOrange;
            this.btnclear.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnclear.BorderRadius = 10;
            this.btnclear.BorderSize = 0;
            this.btnclear.FlatAppearance.BorderSize = 0;
            this.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnclear.ForeColor = System.Drawing.Color.White;
            this.btnclear.Location = new System.Drawing.Point(302, 210);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(104, 84);
            this.btnclear.TabIndex = 7;
            this.btnclear.Tag = "إذالة المعلومات";
            this.btnclear.Text = "Clear";
            this.btnclear.TextColor = System.Drawing.Color.White;
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnedit
            // 
            this.btnedit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(91)))));
            this.btnedit.BackGraundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(91)))));
            this.btnedit.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnedit.BorderRadius = 10;
            this.btnedit.BorderSize = 0;
            this.btnedit.FlatAppearance.BorderSize = 0;
            this.btnedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnedit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnedit.ForeColor = System.Drawing.Color.White;
            this.btnedit.Location = new System.Drawing.Point(302, 111);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(104, 84);
            this.btnedit.TabIndex = 6;
            this.btnedit.Tag = "تعديل";
            this.btnedit.Text = "Edit";
            this.btnedit.TextColor = System.Drawing.Color.White;
            this.btnedit.UseVisualStyleBackColor = false;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.btnadd.BackGraundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.btnadd.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.btnadd.BorderRadius = 10;
            this.btnadd.BorderSize = 0;
            this.btnadd.FlatAppearance.BorderSize = 0;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnadd.ForeColor = System.Drawing.Color.White;
            this.btnadd.Location = new System.Drawing.Point(302, 12);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(104, 84);
            this.btnadd.TabIndex = 5;
            this.btnadd.Tag = "إضافة";
            this.btnadd.Text = "Add";
            this.btnadd.TextColor = System.Drawing.Color.White;
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // cbxaccounttype
            // 
            this.cbxaccounttype.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbxaccounttype.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxaccounttype.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cbxaccounttype.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxaccounttype.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbxaccounttype.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(91)))));
            this.cbxaccounttype.FormattingEnabled = true;
            this.cbxaccounttype.Items.AddRange(new object[] {
            "Accountant",
            "Manager"});
            this.cbxaccounttype.Location = new System.Drawing.Point(27, 175);
            this.cbxaccounttype.Name = "cbxaccounttype";
            this.cbxaccounttype.Size = new System.Drawing.Size(249, 28);
            this.cbxaccounttype.TabIndex = 2;
            this.cbxaccounttype.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxaccounttype_KeyPress);
            // 
            // lblaccounttype
            // 
            this.lblaccounttype.AutoSize = true;
            this.lblaccounttype.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblaccounttype.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(91)))));
            this.lblaccounttype.Location = new System.Drawing.Point(15, 136);
            this.lblaccounttype.Name = "lblaccounttype";
            this.lblaccounttype.Size = new System.Drawing.Size(106, 20);
            this.lblaccounttype.TabIndex = 28;
            this.lblaccounttype.Tag = "نوع الحساب";
            this.lblaccounttype.Text = "Account Type";
            this.lblaccounttype.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbxname
            // 
            this.cbxname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbxname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cbxname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbxname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.cbxname.FormattingEnabled = true;
            this.cbxname.Location = new System.Drawing.Point(25, 90);
            this.cbxname.Name = "cbxname";
            this.cbxname.Size = new System.Drawing.Size(145, 28);
            this.cbxname.TabIndex = 1;
            this.cbxname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxname_KeyPress);
            // 
            // txtpassword
            // 
            this.txtpassword._Text = "";
            this.txtpassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtpassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtpassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.txtpassword.BorderColor = System.Drawing.Color.Silver;
            this.txtpassword.BorderSize = 5;
            this.txtpassword.FocusColor = System.Drawing.Color.Crimson;
            this.txtpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtpassword.ForeColor = System.Drawing.Color.Crimson;
            this.txtpassword.Location = new System.Drawing.Point(25, 356);
            this.txtpassword.MultiLine = false;
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Padding = new System.Windows.Forms.Padding(7);
            this.txtpassword.PasswordChar = false;
            this.txtpassword.Size = new System.Drawing.Size(249, 39);
            this.txtpassword.TabIndex = 4;
            this.txtpassword.UnderLinedStyle = true;
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblpassword.ForeColor = System.Drawing.Color.Crimson;
            this.lblpassword.Location = new System.Drawing.Point(13, 317);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(82, 20);
            this.lblpassword.TabIndex = 26;
            this.lblpassword.Tag = "كلمة المرور";
            this.lblpassword.Text = "Password:";
            // 
            // txtusername
            // 
            this.txtusername._Text = "";
            this.txtusername.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtusername.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtusername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.txtusername.BorderColor = System.Drawing.Color.Silver;
            this.txtusername.BorderSize = 5;
            this.txtusername.FocusColor = System.Drawing.Color.DarkOrange;
            this.txtusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtusername.ForeColor = System.Drawing.Color.DarkOrange;
            this.txtusername.Location = new System.Drawing.Point(25, 260);
            this.txtusername.MultiLine = false;
            this.txtusername.Name = "txtusername";
            this.txtusername.Padding = new System.Windows.Forms.Padding(7);
            this.txtusername.PasswordChar = false;
            this.txtusername.Size = new System.Drawing.Size(249, 39);
            this.txtusername.TabIndex = 3;
            this.txtusername.UnderLinedStyle = true;
            this.txtusername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtusername_KeyPress);
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblusername.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblusername.Location = new System.Drawing.Point(12, 221);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(89, 20);
            this.lblusername.TabIndex = 24;
            this.lblusername.Tag = "السم المستخدم";
            this.lblusername.Text = "User Name";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.lblname.Location = new System.Drawing.Point(12, 51);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(125, 20);
            this.lblname.TabIndex = 22;
            this.lblname.Tag = "اسم الموظف";
            this.lblname.Text = "Employee Name";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.lblid.Location = new System.Drawing.Point(186, 51);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(23, 20);
            this.lblid.TabIndex = 21;
            this.lblid.Tag = "الرقم";
            this.lblid.Text = "Id";
            // 
            // txtid
            // 
            this.txtid._Text = "";
            this.txtid.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtid.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.txtid.BorderColor = System.Drawing.Color.Silver;
            this.txtid.BorderSize = 5;
            this.txtid.FocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.txtid.Location = new System.Drawing.Point(201, 79);
            this.txtid.MultiLine = false;
            this.txtid.Name = "txtid";
            this.txtid.Padding = new System.Windows.Forms.Padding(7);
            this.txtid.PasswordChar = false;
            this.txtid.Size = new System.Drawing.Size(73, 39);
            this.txtid.TabIndex = 20;
            this.txtid.UnderLinedStyle = true;
            this.txtid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtid_KeyPress);
            // 
            // lblaccountsinfo
            // 
            this.lblaccountsinfo.AutoSize = true;
            this.lblaccountsinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblaccountsinfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(0)))));
            this.lblaccountsinfo.Location = new System.Drawing.Point(12, 12);
            this.lblaccountsinfo.Name = "lblaccountsinfo";
            this.lblaccountsinfo.Size = new System.Drawing.Size(108, 20);
            this.lblaccountsinfo.TabIndex = 16;
            this.lblaccountsinfo.Tag = "معلومات الحساب";
            this.lblaccountsinfo.Text = "Accounts Info";
            // 
            // pnlcontaineraccountant
            // 
            this.pnlcontaineraccountant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.pnlcontaineraccountant.Controls.Add(this.pnlaccountants);
            this.pnlcontaineraccountant.Location = new System.Drawing.Point(12, 183);
            this.pnlcontaineraccountant.Name = "pnlcontaineraccountant";
            this.pnlcontaineraccountant.Padding = new System.Windows.Forms.Padding(3);
            this.pnlcontaineraccountant.Size = new System.Drawing.Size(450, 250);
            this.pnlcontaineraccountant.TabIndex = 21;
            this.pnlcontaineraccountant.Visible = false;
            // 
            // pnlaccountants
            // 
            this.pnlaccountants.AutoScroll = true;
            this.pnlaccountants.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.pnlaccountants.Controls.Add(this.pnlaccountanttools);
            this.pnlaccountants.Controls.Add(this.lblaccountants);
            this.pnlaccountants.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlaccountants.Location = new System.Drawing.Point(3, 3);
            this.pnlaccountants.Name = "pnlaccountants";
            this.pnlaccountants.Size = new System.Drawing.Size(444, 244);
            this.pnlaccountants.TabIndex = 14;
            // 
            // pnlaccountanttools
            // 
            this.pnlaccountanttools.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlaccountanttools.Location = new System.Drawing.Point(0, 40);
            this.pnlaccountanttools.Name = "pnlaccountanttools";
            this.pnlaccountanttools.Size = new System.Drawing.Size(444, 204);
            this.pnlaccountanttools.TabIndex = 20;
            // 
            // lblaccountants
            // 
            this.lblaccountants.AutoSize = true;
            this.lblaccountants.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblaccountants.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblaccountants.Location = new System.Drawing.Point(12, 12);
            this.lblaccountants.Name = "lblaccountants";
            this.lblaccountants.Size = new System.Drawing.Size(99, 20);
            this.lblaccountants.TabIndex = 19;
            this.lblaccountants.Text = "Accountants";
            // 
            // pnlcontainermanager
            // 
            this.pnlcontainermanager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.pnlcontainermanager.Controls.Add(this.pnlmanagers);
            this.pnlcontainermanager.Location = new System.Drawing.Point(12, 12);
            this.pnlcontainermanager.Name = "pnlcontainermanager";
            this.pnlcontainermanager.Padding = new System.Windows.Forms.Padding(3);
            this.pnlcontainermanager.Size = new System.Drawing.Size(450, 159);
            this.pnlcontainermanager.TabIndex = 20;
            this.pnlcontainermanager.Visible = false;
            // 
            // pnlmanagers
            // 
            this.pnlmanagers.AutoScroll = true;
            this.pnlmanagers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.pnlmanagers.Controls.Add(this.pnlmanagertools);
            this.pnlmanagers.Controls.Add(this.lblmanagers);
            this.pnlmanagers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlmanagers.Location = new System.Drawing.Point(3, 3);
            this.pnlmanagers.Name = "pnlmanagers";
            this.pnlmanagers.Size = new System.Drawing.Size(444, 153);
            this.pnlmanagers.TabIndex = 18;
            // 
            // pnlmanagertools
            // 
            this.pnlmanagertools.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlmanagertools.Location = new System.Drawing.Point(0, 40);
            this.pnlmanagertools.Name = "pnlmanagertools";
            this.pnlmanagertools.Size = new System.Drawing.Size(444, 113);
            this.pnlmanagertools.TabIndex = 17;
            // 
            // lblmanagers
            // 
            this.lblmanagers.AutoSize = true;
            this.lblmanagers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblmanagers.ForeColor = System.Drawing.Color.Crimson;
            this.lblmanagers.Location = new System.Drawing.Point(12, 12);
            this.lblmanagers.Name = "lblmanagers";
            this.lblmanagers.Size = new System.Drawing.Size(80, 20);
            this.lblmanagers.TabIndex = 16;
            this.lblmanagers.Text = "Managers";
            // 
            // lblerror
            // 
            this.lblerror.AutoSize = true;
            this.lblerror.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.lblerror.Location = new System.Drawing.Point(12, 637);
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(0, 17);
            this.lblerror.TabIndex = 2;
            // 
            // elipsAccounts
            // 
            this.elipsAccounts.ElipseRadius = 10;
            this.elipsAccounts.TargetControl = this;
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
            this.aboodPictureBox1.Location = new System.Drawing.Point(420, 58);
            this.aboodPictureBox1.Name = "aboodPictureBox1";
            this.aboodPictureBox1.Size = new System.Drawing.Size(100, 100);
            this.aboodPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.aboodPictureBox1.TabIndex = 14;
            this.aboodPictureBox1.TabStop = false;
            // 
            // backworker
            // 
            this.backworker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backworker_DoWork);
            // 
            // AccountsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(939, 666);
            this.Controls.Add(this.aboodPictureBox1);
            this.Controls.Add(this.lblerror);
            this.Controls.Add(this.pnlcontainer);
            this.Controls.Add(this.pnltop);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AccountsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccountsForm";
            this.Load += new System.EventHandler(this.AccountsForm_Load);
            this.pnltop.ResumeLayout(false);
            this.pnltop.PerformLayout();
            this.pnlcontainer.ResumeLayout(false);
            this.pnlmain.ResumeLayout(false);
            this.pnlcontainerinfo.ResumeLayout(false);
            this.pnlinfo.ResumeLayout(false);
            this.pnlinfo.PerformLayout();
            this.pnlcontaineraccountant.ResumeLayout(false);
            this.pnlaccountants.ResumeLayout(false);
            this.pnlaccountants.PerformLayout();
            this.pnlcontainermanager.ResumeLayout(false);
            this.pnlmanagers.ResumeLayout(false);
            this.pnlmanagers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aboodPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnltop;
        private AboodTools_v5.AboodButton btnrestart;
        private AboodTools_v5.AboodButton btnexit;
        private System.Windows.Forms.Panel pnlcontainer;
        private System.Windows.Forms.Panel pnlmain;
        private System.Windows.Forms.Label lblerror;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Panel pnlcontaineraccountant;
        private System.Windows.Forms.Panel pnlaccountants;
        private System.Windows.Forms.Panel pnlcontainermanager;
        private System.Windows.Forms.Panel pnlmanagers;
        private System.Windows.Forms.Label lblmanagers;
        private System.Windows.Forms.Label lblaccountants;
        private System.Windows.Forms.Panel pnlcontainerinfo;
        private System.Windows.Forms.Panel pnlinfo;
        private System.Windows.Forms.Label lblaccountsinfo;
        private Bunifu.Framework.UI.BunifuElipse elipsAccounts;
        private System.Windows.Forms.Label lblid;
        private AboodTools_v5.AboodTextBox txtid;
        private System.Windows.Forms.Label lblaccounttype;
        private AboodTools_v5.AboodTextBox txtpassword;
        private System.Windows.Forms.Label lblpassword;
        private AboodTools_v5.AboodTextBox txtusername;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.ComboBox cbxaccounttype;
        private System.Windows.Forms.ComboBox cbxname;
        private System.Windows.Forms.Panel pnlaccountanttools;
        private System.Windows.Forms.Panel pnlmanagertools;
        private AboodTools_v5.AboodPictureBox aboodPictureBox1;
        private AboodTools_v5.AboodButton btndelete;
        private AboodTools_v5.AboodButton btnclear;
        private AboodTools_v5.AboodButton btnedit;
        private AboodTools_v5.AboodButton btnadd;
        private System.ComponentModel.BackgroundWorker backworker;
    }
}