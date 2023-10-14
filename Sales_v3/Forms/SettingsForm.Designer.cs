namespace Sales_v3.Forms
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.pnltop = new System.Windows.Forms.Panel();
            this.btnrestartapp = new AboodTools_v5.AboodButton();
            this.btnrestart = new AboodTools_v5.AboodButton();
            this.btnexit = new AboodTools_v5.AboodButton();
            this.lbltitel = new System.Windows.Forms.Label();
            this.pnlcontainer = new System.Windows.Forms.Panel();
            this.pnltools = new System.Windows.Forms.Panel();
            this.pnlptinter = new System.Windows.Forms.Panel();
            this.lblprinter = new System.Windows.Forms.Label();
            this.btnprinterdufulte = new AboodTools_v5.AboodButton();
            this.cbxprinter = new System.Windows.Forms.ComboBox();
            this.btndefulte = new AboodTools_v5.AboodButton();
            this.btncancel = new AboodTools_v5.AboodButton();
            this.btnsave = new AboodTools_v5.AboodButton();
            this.pnllanguage = new System.Windows.Forms.Panel();
            this.lblenglish = new System.Windows.Forms.Label();
            this.lblarabic = new System.Windows.Forms.Label();
            this.togglelanguage = new AboodTools_v5.AboodToggleButton();
            this.lbllanguage = new System.Windows.Forms.Label();
            this.pnlmaincolor = new System.Windows.Forms.Panel();
            this.pnlcolor6 = new System.Windows.Forms.Panel();
            this.pnlcolor3 = new System.Windows.Forms.Panel();
            this.pnlcolor5 = new System.Windows.Forms.Panel();
            this.pnlcolor4 = new System.Windows.Forms.Panel();
            this.pnlcolor2 = new System.Windows.Forms.Panel();
            this.pnlcolor1 = new System.Windows.Forms.Panel();
            this.lblmaincolor = new System.Windows.Forms.Label();
            this.pnltheme = new System.Windows.Forms.Panel();
            this.lbllight = new System.Windows.Forms.Label();
            this.lbldark = new System.Windows.Forms.Label();
            this.toggletheme = new AboodTools_v5.AboodToggleButton();
            this.lbltheme = new System.Windows.Forms.Label();
            this.pnldatabase = new System.Windows.Forms.Panel();
            this.btnclear = new AboodTools_v5.AboodButton();
            this.btnsearch = new AboodTools_v5.AboodButton();
            this.txtdatabaseroot = new AboodTools_v5.AboodTextBox();
            this.lbldatabase = new System.Windows.Forms.Label();
            this.aboodPictureBox1 = new AboodTools_v5.AboodPictureBox();
            this.ofddatabase = new System.Windows.Forms.OpenFileDialog();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.backworker = new System.ComponentModel.BackgroundWorker();
            this.lblerror = new System.Windows.Forms.Label();
            this.pnltop.SuspendLayout();
            this.pnlcontainer.SuspendLayout();
            this.pnltools.SuspendLayout();
            this.pnlptinter.SuspendLayout();
            this.pnllanguage.SuspendLayout();
            this.pnlmaincolor.SuspendLayout();
            this.pnltheme.SuspendLayout();
            this.pnldatabase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aboodPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnltop
            // 
            this.pnltop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.pnltop.Controls.Add(this.btnrestartapp);
            this.pnltop.Controls.Add(this.btnrestart);
            this.pnltop.Controls.Add(this.btnexit);
            this.pnltop.Controls.Add(this.lbltitel);
            this.pnltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnltop.Location = new System.Drawing.Point(0, 0);
            this.pnltop.Name = "pnltop";
            this.pnltop.Size = new System.Drawing.Size(730, 35);
            this.pnltop.TabIndex = 0;
            this.pnltop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnltop_MouseDown);
            this.pnltop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnltop_MouseMove);
            this.pnltop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnltop_MouseUp);
            // 
            // btnrestartapp
            // 
            this.btnrestartapp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnrestartapp.BackColor = System.Drawing.Color.Transparent;
            this.btnrestartapp.BackGraundColor = System.Drawing.Color.Transparent;
            this.btnrestartapp.BorderColor = System.Drawing.Color.Transparent;
            this.btnrestartapp.BorderRadius = 10;
            this.btnrestartapp.BorderSize = 0;
            this.btnrestartapp.FlatAppearance.BorderSize = 0;
            this.btnrestartapp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrestartapp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnrestartapp.ForeColor = System.Drawing.Color.White;
            this.btnrestartapp.Location = new System.Drawing.Point(528, 1);
            this.btnrestartapp.Name = "btnrestartapp";
            this.btnrestartapp.Size = new System.Drawing.Size(111, 33);
            this.btnrestartapp.TabIndex = 13;
            this.btnrestartapp.Tag = "إعادة تشغيل";
            this.btnrestartapp.Text = "Restart App";
            this.btnrestartapp.TextColor = System.Drawing.Color.White;
            this.btnrestartapp.UseVisualStyleBackColor = false;
            this.btnrestartapp.Visible = false;
            this.btnrestartapp.Click += new System.EventHandler(this.btnrestartapp_Click);
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
            this.btnrestart.TabIndex = 12;
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
            this.btnexit.BorderColor = System.Drawing.Color.Transparent;
            this.btnexit.BorderRadius = 10;
            this.btnexit.BorderSize = 0;
            this.btnexit.FlatAppearance.BorderSize = 0;
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexit.ForeColor = System.Drawing.Color.White;
            this.btnexit.Location = new System.Drawing.Point(692, 1);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(33, 33);
            this.btnexit.TabIndex = 1;
            this.btnexit.Tag = "X";
            this.btnexit.Text = "X";
            this.btnexit.TextColor = System.Drawing.Color.White;
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // lbltitel
            // 
            this.lbltitel.AutoSize = true;
            this.lbltitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbltitel.ForeColor = System.Drawing.Color.White;
            this.lbltitel.Location = new System.Drawing.Point(8, 8);
            this.lbltitel.Name = "lbltitel";
            this.lbltitel.Size = new System.Drawing.Size(60, 20);
            this.lbltitel.TabIndex = 0;
            this.lbltitel.Tag = "الإعدادات";
            this.lbltitel.Text = "Setting";
            // 
            // pnlcontainer
            // 
            this.pnlcontainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.pnlcontainer.Controls.Add(this.pnltools);
            this.pnlcontainer.Location = new System.Drawing.Point(12, 180);
            this.pnlcontainer.Name = "pnlcontainer";
            this.pnlcontainer.Padding = new System.Windows.Forms.Padding(3);
            this.pnlcontainer.Size = new System.Drawing.Size(706, 363);
            this.pnlcontainer.TabIndex = 1;
            this.pnlcontainer.Visible = false;
            // 
            // pnltools
            // 
            this.pnltools.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.pnltools.Controls.Add(this.pnlptinter);
            this.pnltools.Controls.Add(this.btndefulte);
            this.pnltools.Controls.Add(this.btncancel);
            this.pnltools.Controls.Add(this.btnsave);
            this.pnltools.Controls.Add(this.pnllanguage);
            this.pnltools.Controls.Add(this.pnlmaincolor);
            this.pnltools.Controls.Add(this.pnltheme);
            this.pnltools.Controls.Add(this.pnldatabase);
            this.pnltools.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnltools.Location = new System.Drawing.Point(3, 3);
            this.pnltools.Name = "pnltools";
            this.pnltools.Padding = new System.Windows.Forms.Padding(3);
            this.pnltools.Size = new System.Drawing.Size(700, 357);
            this.pnltools.TabIndex = 0;
            // 
            // pnlptinter
            // 
            this.pnlptinter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlptinter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.pnlptinter.Controls.Add(this.lblprinter);
            this.pnlptinter.Controls.Add(this.btnprinterdufulte);
            this.pnlptinter.Controls.Add(this.cbxprinter);
            this.pnlptinter.Location = new System.Drawing.Point(281, 258);
            this.pnlptinter.Name = "pnlptinter";
            this.pnlptinter.Size = new System.Drawing.Size(285, 83);
            this.pnlptinter.TabIndex = 35;
            // 
            // lblprinter
            // 
            this.lblprinter.AutoSize = true;
            this.lblprinter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblprinter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.lblprinter.Location = new System.Drawing.Point(12, 12);
            this.lblprinter.Name = "lblprinter";
            this.lblprinter.Size = new System.Drawing.Size(142, 20);
            this.lblprinter.TabIndex = 27;
            this.lblprinter.Tag = "الطابعة الإفتراضية";
            this.lblprinter.Text = "The Defulte Printer";
            // 
            // btnprinterdufulte
            // 
            this.btnprinterdufulte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.btnprinterdufulte.BackGraundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.btnprinterdufulte.BorderColor = System.Drawing.Color.White;
            this.btnprinterdufulte.BorderRadius = 10;
            this.btnprinterdufulte.BorderSize = 0;
            this.btnprinterdufulte.FlatAppearance.BorderSize = 0;
            this.btnprinterdufulte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnprinterdufulte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnprinterdufulte.ForeColor = System.Drawing.Color.White;
            this.btnprinterdufulte.Location = new System.Drawing.Point(207, 40);
            this.btnprinterdufulte.Name = "btnprinterdufulte";
            this.btnprinterdufulte.Size = new System.Drawing.Size(60, 30);
            this.btnprinterdufulte.TabIndex = 26;
            this.btnprinterdufulte.Tag = "تحديد";
            this.btnprinterdufulte.Text = "Set";
            this.btnprinterdufulte.TextColor = System.Drawing.Color.White;
            this.btnprinterdufulte.UseVisualStyleBackColor = false;
            // 
            // cbxprinter
            // 
            this.cbxprinter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxprinter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cbxprinter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxprinter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbxprinter.ForeColor = System.Drawing.Color.Silver;
            this.cbxprinter.FormattingEnabled = true;
            this.cbxprinter.Location = new System.Drawing.Point(17, 40);
            this.cbxprinter.Name = "cbxprinter";
            this.cbxprinter.Size = new System.Drawing.Size(174, 28);
            this.cbxprinter.TabIndex = 0;
            // 
            // btndefulte
            // 
            this.btndefulte.BackColor = System.Drawing.Color.Crimson;
            this.btndefulte.BackGraundColor = System.Drawing.Color.Crimson;
            this.btndefulte.BorderColor = System.Drawing.Color.PapayaWhip;
            this.btndefulte.BorderRadius = 10;
            this.btndefulte.BorderSize = 0;
            this.btndefulte.FlatAppearance.BorderSize = 0;
            this.btndefulte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndefulte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btndefulte.ForeColor = System.Drawing.Color.White;
            this.btndefulte.Location = new System.Drawing.Point(578, 139);
            this.btndefulte.Name = "btndefulte";
            this.btndefulte.Size = new System.Drawing.Size(110, 60);
            this.btndefulte.TabIndex = 7;
            this.btndefulte.Tag = "إعدادات إفتراضية";
            this.btndefulte.Text = "Defults";
            this.btndefulte.TextColor = System.Drawing.Color.White;
            this.btndefulte.UseVisualStyleBackColor = false;
            this.btndefulte.Visible = false;
            this.btndefulte.Click += new System.EventHandler(this.btndefulte_Click);
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.Color.DarkOrange;
            this.btncancel.BackGraundColor = System.Drawing.Color.DarkOrange;
            this.btncancel.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btncancel.BorderRadius = 10;
            this.btncancel.BorderSize = 0;
            this.btncancel.FlatAppearance.BorderSize = 0;
            this.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btncancel.ForeColor = System.Drawing.Color.White;
            this.btncancel.Location = new System.Drawing.Point(578, 208);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(110, 60);
            this.btncancel.TabIndex = 6;
            this.btncancel.Tag = "إلغاء التعديلات";
            this.btncancel.Text = "Cancel";
            this.btncancel.TextColor = System.Drawing.Color.White;
            this.btncancel.UseVisualStyleBackColor = false;
            this.btncancel.Visible = false;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.btnsave.BackGraundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.btnsave.BorderColor = System.Drawing.Color.PapayaWhip;
            this.btnsave.BorderRadius = 10;
            this.btnsave.BorderSize = 0;
            this.btnsave.FlatAppearance.BorderSize = 0;
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnsave.ForeColor = System.Drawing.Color.White;
            this.btnsave.Location = new System.Drawing.Point(578, 277);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(110, 60);
            this.btnsave.TabIndex = 5;
            this.btnsave.Tag = "حفظ";
            this.btnsave.Text = "Save";
            this.btnsave.TextColor = System.Drawing.Color.White;
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Visible = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // pnllanguage
            // 
            this.pnllanguage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.pnllanguage.Controls.Add(this.lblenglish);
            this.pnllanguage.Controls.Add(this.lblarabic);
            this.pnllanguage.Controls.Add(this.togglelanguage);
            this.pnllanguage.Controls.Add(this.lbllanguage);
            this.pnllanguage.Location = new System.Drawing.Point(12, 246);
            this.pnllanguage.Name = "pnllanguage";
            this.pnllanguage.Size = new System.Drawing.Size(255, 95);
            this.pnllanguage.TabIndex = 3;
            this.pnllanguage.Visible = false;
            // 
            // lblenglish
            // 
            this.lblenglish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblenglish.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.lblenglish.Location = new System.Drawing.Point(9, 38);
            this.lblenglish.Name = "lblenglish";
            this.lblenglish.Size = new System.Drawing.Size(69, 40);
            this.lblenglish.TabIndex = 5;
            this.lblenglish.Tag = "إنكليزي";
            this.lblenglish.Text = "English";
            this.lblenglish.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblarabic
            // 
            this.lblarabic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.lblarabic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblarabic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.lblarabic.Location = new System.Drawing.Point(182, 38);
            this.lblarabic.Name = "lblarabic";
            this.lblarabic.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblarabic.Size = new System.Drawing.Size(64, 40);
            this.lblarabic.TabIndex = 4;
            this.lblarabic.Tag = "عربي";
            this.lblarabic.Text = "Arabic";
            this.lblarabic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // togglelanguage
            // 
            this.togglelanguage.Location = new System.Drawing.Point(91, 40);
            this.togglelanguage.MinimumSize = new System.Drawing.Size(45, 22);
            this.togglelanguage.Name = "togglelanguage";
            this.togglelanguage.OffBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.togglelanguage.OffToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.togglelanguage.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.togglelanguage.OnToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.togglelanguage.Size = new System.Drawing.Size(85, 40);
            this.togglelanguage.TabIndex = 3;
            this.togglelanguage.UseVisualStyleBackColor = true;
            this.togglelanguage.CheckedChanged += new System.EventHandler(this.togglelanguage_CheckedChanged);
            // 
            // lbllanguage
            // 
            this.lbllanguage.AutoSize = true;
            this.lbllanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbllanguage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.lbllanguage.Location = new System.Drawing.Point(12, 12);
            this.lbllanguage.Name = "lbllanguage";
            this.lbllanguage.Size = new System.Drawing.Size(81, 20);
            this.lbllanguage.TabIndex = 2;
            this.lbllanguage.Tag = "اللغة";
            this.lbllanguage.Text = "Language";
            // 
            // pnlmaincolor
            // 
            this.pnlmaincolor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.pnlmaincolor.Controls.Add(this.pnlcolor6);
            this.pnlmaincolor.Controls.Add(this.pnlcolor3);
            this.pnlmaincolor.Controls.Add(this.pnlcolor5);
            this.pnlmaincolor.Controls.Add(this.pnlcolor4);
            this.pnlmaincolor.Controls.Add(this.pnlcolor2);
            this.pnlmaincolor.Controls.Add(this.pnlcolor1);
            this.pnlmaincolor.Controls.Add(this.lblmaincolor);
            this.pnlmaincolor.Location = new System.Drawing.Point(281, 139);
            this.pnlmaincolor.Name = "pnlmaincolor";
            this.pnlmaincolor.Size = new System.Drawing.Size(285, 110);
            this.pnlmaincolor.TabIndex = 2;
            this.pnlmaincolor.Visible = false;
            // 
            // pnlcolor6
            // 
            this.pnlcolor6.BackColor = System.Drawing.Color.DarkOrange;
            this.pnlcolor6.Location = new System.Drawing.Point(237, 62);
            this.pnlcolor6.Name = "pnlcolor6";
            this.pnlcolor6.Size = new System.Drawing.Size(30, 40);
            this.pnlcolor6.TabIndex = 14;
            this.pnlcolor6.Tag = "5";
            this.pnlcolor6.Click += new System.EventHandler(this.PnlColorEvent);
            // 
            // pnlcolor3
            // 
            this.pnlcolor3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(91)))));
            this.pnlcolor3.Location = new System.Drawing.Point(105, 62);
            this.pnlcolor3.Name = "pnlcolor3";
            this.pnlcolor3.Size = new System.Drawing.Size(30, 40);
            this.pnlcolor3.TabIndex = 13;
            this.pnlcolor3.Tag = "2";
            this.pnlcolor3.Click += new System.EventHandler(this.PnlColorEvent);
            // 
            // pnlcolor5
            // 
            this.pnlcolor5.BackColor = System.Drawing.Color.Fuchsia;
            this.pnlcolor5.Location = new System.Drawing.Point(193, 62);
            this.pnlcolor5.Name = "pnlcolor5";
            this.pnlcolor5.Size = new System.Drawing.Size(30, 40);
            this.pnlcolor5.TabIndex = 10;
            this.pnlcolor5.Tag = "4";
            this.pnlcolor5.Click += new System.EventHandler(this.PnlColorEvent);
            // 
            // pnlcolor4
            // 
            this.pnlcolor4.BackColor = System.Drawing.Color.Crimson;
            this.pnlcolor4.Location = new System.Drawing.Point(149, 62);
            this.pnlcolor4.Name = "pnlcolor4";
            this.pnlcolor4.Size = new System.Drawing.Size(30, 40);
            this.pnlcolor4.TabIndex = 11;
            this.pnlcolor4.Tag = "3";
            this.pnlcolor4.Click += new System.EventHandler(this.PnlColorEvent);
            // 
            // pnlcolor2
            // 
            this.pnlcolor2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(0)))));
            this.pnlcolor2.Location = new System.Drawing.Point(61, 62);
            this.pnlcolor2.Name = "pnlcolor2";
            this.pnlcolor2.Size = new System.Drawing.Size(30, 40);
            this.pnlcolor2.TabIndex = 12;
            this.pnlcolor2.Tag = "1";
            this.pnlcolor2.Click += new System.EventHandler(this.PnlColorEvent);
            // 
            // pnlcolor1
            // 
            this.pnlcolor1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.pnlcolor1.Location = new System.Drawing.Point(17, 62);
            this.pnlcolor1.Name = "pnlcolor1";
            this.pnlcolor1.Size = new System.Drawing.Size(30, 40);
            this.pnlcolor1.TabIndex = 9;
            this.pnlcolor1.Tag = "0";
            this.pnlcolor1.Click += new System.EventHandler(this.PnlColorEvent);
            // 
            // lblmaincolor
            // 
            this.lblmaincolor.AutoSize = true;
            this.lblmaincolor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblmaincolor.ForeColor = System.Drawing.Color.Fuchsia;
            this.lblmaincolor.Location = new System.Drawing.Point(12, 12);
            this.lblmaincolor.Name = "lblmaincolor";
            this.lblmaincolor.Size = new System.Drawing.Size(84, 20);
            this.lblmaincolor.TabIndex = 8;
            this.lblmaincolor.Tag = "اللون الرئيسي";
            this.lblmaincolor.Text = "Main Color";
            // 
            // pnltheme
            // 
            this.pnltheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.pnltheme.Controls.Add(this.lbllight);
            this.pnltheme.Controls.Add(this.lbldark);
            this.pnltheme.Controls.Add(this.toggletheme);
            this.pnltheme.Controls.Add(this.lbltheme);
            this.pnltheme.Location = new System.Drawing.Point(12, 139);
            this.pnltheme.Name = "pnltheme";
            this.pnltheme.Size = new System.Drawing.Size(255, 95);
            this.pnltheme.TabIndex = 1;
            this.pnltheme.Visible = false;
            // 
            // lbllight
            // 
            this.lbllight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.lbllight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbllight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.lbllight.Location = new System.Drawing.Point(195, 38);
            this.lbllight.Name = "lbllight";
            this.lbllight.Size = new System.Drawing.Size(50, 40);
            this.lbllight.TabIndex = 4;
            this.lbllight.Tag = "مضيء";
            this.lbllight.Text = "Light";
            this.lbllight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbldark
            // 
            this.lbldark.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbldark.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.lbldark.Location = new System.Drawing.Point(9, 38);
            this.lbldark.Name = "lbldark";
            this.lbldark.Size = new System.Drawing.Size(69, 40);
            this.lbldark.TabIndex = 3;
            this.lbldark.Tag = "داكن";
            this.lbldark.Text = "Dark";
            this.lbldark.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toggletheme
            // 
            this.toggletheme.Location = new System.Drawing.Point(91, 40);
            this.toggletheme.MinimumSize = new System.Drawing.Size(45, 22);
            this.toggletheme.Name = "toggletheme";
            this.toggletheme.OffBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.toggletheme.OffToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.toggletheme.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.toggletheme.OnToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.toggletheme.Size = new System.Drawing.Size(85, 40);
            this.toggletheme.TabIndex = 2;
            this.toggletheme.UseVisualStyleBackColor = true;
            this.toggletheme.CheckedChanged += new System.EventHandler(this.toggletheme_CheckedChanged);
            // 
            // lbltheme
            // 
            this.lbltheme.AutoSize = true;
            this.lbltheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbltheme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(0)))));
            this.lbltheme.Location = new System.Drawing.Point(12, 12);
            this.lbltheme.Name = "lbltheme";
            this.lbltheme.Size = new System.Drawing.Size(58, 20);
            this.lbltheme.TabIndex = 1;
            this.lbltheme.Tag = "السمة";
            this.lbltheme.Text = "Theme";
            // 
            // pnldatabase
            // 
            this.pnldatabase.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnldatabase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.pnldatabase.Controls.Add(this.btnclear);
            this.pnldatabase.Controls.Add(this.btnsearch);
            this.pnldatabase.Controls.Add(this.txtdatabaseroot);
            this.pnldatabase.Controls.Add(this.lbldatabase);
            this.pnldatabase.Location = new System.Drawing.Point(12, 12);
            this.pnldatabase.Name = "pnldatabase";
            this.pnldatabase.Padding = new System.Windows.Forms.Padding(12);
            this.pnldatabase.Size = new System.Drawing.Size(676, 115);
            this.pnldatabase.TabIndex = 0;
            this.pnldatabase.Visible = false;
            // 
            // btnclear
            // 
            this.btnclear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnclear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(0)))));
            this.btnclear.BackGraundColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(0)))));
            this.btnclear.BorderColor = System.Drawing.Color.PapayaWhip;
            this.btnclear.BorderRadius = 10;
            this.btnclear.BorderSize = 0;
            this.btnclear.FlatAppearance.BorderSize = 0;
            this.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnclear.ForeColor = System.Drawing.Color.White;
            this.btnclear.Location = new System.Drawing.Point(566, 61);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(92, 40);
            this.btnclear.TabIndex = 3;
            this.btnclear.Tag = "إذالة المعلومات";
            this.btnclear.Text = "Clear";
            this.btnclear.TextColor = System.Drawing.Color.White;
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(91)))));
            this.btnsearch.BackGraundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(91)))));
            this.btnsearch.BorderColor = System.Drawing.Color.PapayaWhip;
            this.btnsearch.BorderRadius = 10;
            this.btnsearch.BorderSize = 0;
            this.btnsearch.FlatAppearance.BorderSize = 0;
            this.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnsearch.ForeColor = System.Drawing.Color.White;
            this.btnsearch.Location = new System.Drawing.Point(566, 12);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(92, 40);
            this.btnsearch.TabIndex = 2;
            this.btnsearch.Tag = "إستعراض";
            this.btnsearch.Text = "Search";
            this.btnsearch.TextColor = System.Drawing.Color.White;
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // txtdatabaseroot
            // 
            this.txtdatabaseroot._Text = "";
            this.txtdatabaseroot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtdatabaseroot.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtdatabaseroot.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtdatabaseroot.AutoSize = true;
            this.txtdatabaseroot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.txtdatabaseroot.BorderColor = System.Drawing.Color.Silver;
            this.txtdatabaseroot.BorderSize = 5;
            this.txtdatabaseroot.FocusColor = System.Drawing.Color.DarkOrange;
            this.txtdatabaseroot.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdatabaseroot.ForeColor = System.Drawing.Color.DarkOrange;
            this.txtdatabaseroot.Location = new System.Drawing.Point(12, 63);
            this.txtdatabaseroot.MultiLine = false;
            this.txtdatabaseroot.Name = "txtdatabaseroot";
            this.txtdatabaseroot.Padding = new System.Windows.Forms.Padding(7);
            this.txtdatabaseroot.PasswordChar = false;
            this.txtdatabaseroot.Size = new System.Drawing.Size(527, 33);
            this.txtdatabaseroot.TabIndex = 1;
            this.txtdatabaseroot.UnderLinedStyle = true;
            // 
            // lbldatabase
            // 
            this.lbldatabase.AutoSize = true;
            this.lbldatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbldatabase.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbldatabase.Location = new System.Drawing.Point(12, 12);
            this.lbldatabase.Name = "lbldatabase";
            this.lbldatabase.Size = new System.Drawing.Size(79, 20);
            this.lbldatabase.TabIndex = 0;
            this.lbldatabase.Tag = "قاعدة البيانات";
            this.lbldatabase.Text = "Database";
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
            this.aboodPictureBox1.TabIndex = 10;
            this.aboodPictureBox1.TabStop = false;
            // 
            // ofddatabase
            // 
            this.ofddatabase.FileName = "openFileDialog1";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // backworker
            // 
            this.backworker.WorkerReportsProgress = true;
            this.backworker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backworker_DoWork);
            // 
            // lblerror
            // 
            this.lblerror.AutoSize = true;
            this.lblerror.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblerror.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.lblerror.Location = new System.Drawing.Point(12, 548);
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(0, 13);
            this.lblerror.TabIndex = 11;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(730, 577);
            this.Controls.Add(this.lblerror);
            this.Controls.Add(this.aboodPictureBox1);
            this.Controls.Add(this.pnlcontainer);
            this.Controls.Add(this.pnltop);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SettingsForm";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.pnltop.ResumeLayout(false);
            this.pnltop.PerformLayout();
            this.pnlcontainer.ResumeLayout(false);
            this.pnltools.ResumeLayout(false);
            this.pnlptinter.ResumeLayout(false);
            this.pnlptinter.PerformLayout();
            this.pnllanguage.ResumeLayout(false);
            this.pnllanguage.PerformLayout();
            this.pnlmaincolor.ResumeLayout(false);
            this.pnlmaincolor.PerformLayout();
            this.pnltheme.ResumeLayout(false);
            this.pnltheme.PerformLayout();
            this.pnldatabase.ResumeLayout(false);
            this.pnldatabase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aboodPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnltop;
        private System.Windows.Forms.Label lbltitel;
        private AboodTools_v5.AboodButton btnexit;
        private System.Windows.Forms.Panel pnlcontainer;
        private System.Windows.Forms.Panel pnltools;
        private System.Windows.Forms.Panel pnldatabase;
        private System.Windows.Forms.Label lbldatabase;
        private AboodTools_v5.AboodTextBox txtdatabaseroot;
        private AboodTools_v5.AboodButton btnsearch;
        private AboodTools_v5.AboodButton btnclear;
        private System.Windows.Forms.Panel pnltheme;
        private System.Windows.Forms.Label lbltheme;
        private System.Windows.Forms.Panel pnlmaincolor;
        private System.Windows.Forms.Panel pnlcolor3;
        private System.Windows.Forms.Panel pnlcolor5;
        private System.Windows.Forms.Panel pnlcolor4;
        private System.Windows.Forms.Panel pnlcolor2;
        private System.Windows.Forms.Panel pnlcolor1;
        private System.Windows.Forms.Label lblmaincolor;
        private System.Windows.Forms.Label lbllight;
        private System.Windows.Forms.Label lbldark;
        private AboodTools_v5.AboodToggleButton toggletheme;
        private System.Windows.Forms.Panel pnllanguage;
        private System.Windows.Forms.Label lbllanguage;
        private System.Windows.Forms.Label lblenglish;
        private System.Windows.Forms.Label lblarabic;
        private AboodTools_v5.AboodToggleButton togglelanguage;
        private AboodTools_v5.AboodButton btndefulte;
        private AboodTools_v5.AboodButton btncancel;
        private AboodTools_v5.AboodButton btnsave;
        private System.Windows.Forms.Panel pnlcolor6;
        private AboodTools_v5.AboodPictureBox aboodPictureBox1;
        private System.Windows.Forms.OpenFileDialog ofddatabase;
        private AboodTools_v5.AboodButton btnrestart;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private AboodTools_v5.AboodButton btnrestartapp;
        private System.ComponentModel.BackgroundWorker backworker;
        private System.Windows.Forms.Label lblerror;
        private System.Windows.Forms.Panel pnlptinter;
        private System.Windows.Forms.Label lblprinter;
        private AboodTools_v5.AboodButton btnprinterdufulte;
        private System.Windows.Forms.ComboBox cbxprinter;
    }
}