namespace Sales_v3.Forms
{
    partial class EmployeesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeesForm));
            this.pnltop = new System.Windows.Forms.Panel();
            this.btnrestart = new AboodTools_v5.AboodButton();
            this.lbltitle = new System.Windows.Forms.Label();
            this.btnexit = new AboodTools_v5.AboodButton();
            this.pnlcontaineremp = new System.Windows.Forms.Panel();
            this.pnlemployees = new System.Windows.Forms.Panel();
            this.pnlcontainerinfo = new System.Windows.Forms.Panel();
            this.pnlinfo = new System.Windows.Forms.Panel();
            this.btndelete = new AboodTools_v5.AboodButton();
            this.btnclear = new AboodTools_v5.AboodButton();
            this.btnedite = new AboodTools_v5.AboodButton();
            this.btnadd = new AboodTools_v5.AboodButton();
            this.txtphone = new AboodTools_v5.AboodTextBox();
            this.lblphone = new System.Windows.Forms.Label();
            this.txtlname = new AboodTools_v5.AboodTextBox();
            this.txtprofession = new AboodTools_v5.AboodTextBox();
            this.lblprofession = new System.Windows.Forms.Label();
            this.txtdivision = new AboodTools_v5.AboodTextBox();
            this.lbldivision = new System.Windows.Forms.Label();
            this.txtsalary = new AboodTools_v5.AboodTextBox();
            this.lblsalary = new System.Windows.Forms.Label();
            this.txtworkshift = new AboodTools_v5.AboodTextBox();
            this.lblworkshift = new System.Windows.Forms.Label();
            this.txtaddress = new AboodTools_v5.AboodTextBox();
            this.lbladdress = new System.Windows.Forms.Label();
            this.lbllname = new System.Windows.Forms.Label();
            this.txtfname = new AboodTools_v5.AboodTextBox();
            this.lblfname = new System.Windows.Forms.Label();
            this.lblinfo = new System.Windows.Forms.Label();
            this.pnlcontaineremployees = new System.Windows.Forms.Panel();
            this.pnlemp = new System.Windows.Forms.Panel();
            this.flowpnlemp = new System.Windows.Forms.FlowLayoutPanel();
            this.lblemptitle = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.aboodPictureBox1 = new AboodTools_v5.AboodPictureBox();
            this.lblerror = new System.Windows.Forms.Label();
            this.ellipsloginform = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.backworker = new System.ComponentModel.BackgroundWorker();
            this.pnltop.SuspendLayout();
            this.pnlcontaineremp.SuspendLayout();
            this.pnlemployees.SuspendLayout();
            this.pnlcontainerinfo.SuspendLayout();
            this.pnlinfo.SuspendLayout();
            this.pnlcontaineremployees.SuspendLayout();
            this.pnlemp.SuspendLayout();
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
            this.pnltop.Margin = new System.Windows.Forms.Padding(3, 3, 3, 12);
            this.pnltop.Name = "pnltop";
            this.pnltop.Size = new System.Drawing.Size(939, 35);
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
            this.btnrestart.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnrestart.BorderRadius = 10;
            this.btnrestart.BorderSize = 0;
            this.btnrestart.FlatAppearance.BorderSize = 0;
            this.btnrestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrestart.ForeColor = System.Drawing.Color.White;
            this.btnrestart.Location = new System.Drawing.Point(863, 1);
            this.btnrestart.Name = "btnrestart";
            this.btnrestart.Size = new System.Drawing.Size(33, 33);
            this.btnrestart.TabIndex = 3;
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
            this.lbltitle.Location = new System.Drawing.Point(5, 8);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(128, 20);
            this.lbltitle.TabIndex = 2;
            this.lbltitle.Text = "Employees Page";
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
            this.btnexit.TabIndex = 1;
            this.btnexit.Text = "X";
            this.btnexit.TextColor = System.Drawing.Color.White;
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // pnlcontaineremp
            // 
            this.pnlcontaineremp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.pnlcontaineremp.Controls.Add(this.pnlemployees);
            this.pnlcontaineremp.Location = new System.Drawing.Point(12, 180);
            this.pnlcontaineremp.Name = "pnlcontaineremp";
            this.pnlcontaineremp.Padding = new System.Windows.Forms.Padding(3);
            this.pnlcontaineremp.Size = new System.Drawing.Size(915, 445);
            this.pnlcontaineremp.TabIndex = 2;
            this.pnlcontaineremp.Visible = false;
            // 
            // pnlemployees
            // 
            this.pnlemployees.AutoScroll = true;
            this.pnlemployees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.pnlemployees.Controls.Add(this.pnlcontainerinfo);
            this.pnlemployees.Controls.Add(this.pnlcontaineremployees);
            this.pnlemployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlemployees.Location = new System.Drawing.Point(3, 3);
            this.pnlemployees.Name = "pnlemployees";
            this.pnlemployees.Padding = new System.Windows.Forms.Padding(12);
            this.pnlemployees.Size = new System.Drawing.Size(909, 439);
            this.pnlemployees.TabIndex = 0;
            // 
            // pnlcontainerinfo
            // 
            this.pnlcontainerinfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.pnlcontainerinfo.Controls.Add(this.pnlinfo);
            this.pnlcontainerinfo.Location = new System.Drawing.Point(444, 12);
            this.pnlcontainerinfo.Name = "pnlcontainerinfo";
            this.pnlcontainerinfo.Padding = new System.Windows.Forms.Padding(3);
            this.pnlcontainerinfo.Size = new System.Drawing.Size(454, 415);
            this.pnlcontainerinfo.TabIndex = 3;
            this.pnlcontainerinfo.Visible = false;
            // 
            // pnlinfo
            // 
            this.pnlinfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.pnlinfo.Controls.Add(this.btndelete);
            this.pnlinfo.Controls.Add(this.btnclear);
            this.pnlinfo.Controls.Add(this.btnedite);
            this.pnlinfo.Controls.Add(this.btnadd);
            this.pnlinfo.Controls.Add(this.txtphone);
            this.pnlinfo.Controls.Add(this.lblphone);
            this.pnlinfo.Controls.Add(this.txtlname);
            this.pnlinfo.Controls.Add(this.txtprofession);
            this.pnlinfo.Controls.Add(this.lblprofession);
            this.pnlinfo.Controls.Add(this.txtdivision);
            this.pnlinfo.Controls.Add(this.lbldivision);
            this.pnlinfo.Controls.Add(this.txtsalary);
            this.pnlinfo.Controls.Add(this.lblsalary);
            this.pnlinfo.Controls.Add(this.txtworkshift);
            this.pnlinfo.Controls.Add(this.lblworkshift);
            this.pnlinfo.Controls.Add(this.txtaddress);
            this.pnlinfo.Controls.Add(this.lbladdress);
            this.pnlinfo.Controls.Add(this.lbllname);
            this.pnlinfo.Controls.Add(this.txtfname);
            this.pnlinfo.Controls.Add(this.lblfname);
            this.pnlinfo.Controls.Add(this.lblinfo);
            this.pnlinfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlinfo.Location = new System.Drawing.Point(3, 3);
            this.pnlinfo.Name = "pnlinfo";
            this.pnlinfo.Padding = new System.Windows.Forms.Padding(3);
            this.pnlinfo.Size = new System.Drawing.Size(448, 409);
            this.pnlinfo.TabIndex = 2;
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
            this.btndelete.Location = new System.Drawing.Point(334, 310);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(104, 84);
            this.btndelete.TabIndex = 39;
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
            this.btnclear.Location = new System.Drawing.Point(334, 210);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(104, 84);
            this.btnclear.TabIndex = 38;
            this.btnclear.Tag = "إذالة المعلومات";
            this.btnclear.Text = "Clear";
            this.btnclear.TextColor = System.Drawing.Color.White;
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnedite
            // 
            this.btnedite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(91)))));
            this.btnedite.BackGraundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(91)))));
            this.btnedite.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnedite.BorderRadius = 10;
            this.btnedite.BorderSize = 0;
            this.btnedite.FlatAppearance.BorderSize = 0;
            this.btnedite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnedite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnedite.ForeColor = System.Drawing.Color.White;
            this.btnedite.Location = new System.Drawing.Point(334, 111);
            this.btnedite.Name = "btnedite";
            this.btnedite.Size = new System.Drawing.Size(104, 84);
            this.btnedite.TabIndex = 37;
            this.btnedite.Tag = "تعديل";
            this.btnedite.Text = "Edite";
            this.btnedite.TextColor = System.Drawing.Color.White;
            this.btnedite.UseVisualStyleBackColor = false;
            this.btnedite.Click += new System.EventHandler(this.btnedit_Click);
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
            this.btnadd.Location = new System.Drawing.Point(334, 12);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(104, 84);
            this.btnadd.TabIndex = 36;
            this.btnadd.Tag = "إضافة";
            this.btnadd.Text = "Add";
            this.btnadd.TextColor = System.Drawing.Color.White;
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // txtphone
            // 
            this.txtphone._Text = "";
            this.txtphone.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtphone.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtphone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.txtphone.BorderColor = System.Drawing.Color.Silver;
            this.txtphone.BorderSize = 5;
            this.txtphone.FocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(0)))));
            this.txtphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtphone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(0)))));
            this.txtphone.Location = new System.Drawing.Point(32, 218);
            this.txtphone.MultiLine = false;
            this.txtphone.Name = "txtphone";
            this.txtphone.Padding = new System.Windows.Forms.Padding(7);
            this.txtphone.PasswordChar = false;
            this.txtphone.Size = new System.Drawing.Size(101, 35);
            this.txtphone.TabIndex = 23;
            this.txtphone.UnderLinedStyle = true;
            // 
            // lblphone
            // 
            this.lblphone.AutoSize = true;
            this.lblphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblphone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(0)))));
            this.lblphone.Location = new System.Drawing.Point(12, 192);
            this.lblphone.Name = "lblphone";
            this.lblphone.Size = new System.Drawing.Size(55, 20);
            this.lblphone.TabIndex = 22;
            this.lblphone.Tag = "الهاتف";
            this.lblphone.Text = "Phone";
            // 
            // txtlname
            // 
            this.txtlname._Text = "";
            this.txtlname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtlname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtlname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.txtlname.BorderColor = System.Drawing.Color.Silver;
            this.txtlname.BorderSize = 5;
            this.txtlname.FocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.txtlname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.txtlname.Location = new System.Drawing.Point(32, 148);
            this.txtlname.MultiLine = false;
            this.txtlname.Name = "txtlname";
            this.txtlname.Padding = new System.Windows.Forms.Padding(7);
            this.txtlname.PasswordChar = false;
            this.txtlname.Size = new System.Drawing.Size(270, 35);
            this.txtlname.TabIndex = 5;
            this.txtlname.UnderLinedStyle = true;
            // 
            // txtprofession
            // 
            this.txtprofession._Text = "";
            this.txtprofession.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtprofession.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtprofession.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.txtprofession.BorderColor = System.Drawing.Color.Silver;
            this.txtprofession.BorderSize = 5;
            this.txtprofession.FocusColor = System.Drawing.Color.Crimson;
            this.txtprofession.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprofession.ForeColor = System.Drawing.Color.Crimson;
            this.txtprofession.Location = new System.Drawing.Point(201, 358);
            this.txtprofession.MultiLine = false;
            this.txtprofession.Name = "txtprofession";
            this.txtprofession.Padding = new System.Windows.Forms.Padding(7);
            this.txtprofession.PasswordChar = false;
            this.txtprofession.Size = new System.Drawing.Size(101, 35);
            this.txtprofession.TabIndex = 17;
            this.txtprofession.UnderLinedStyle = true;
            // 
            // lblprofession
            // 
            this.lblprofession.AutoSize = true;
            this.lblprofession.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblprofession.ForeColor = System.Drawing.Color.Crimson;
            this.lblprofession.Location = new System.Drawing.Point(170, 332);
            this.lblprofession.Name = "lblprofession";
            this.lblprofession.Size = new System.Drawing.Size(84, 20);
            this.lblprofession.TabIndex = 16;
            this.lblprofession.Tag = "المهنة";
            this.lblprofession.Text = "Profession";
            // 
            // txtdivision
            // 
            this.txtdivision._Text = "";
            this.txtdivision.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtdivision.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtdivision.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.txtdivision.BorderColor = System.Drawing.Color.Silver;
            this.txtdivision.BorderSize = 5;
            this.txtdivision.FocusColor = System.Drawing.Color.Crimson;
            this.txtdivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdivision.ForeColor = System.Drawing.Color.Crimson;
            this.txtdivision.Location = new System.Drawing.Point(32, 358);
            this.txtdivision.MultiLine = false;
            this.txtdivision.Name = "txtdivision";
            this.txtdivision.Padding = new System.Windows.Forms.Padding(7);
            this.txtdivision.PasswordChar = false;
            this.txtdivision.Size = new System.Drawing.Size(101, 35);
            this.txtdivision.TabIndex = 15;
            this.txtdivision.UnderLinedStyle = true;
            // 
            // lbldivision
            // 
            this.lbldivision.AutoSize = true;
            this.lbldivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbldivision.ForeColor = System.Drawing.Color.Crimson;
            this.lbldivision.Location = new System.Drawing.Point(12, 332);
            this.lbldivision.Name = "lbldivision";
            this.lbldivision.Size = new System.Drawing.Size(63, 20);
            this.lbldivision.TabIndex = 14;
            this.lbldivision.Tag = "القسم";
            this.lbldivision.Text = "Division";
            // 
            // txtsalary
            // 
            this.txtsalary._Text = "";
            this.txtsalary.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtsalary.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtsalary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.txtsalary.BorderColor = System.Drawing.Color.Silver;
            this.txtsalary.BorderSize = 5;
            this.txtsalary.FocusColor = System.Drawing.Color.Magenta;
            this.txtsalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsalary.ForeColor = System.Drawing.Color.Magenta;
            this.txtsalary.Location = new System.Drawing.Point(201, 288);
            this.txtsalary.MultiLine = false;
            this.txtsalary.Name = "txtsalary";
            this.txtsalary.Padding = new System.Windows.Forms.Padding(7);
            this.txtsalary.PasswordChar = false;
            this.txtsalary.Size = new System.Drawing.Size(101, 35);
            this.txtsalary.TabIndex = 13;
            this.txtsalary.UnderLinedStyle = true;
            // 
            // lblsalary
            // 
            this.lblsalary.AutoSize = true;
            this.lblsalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblsalary.ForeColor = System.Drawing.Color.Magenta;
            this.lblsalary.Location = new System.Drawing.Point(170, 262);
            this.lblsalary.Name = "lblsalary";
            this.lblsalary.Size = new System.Drawing.Size(53, 20);
            this.lblsalary.TabIndex = 12;
            this.lblsalary.Tag = "الراتب";
            this.lblsalary.Text = "Salary";
            // 
            // txtworkshift
            // 
            this.txtworkshift._Text = "";
            this.txtworkshift.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtworkshift.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtworkshift.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.txtworkshift.BorderColor = System.Drawing.Color.Silver;
            this.txtworkshift.BorderSize = 5;
            this.txtworkshift.FocusColor = System.Drawing.Color.Magenta;
            this.txtworkshift.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtworkshift.ForeColor = System.Drawing.Color.Magenta;
            this.txtworkshift.Location = new System.Drawing.Point(32, 288);
            this.txtworkshift.MultiLine = false;
            this.txtworkshift.Name = "txtworkshift";
            this.txtworkshift.Padding = new System.Windows.Forms.Padding(7);
            this.txtworkshift.PasswordChar = false;
            this.txtworkshift.Size = new System.Drawing.Size(101, 35);
            this.txtworkshift.TabIndex = 11;
            this.txtworkshift.UnderLinedStyle = true;
            // 
            // lblworkshift
            // 
            this.lblworkshift.AutoSize = true;
            this.lblworkshift.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblworkshift.ForeColor = System.Drawing.Color.Magenta;
            this.lblworkshift.Location = new System.Drawing.Point(12, 262);
            this.lblworkshift.Name = "lblworkshift";
            this.lblworkshift.Size = new System.Drawing.Size(83, 20);
            this.lblworkshift.TabIndex = 10;
            this.lblworkshift.Tag = "المناوبة";
            this.lblworkshift.Text = "Work Shift";
            // 
            // txtaddress
            // 
            this.txtaddress._Text = "";
            this.txtaddress.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtaddress.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtaddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.txtaddress.BorderColor = System.Drawing.Color.Silver;
            this.txtaddress.BorderSize = 5;
            this.txtaddress.FocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(0)))));
            this.txtaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(0)))));
            this.txtaddress.Location = new System.Drawing.Point(201, 218);
            this.txtaddress.MultiLine = false;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Padding = new System.Windows.Forms.Padding(7);
            this.txtaddress.PasswordChar = false;
            this.txtaddress.Size = new System.Drawing.Size(101, 35);
            this.txtaddress.TabIndex = 7;
            this.txtaddress.UnderLinedStyle = true;
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbladdress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(0)))));
            this.lbladdress.Location = new System.Drawing.Point(170, 192);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(68, 20);
            this.lbladdress.TabIndex = 6;
            this.lbladdress.Tag = "العنوان";
            this.lbladdress.Text = "Address";
            // 
            // lbllname
            // 
            this.lbllname.AutoSize = true;
            this.lbllname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbllname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.lbllname.Location = new System.Drawing.Point(12, 122);
            this.lbllname.Name = "lbllname";
            this.lbllname.Size = new System.Drawing.Size(86, 20);
            this.lbllname.TabIndex = 4;
            this.lbllname.Tag = "الكنية";
            this.lbllname.Text = "Last Name";
            // 
            // txtfname
            // 
            this.txtfname._Text = "";
            this.txtfname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtfname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtfname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.txtfname.BorderColor = System.Drawing.Color.Silver;
            this.txtfname.BorderSize = 5;
            this.txtfname.FocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.txtfname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.txtfname.Location = new System.Drawing.Point(32, 78);
            this.txtfname.MultiLine = false;
            this.txtfname.Name = "txtfname";
            this.txtfname.Padding = new System.Windows.Forms.Padding(7);
            this.txtfname.PasswordChar = false;
            this.txtfname.Size = new System.Drawing.Size(270, 35);
            this.txtfname.TabIndex = 3;
            this.txtfname.UnderLinedStyle = true;
            // 
            // lblfname
            // 
            this.lblfname.AutoSize = true;
            this.lblfname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblfname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.lblfname.Location = new System.Drawing.Point(12, 52);
            this.lblfname.Name = "lblfname";
            this.lblfname.Size = new System.Drawing.Size(86, 20);
            this.lblfname.TabIndex = 2;
            this.lblfname.Tag = "الاسم";
            this.lblfname.Text = "First Name";
            // 
            // lblinfo
            // 
            this.lblinfo.AutoSize = true;
            this.lblinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblinfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(91)))));
            this.lblinfo.Location = new System.Drawing.Point(12, 12);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(111, 20);
            this.lblinfo.TabIndex = 1;
            this.lblinfo.Tag = "معلومات الموظف";
            this.lblinfo.Text = "Employee Info";
            // 
            // pnlcontaineremployees
            // 
            this.pnlcontaineremployees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.pnlcontaineremployees.Controls.Add(this.pnlemp);
            this.pnlcontaineremployees.Location = new System.Drawing.Point(12, 12);
            this.pnlcontaineremployees.Name = "pnlcontaineremployees";
            this.pnlcontaineremployees.Padding = new System.Windows.Forms.Padding(3);
            this.pnlcontaineremployees.Size = new System.Drawing.Size(420, 415);
            this.pnlcontaineremployees.TabIndex = 2;
            this.pnlcontaineremployees.Visible = false;
            // 
            // pnlemp
            // 
            this.pnlemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.pnlemp.Controls.Add(this.flowpnlemp);
            this.pnlemp.Controls.Add(this.lblemptitle);
            this.pnlemp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlemp.Location = new System.Drawing.Point(3, 3);
            this.pnlemp.Name = "pnlemp";
            this.pnlemp.Size = new System.Drawing.Size(414, 409);
            this.pnlemp.TabIndex = 1;
            // 
            // flowpnlemp
            // 
            this.flowpnlemp.AutoScroll = true;
            this.flowpnlemp.AutoScrollMargin = new System.Drawing.Size(10, 0);
            this.flowpnlemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.flowpnlemp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowpnlemp.Location = new System.Drawing.Point(0, 39);
            this.flowpnlemp.Name = "flowpnlemp";
            this.flowpnlemp.Padding = new System.Windows.Forms.Padding(25);
            this.flowpnlemp.Size = new System.Drawing.Size(414, 370);
            this.flowpnlemp.TabIndex = 1;
            // 
            // lblemptitle
            // 
            this.lblemptitle.AutoSize = true;
            this.lblemptitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblemptitle.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblemptitle.Location = new System.Drawing.Point(12, 12);
            this.lblemptitle.Name = "lblemptitle";
            this.lblemptitle.Size = new System.Drawing.Size(87, 20);
            this.lblemptitle.TabIndex = 0;
            this.lblemptitle.Text = "Employees";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 0;
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
            this.aboodPictureBox1.TabIndex = 10;
            this.aboodPictureBox1.TabStop = false;
            // 
            // lblerror
            // 
            this.lblerror.AutoSize = true;
            this.lblerror.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblerror.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.lblerror.Location = new System.Drawing.Point(12, 630);
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(0, 17);
            this.lblerror.TabIndex = 11;
            // 
            // ellipsloginform
            // 
            this.ellipsloginform.ElipseRadius = 10;
            this.ellipsloginform.TargetControl = this;
            // 
            // backworker
            // 
            this.backworker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backworker_DoWork);
            // 
            // EmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(939, 659);
            this.Controls.Add(this.lblerror);
            this.Controls.Add(this.aboodPictureBox1);
            this.Controls.Add(this.pnlcontaineremp);
            this.Controls.Add(this.pnltop);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EmployeesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccountsAndEmployees";
            this.Load += new System.EventHandler(this.EmployeesForm_Load);
            this.pnltop.ResumeLayout(false);
            this.pnltop.PerformLayout();
            this.pnlcontaineremp.ResumeLayout(false);
            this.pnlemployees.ResumeLayout(false);
            this.pnlcontainerinfo.ResumeLayout(false);
            this.pnlinfo.ResumeLayout(false);
            this.pnlinfo.PerformLayout();
            this.pnlcontaineremployees.ResumeLayout(false);
            this.pnlemp.ResumeLayout(false);
            this.pnlemp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aboodPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnltop;
        private AboodTools_v5.AboodButton btnexit;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Panel pnlcontaineremp;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlemployees;
        private AboodTools_v5.AboodPictureBox aboodPictureBox1;
        private System.Windows.Forms.Label lblerror;
        private Bunifu.Framework.UI.BunifuElipse ellipsloginform;
        private AboodTools_v5.AboodButton btnrestart;
        private System.Windows.Forms.Panel pnlcontaineremployees;
        private System.Windows.Forms.Panel pnlcontainerinfo;
        private System.Windows.Forms.Panel pnlinfo;
        private AboodTools_v5.AboodTextBox txtphone;
        private System.Windows.Forms.Label lblphone;
        private AboodTools_v5.AboodTextBox txtlname;
        private AboodTools_v5.AboodTextBox txtprofession;
        private System.Windows.Forms.Label lblprofession;
        private AboodTools_v5.AboodTextBox txtdivision;
        private System.Windows.Forms.Label lbldivision;
        private AboodTools_v5.AboodTextBox txtsalary;
        private System.Windows.Forms.Label lblsalary;
        private AboodTools_v5.AboodTextBox txtworkshift;
        private System.Windows.Forms.Label lblworkshift;
        private AboodTools_v5.AboodTextBox txtaddress;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.Label lbllname;
        private AboodTools_v5.AboodTextBox txtfname;
        private System.Windows.Forms.Label lblfname;
        private System.Windows.Forms.Label lblinfo;
        private System.Windows.Forms.Panel pnlemp;
        private System.Windows.Forms.FlowLayoutPanel flowpnlemp;
        private System.Windows.Forms.Label lblemptitle;
        private AboodTools_v5.AboodButton btndelete;
        private AboodTools_v5.AboodButton btnclear;
        private AboodTools_v5.AboodButton btnedite;
        private AboodTools_v5.AboodButton btnadd;
        private System.ComponentModel.BackgroundWorker backworker;
    }
}