using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using Sales_v3.Class;

namespace Sales_v3.Forms
{
    public partial class SalesForm : Form
    {
        //Fildes
        public static DataServices json = new DataServices();
        public Color _BackColor = new Color();
        public bool Dragging = false;
        public Point StartPoint = new Point(0, 0);
        List<string> Sales = SalePointForm.Sales;
        public int Counter = 0;
        public bool Changed = false;
        string[] Files;
        string[] Files1;
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
        //Methods
        public void AddSales()
        {
            try {
                dgvsales.Rows.Clear();
                if (!Changed)
                {
                    if (Sales.Count > 0)
                    {
                        for (int i = 0; i < Sales.Count; i++)
                        {
                            string[] Data = Sales[i].Split(';');
                            dgvsales.Rows.Add(Data);
                        }
                    }
                }
                else
                {
                    if (Counter < cbxfilles.Items.Count - 1)
                    {
                        using (StreamReader sw = new StreamReader(Files[Counter]))
                        {
                            string data = sw.ReadToEnd();
                            string[] Data = data.Split(';');
                            for (int i = 0; i < Data.Length - 6; i += 6)
                            {
                                object id = Data[i];
                                object name = Data[i + 1];
                                object qty = Data[i + 2];
                                object price = Data[i + 3];
                                object subtotal = Data[i + 4];
                                object ordernumber = Data[i + 5];
                                object[] row = { id, name, qty, price, subtotal, ordernumber }; ;
                                dgvsales.Rows.Add(row);
                            }
                            sw.Dispose();
                        }
                    }
                    else
                    {
                        if (Sales.Count > 0)
                        {
                            for (int i = 0; i < Sales.Count; i++)
                            {
                                string[] Data = Sales[i].Split(';');
                                dgvsales.Rows.Add(Data);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                lblerror.Text = ex.Message;
                Thread.Sleep(3000);
                this.Close();
            }
        }
        public void GetFilles()
        {
            try
            {
                Files = Directory.GetFiles(SalePointForm.SalesRoot);
                Files1 = new string[Files.Length];
                for (int i = 0; i < Files.Length; i++)
                {
                    Files1[i] = Path.GetFileNameWithoutExtension(Files[i]);
                }
                cbxfilles.Items.AddRange(Files1);
                cbxfilles.Items.Add("Current File");
            }
            catch (Exception ex)
            {
                lblerror.Text = ex.Message;
                Thread.Sleep(3000);
                this.Close();
            }
        }
        public void ChangeColor()
        {
            pnltop.BackColor = _BackColor;
            dgvsales.HeaderBgColor = _BackColor;
            pnldgvsales.BackColor = _BackColor;
            if (json.Theme == "Dark")
            {
                BackColor = Color.FromArgb(255, 43, 43, 43);
            }
            else if (json.Theme == "Light")
            {
                BackColor = Color.FromArgb(255, 213, 213, 213);
            }
        }
        public SalesForm()
        {
            InitializeComponent();
        }

        //Events
        #region Dragging
        private void pnltop_MouseDown(object sender, MouseEventArgs e)
        {
            Dragging = true;
            StartPoint = new Point(e.X, e.Y);
        }
        private void pnltop_MouseUp(object sender, MouseEventArgs e) => Dragging = false;
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
            this.Close()
                ;
        }
        private void SalesForm_Load(object sender, EventArgs e)
        {
            try
            {
                json = SalePointForm.json;
                _BackColor = LoginForm.MainColor[json.MainColorNum];
                ChangeColor();
                AddSales();
                GetFilles();
            }
            catch (Exception ex)
            {
                lblerror.Text = ex.Message;
                Thread.Sleep(3000);
                Close();
            }
        }
        private void cbxfilles_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Changed = true;
                Counter = cbxfilles.SelectedIndex;
                AddSales();
            }
            catch (Exception ex)
            {
                lblerror.Text = ex.Message;
                Thread.Sleep(3000);
                Close();
            }
        }
    }
}
