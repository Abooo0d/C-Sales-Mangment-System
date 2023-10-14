using System;
using System.Drawing;
using System.Windows.Forms;
using Sales_v3.Class;

namespace Sales_v3.Forms
{
    public partial class WarningsForm : Form
    {
        //Fields
        #region Fields
        public static DataServices json = new DataServices();
        public Color _BackColor = new Color();
        public bool Dragging = false;
        public Point StartPoint = new Point(0, 0);
        public string[] Warnings;
        public string[] QTYs;
        //DropShadow
        private static Int32 CS_DROPSHADOW = 0x00020000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams parameters = base.CreateParams;
                parameters.ClassStyle |= CS_DROPSHADOW;
                return parameters;
            }
        }
        #endregion
        //Methods
        #region Methods
        public WarningsForm()
        {
            InitializeComponent();
        }
        public void GetWarnings()
        {
            try
            {
                Warnings = new string[LoginForm.WarningsNum];
                QTYs = new string[LoginForm.WarningsNum];
                if (LoginForm.WarningsNum == 0)
                    return;
                else
                {
                    for (int i = 0; i < LoginForm.WarningsNum; i++)
                    {
                        string[] data = LoginForm.Warnings[i].Split(';');
                        Warnings[i] = data[0];
                        QTYs[i] = data[1];
                    }
                    for (int i = 0; i < Warnings.Length; i++)
                    {
                        Panel pnl1 = new Panel();
                        pnl1.Size = new Size(440, 75);
                        Label lbl1 = new Label();
                        lbl1.ForeColor = Color.White;
                        lbl1.Dock = DockStyle.Fill;
                        lbl1.AutoSize = false;
                        lbl1.TextAlign = ContentAlignment.MiddleCenter;
                        lbl1.Text = $"Low Qty For {Warnings[i]} The QTY Is {QTYs[i]} kg.";
                        if (json.Theme == "Dark")
                        {
                            pnl1.BackColor = Color.FromArgb(255, 43, 43, 43);
                        }
                        else if (json.Theme == "Light")
                        {
                            pnl1.BackColor = Color.FromArgb(255, 240, 240, 240);
                        }
                        lbl1.ForeColor = _BackColor;
                        pnl1.Controls.Add(lbl1);
                        pnlwarnings.Controls.Add(pnl1);
                    }
                }
            }
            catch (Exception ex)
            {
                lblerror.Text = ex.Message;
            }
        }
        public void ChangeColor()
        {
            try
            {
                pnltop.BackColor = _BackColor;
                pnlcontainer.BackColor = _BackColor;
                if (json.Theme == "Dark")
                {
                    BackColor = Color.FromArgb(255, 43, 43, 43);
                    pnlwarnings.BackColor = Color.FromArgb(255, 50, 50, 50);
                }
                else if(json.Theme == "Light")
                {
                    BackColor = Color.FromArgb(255, 213, 213, 213);
                    pnlwarnings.BackColor = Color.FromArgb(255, 230, 230, 230);
                }
            }
            catch (Exception ex)
            {
                lblerror.Text = ex.Message;
            }
        }
        #endregion
        //Events
        #region Events
        #region Dragging
        private void pnltop_MouseDown(object sender, MouseEventArgs e)
        {
            Dragging = true;
            StartPoint = new Point(e.X, e.Y);
        }

        private void pnltop_MouseUp(object sender, MouseEventArgs e)
        {
            Dragging = false;
        }

        private void pnltop_MouseMove(object sender, MouseEventArgs e)
        {
            if (Dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - StartPoint.X, p.Y - StartPoint.Y);
            }
        }
        #endregion
        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void WarningsForm_Load(object sender, EventArgs e)
        {
            try
            {
                json = SalePointForm.json;
                _BackColor = LoginForm.MainColor[json.MainColorNum];
                ChangeColor();
                GetWarnings();
            }
            catch(Exception ex)
            {
                lblerror.Text = ex.Message;
            }
        }
        #endregion
    }
}
