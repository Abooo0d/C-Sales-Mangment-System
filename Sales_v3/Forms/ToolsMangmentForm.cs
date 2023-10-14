using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.ComponentModel;
using Sales_v3.Class;

namespace Sales_v3.Forms
{
    public partial class ToolsMangmentForms : Form
    {
        //Fildes
        #region Fields
        public bool Database = false;
        public bool Loading = false;
        public static DataServices json = new DataServices();
        public Color _BackColor1 = new Color();
        public bool Dragging = false;
        public Point StartPoint = new Point(0, 0);
        public int Counter = 0;
        public string Id;
        public string Matrial;
        public string Price;
        public string _BackColor;
        public string _BorderColor;
        public bool _Button;
        public bool _Border;
        public int ToolOrder;
        public bool Error = false;
        public string[] ArabicNames = new string[2] { "إدارة الأدوات", "اسم المادة" };
        public string[] EnglishNames = new string[2] { "ToolsManagment", "Matrial Name" };
        public Color Dark1 = Color.FromArgb(255, 43, 43, 43);
        public Color Dark2 = Color.FromArgb(255, 50, 50, 50);
        public Color Light1 = Color.FromArgb(255, 213, 213, 213);
        public Color Light2 = Color.FromArgb(255, 230, 230, 230);
        public enum Languages { Arabic,English};
        public Languages language = Languages.English;
        //DropShadow
        private static int CS_DROPSHADOW = 0x00020000;
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
        public ToolsMangmentForms()
        {
            InitializeComponent();
        }
        public void FillData()
        {
            try
            {
                txtid._Text = "";
                txtmatrial._Text = "";
                txtprice._Text = "";
                numtoolorder.Value = 1;
                if (!Database) return;
                if (LoginForm.SalesTable.Rows.Count == 0) return;
                if (Counter > LoginForm.SalesTable.Rows.Count - 1) return;
                Id = Convert.ToString(LoginForm.SalesTable.Rows[Counter]["Id"]);
                Matrial = Convert.ToString(LoginForm.SalesTable.Rows[Counter]["Material_Name"]);
                Price = Convert.ToString(LoginForm.SalesTable.Rows[Counter]["Price"]);
                _BackColor = Convert.ToString(LoginForm.SalesTable.Rows[Counter]["Color"]);
                _BorderColor = Convert.ToString(LoginForm.SalesTable.Rows[Counter]["Border_Color"]);
                string button = Convert.ToString(LoginForm.SalesTable.Rows[Counter]["Button"]).ToLower();
                string border = Convert.ToString(LoginForm.SalesTable.Rows[Counter]["Border"]).ToLower();
                ToolOrder = Convert.ToInt32(LoginForm.SalesTable.Rows[Counter]["Tool_Order"]);

                txtid._Text = Id;
                txtmatrial._Text = Matrial;
                txtprice._Text = Price;
                cbxcolor.Text = _BackColor;
                cbxbordercolor.Text = _BorderColor;
                numtoolorder.Value = ToolOrder;
                if (_BackColor.Trim() != "")
                    pnlcolor.BackColor = Color.FromName(_BackColor);
                else
                    pnlcolor.BackColor = Color.Transparent;
                if (_BorderColor.Trim() != "")
                    pnlbordercolor.BackColor = Color.FromName(_BorderColor);
                else
                    pnlbordercolor.BackColor = Color.Transparent;
                if (button == "true")
                {
                    _Button = true;
                    togglebutton.CheckState = CheckState.Checked;
                }
                else if (button == "false")
                {
                    _Button = false;
                    togglebutton.CheckState = CheckState.Unchecked;
                }
                if (border == "true")
                {
                    _Border = true;
                    toggleborder.CheckState = CheckState.Checked;
                }
                else if (border == "false")
                {
                    _Border = false;
                    toggleborder.CheckState = CheckState.Unchecked;
                }
            }
            catch (Exception ex)
            {
                Error = true;
                lblerror.Text = "FillData() " + ex.Message;
                MessageBox.Show(ex.Message);
            }
        }
        public void Filldgvsales()
        {
            try
            {
                dgvsales.Rows.Clear();
                if (!Database) return;
                for (int i = 0; i < LoginForm.SalesTable.Rows.Count; i++)
                {
                    object[] data = { LoginForm.SalesTable.Rows[i]["Material_Name"] };
                    dgvsales.Rows.Add(data);
                }
            }
            catch (Exception ex)
            {
                Error = true;
                lblerror.Text = "FillDgvSalews() " + ex.Message;
            }
        }
        public void FillColors()
        {
            try
            {
                List<object> Colors = new List<object>();
                foreach (System.Reflection.PropertyInfo prop in typeof(Color).GetProperties())
                {
                    if (prop.PropertyType.FullName == "System.Drawing.Color")
                    {
                        Colors.Add(prop.Name);
                        cbxcolor.Invoke((MethodInvoker)delegate
                        {
                            cbxcolor.Items.Add(prop.Name);
                        });
                        cbxbordercolor.Invoke((MethodInvoker)delegate
                         {
                             cbxbordercolor.Items.Add(prop.Name);
                         });
                    }
                }
            }
            catch (Exception ex)
            {
                Error = true;
                lblerror.Invoke((MethodInvoker)delegate
                {
                    lblerror.Text = "FillColor() " + ex.Message;
                });
            }
        }
        public void ChangeColor()
        {
            try
            {
                pnltop.BackColor = _BackColor1;
                dgvsales.HeaderBgColor = _BackColor1;
                pnlcontainer.BackColor = _BackColor1;
                pnldgvsales.BackColor = _BackColor1;
                if (json.Theme == "Dark")
                {
                    BackColor = Dark1;
                    pnltools.BackColor = Dark2;
                    txtid.BackColor = Dark2;
                    txtmatrial.BackColor = Dark2;
                    txtprice.BackColor = Dark2;
                    numtoolorder.BackColor = Dark2;
                    cbxbordercolor.BackColor = Dark2;
                    cbxcolor.BackColor = Dark2;
                    cbxbordercolor.ForeColor = Light2;
                    cbxcolor.ForeColor = Light2;
                }
                else if (json.Theme == "Light")
                {
                    BackColor = Light1;
                    pnltools.BackColor = Light2;
                    txtid.BackColor = Light2;
                    txtmatrial.BackColor = Light2;
                    txtprice.BackColor = Light2;
                    numtoolorder.BackColor = Light2;
                    cbxbordercolor.BackColor = Light2;
                    cbxcolor.BackColor = Light2;
                    cbxbordercolor.ForeColor = Dark2;
                    cbxcolor.ForeColor = Dark2;
                }
            }
            catch (Exception ex)
            {
                Error = true;
                lblerror.Text = "ChangeColor() " + ex.Message;
            }
        }
        public void Editedata()
        {
            try
            {
                if (!Database) return;
                MessageBox.Show($"{LoginForm.SalesTable.Rows.Count} {Counter}");
                LoginForm.SalesTable.Rows[Counter]["Id"] = Id;
                LoginForm.SalesTable.Rows[Counter]["Material_Name"] = Matrial;
                LoginForm.SalesTable.Rows[Counter]["Price"] = Price;
                LoginForm.SalesTable.Rows[Counter]["Color"] = _BackColor;
                LoginForm.SalesTable.Rows[Counter]["Border_Color"] = _BorderColor;
                LoginForm.SalesTable.Rows[Counter]["Button"] = _Button;
                LoginForm.SalesTable.Rows[Counter]["Border"] = _Border;
                LoginForm.SalesTable.Rows[Counter]["Tool_Order"] = ToolOrder;
                LoginForm.SalesAdapter.Update(LoginForm.SalesTable);
            }
            catch (Exception ex)
            {
                Error = true;
                lblerror.Text = "EditeData() " + ex.Message;
            }
        }
        public void CheckPreviwe()
        {
            try
            {
                if (!Database) return;
                btnpreview.Invoke((MethodInvoker)delegate
                {
                    btnpreview.BackColor = Color.FromName(_BackColor);
                    btnpreview.Text = Matrial;
                    if (_Border)
                        btnpreview.BorderSize = 2;
                    else
                        btnpreview.BorderSize = 0;
                    if (_Button)
                        btnpreview.Visible = true;
                    else
                        btnpreview.Visible = false;
                    btnpreview.BorderColor = Color.FromName(_BorderColor);
                });
            }
            catch (Exception ex)
            {
                Error = true;
                lblerror.Invoke((MethodInvoker)delegate
                {
                    lblerror.Text = "CheckPreviwe() " + ex.Message;
                });
            }
        }
        public void ChangeLanguage()
        {
            if (json.Language == "Arabic")
            {
                if (language == Languages.English)
                {
                    pnltools.RightToLeft = RightToLeft.Yes;
                    lbltitle.Text = ArabicNames[0];
                    colname.HeaderText = ArabicNames[1];
                    lbltitle.Location = new Point(pnltop.Width - lbltitle.Width - 5, 8);
                    btnexit.Location = new Point(5, 1);
                    btnrestart.Location = new Point(43, 1);
                    lblid.Location = new Point(157, 12);
                    lbltoolorder.Location = new Point(323, 12);
                    lblmatrialname.Location = new Point(337, 78);
                    lblprice.Location = new Point(355, 146);
                    lblpreview.Location = new Point(494, 281);
                    foreach (Control control in pnltools.Controls)
                    {
                        string name = Convert.ToString(control.Tag);
                        control.Tag = control.Text;
                        control.Text = name;
                    }
                    language = Languages.Arabic;
                }
            }
            else if (json.Language == "English")
            {
                if (language == Languages.Arabic)
                {
                    pnltools.RightToLeft = RightToLeft.No;
                    lbltitle.Text = EnglishNames[0];
                    colname.HeaderText = EnglishNames[1];
                    lbltitle.Location = new Point(5, 8);
                    btnexit.Location = new Point(692, 1);
                    btnrestart.Location = new Point(654, 1);
                    lblid.Location = new Point(24, 12);
                    lbltoolorder.Location = new Point(242, 12);
                    lblmatrialname.Location = new Point(24, 78);
                    lblprice.Location = new Point(24, 146);
                    lblpreview.Location = new Point(395, 281);
                    foreach (Control control in pnltools.Controls)
                    {
                        string name = Convert.ToString(control.Tag);
                        control.Tag = control.Text;
                        control.Text = name;
                    }
                    language = Languages.English;
                }
            }
        }
        #endregion
        //Event
        #region Events
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
        private void txtid_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void ToolsMangmentForms_Load(object sender, EventArgs e)
        {
            try
            {
                Database = LoginForm.DataBase;
                Loading = true;
                json = MainForm.json;
                _BackColor1 = LoginForm.MainColor[json.MainColorNum];
                ChangeColor();
                ChangeLanguage();
                backworker.RunWorkerAsync();
                FillData();
                Filldgvsales();
            }
            catch (Exception ex)
            {
                Error = true;
                Loading = false;
                lblerror.Text = "Load() " + ex.Message;
            }
        }
        private void btnexit_Click(object sender, EventArgs e)
        {
            try
            {
                if (Loading) return;
                if (Error) return;
                Close();
                Application.OpenForms[1].Show();
            }
            catch (Exception ex)
            {
                Error = true;
                lblerror.Text = "Exit() " + ex.Message;
            }
        }
        private void cbxcolor_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (Loading) return;
                if (Error) return;
                _BackColor = cbxcolor.Text;
                pnlcolor.BackColor = Color.FromName(cbxcolor.Text);
                CheckPreviwe();
            }
            catch (Exception ex)
            {
                Error = true;
                lblerror.Text = "CbxColor() " + ex.Message;
            }
        }
        private void cbxbordercolor_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (Loading) return;
                if (Error) return;
                _BorderColor = cbxbordercolor.Text;
                pnlbordercolor.BackColor = Color.FromName(cbxbordercolor.Text);
                CheckPreviwe();
            }
            catch (Exception ex)
            {
                Error = true;
                lblerror.Text = "CbxBorderColor() " + ex.Message;
            }
        }
        private void togglbutton_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (Loading) return;
                if (Error) return;
                if (togglebutton.CheckState == CheckState.Checked)
                {
                    _Button = true;
                }
                else if (togglebutton.CheckState == CheckState.Unchecked)
                {
                    _Button = false;
                }
                CheckPreviwe();
            }
            catch (Exception ex)
            {
                Error = true;
                lblerror.Text = "ToggleVisible() " + ex.Message;
            }
        }
        private void toggleborder_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (Loading) return;
                if (Error) return;
                if (toggleborder.CheckState == CheckState.Checked)
                {
                    _Border = true;
                }
                else if (toggleborder.CheckState == CheckState.Unchecked)
                {
                    _Border = false;
                }
                CheckPreviwe();
            }
            catch (Exception ex)
            {
                Error = true;
                lblerror.Text = "ToggleBorder() " + ex.Message;
            }
        }
        private void btnfirstone_Click(object sender, EventArgs e)
        {
            try
            {
                if (Loading) return;
                if (Error) return;
                Counter = 0;
                FillData();
                CheckPreviwe();
            }
            catch (Exception ex)
            {
                Error = true;
                lblerror.Text = "FirstOne() " + ex.Message;
            }
        }
        private void btnback_Click(object sender, EventArgs e)
        {
            try
            {
                if (Loading) return;
                if (Error) return;
                if (Counter > 0)
                {
                    Counter--;
                    FillData();
                    CheckPreviwe();
                }
            }
            catch (Exception ex)
            {
                Error = true;
                lblerror.Text = "Back() " + ex.Message;
            }
        }
        private void btnnext_Click(object sender, EventArgs e)
        {
            try
            {
                if (Loading) return;
                if (Error) return;
                if (Counter < LoginForm.SalesTable.Rows.Count - 1)
                {
                    Counter++;
                    FillData();
                    CheckPreviwe();
                }
            }
            catch (Exception ex)
            {
                Error = true;
                lblerror.Text = "Next() " + ex.Message;
            }
        }
        private void btnlastone_Click(object sender, EventArgs e)
        {
            try
            {
                if (Loading) return;
                if (Error) return;
                Counter = LoginForm.SalesTable.Rows.Count - 1;
                FillData();
                CheckPreviwe();
            }
            catch (Exception ex)
            {
                Error = true;
                lblerror.Text = "LastOne() " + ex.Message;
            }
        }
        private void btnedite_Click(object sender, EventArgs e)
        {
            try
            {
                if (Loading) return;
                if (Error) return;
                Editedata();
            }
            catch (Exception ex)
            {
                Error = true;
                lblerror.Text = "Edite() " + ex.Message;
            }
        }
        private void dgvsales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (Loading) return;
                if (Error) return;
                Counter = dgvsales.CurrentRow.Index;
                FillData();
                CheckPreviwe();
            }
            catch (Exception ex)
            {
                Error = true;
                lblerror.Text = "DgvSalesClick() " + ex.Message;
            }
        }
        private void numtoolorder_ValueChanged(object sender, EventArgs e)
        {
            if (Loading) return;
            ToolOrder = Convert.ToInt32(numtoolorder.Value);
        }
        private void btnrestart_Click(object sender, EventArgs e)
        {
            try
            {
                if (Loading) return;
                Close();
                LoginForm.ToolsMangmentForms1 = new ToolsMangmentForms();
                Thread.Sleep(1000);
                LoginForm.ToolsMangmentForms1.Show();
            }
            catch (Exception ex)
            {
                Error = true;
                lblerror.Text = "Restart() " + ex.Message;
            }
        }
        private void backworker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                pnlcontainer.Invoke((MethodInvoker)delegate
                {
                    pnlcontainer.Visible = true;
                });
                Thread.Sleep(200);
                btnfirstone.Invoke((MethodInvoker)delegate
                {
                    btnfirstone.Visible = true;
                });
                Thread.Sleep(200);
                btnback.Invoke((MethodInvoker)delegate
                {
                    btnback.Visible = true;
                });
                Thread.Sleep(200);
                btnnext.Invoke((MethodInvoker)delegate
                {
                    btnnext.Visible = true;
                });
                Thread.Sleep(200);
                btnlastone.Invoke((MethodInvoker)delegate
                {
                    btnlastone.Visible = true;

                });
                Thread.Sleep(200);
                btnedite.Invoke((MethodInvoker)delegate
                {
                    btnedite.Visible = true;
                });
                FillColors();
                CheckPreviwe();
                Thread.Sleep(500);
                Loading = false;
            }
            catch (Exception ex)
            {
                Loading = false;
                Error = true;
                lblerror.Invoke((MethodInvoker)delegate
                {
                    lblerror.Text = "backWorker() " + ex.Message;
                });
            }
        }
        #endregion
    }
}
