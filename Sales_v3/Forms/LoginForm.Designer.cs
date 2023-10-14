namespace Sales_v3.Forms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.pnltop = new System.Windows.Forms.Panel();
            this.btnrestart = new AboodTools_v5.AboodButton();
            this.btnexit = new AboodTools_v5.AboodButton();
            this.lbltitel = new System.Windows.Forms.Label();
            this.ellipsloginform = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlcontainer = new System.Windows.Forms.Panel();
            this.pnltools = new System.Windows.Forms.Panel();
            this.btnshowpassword = new AboodTools_v5.AboodButton();
            this.btnsignup = new AboodTools_v5.AboodButton();
            this.btnsignin = new AboodTools_v5.AboodButton();
            this.txtpassword = new AboodTools_v5.AboodTextBox();
            this.txtusername = new AboodTools_v5.AboodTextBox();
            this.lblpassword = new System.Windows.Forms.Label();
            this.lbluser = new System.Windows.Forms.Label();
            this.aboodPictureBox1 = new AboodTools_v5.AboodPictureBox();
            this.backworker = new System.ComponentModel.BackgroundWorker();
            this.mainprogress = new AboodTools_v5.AboodProgressBar();
            this.btnstartconection = new AboodTools_v5.AboodButton();
            this.pnltop.SuspendLayout();
            this.pnlcontainer.SuspendLayout();
            this.pnltools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aboodPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnltop
            // 
            this.pnltop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.pnltop.Controls.Add(this.btnrestart);
            this.pnltop.Controls.Add(this.btnexit);
            this.pnltop.Controls.Add(this.lbltitel);
            this.pnltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnltop.Location = new System.Drawing.Point(0, 0);
            this.pnltop.Name = "pnltop";
            this.pnltop.Size = new System.Drawing.Size(400, 35);
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
            this.btnrestart.Location = new System.Drawing.Point(323, 1);
            this.btnrestart.Name = "btnrestart";
            this.btnrestart.Size = new System.Drawing.Size(33, 33);
            this.btnrestart.TabIndex = 9;
            this.btnrestart.Tag = "R";
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
            this.btnexit.Location = new System.Drawing.Point(362, 1);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(33, 33);
            this.btnexit.TabIndex = 2;
            this.btnexit.Tag = "X";
            this.btnexit.Text = "X";
            this.btnexit.TextColor = System.Drawing.Color.White;
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // lbltitel
            // 
            this.lbltitel.AutoSize = true;
            this.lbltitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitel.ForeColor = System.Drawing.Color.White;
            this.lbltitel.Location = new System.Drawing.Point(5, 8);
            this.lbltitel.Name = "lbltitel";
            this.lbltitel.Size = new System.Drawing.Size(54, 20);
            this.lbltitel.TabIndex = 0;
            this.lbltitel.Tag = "تسجيل دخول";
            this.lbltitel.Text = "Log In";
            // 
            // ellipsloginform
            // 
            this.ellipsloginform.ElipseRadius = 10;
            this.ellipsloginform.TargetControl = this;
            // 
            // pnlcontainer
            // 
            this.pnlcontainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.pnlcontainer.Controls.Add(this.pnltools);
            this.pnlcontainer.Location = new System.Drawing.Point(12, 180);
            this.pnlcontainer.Name = "pnlcontainer";
            this.pnlcontainer.Padding = new System.Windows.Forms.Padding(3);
            this.pnlcontainer.Size = new System.Drawing.Size(376, 336);
            this.pnlcontainer.TabIndex = 6;
            this.pnlcontainer.Visible = false;
            // 
            // pnltools
            // 
            this.pnltools.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.pnltools.Controls.Add(this.btnshowpassword);
            this.pnltools.Controls.Add(this.btnsignup);
            this.pnltools.Controls.Add(this.btnsignin);
            this.pnltools.Controls.Add(this.txtpassword);
            this.pnltools.Controls.Add(this.txtusername);
            this.pnltools.Controls.Add(this.lblpassword);
            this.pnltools.Controls.Add(this.lbluser);
            this.pnltools.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnltools.Location = new System.Drawing.Point(3, 3);
            this.pnltools.Name = "pnltools";
            this.pnltools.Size = new System.Drawing.Size(370, 330);
            this.pnltools.TabIndex = 7;
            // 
            // btnshowpassword
            // 
            this.btnshowpassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(0)))));
            this.btnshowpassword.BackGraundColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(0)))));
            this.btnshowpassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.btnshowpassword.BorderRadius = 10;
            this.btnshowpassword.BorderSize = 0;
            this.btnshowpassword.FlatAppearance.BorderSize = 0;
            this.btnshowpassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnshowpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshowpassword.ForeColor = System.Drawing.Color.White;
            this.btnshowpassword.Location = new System.Drawing.Point(264, 142);
            this.btnshowpassword.Name = "btnshowpassword";
            this.btnshowpassword.Size = new System.Drawing.Size(30, 28);
            this.btnshowpassword.TabIndex = 0;
            this.btnshowpassword.TabStop = false;
            this.btnshowpassword.Tag = "S";
            this.btnshowpassword.Text = "S";
            this.btnshowpassword.TextColor = System.Drawing.Color.White;
            this.btnshowpassword.UseVisualStyleBackColor = false;
            this.btnshowpassword.Click += new System.EventHandler(this.btnshowpassword_Click);
            // 
            // btnsignup
            // 
            this.btnsignup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(0)))));
            this.btnsignup.BackGraundColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(0)))));
            this.btnsignup.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnsignup.BorderRadius = 10;
            this.btnsignup.BorderSize = 0;
            this.btnsignup.FlatAppearance.BorderSize = 0;
            this.btnsignup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsignup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsignup.ForeColor = System.Drawing.Color.White;
            this.btnsignup.Location = new System.Drawing.Point(38, 251);
            this.btnsignup.Name = "btnsignup";
            this.btnsignup.Size = new System.Drawing.Size(101, 37);
            this.btnsignup.TabIndex = 10;
            this.btnsignup.Tag = "إنشاء حساب";
            this.btnsignup.Text = "Sign Up";
            this.btnsignup.TextColor = System.Drawing.Color.White;
            this.btnsignup.UseVisualStyleBackColor = false;
            this.btnsignup.Click += new System.EventHandler(this.btnsignup_Click);
            // 
            // btnsignin
            // 
            this.btnsignin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(91)))));
            this.btnsignin.BackGraundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(91)))));
            this.btnsignin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(91)))));
            this.btnsignin.BorderRadius = 10;
            this.btnsignin.BorderSize = 0;
            this.btnsignin.FlatAppearance.BorderSize = 0;
            this.btnsignin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsignin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsignin.ForeColor = System.Drawing.Color.White;
            this.btnsignin.Location = new System.Drawing.Point(165, 235);
            this.btnsignin.Name = "btnsignin";
            this.btnsignin.Size = new System.Drawing.Size(164, 69);
            this.btnsignin.TabIndex = 9;
            this.btnsignin.Tag = "تسجيل دخول";
            this.btnsignin.Text = "Sign In";
            this.btnsignin.TextColor = System.Drawing.Color.White;
            this.btnsignin.UseVisualStyleBackColor = false;
            this.btnsignin.Click += new System.EventHandler(this.btnsignin_Click);
            // 
            // txtpassword
            // 
            this.txtpassword._Text = "";
            this.txtpassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtpassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtpassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtpassword.BorderColor = System.Drawing.Color.Silver;
            this.txtpassword.BorderSize = 4;
            this.txtpassword.FocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(91)))));
            this.txtpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(91)))));
            this.txtpassword.Location = new System.Drawing.Point(55, 137);
            this.txtpassword.MultiLine = false;
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Padding = new System.Windows.Forms.Padding(7);
            this.txtpassword.PasswordChar = true;
            this.txtpassword.Size = new System.Drawing.Size(260, 41);
            this.txtpassword.TabIndex = 8;
            this.txtpassword.UnderLinedStyle = true;
            this.txtpassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpassword_KeyPress);
            // 
            // txtusername
            // 
            this.txtusername._Text = "";
            this.txtusername.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtusername.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtusername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtusername.BorderColor = System.Drawing.Color.Silver;
            this.txtusername.BorderSize = 4;
            this.txtusername.FocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.txtusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.txtusername.Location = new System.Drawing.Point(55, 62);
            this.txtusername.MultiLine = false;
            this.txtusername.Name = "txtusername";
            this.txtusername.Padding = new System.Windows.Forms.Padding(7);
            this.txtusername.PasswordChar = false;
            this.txtusername.Size = new System.Drawing.Size(260, 41);
            this.txtusername.TabIndex = 7;
            this.txtusername.UnderLinedStyle = true;
            this.txtusername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtusername_KeyPress);
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.BackColor = System.Drawing.Color.Transparent;
            this.lblpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(91)))));
            this.lblpassword.Location = new System.Drawing.Point(29, 117);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(78, 20);
            this.lblpassword.TabIndex = 5;
            this.lblpassword.Tag = "كلمة المرور";
            this.lblpassword.Text = "Password";
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.BackColor = System.Drawing.Color.Transparent;
            this.lbluser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.lbluser.Location = new System.Drawing.Point(29, 39);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(89, 20);
            this.lbluser.TabIndex = 6;
            this.lbluser.Tag = "اسم المستخدم";
            this.lbluser.Text = "User Name";
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
            this.aboodPictureBox1.Location = new System.Drawing.Point(150, 58);
            this.aboodPictureBox1.Name = "aboodPictureBox1";
            this.aboodPictureBox1.Size = new System.Drawing.Size(100, 100);
            this.aboodPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.aboodPictureBox1.TabIndex = 8;
            this.aboodPictureBox1.TabStop = false;
            // 
            // backworker
            // 
            this.backworker.WorkerReportsProgress = true;
            this.backworker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backworker_DoWork);
            this.backworker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backworker_ProgressChanged);
            this.backworker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backworker_RunWorkerCompleted);
            // 
            // mainprogress
            // 
            this.mainprogress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.mainprogress.ChannelColor = System.Drawing.Color.Silver;
            this.mainprogress.ChannelHeight = 1;
            this.mainprogress.ForeBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.mainprogress.ForeColor = System.Drawing.Color.White;
            this.mainprogress.Location = new System.Drawing.Point(49, 370);
            this.mainprogress.Name = "mainprogress";
            this.mainprogress.ShowMaximum = false;
            this.mainprogress.ShowValue = AboodTools_v5.AboodProgressBar.TextPosition.None;
            this.mainprogress.Size = new System.Drawing.Size(300, 18);
            this.mainprogress.SliderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.mainprogress.Sliderheight = 4;
            this.mainprogress.Step = 1;
            this.mainprogress.SymbolAfter = "";
            this.mainprogress.SymbolBefor = "";
            this.mainprogress.TabIndex = 15;
            // 
            // btnstartconection
            // 
            this.btnstartconection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnstartconection.BackGraundColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnstartconection.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.btnstartconection.BorderRadius = 60;
            this.btnstartconection.BorderSize = 3;
            this.btnstartconection.FlatAppearance.BorderSize = 0;
            this.btnstartconection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnstartconection.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstartconection.ForeColor = System.Drawing.Color.White;
            this.btnstartconection.Location = new System.Drawing.Point(84, 300);
            this.btnstartconection.Name = "btnstartconection";
            this.btnstartconection.Size = new System.Drawing.Size(230, 65);
            this.btnstartconection.TabIndex = 14;
            this.btnstartconection.Tag = "إنشاء إتصال";
            this.btnstartconection.Text = "Start Connection";
            this.btnstartconection.TextColor = System.Drawing.Color.White;
            this.btnstartconection.UseVisualStyleBackColor = false;
            this.btnstartconection.Click += new System.EventHandler(this.btnstartconection_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(400, 550);
            this.Controls.Add(this.aboodPictureBox1);
            this.Controls.Add(this.pnlcontainer);
            this.Controls.Add(this.pnltop);
            this.Controls.Add(this.btnstartconection);
            this.Controls.Add(this.mainprogress);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Silver;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginForm";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.VisibleChanged += new System.EventHandler(this.LoginForm_VisibleChanged);
            this.pnltop.ResumeLayout(false);
            this.pnltop.PerformLayout();
            this.pnlcontainer.ResumeLayout(false);
            this.pnltools.ResumeLayout(false);
            this.pnltools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aboodPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }
        
        #endregion

        private System.Windows.Forms.Panel pnltop;
        private System.Windows.Forms.Label lbltitel;
        private AboodTools_v5.AboodButton btnexit;
        private Bunifu.Framework.UI.BunifuElipse ellipsloginform;
        private System.Windows.Forms.Panel pnlcontainer;
        private System.Windows.Forms.Panel pnltools;
        private AboodTools_v5.AboodButton btnsignup;
        private AboodTools_v5.AboodButton btnsignin;
        private AboodTools_v5.AboodTextBox txtpassword;
        private AboodTools_v5.AboodTextBox txtusername;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Label lbluser;
        private AboodTools_v5.AboodButton btnshowpassword;
        private AboodTools_v5.AboodPictureBox aboodPictureBox1;
        private AboodTools_v5.AboodButton btnrestart;
        private System.ComponentModel.BackgroundWorker backworker;
        private AboodTools_v5.AboodProgressBar mainprogress;
        private AboodTools_v5.AboodButton btnstartconection;
    }
    
}