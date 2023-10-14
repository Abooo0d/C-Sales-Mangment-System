using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using AboodTools_v5;
using Sales_v3.Class;


namespace Sales_v3.Forms
{
    public partial class AccountsForm : Form
    {
        //Fildes
        #region Fieldes
        public bool Database = false;
        public bool Loading = false;
        public static DataServices json = new DataServices();
        public Color _BackColor = new Color();
        public bool Dragging = false;
        public Point StartPoint = new Point(0, 0);
        public int Managers = 0;
        public int Accountant = 0;
        public AboodButton[] MangersArray = new AboodButton[2];
        public AboodButton[] AccountantArray = new AboodButton[4];
        public int ManagerY = 0;
        public int ManagerX = 30;
        public int ManagerCount = 0;
        public int AccountantY = 0;
        public int AccountantX = 30;
        public int AccountantCount = 0;
        public int Counter = 0;
        public string Id, EmployeeName, UserName, Password, AccountType;
        public bool Out = false;
        public bool Edite = false;
        public bool Error = false;
        public string[] ArabicNames = new string[3] {  "الحسابات","المدراء", "المحاسبين" };
        public string[] EnglishNames = new string[3] { "Accounts","Managers", "Accountants" };
        public Color Dark1 = Color.FromArgb(255, 43, 43, 43);
        public Color Dark2 = Color.FromArgb(255, 50, 50, 50);
        public Color Light1 = Color.FromArgb(255, 213, 213, 213);
        public Color Light2 = Color.FromArgb(255, 230, 230, 230);
        public enum Languages { Arabic, English };
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
        public AccountsForm()
        {
            InitializeComponent();
        }
        public void GetAccounts()
        {
            try
            {
                pnlmanagertools.Controls.Clear();
                pnlaccountanttools.Controls.Clear();
                cbxname.Items.Clear();
                ManagerY = 0;
                ManagerX = 30;
                ManagerCount = 0;
                AccountantY = 0;
                AccountantX = 30;
                AccountantCount = 0;
                if (!Database) return;
                else
                {
                    for (int i = 0; i < LoginForm.EmployeesTable.Rows.Count; i++)
                    {
                        bool add = false;
                        for (int x = 0; x < LoginForm.AccountsTable.Rows.Count; x++)
                        {
                            if (Convert.ToString(LoginForm.EmployeesTable.Rows[i]["F_Name"]).Trim() == Convert.ToString(LoginForm.AccountsTable.Rows[x]["Name"]).Trim())
                            {
                                add = true;
                                break;
                            }
                            else
                            { add = false; }
                        }
                        if (!add)
                        {
                            cbxname.Invoke((MethodInvoker)delegate
                            {
                                cbxname.Items.Add(Convert.ToString(LoginForm.EmployeesTable.Rows[i]["F_Name"]));
                            });
                        }
                    }
                    if (LoginForm.AccountsTable.Rows.Count == 0) return;
                    else
                    {
                        for (int i = 0; i < LoginForm.AccountsTable.Rows.Count; i++)
                        {
                            if (Convert.ToString(LoginForm.AccountsTable.Rows[i]["Account_Type"]) == "Manager")
                            {
                                AboodButton btnmanager = new AboodButton
                                {
                                    Tag = i,
                                    Text = Convert.ToString(LoginForm.AccountsTable.Rows[i]["Name"]),
                                    BackColor = Color.FromArgb(255, 50, 50, 50),
                                    ForeColor = Color.White,
                                    BorderColor = Color.Crimson,
                                    BorderRadius = 10,
                                    BorderSize = 2,
                                    Size = new Size(120, 100),
                                };
                                btnmanager.Click += delegate { BtnEvent(btnmanager); };
                                if (json.Theme == "Dark")
                                {
                                    btnmanager.ForeColor = Light2;
                                    btnmanager.BackColor = Dark2;
                                }
                                else if (json.Theme == "Light")
                                {
                                    btnmanager.ForeColor = Dark2;
                                    btnmanager.BackColor = Light2;
                                }
                                pnlmanagertools.Invoke((MethodInvoker)delegate
                                {
                                    pnlmanagertools.Controls.Add(btnmanager);
                                });
                                btnmanager.Invoke((MethodInvoker)delegate
                                {
                                    btnmanager.Location = new Point(ManagerX, ManagerY);
                                    btnmanager.BringToFront();
                                });
                                ManagerX += 132;
                                ManagerCount += 1;
                                if (ManagerCount == 3)
                                {
                                    ManagerX = 30;
                                    ManagerY += 112;
                                    ManagerCount = 0;
                                }
                                Thread.Sleep(100);
                            }
                            else if (Convert.ToString(LoginForm.AccountsTable.Rows[i]["Account_Type"]) == "Accountant")
                            {
                                AboodButton btnaccountant = new AboodButton
                                {
                                    Tag = i,
                                    Text = Convert.ToString(LoginForm.AccountsTable.Rows[i]["Name"]),
                                    BackColor = Color.FromArgb(255, 50, 50, 50),
                                    ForeColor = Color.White,
                                    BorderColor = Color.DarkOrange,
                                    BorderRadius = 10,
                                    BorderSize = 2,
                                    Size = new Size(87, 60),
                                };
                                btnaccountant.Click += delegate { BtnEvent(btnaccountant); };
                                if (json.Theme == "Dark")
                                {
                                    btnaccountant.ForeColor = Light2;
                                    btnaccountant.BackColor = Dark2;
                                }
                                else if (json.Theme == "Light")
                                {
                                    btnaccountant.ForeColor = Dark2;
                                    btnaccountant.BackColor = Light2;
                                }
                                pnlaccountanttools.Invoke((MethodInvoker)delegate
                                { 
                                    pnlaccountanttools.Controls.Add(btnaccountant);
                                });
                                btnaccountant.Invoke((MethodInvoker)delegate
                                {
                                    btnaccountant.Location = new Point(AccountantX, AccountantY);
                                    btnaccountant.BringToFront();
                                });
                                AccountantX += 99;
                                AccountantY += 1;
                                if (AccountantCount == 4)
                                {
                                    AccountantY += 72;
                                    AccountantX = 30;
                                    AccountantCount = 0;
                                }
                                Thread.Sleep(100);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Error = true;
                lblerror.Invoke((MethodInvoker)delegate {
                    lblerror.Text = "GetAccount() " + ex.Message;
                });
            }
        }
        public void BtnEvent(AboodButton btnaccount)
        {
            try
            {
                if (Error) return;
                Out = false;
                Counter = Convert.ToInt32(btnaccount.Tag);
                FillData();
            }
            catch (Exception ex)
            {
                Error = true;
                lblerror.Invoke((MethodInvoker)delegate
                {
                    lblerror.Text = "BtnEvent() " + ex.Message;
                });
            }
        }
        public void FillData()
        {
            try
            {
                if (!Database) return;
                if (LoginForm.AccountsTable.Rows.Count == 0) return;
                if (Out) return;
                Id = Convert.ToString(LoginForm.AccountsTable.Rows[Counter]["Id"]);
                EmployeeName = Convert.ToString(LoginForm.AccountsTable.Rows[Counter]["Name"]);
                UserName = Convert.ToString(LoginForm.AccountsTable.Rows[Counter]["User_Name"]);
                Password = Convert.ToString(LoginForm.AccountsTable.Rows[Counter]["Password"]);
                AccountType = Convert.ToString(LoginForm.AccountsTable.Rows[Counter]["Account_Type"]);
                txtid._Text = Convert.ToString(Id);
                cbxname.Text = EmployeeName;
                txtusername._Text = UserName;
                txtpassword._Text = Password;
                cbxaccounttype.Text = AccountType;
                ChangeAccountColor();
            }
            catch (Exception ex)
            {
                Error = true;
                lblerror.Invoke((MethodInvoker)delegate
                {
                    lblerror.Text = "FillData() " + ex.Message;
                });
            }
        }
        public void ChangeAccountColor()
        {
            try
            {
                if (Error) return;
                if (!Database) return;
                if (LoginForm.AccountsTable.Rows.Count == 0) return;
                if (Out)
                {
                    foreach (AboodButton btn in pnlmanagertools.Controls)
                    {
                        btn.BorderColor = Color.Crimson;
                    }
                    foreach (AboodButton btn in pnlaccountanttools.Controls)
                    {
                        btn.BorderColor = Color.DarkOrange;
                    }
                }
                else
                {
                    foreach (AboodButton btn in pnlmanagertools.Controls)
                    {
                        if (Convert.ToInt32(btn.Tag) == Counter)
                            btn.BorderColor = _BackColor;
                        else
                            btn.BorderColor = Color.Crimson;
                    }
                    foreach (AboodButton btn in pnlaccountanttools.Controls)
                    {
                        if (Convert.ToInt32(btn.Tag) == Counter)
                            btn.BorderColor =_BackColor;
                        else
                            btn.BorderColor = Color.DarkOrange;

                    }
                }
            }
            catch (Exception ex)
            {
                Error = true;
                lblerror.Invoke((MethodInvoker)delegate
                {
                    lblerror.Text = "ChangeAccountColor() " + ex.Message;
                });
            }
        }
        public void ClearInfo()
        {
            txtid._Text = "";
            cbxname.Text = "";
            txtusername._Text = "";
            txtpassword._Text = "";
            cbxaccounttype.Text = "";
        }
        public bool FillVars()
        {
            try
            {
                if (Error) return false;
                lblerror.Text = "";
                if (!Database) return false;
                if (Edite)
                {
                    EmployeeName = Convert.ToString(cbxname.Text);
                }
                else
                {
                    if (cbxname.SelectedIndex <= -1)
                    {
                        lblerror.Text = " Plese Fill All The Fields!";
                        return false;
                    }
                    else
                    {
                        EmployeeName = Convert.ToString(cbxname.SelectedItem);
                    }
                }
                if (txtusername._Text.Trim() != "")
                    UserName = txtusername._Text;
                else
                {
                    lblerror.Text = " Plese Fill All The Fields!";
                    return false;
                }
                if (txtpassword._Text.Trim() != "")
                    Password = txtpassword._Text;
                else
                {
                    lblerror.Text = " Plese Fill All The Fields!";
                    return false;
                }
                if (cbxaccounttype.SelectedIndex != -1)
                    AccountType = Convert.ToString(cbxaccounttype.SelectedItem);
                else
                {
                    lblerror.Text = " Plese Fill All The Fields!";
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                Error = true;
                lblerror.Text = "FillVars()" + ex.Message;
                return false;
            }
        }
        public void ChangeColor()
        {
            pnltop.BackColor = _BackColor;
            pnlcontainer.BackColor = _BackColor;
            pnlcontainermanager.BackColor = _BackColor;
            pnlcontaineraccountant.BackColor = _BackColor;
            pnlcontainerinfo.BackColor = _BackColor;
            if (json.Theme == "Dark")
            {
                BackColor = Dark1;
                pnlmain.BackColor = Dark2;
                pnlmanagers.BackColor = Dark1;
                pnlmanagertools.BackColor = Dark1;
                pnlaccountants.BackColor = Dark1;
                pnlaccountanttools.BackColor = Dark1;
                pnlinfo.BackColor = Dark1;
                txtid.BackColor = Dark1;
                cbxname.BackColor = Dark1;
                cbxaccounttype.BackColor = Dark1;
                txtusername.BackColor = Dark1;
                txtpassword.BackColor = Dark1;
            }
            else if(json.Theme == "Light")
            {
                BackColor = Light1;
                pnlmain.BackColor = Light2;
                pnlmanagers.BackColor = Light1;
                pnlmanagertools.BackColor = Light1;
                pnlaccountants.BackColor = Light1;
                pnlaccountanttools.BackColor = Light1;
                pnlinfo.BackColor = Light1;
                txtid.BackColor = Color.FromArgb(255, 213, 213, 213);
                cbxname.BackColor = Color.FromArgb(255, 213, 213, 213);
                cbxaccounttype.BackColor = Color.FromArgb(255, 213, 213, 213);
                txtusername.BackColor = Color.FromArgb(255, 213, 213, 213);
                txtpassword.BackColor = Color.FromArgb(255, 213, 213, 213);
            }
        }
        public void ChangeLanguage()
        {
            if (json.Language == "Arabic")
            {
                if (language == Languages.English)
                {
                    pnltop.RightToLeft = RightToLeft.Yes;
                    pnlinfo.RightToLeft = RightToLeft.Yes;
                    pnlmanagers.RightToLeft = RightToLeft.Yes;
                    pnlaccountants.RightToLeft = RightToLeft.Yes;
                    lbltitle.Text = ArabicNames[0];
                    lblmanagers.Text = ArabicNames[1];
                    lblaccountants.Text = ArabicNames[2];
                    lbltitle.Location = new Point(pnltop.Width - lbltitle.Width - 5, 8);
                    btnexit.Location = new Point(5, 1);
                    btnrestart.Location = new Point(43, 1);
                    lblmanagers.Location = new Point(389, 12);
                    lblaccountants.Location = new Point(376, 12);
                    lblaccountsinfo.Location = new Point(194, 12);
                    lblid.Location = new Point(218, 51);
                    lblname.Location = new Point(98, 51);
                    lblaccounttype.Location = new Point(215, 133);
                    lblusername.Location = new Point(213, 221);
                    lblpassword.Location = new Point(218, 309);
                    foreach (Control control in pnlinfo.Controls)
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
                    pnltop.RightToLeft = RightToLeft.No;
                    pnlinfo.RightToLeft = RightToLeft.No;
                    pnlmanagers.RightToLeft = RightToLeft.No;
                    pnlaccountants.RightToLeft = RightToLeft.No;
                    lbltitle.Text = EnglishNames[0];
                    lblmanagers.Text = EnglishNames[1];
                    lblaccountants.Text = EnglishNames[2];
                    lblaccountants.Location = new Point(12, 12);
                    lblaccountsinfo.Location = new Point(12, 12);
                    lblid.Location = new Point(188, 51);
                    lblname.Location = new Point(12, 51);
                    lblaccounttype.Location = new Point(12, 133);
                    lblusername.Location = new Point(12, 221);
                    lblpassword.Location = new Point(12, 309);
                    foreach (Control control in pnlinfo.Controls)
                    {
                        string name = Convert.ToString(control.Tag);
                        control.Tag = control.Text;
                        control.Text = name;
                    }
                    language = Languages.English;
                }
            }
        }
        public void DeleteRow()
        {
            try
            {
                if (!Database) return;
                for (int i = Counter; i < LoginForm.AccountsTable.Rows.Count - 1; i++)
                {
                    LoginForm.SalesTable.Rows[i]["Name"] = LoginForm.SalesTable.Rows[i + 1]["Name"];
                    LoginForm.SalesTable.Rows[i]["User_Name"] = LoginForm.SalesTable.Rows[i + 1]["User_Name"];
                    LoginForm.SalesTable.Rows[i]["Password"] = LoginForm.SalesTable.Rows[i + 1]["Password"];
                    LoginForm.SalesTable.Rows[i]["Account_Type"] = LoginForm.SalesTable.Rows[i + 1]["Account_Type"];
                }
                int index = LoginForm.AccountsTable.Rows.Count - 1;
                LoginForm.AccountsTable.Rows[index].Delete();
                LoginForm.AccountsAdapter.Update(LoginForm.AccountsTable);
                LoginForm.FillAccountsTable();
                Counter = 0;
            }
            catch (Exception ex)
            {
                Error = true;
                lblerror.Text = "DeleteRow() " + ex.Message;
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
        private void pnltop_MouseMove(object sender, MouseEventArgs e)
        {
            if (Dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - StartPoint.X, p.Y - StartPoint.Y);
            }
        }
        private void pnltop_MouseUp(object sender, MouseEventArgs e)
        {
            Dragging = false;
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
        private void AccountsForm_Load(object sender, EventArgs e)
        {
            try
            {
                Loading = true;
                Database = LoginForm.DataBase;
                json = MainForm.json;
                _BackColor = LoginForm.MainColor[json.MainColorNum];
                ChangeColor();
                ChangeLanguage();
                backworker.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                Loading = false;
                Error = true;
                lblerror.Invoke((MethodInvoker)delegate
                {
                    lblerror.Text = "Load() " + ex.Message;
                });
            }
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            try {
                if (Loading) return;
                if (Error) return;
                if (!Database) return;
                if (FillVars())
                {
                    Id = Convert.ToString(LoginForm.AccountsTable.Rows.Count + 1);
                    object[] row = new object[]
                    {Id,EmployeeName,UserName,Password,AccountType };
                    LoginForm.AccountsTable.Rows.Add(row);
                    LoginForm.AccountsAdapter.Update(LoginForm.AccountsTable);
                    Counter = LoginForm.AccountsTable.Rows.Count - 1;
                    Out = false;
                    GetAccounts();
                    FillData();
                    LoginForm.Empty = false;
                }
            }

            catch (Exception ex)
            {
                Error = true;
                lblerror.Text = "Add() " + ex.Message;
            }
        }
        private void btnedit_Click(object sender, EventArgs e)
        {
            try
            {
                if (Loading) return;
                if (Error) return;
                Edite = true;
                if (FillVars())
                {
                    LoginForm.AccountsTable.Rows[Counter]["Name"] = EmployeeName;
                    LoginForm.AccountsTable.Rows[Counter]["User_Name"] = UserName;
                    LoginForm.AccountsTable.Rows[Counter]["Password"] = Password;
                    LoginForm.AccountsTable.Rows[Counter]["Account_Type"] = AccountType;
                    LoginForm.AccountsAdapter.Update(LoginForm.AccountsTable);
                    Out = false;
                    GetAccounts();
                    FillData();
                }
                Edite = false;
            }
            catch (Exception ex)
            {
                Edite = false;
                Error = true;
                lblerror.Text = "Edite() " + ex.Message;
            }
        }
        private void btnclear_Click(object sender, EventArgs e)
        {
            try
            {
                if (Loading) return;
                if (Error) return;
                Out = true;
                ClearInfo();
                ChangeAccountColor();
            }
            catch (Exception ex)
            {
                Error = true;
                lblerror.Text = "Clear() " + ex.Message;
            }
        }
        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (Loading) return;
                if (Error) return;
                if (Error) return;
                if (!LoginForm.DataBase) return;
                if (LoginForm.AccountsTable.Rows.Count == 0) return;
                DeleteRow();
                Out = true;
                ClearInfo();
                Counter = 0;
                GetAccounts();
                FillData();
                if (LoginForm.AccountsTable.Rows.Count == 0)
                {
                    LoginForm.Empty = true;
                    return;
                }
            }
            catch (Exception ex)
            {
                Error = true;
                lblerror.Text = "Delete() " + ex.Message;
            }
        }
        private void txtid_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void btnrestart_Click(object sender, EventArgs e)
        {
            try
            {
                if (Loading) return;
                this.Close();
                Thread.Sleep(1000);
                LoginForm.AccountsForm1 = new AccountsForm();
                LoginForm.AccountsForm1.Show();
            }
            catch (Exception ex)
            {
                Error = true;
                lblerror.Text = "Restart() " + ex.Message;
            }
        }
        private void cbxname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Loading) return;
            if (e.KeyChar == (char)Keys.Enter)
            {
                cbxaccounttype.Select();
                cbxaccounttype.Focus();
            }
            else
            {
                e.Handled = true;
            }
        }
        private void cbxaccounttype_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Loading) return;
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtusername.Select();
                txtusername.Focus();
            }
            else
            {
                e.Handled = true;
            }
        }
        private void txtusername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Loading) return;
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtpassword.Select();
                txtpassword.Focus();
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
                Thread.Sleep(200);
                pnlcontainermanager.Invoke((MethodInvoker)delegate
                {
                    pnlcontainermanager.Visible = true;
                });
                Thread.Sleep(200);
                pnlcontaineraccountant.Invoke((MethodInvoker)delegate
                {
                    pnlcontaineraccountant.Visible = true;
                });
                Thread.Sleep(200);
                pnlcontainerinfo.Invoke((MethodInvoker)delegate
                {
                    pnlcontainerinfo.Visible = true;
                });
                Thread.Sleep(200);
                Out = true;
                GetAccounts();
                Thread.Sleep(500);
                Loading = false;
            }
            catch (Exception ex)
            {
                Loading = false;
                lblerror.Invoke((MethodInvoker)delegate {
                    lblerror.Text = "BackWorker() " + ex.Message;
                });
            }
        }
        #endregion
    }
}
