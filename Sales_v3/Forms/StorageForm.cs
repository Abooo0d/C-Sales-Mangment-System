using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Sales_v3.Class;


namespace Sales_v3.Forms
{
    public partial class StorageForm : Form
    {
        //Fields
        #region Fields
        public bool Loading = false;
        public bool Database = false;
        public static DataServices json = new DataServices();
        public Color _BackColor = new Color();
        public bool Dragging = false;
        public Point StartPoint = new Point(0, 0);
        public int Counter = 0;
        public int ID;
        public object MatrialName;
        public object Price;
        public object QTY;
        public object AddedQTY;
        public object Warning;
        public bool Error = false;
        public string[] ArabicNames = new string[2] { "المستودع", "اسم المادة" };
        public string[] EnglishNames = new string[2] { "Storage", "Matrial Name" };
        //DropShadow
        private static int CS_DROPSHADOW = 0x00020000;
        public Color Dark1 = Color.FromArgb(255, 43, 43, 43);
        public Color Dark2 = Color.FromArgb(255, 50, 50, 50);
        public Color Light1 = Color.FromArgb(255, 213, 213, 213);
        public Color Light2 = Color.FromArgb(255, 230, 230, 230);
        public enum Languages { Arabic, English };
        public Languages language = Languages.English;
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
        public StorageForm()
        {
            InitializeComponent();
        }
        public void ChangeColor()
        {
            try
            {
                pnltop.BackColor = _BackColor;
                pnlcontainer.BackColor = _BackColor;
                dgvsales.HeaderBgColor = _BackColor;
                pnldgvsales.BackColor = _BackColor;

                if (json.Theme == "Dark")
                {
                    BackColor = Dark1;
                    pnltools.BackColor = Dark2;
                    txtmatrialname.BackColor = Dark2;
                    txtqty.BackColor = Dark2;
                    txtaddedqty.BackColor = Dark2;
                    txtprice.BackColor = Dark2;
                }
                else if (json.Theme == "Light")
                {
                    BackColor = Light1;
                    pnltools.BackColor = Light2;
                    txtqty.BackColor = Light2;
                    txtaddedqty.BackColor = Light2;
                    txtprice.BackColor = Light2;
                    txtmatrialname.BackColor = Light2;
                }
            }
            catch (Exception ex)
            {
                Error = true;
                lblerror.Text = "ChangeColor() " + ex.Message;
            }
        }
        public void FillData()
        {
            try
            {
                txtmatrialname._Text = "";
                txtprice._Text = "";
                txtqty._Text = "";
                txtaddedqty._Text = "";
                if (!Database) return;
                MatrialName = LoginForm.SalesTable.Rows[Counter]["Material_Name"];
                QTY = LoginForm.SalesTable.Rows[Counter]["QTY"];
                Price = LoginForm.SalesTable.Rows[Counter]["Price"];
                Warning = LoginForm.SalesTable.Rows[Counter]["Warning"];

                txtmatrialname._Text = Convert.ToString(MatrialName);
                txtqty._Text = Convert.ToString(QTY);
                txtprice._Text = Convert.ToString(Price);

                if (Warning.ToString().Trim().ToLower() == "true")
                    togglewarning.CheckState = CheckState.Checked;
                else if (Warning.ToString().Trim().ToLower() == "false")
                    togglewarning.CheckState = CheckState.Unchecked;
            }
            catch (Exception ex)
            {
                Error = true;
                lblerror.Text = "FillData() " + ex.Message;
            }
        }
        public void Filldgvsales()
        {
            try
            {
                dgvsales.Rows.Clear();
                if (!Database) return;
                dgvsales.Rows.Clear();
                for (int i = 0; i < LoginForm.SalesTable.Rows.Count; i++)
                {
                    object[] data = {
                    LoginForm.SalesTable.Rows[i]["Material_Name"]
                };
                    dgvsales.Rows.Add(data);
                }
            }
            catch (Exception ex)
            {
                Error = true;
                lblerror.Text = "Filldgvsales() " + ex.Message;
            }
        }
        public void EditeRow()
        {
            try
            {
                if (!Database) return;
                MatrialName = txtmatrialname._Text.Trim();
                Price = txtprice._Text.Trim();
                if (togglewarning.CheckState == CheckState.Checked)
                    Warning = true;
                else if (togglewarning.CheckState == CheckState.Unchecked)
                    Warning = false;
                LoginForm.SalesTable.Rows[Counter]["Material_Name"] = MatrialName;
                LoginForm.SalesTable.Rows[Counter]["Price"] = Price;
                LoginForm.SalesTable.Rows[Counter]["Warning"] = Warning;
                LoginForm.SalesAdapter.Update(LoginForm.SalesTable);
            }
            catch (Exception ex)
            {
                Error = true;
                lblerror.Text = "EditeRow() " + ex.Message;
            }
        }
        public void AddQTY()
        {
            try
            {
                if (!Database) return;
                if (txtaddedqty._Text.Trim() == "") return;
                else
                {
                    AddedQTY = txtaddedqty._Text.Trim();
                    double qty = (Convert.ToDouble(QTY) + Convert.ToDouble(AddedQTY));
                    LoginForm.SalesTable.Rows[Counter]["QTY"] = qty;
                    LoginForm.SalesAdapter.Update(LoginForm.SalesTable);
                }
            }
            catch (Exception ex)
            {
                Error = true;
                lblerror.Text = "AddQTY() " + ex.Message;
            }
        }
        public void AddNewItem()
        {
            try
            {

                if (!Database) return;
                bool AddNewItem = true;
                ID = LoginForm.SalesTable.Rows.Count + 1;
                MatrialName = txtmatrialname._Text.Trim();

                Price = txtprice._Text.Trim();
                QTY = txtqty._Text.Trim();
                if (togglewarning.CheckState == CheckState.Checked)
                {
                    Warning = true;
                }
                else if (togglewarning.CheckState == CheckState.Unchecked)
                {
                    Warning = false;
                }
                object[] row = new object[] { ID, MatrialName, QTY, Price, "Black", true, false, "White", Warning, ID };
                for (int i = 0; i < LoginForm.SalesTable.Rows.Count; i++)
                {
                    if (LoginForm.SalesTable.Rows[i]["Material_Name"].ToString() == MatrialName.ToString())
                    {
                        AddNewItem = false;
                        break;
                    }
                }
                if (!AddNewItem)
                {
                    lblerror.Text = "This Matrerial Is Already Added ";
                    return;
                }
                else
                {
                    LoginForm.SalesTable.Rows.Add(row);
                    LoginForm.SalesAdapter.Update(LoginForm.SalesTable);
                    Counter = LoginForm.SalesTable.Rows.Count - 1;
                }
            }
            catch (Exception ex)
            {
                Error = true;
                lblerror.Text = "AddNewItem() " + ex.Message;
            }
        }
        public void DeleteRow()
        {
            try
            {
                if (!Database) return;
                for (int i = Counter; i < LoginForm.SalesTable.Rows.Count - 1; i++)
                {
                    MessageBox.Show(LoginForm.SalesTable.Rows[i + 1]["Id"].ToString());
                    LoginForm.SalesTable.Rows[i]["Material_Name"] = LoginForm.SalesTable.Rows[i + 1]["Material_Name"];
                    LoginForm.SalesTable.Rows[i]["QTY"] = LoginForm.SalesTable.Rows[i + 1]["QTY"];
                    LoginForm.SalesTable.Rows[i]["Price"] = LoginForm.SalesTable.Rows[i + 1]["Price"];
                    LoginForm.SalesTable.Rows[i]["Color"] = LoginForm.SalesTable.Rows[i + 1]["Color"];
                    LoginForm.SalesTable.Rows[i]["Button"] = LoginForm.SalesTable.Rows[i + 1]["Button"];
                    LoginForm.SalesTable.Rows[i]["Border"] = LoginForm.SalesTable.Rows[i + 1]["Border"];
                    LoginForm.SalesTable.Rows[i]["Border_Color"] = LoginForm.SalesTable.Rows[i + 1]["Border_Color"];
                    LoginForm.SalesTable.Rows[i]["Warning"] = LoginForm.SalesTable.Rows[i + 1]["Warning"];
                    LoginForm.SalesTable.Rows[i]["Tool_Order"] = LoginForm.SalesTable.Rows[i + 1]["Tool_Order"];
                }
                int index = LoginForm.SalesTable.Rows.Count - 1;
                LoginForm.SalesTable.Rows[index].Delete();
                LoginForm.SalesAdapter.Update(LoginForm.SalesTable);
                LoginForm.FillSalesTable();
                Filldgvsales();
                Counter = 0;
            }
            catch (Exception ex)
            {
                Error = true;
                lblerror.Text = "DeleteRow() " + ex.Message;
            }
        }
        public void ChangeLanguage()
        {
            if (json.Language == "Arabic")
            {
                if (language == Languages.English)
                {
                    pnltools.RightToLeft = RightToLeft.Yes;
                    lbltitle.Location = new Point(pnltop.Width - lbltitle.Width - 5, 8);
                    btnexit.Location = new Point(5, 1);
                    btnrestart.Location = new Point(43, 1);
                    lblmatrialname.Location = new Point(323, 12);
                    lblqty.Location = new Point(342, 85);
                    lblprice.Location = new Point(341, 167);
                    lbladdedqty.Location = new Point(297, 239);
                    foreach (Control control in pnltools.Controls)
                    {
                        string name = Convert.ToString(control.Tag);
                        control.Tag = control.Text;
                        control.Text = name;
                    }
                    lbltitle.Text = ArabicNames[0];
                    colname.HeaderText = ArabicNames[1];
                    language = Languages.Arabic;
                }
            }
            else if (json.Language == "Englihs")
            {
                if (language == Languages.Arabic)
                {
                    pnltools.RightToLeft = RightToLeft.No;
                    lbltitle.Location = new Point(5, 8);
                    btnexit.Location = new Point(562, 1);
                    btnrestart.Location = new Point(524, 1);
                    lblmatrialname.Location = new Point(12, 12);
                    lblqty.Location = new Point(12, 85);
                    lblprice.Location = new Point(12, 167);
                    lbladdedqty.Location = new Point(143, 239);
                    foreach (Control control in pnltools.Controls)
                    {
                        string name = Convert.ToString(control.Tag);
                        control.Tag = control.Text;
                        control.Text = name;
                    }
                    lbltitle.Text = EnglishNames[0];
                    colname.HeaderText = EnglishNames[1];
                    language = Languages.English;
                }
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
        private void StorageForm_Load(object sender, EventArgs e)
        {
            try
            {
                Database = LoginForm.DataBase;
                Loading = true;
                json = MainForm.json;
                _BackColor = LoginForm.MainColor[json.MainColorNum];
                ChangeColor();
                ChangeLanguage();
                backworker.RunWorkerAsync();
                Filldgvsales();
                FillData();
            }
            catch (Exception ex)
            {
                Error = true;
                lblerror.Invoke((MethodInvoker)delegate
                {
                    lblerror.Text = "Load() " + ex.Message;
                });
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
            }
            catch (Exception ex)
            {
                Error = true;
                lblerror.Text = "DgvClick() " + ex.Message;
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
            }
            catch (Exception ex)
            {
                Error = true;
                lblerror.Text = "First() " + ex.Message;
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
            }
            catch (Exception ex)
            {
                Error = true;
                lblerror.Text = "Last() " + ex.Message;
            }
        }
        private void btnedite_Click(object sender, EventArgs e)
        {
            try
            {
                if (Loading) return;
                if (Error) return;
                EditeRow();
                FillData();
                Filldgvsales();
                LoginForm.CheckForLowQTYs();
            }
            catch (Exception ex)
            {
                Error = true;
                lblerror.Text = "Edite()" + ex.Message;
            }
        }
        private void btnaddqty_Click(object sender, EventArgs e)
        {
            try
            {
                if (Loading) return;
                if (Error) return;
                AddQTY();
                FillData();
                Filldgvsales();
                txtaddedqty._Text = "";
                LoginForm.CheckForLowQTYs();
            }
            catch (Exception ex)
            {
                Error = true;
                lblerror.Text = "AddQty" + ex.Message;
            }
        }
        private void btnclear_Click(object sender, EventArgs e)
        {
            if (Loading) return;
            Counter = 0;
            txtmatrialname._Text = "";
            txtprice._Text = "";
            txtqty._Text = "";
            txtaddedqty._Text = "";
            togglewarning.CheckState = CheckState.Unchecked;
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                if (Loading) return;
                if (Error) return;
                AddNewItem();
                FillData();
                Filldgvsales();
            }
            catch (Exception ex)
            {
                Error = true;
                lblerror.Text = "Add() " + ex.Message;
            }
        }
        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (Loading) return;
                if (Error) return;
                DeleteRow();
                FillData();
                Filldgvsales();
            }
            catch (Exception ex)
            {
                Error = true;
                lblerror.Text = "Delete() " + ex.Message;
            }
        }
        private void txtqty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && (!char.IsPunctuation(e.KeyChar))) e.Handled = true;
        }
        private void txtprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && (!char.IsPunctuation(e.KeyChar))) e.Handled = true;
        }
        private void txtaddedqty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && (!char.IsPunctuation(e.KeyChar))) e.Handled = true;
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnaddqty.PerformClick();
            }
        }
        private void btnrestart_Click(object sender, EventArgs e)
        {
            try
            {
                if (Loading) return;
                this.Close();
                Thread.Sleep(1000);
                LoginForm.StorageForm1 = new StorageForm();
                LoginForm.StorageForm1.Show();
            }
            catch (Exception ex)
            {
                Error = true;
                lblerror.Text = "Restart() " + ex.Message;
            }
        }
        private void backworker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            try
            {
                pnlcontainer.Invoke((MethodInvoker)delegate
                {
                    pnlcontainer.Visible = true;
                });
                Thread.Sleep(75);
                btnaddqty.Invoke((MethodInvoker)delegate
                {
                    btnaddqty.Visible = true;
                });
                Thread.Sleep(75);
                btnlastone.Invoke((MethodInvoker)delegate
                {
                    btnlastone.Visible = true;
                });
                Thread.Sleep(75);
                btnfirstone.Invoke((MethodInvoker)delegate
                {
                    btnfirstone.Visible = true;
                });
                Thread.Sleep(75);
                btnnext.Invoke((MethodInvoker)delegate
                {
                    btnnext.Visible = true;
                });
                Thread.Sleep(75);
                btnback.Invoke((MethodInvoker)delegate
                {
                    btnback.Visible = true;
                });
                Thread.Sleep(75);
                btnedite.Invoke((MethodInvoker)delegate
                {
                    btnedite.Visible = true;
                });
                Thread.Sleep(75);
                btnclear.Invoke((MethodInvoker)delegate
                {
                    btnclear.Visible = true;
                });
                Thread.Sleep(75);
                btnadd.Invoke((MethodInvoker)delegate
                {
                    btnadd.Visible = true;
                });
                Thread.Sleep(75);
                btndelete.Invoke((MethodInvoker)delegate
                {
                    btndelete.Visible = true;
                });
                Thread.Sleep(500);
                Loading = false;
            }
            catch (Exception ex)
            {
                Loading = false;
                Error = true;
                lblerror.Invoke((MethodInvoker)delegate
                {
                    lblerror.Text = "BackWorker() " + ex.Message;
                });
            }
        }
        #endregion
    }
}
