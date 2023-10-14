namespace Sales_v3.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnltop = new System.Windows.Forms.Panel();
            this.btnexit = new AboodTools_v5.AboodButton();
            this.lbltitle = new System.Windows.Forms.Label();
            this.elipsemainform = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlcontainer = new System.Windows.Forms.Panel();
            this.pnltools = new System.Windows.Forms.Panel();
            this.btnempty = new AboodTools_v5.AboodButton();
            this.btnaccounts = new AboodTools_v5.AboodButton();
            this.btnsettings = new AboodTools_v5.AboodButton();
            this.btnemployees = new AboodTools_v5.AboodButton();
            this.btnstorage = new AboodTools_v5.AboodButton();
            this.btntoolsmangmaent = new AboodTools_v5.AboodButton();
            this.btnsalepoint = new AboodTools_v5.AboodButton();
            this.aboodPictureBox1 = new AboodTools_v5.AboodPictureBox();
            this.backworker = new System.ComponentModel.BackgroundWorker();
            this.pnltop.SuspendLayout();
            this.pnlcontainer.SuspendLayout();
            this.pnltools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aboodPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnltop
            // 
            this.pnltop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.pnltop.Controls.Add(this.btnexit);
            this.pnltop.Controls.Add(this.lbltitle);
            this.pnltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnltop.Location = new System.Drawing.Point(0, 0);
            this.pnltop.Name = "pnltop";
            this.pnltop.Size = new System.Drawing.Size(649, 35);
            this.pnltop.TabIndex = 0;
            this.pnltop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnltop_MouseDown);
            this.pnltop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnltop_MouseMove);
            this.pnltop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnltop_MouseUp);
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
            this.btnexit.Location = new System.Drawing.Point(611, 1);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(33, 33);
            this.btnexit.TabIndex = 7;
            this.btnexit.TabStop = false;
            this.btnexit.Tag = "X";
            this.btnexit.Text = "X";
            this.btnexit.TextColor = System.Drawing.Color.White;
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.BackColor = System.Drawing.Color.Transparent;
            this.lbltitle.ForeColor = System.Drawing.Color.White;
            this.lbltitle.Location = new System.Drawing.Point(8, 8);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(84, 17);
            this.lbltitle.TabIndex = 0;
            this.lbltitle.Tag = "الصفحة الرئيسية";
            this.lbltitle.Text = "Main Page";
            // 
            // elipsemainform
            // 
            this.elipsemainform.ElipseRadius = 10;
            this.elipsemainform.TargetControl = this;
            // 
            // pnlcontainer
            // 
            this.pnlcontainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.pnlcontainer.Controls.Add(this.pnltools);
            this.pnlcontainer.Location = new System.Drawing.Point(12, 180);
            this.pnlcontainer.Name = "pnlcontainer";
            this.pnlcontainer.Padding = new System.Windows.Forms.Padding(3);
            this.pnlcontainer.Size = new System.Drawing.Size(625, 404);
            this.pnlcontainer.TabIndex = 2;
            this.pnlcontainer.Visible = false;
            // 
            // pnltools
            // 
            this.pnltools.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.pnltools.Controls.Add(this.btnempty);
            this.pnltools.Controls.Add(this.btnaccounts);
            this.pnltools.Controls.Add(this.btnsettings);
            this.pnltools.Controls.Add(this.btnemployees);
            this.pnltools.Controls.Add(this.btnstorage);
            this.pnltools.Controls.Add(this.btntoolsmangmaent);
            this.pnltools.Controls.Add(this.btnsalepoint);
            this.pnltools.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnltools.Location = new System.Drawing.Point(3, 3);
            this.pnltools.Name = "pnltools";
            this.pnltools.Size = new System.Drawing.Size(619, 398);
            this.pnltools.TabIndex = 6;
            // 
            // btnempty
            // 
            this.btnempty.BackColor = System.Drawing.Color.Red;
            this.btnempty.BackGraundColor = System.Drawing.Color.Red;
            this.btnempty.BorderColor = System.Drawing.Color.DarkMagenta;
            this.btnempty.BorderRadius = 20;
            this.btnempty.BorderSize = 0;
            this.btnempty.FlatAppearance.BorderSize = 0;
            this.btnempty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnempty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnempty.ForeColor = System.Drawing.Color.White;
            this.btnempty.Location = new System.Drawing.Point(326, 147);
            this.btnempty.Name = "btnempty";
            this.btnempty.Size = new System.Drawing.Size(128, 102);
            this.btnempty.TabIndex = 7;
            this.btnempty.Tag = "الطباعة";
            this.btnempty.Text = "Printing";
            this.btnempty.TextColor = System.Drawing.Color.White;
            this.btnempty.UseVisualStyleBackColor = false;
            this.btnempty.Visible = false;
            this.btnempty.Click += new System.EventHandler(this.btnempty_Click);
            // 
            // btnaccounts
            // 
            this.btnaccounts.BackColor = System.Drawing.Color.LimeGreen;
            this.btnaccounts.BackGraundColor = System.Drawing.Color.LimeGreen;
            this.btnaccounts.BorderColor = System.Drawing.Color.Blue;
            this.btnaccounts.BorderRadius = 20;
            this.btnaccounts.BorderSize = 0;
            this.btnaccounts.FlatAppearance.BorderSize = 0;
            this.btnaccounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaccounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnaccounts.ForeColor = System.Drawing.Color.White;
            this.btnaccounts.Location = new System.Drawing.Point(174, 147);
            this.btnaccounts.Name = "btnaccounts";
            this.btnaccounts.Size = new System.Drawing.Size(140, 239);
            this.btnaccounts.TabIndex = 3;
            this.btnaccounts.Tag = "الحسابات";
            this.btnaccounts.Text = "Accounts";
            this.btnaccounts.TextColor = System.Drawing.Color.White;
            this.btnaccounts.UseVisualStyleBackColor = false;
            this.btnaccounts.Visible = false;
            this.btnaccounts.Click += new System.EventHandler(this.btnaccounts_Click);
            // 
            // btnsettings
            // 
            this.btnsettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(90)))));
            this.btnsettings.BackGraundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(90)))));
            this.btnsettings.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnsettings.BorderRadius = 20;
            this.btnsettings.BorderSize = 0;
            this.btnsettings.FlatAppearance.BorderSize = 0;
            this.btnsettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnsettings.ForeColor = System.Drawing.Color.White;
            this.btnsettings.Location = new System.Drawing.Point(465, 12);
            this.btnsettings.Name = "btnsettings";
            this.btnsettings.Size = new System.Drawing.Size(142, 237);
            this.btnsettings.TabIndex = 5;
            this.btnsettings.Tag = "الإعدادات";
            this.btnsettings.Text = "Settings";
            this.btnsettings.TextColor = System.Drawing.Color.White;
            this.btnsettings.UseVisualStyleBackColor = false;
            this.btnsettings.Visible = false;
            this.btnsettings.Click += new System.EventHandler(this.btnsettings_Click);
            // 
            // btnemployees
            // 
            this.btnemployees.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnemployees.BackGraundColor = System.Drawing.Color.DodgerBlue;
            this.btnemployees.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.btnemployees.BorderRadius = 20;
            this.btnemployees.BorderSize = 0;
            this.btnemployees.FlatAppearance.BorderSize = 0;
            this.btnemployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnemployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnemployees.ForeColor = System.Drawing.Color.White;
            this.btnemployees.Location = new System.Drawing.Point(327, 259);
            this.btnemployees.Name = "btnemployees";
            this.btnemployees.Size = new System.Drawing.Size(281, 127);
            this.btnemployees.TabIndex = 4;
            this.btnemployees.Tag = "الموظفين";
            this.btnemployees.Text = "Employees";
            this.btnemployees.TextColor = System.Drawing.Color.White;
            this.btnemployees.UseVisualStyleBackColor = false;
            this.btnemployees.Visible = false;
            this.btnemployees.Click += new System.EventHandler(this.btnemployees_Click);
            // 
            // btnstorage
            // 
            this.btnstorage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(0)))));
            this.btnstorage.BackGraundColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(0)))));
            this.btnstorage.BorderColor = System.Drawing.Color.Firebrick;
            this.btnstorage.BorderRadius = 20;
            this.btnstorage.BorderSize = 0;
            this.btnstorage.FlatAppearance.BorderSize = 0;
            this.btnstorage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnstorage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnstorage.ForeColor = System.Drawing.Color.White;
            this.btnstorage.Location = new System.Drawing.Point(12, 243);
            this.btnstorage.Name = "btnstorage";
            this.btnstorage.Size = new System.Drawing.Size(151, 143);
            this.btnstorage.TabIndex = 2;
            this.btnstorage.Tag = "المخزن";
            this.btnstorage.Text = "Storage";
            this.btnstorage.TextColor = System.Drawing.Color.White;
            this.btnstorage.UseVisualStyleBackColor = false;
            this.btnstorage.Visible = false;
            this.btnstorage.Click += new System.EventHandler(this.btnstorage_Click);
            // 
            // btntoolsmangmaent
            // 
            this.btntoolsmangmaent.BackColor = System.Drawing.Color.DarkOrchid;
            this.btntoolsmangmaent.BackGraundColor = System.Drawing.Color.DarkOrchid;
            this.btntoolsmangmaent.BorderColor = System.Drawing.Color.Maroon;
            this.btntoolsmangmaent.BorderRadius = 20;
            this.btntoolsmangmaent.BorderSize = 0;
            this.btntoolsmangmaent.FlatAppearance.BorderSize = 0;
            this.btntoolsmangmaent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntoolsmangmaent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btntoolsmangmaent.ForeColor = System.Drawing.Color.White;
            this.btntoolsmangmaent.Location = new System.Drawing.Point(174, 12);
            this.btntoolsmangmaent.Name = "btntoolsmangmaent";
            this.btntoolsmangmaent.Size = new System.Drawing.Size(279, 123);
            this.btntoolsmangmaent.TabIndex = 6;
            this.btntoolsmangmaent.Tag = "إدارة الأدوات";
            this.btntoolsmangmaent.Text = "Tools Mangment";
            this.btntoolsmangmaent.TextColor = System.Drawing.Color.White;
            this.btntoolsmangmaent.UseVisualStyleBackColor = false;
            this.btntoolsmangmaent.Visible = false;
            this.btntoolsmangmaent.Click += new System.EventHandler(this.btntoolsmangmaent_Click);
            // 
            // btnsalepoint
            // 
            this.btnsalepoint.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnsalepoint.BackGraundColor = System.Drawing.Color.DodgerBlue;
            this.btnsalepoint.BorderColor = System.Drawing.Color.Blue;
            this.btnsalepoint.BorderRadius = 20;
            this.btnsalepoint.BorderSize = 0;
            this.btnsalepoint.FlatAppearance.BorderSize = 0;
            this.btnsalepoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalepoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnsalepoint.ForeColor = System.Drawing.Color.White;
            this.btnsalepoint.Location = new System.Drawing.Point(12, 12);
            this.btnsalepoint.Name = "btnsalepoint";
            this.btnsalepoint.Size = new System.Drawing.Size(150, 219);
            this.btnsalepoint.TabIndex = 1;
            this.btnsalepoint.Tag = "نقطة البيع";
            this.btnsalepoint.Text = "Sale Point ";
            this.btnsalepoint.TextColor = System.Drawing.Color.White;
            this.btnsalepoint.UseVisualStyleBackColor = false;
            this.btnsalepoint.Visible = false;
            this.btnsalepoint.Click += new System.EventHandler(this.btnsalepoint_Click);
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
            this.aboodPictureBox1.Location = new System.Drawing.Point(260, 58);
            this.aboodPictureBox1.Name = "aboodPictureBox1";
            this.aboodPictureBox1.Size = new System.Drawing.Size(100, 100);
            this.aboodPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.aboodPictureBox1.TabIndex = 12;
            this.aboodPictureBox1.TabStop = false;
            // 
            // backworker
            // 
            this.backworker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backworker_DoWork);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(649, 612);
            this.Controls.Add(this.aboodPictureBox1);
            this.Controls.Add(this.pnlcontainer);
            this.Controls.Add(this.pnltop);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.VisibleChanged += new System.EventHandler(this.MainForm_VisibleChanged);
            this.pnltop.ResumeLayout(false);
            this.pnltop.PerformLayout();
            this.pnlcontainer.ResumeLayout(false);
            this.pnltools.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.aboodPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnltop;
        private System.Windows.Forms.Label lbltitle;
        private AboodTools_v5.AboodButton btnexit;
        private Bunifu.Framework.UI.BunifuElipse elipsemainform;
        private System.Windows.Forms.Panel pnlcontainer;
        private System.Windows.Forms.Panel pnltools;
        private AboodTools_v5.AboodButton btnsettings;
        private AboodTools_v5.AboodButton btnemployees;
        private AboodTools_v5.AboodButton btnstorage;
        private AboodTools_v5.AboodButton btntoolsmangmaent;
        private AboodTools_v5.AboodButton btnsalepoint;
        private AboodTools_v5.AboodPictureBox aboodPictureBox1;
        private AboodTools_v5.AboodButton btnaccounts;
        private AboodTools_v5.AboodButton btnempty;
        private System.ComponentModel.BackgroundWorker backworker;
    }
}