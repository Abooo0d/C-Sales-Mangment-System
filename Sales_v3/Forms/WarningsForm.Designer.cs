namespace Sales_v3.Forms
{
    partial class WarningsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WarningsForm));
            this.pnltop = new System.Windows.Forms.Panel();
            this.btnexit = new AboodTools_v5.AboodButton();
            this.lbltitle = new System.Windows.Forms.Label();
            this.pnlcontainer = new System.Windows.Forms.Panel();
            this.pnlwarnings = new System.Windows.Forms.FlowLayoutPanel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lblerror = new System.Windows.Forms.Label();
            this.pnltop.SuspendLayout();
            this.pnlcontainer.SuspendLayout();
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
            this.pnltop.Size = new System.Drawing.Size(530, 35);
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
            this.btnexit.Location = new System.Drawing.Point(492, 1);
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
            this.lbltitle.Location = new System.Drawing.Point(12, 9);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(117, 17);
            this.lbltitle.TabIndex = 0;
            this.lbltitle.Text = "Warnings Form";
            // 
            // pnlcontainer
            // 
            this.pnlcontainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.pnlcontainer.Controls.Add(this.pnlwarnings);
            this.pnlcontainer.Location = new System.Drawing.Point(12, 47);
            this.pnlcontainer.Name = "pnlcontainer";
            this.pnlcontainer.Size = new System.Drawing.Size(506, 261);
            this.pnlcontainer.TabIndex = 1;
            // 
            // pnlwarnings
            // 
            this.pnlwarnings.AutoScroll = true;
            this.pnlwarnings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.pnlwarnings.Location = new System.Drawing.Point(3, 3);
            this.pnlwarnings.Name = "pnlwarnings";
            this.pnlwarnings.Padding = new System.Windows.Forms.Padding(30, 12, 30, 12);
            this.pnlwarnings.Size = new System.Drawing.Size(500, 255);
            this.pnlwarnings.TabIndex = 0;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // lblerror
            // 
            this.lblerror.AutoSize = true;
            this.lblerror.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.lblerror.Location = new System.Drawing.Point(12, 317);
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(0, 17);
            this.lblerror.TabIndex = 2;
            // 
            // WarningsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(530, 343);
            this.Controls.Add(this.lblerror);
            this.Controls.Add(this.pnlcontainer);
            this.Controls.Add(this.pnltop);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "WarningsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WarningsForm";
            this.Load += new System.EventHandler(this.WarningsForm_Load);
            this.pnltop.ResumeLayout(false);
            this.pnltop.PerformLayout();
            this.pnlcontainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnltop;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Panel pnlcontainer;
        private System.Windows.Forms.FlowLayoutPanel pnlwarnings;
        private AboodTools_v5.AboodButton btnexit;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label lblerror;
    }
}