namespace Sales_v3.Forms
{
    partial class SalesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesForm));
            this.pnldgvsales = new System.Windows.Forms.Panel();
            this.dgvsales = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.colnum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colsubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colordernum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnltop = new System.Windows.Forms.Panel();
            this.lbltitla = new System.Windows.Forms.Label();
            this.btnexit = new AboodTools_v5.AboodButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lbllastfiles = new System.Windows.Forms.Label();
            this.cbxfilles = new System.Windows.Forms.ComboBox();
            this.lblerror = new System.Windows.Forms.Label();
            this.pnldgvsales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsales)).BeginInit();
            this.pnltop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnldgvsales
            // 
            this.pnldgvsales.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnldgvsales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.pnldgvsales.Controls.Add(this.dgvsales);
            this.pnldgvsales.Location = new System.Drawing.Point(12, 46);
            this.pnldgvsales.Margin = new System.Windows.Forms.Padding(4);
            this.pnldgvsales.Name = "pnldgvsales";
            this.pnldgvsales.Size = new System.Drawing.Size(576, 310);
            this.pnldgvsales.TabIndex = 2;
            // 
            // dgvsales
            // 
            this.dgvsales.AllowUserToAddRows = false;
            this.dgvsales.AllowUserToDeleteRows = false;
            this.dgvsales.AllowUserToResizeColumns = false;
            this.dgvsales.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
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
            this.colnum,
            this.colname,
            this.colqty,
            this.colprice,
            this.colsubtotal,
            this.colordernum});
            this.dgvsales.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvsales.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvsales.DoubleBuffered = true;
            this.dgvsales.EnableHeadersVisualStyles = false;
            this.dgvsales.GridColor = System.Drawing.Color.Silver;
            this.dgvsales.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.dgvsales.HeaderForeColor = System.Drawing.Color.White;
            this.dgvsales.Location = new System.Drawing.Point(3, 3);
            this.dgvsales.Margin = new System.Windows.Forms.Padding(4);
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
            this.dgvsales.Size = new System.Drawing.Size(570, 304);
            this.dgvsales.TabIndex = 0;
            // 
            // colnum
            // 
            this.colnum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colnum.FillWeight = 70F;
            this.colnum.HeaderText = "Num";
            this.colnum.Name = "colnum";
            this.colnum.ReadOnly = true;
            // 
            // colname
            // 
            this.colname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colname.FillWeight = 180F;
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
            this.colprice.HeaderText = "Price";
            this.colprice.Name = "colprice";
            this.colprice.ReadOnly = true;
            // 
            // colsubtotal
            // 
            this.colsubtotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colsubtotal.HeaderText = "Sub Total";
            this.colsubtotal.Name = "colsubtotal";
            this.colsubtotal.ReadOnly = true;
            // 
            // colordernum
            // 
            this.colordernum.FillWeight = 250F;
            this.colordernum.HeaderText = "Order Num";
            this.colordernum.Name = "colordernum";
            this.colordernum.ReadOnly = true;
            // 
            // pnltop
            // 
            this.pnltop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.pnltop.Controls.Add(this.lbltitla);
            this.pnltop.Controls.Add(this.btnexit);
            this.pnltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnltop.Location = new System.Drawing.Point(0, 0);
            this.pnltop.Margin = new System.Windows.Forms.Padding(4);
            this.pnltop.Name = "pnltop";
            this.pnltop.Size = new System.Drawing.Size(600, 35);
            this.pnltop.TabIndex = 3;
            this.pnltop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnltop_MouseDown);
            this.pnltop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnltop_MouseMove);
            this.pnltop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnltop_MouseUp);
            // 
            // lbltitla
            // 
            this.lbltitla.AutoSize = true;
            this.lbltitla.ForeColor = System.Drawing.Color.White;
            this.lbltitla.Location = new System.Drawing.Point(9, 9);
            this.lbltitla.Name = "lbltitla";
            this.lbltitla.Size = new System.Drawing.Size(48, 17);
            this.lbltitla.TabIndex = 3;
            this.lbltitla.Text = "Sales";
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
            this.btnexit.Location = new System.Drawing.Point(562, 1);
            this.btnexit.Margin = new System.Windows.Forms.Padding(4);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(33, 33);
            this.btnexit.TabIndex = 2;
            this.btnexit.Text = "X";
            this.btnexit.TextColor = System.Drawing.Color.White;
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // lbllastfiles
            // 
            this.lbllastfiles.AutoSize = true;
            this.lbllastfiles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.lbllastfiles.Location = new System.Drawing.Point(15, 365);
            this.lbllastfiles.Name = "lbllastfiles";
            this.lbllastfiles.Size = new System.Drawing.Size(83, 17);
            this.lbllastfiles.TabIndex = 4;
            this.lbllastfiles.Text = "Last Files:";
            // 
            // cbxfilles
            // 
            this.cbxfilles.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbxfilles.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxfilles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cbxfilles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxfilles.FormattingEnabled = true;
            this.cbxfilles.Location = new System.Drawing.Point(125, 362);
            this.cbxfilles.Name = "cbxfilles";
            this.cbxfilles.Size = new System.Drawing.Size(460, 24);
            this.cbxfilles.TabIndex = 6;
            this.cbxfilles.SelectedIndexChanged += new System.EventHandler(this.cbxfilles_SelectedIndexChanged);
            // 
            // lblerror
            // 
            this.lblerror.AutoSize = true;
            this.lblerror.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.lblerror.Location = new System.Drawing.Point(15, 396);
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(0, 17);
            this.lblerror.TabIndex = 7;
            // 
            // SalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(600, 425);
            this.Controls.Add(this.lblerror);
            this.Controls.Add(this.cbxfilles);
            this.Controls.Add(this.lbllastfiles);
            this.Controls.Add(this.pnltop);
            this.Controls.Add(this.pnldgvsales);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SalesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalesForm";
            this.Load += new System.EventHandler(this.SalesForm_Load);
            this.pnldgvsales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvsales)).EndInit();
            this.pnltop.ResumeLayout(false);
            this.pnltop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnldgvsales;
        public Bunifu.Framework.UI.BunifuCustomDataGrid dgvsales;
        private System.Windows.Forms.Panel pnltop;
        private AboodTools_v5.AboodButton btnexit;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colnum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colname;
        private System.Windows.Forms.DataGridViewTextBoxColumn colqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colsubtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colordernum;
        private System.Windows.Forms.Label lbltitla;
        private System.Windows.Forms.Label lbllastfiles;
        private System.Windows.Forms.ComboBox cbxfilles;
        private System.Windows.Forms.Label lblerror;
    }
}