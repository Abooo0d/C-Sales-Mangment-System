using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Data.SqlClient;
using System.Data;
using System.ComponentModel;
using Sales_v3.Class;
using static Sales_v3.Class.JsonServices;

namespace Sales_v3.Forms
{
    public partial class LoginForm : Form
    {
        //Fildes
        #region Fields
        public static DataServices json = new DataServices();
        public static PrintingServcies printing = new PrintingServcies();
        public static string DataRoot = "Data.json";
        public static string PrintingRoot = "printing.json";
        public static string UserName;
        public static string Password;
        public static bool Empty = false;
        public static bool DataBase = false;
        public static bool Error = false;
        public bool Working = false;
        public int Progress = 0;
        public static bool[] IsFinshed = { false, false, false, false, false };
        public Point StartPoint = new Point(0, 0);
        public bool Dragging = false;
        public bool ShowPassword = false;
        public static SqlConnection SalesConnections;
        public static SqlDataAdapter SalesAdapter;
        public static SqlDataAdapter EmployeesAdapter;
        public static SqlDataAdapter AccountsAdapter;
        public static SqlCommandBuilder SalesCommand = new SqlCommandBuilder();
        public static SqlCommandBuilder EmployeesCommand = new SqlCommandBuilder();
        public static SqlCommandBuilder AccountsCommand = new SqlCommandBuilder();
        public static DataTable SalesTable;
        public static DataTable EmployeesTable;
        public static DataTable AccountsTable;
        public static int WarningsNum;
        public static List<string> Warnings = new List<string>();
        public static Color[] MainColor = {
            Color.FromArgb(255,0,126,255),
            Color.FromArgb(255, 220, 220, 0),
            Color.FromArgb(255, 0, 210, 91),
            Color.FromArgb(255,220,20,70),
            Color.FromArgb(255,255,0,255),
            Color.FromArgb(255,255,140,0)
        };
        public string DefulteUserame = "Admin";
        public string DefultePassword = "0000";
        public enum Languages { Arabic, English };

        public enum AccountType
        {
            Accountant,
            Manager,
            Defult
        };
        public static AccountType Account = AccountType.Accountant;
        public static Languages language = Languages.English;
        public Color Dark1 = Color.FromArgb(255, 43, 43, 43);
        public Color Dark2 = Color.FromArgb(255, 50, 50, 50);
        public Color Light1 = Color.FromArgb(255, 213, 213, 213);
        public Color Light2 = Color.FromArgb(255, 230, 230, 230);
        public Color _BackColor = new Color();


        //Forms
        public static MainForm MainForm1 = new MainForm();
        public static SalePointForm SalePointForm1 = new SalePointForm();
        public static ToolsMangmentForms ToolsMangmentForms1 = new ToolsMangmentForms();
        public static StorageForm StorageForm1 = new StorageForm();
        public static SettingsForm SettingsForm1 = new SettingsForm();
        public static EmployeesForm EmployeesForm1 = new EmployeesForm();
        public static AccountsForm AccountsForm1 = new AccountsForm();
        public static PrintingForm PrintingForm1 = new PrintingForm();

        //Threads
        Thread ThreadGetSalesAndTheme = new Thread(GetSalesAndTheme);
        Thread ThreadCreatConnection = new Thread(CreatConnection);
        public static Thread ThreadGetData = new Thread(FillSalesTable);

        //Tools
        public static Label lblerror = new Label();

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
        public LoginForm()
        {
            InitializeComponent();
        }
        public static void GetSalesAndTheme()
        {
            bool[] good = new bool[] { false, false };
            try
            {
                if (File.Exists(DataRoot))
                {
                    ReadDataFile(ref json, DataRoot);
                    good[0] = true;
                }
                if (File.Exists(PrintingRoot))
                {
                    ReadPrintingFile(ref printing, PrintingRoot);
                    good[1] = true;
                }
                if (good[0] && good[1])
                    IsFinshed[0] = true;
                else
                    IsFinshed[0] = false;
            }
            catch (Exception ex)
            {
                IsFinshed[0] = true;
                lblerror.Invoke((MethodInvoker)delegate
                {
                    lblerror.Text = "GetSalesAndTeme()" + ex.Message;
                });
            }
        }
        public static void CreatConnection()
        {
            try
            {
                if (json.DataBaseRoot == "")
                {
                    IsFinshed[1] = true;
                    DataBase = false;
                    return;
                }
                else
                {
                    if (File.Exists(json.DataBaseRoot))
                    {
                        DataBase = true;

                        SalesConnections = new SqlConnection
                            (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="
                                     + json.DataBaseRoot + ";Integrated Security = True");
                        SalesConnections.Open();
                        Thread.Sleep(1000);
                        IsFinshed[1] = true;
                    }
                    else
                    {
                        DataBase = false;
                        IsFinshed[1] = true;
                    }
                }
            }
            catch (Exception ex)
            {
                IsFinshed[1] = true;
                Error = true;
                DataBase = false;
                lblerror.Invoke((MethodInvoker)delegate
                {
                    lblerror.Text = "CreatConection() " + ex.Message;
                });
            }
        }
        public static void FillSalesTable()
        {
            //Sales
            try
            {
                if (!DataBase)
                {
                    IsFinshed[2] = true;
                    return;
                }
                SalesAdapter = new SqlDataAdapter("select * from Sales", SalesConnections);
                SalesCommand = new SqlCommandBuilder(SalesAdapter);
                SalesTable = new DataTable();
                SalesAdapter.Fill(SalesTable);
                IsFinshed[2] = true;

            }
            catch (Exception ex)
            {
                IsFinshed[2] = true;
                lblerror.Invoke((MethodInvoker)delegate
                {
                    lblerror.Text = "FillSalesTable() " + ex.Message;
                });
            }
        }
        public static void FillAccountsTable()
        {
            //Accounts
            try
            {
                if (!DataBase)
                {
                    IsFinshed[4] = true;
                    return;
                }
                Empty = false;
                AccountsAdapter = new SqlDataAdapter("select * from Accounts", SalesConnections);
                AccountsCommand = new SqlCommandBuilder(AccountsAdapter);
                AccountsTable = new DataTable();
                AccountsAdapter.Fill(AccountsTable);
                if (AccountsTable.Rows.Count <= 0)
                    Empty = true;
                else
                    Empty = false;
                IsFinshed[4] = true;

            }
            catch (Exception ex)
            {
                Empty = false;
                IsFinshed[4] = true;
                lblerror.Invoke((MethodInvoker)delegate
                {
                    lblerror.Text = "FillAccountsTable() " + ex.Message;
                });
            }
        }
        public static void FillEmployeesTable()
        {
            //Employees
            try
            {
                if (!DataBase)
                {
                    IsFinshed[3] = true;
                    return;
                }
                EmployeesAdapter = new SqlDataAdapter("select * from Employees", SalesConnections);
                EmployeesCommand = new SqlCommandBuilder(EmployeesAdapter);
                EmployeesTable = new DataTable();
                EmployeesAdapter.Fill(EmployeesTable);
                IsFinshed[3] = true;
            }
            catch (Exception ex)
            {
                lblerror.Invoke((MethodInvoker)delegate
                {
                    IsFinshed[3] = true;
                    lblerror.Text = "FillEmployeesTable() " + ex.Message;
                });
            }
        }
        public static bool CheckAccount(string user, string password)
        {
            try
            {
                for (int i = 0; i < AccountsTable.Rows.Count; i++)
                {
                    if (user.Trim() == Convert.ToString(AccountsTable.Rows[i]["User_Name"]))
                    {
                        if (password.Trim() == Convert.ToString(AccountsTable.Rows[i]["Password"]))
                        {
                            if (Convert.ToString(AccountsTable.Rows[i]["Account_Type"]) == "Accountant")
                                Account = AccountType.Accountant;
                            else if (Convert.ToString(AccountsTable.Rows[i]["Account_Type"]) == "Manager")
                                Account = AccountType.Manager;
                            return true;
                        }
                    }
                }
                return false;
            }
            catch (Exception ex)
            {

                lblerror.Invoke((MethodInvoker)delegate
                {
                    lblerror.Text = "CheckAccount() " + ex.Message;
                });
                return false;
            }
        }
        public void ChangeColor()
        {
            pnltop.BackColor = _BackColor;
            pnlcontainer.BackColor = _BackColor;
            mainprogress.SliderColor = _BackColor;
            btnstartconection.BorderColor = _BackColor;
            btnstartconection.ForeColor = Color.White;
            if (json.Theme == "Dark")
            {
                BackColor = Dark1;
                pnltools.BackColor = Dark2;
                txtusername.BackColor = Dark2;
                txtpassword.BackColor = Dark2;
                btnstartconection.BackColor = Dark2;
                btnstartconection.ForeColor = Light2;
                mainprogress.BackColor = Dark2;

            }
            else if (json.Theme == "Light")
            {
                BackColor = Light1;
                pnltools.BackColor = Light2;
                txtusername.BackColor = Light2;
                txtpassword.BackColor = Light2;
                btnstartconection.BackColor = Light2;
                btnstartconection.ForeColor = Dark1;
                mainprogress.BackColor = Light2;
            }
        }
        public void ClearTools()
        {
            txtusername._Text = "";
            txtpassword._Text = "";
            txtusername.Focus();
            lblerror.Text = "";
        }
        public static void CheckForLowQTYs()
        {
            try
            {
                if (!DataBase) return;
                WarningsNum = 0;
                Warnings.Clear();
                for (int i = 0; i < SalesTable.Rows.Count; i++)
                {
                    double qty = Convert.ToDouble(SalesTable.Rows[i]["QTY"]);
                    string warning = Convert.ToString(SalesTable.Rows[i]["Warning"]).ToLower();
                    if (warning == "true")
                    {
                        if (qty <= 10)
                        {
                            WarningsNum++;
                            object Matrial = SalesTable.Rows[i]["Material_Name"];
                            Warnings.Add(Matrial + ";" + qty);
                        }
                    }
                    else { }
                }
            }
            catch (Exception ex)
            {
                lblerror.Invoke((MethodInvoker)delegate
                {
                    lblerror.Text = "CheckForLowQTYs() " + ex.Message;
                });
            }
        }
        public void GetThingsRady()
        {
            try
            {
                if (Empty)
                {
                    btnsignup.Visible = true;
                    btnsignin.Enabled = false;
                    btnsignup.Focus();
                }
                else
                {
                    btnsignup.Visible = false;
                    btnsignin.Enabled = true;
                }
                if (!DataBase)
                {
                    lblerror.Invoke((MethodInvoker)delegate
                    {
                        lblerror.Text = "No DataBaseDetacted, Login With The Defulte Accounts!!";
                    });
                }
                pnlcontainer.Invoke((MethodInvoker)delegate
                {
                    pnlcontainer.Visible = true;
                });
                Thread.Sleep(200);
                txtusername.Invoke((MethodInvoker)delegate
                {
                    txtusername.Focus();
                });
            }
            catch (Exception ex)
            {
                lblerror.Invoke((MethodInvoker)delegate
                {
                    lblerror.Text = "GetThingsRady() " + ex.Message;
                });
            }

        }
        public void ChangeLanguage()
        {
            if (json.Language == "Arabic")
            {
                if (language == Languages.English)
                {
                    pnltop.RightToLeft = RightToLeft.Yes;
                    pnltools.RightToLeft = RightToLeft.Yes;
                    lbltitel.Location = new Point(317, 8);
                    btnexit.Location = new Point(8, 1);
                    btnrestart.Location = new Point(47, 1);
                    lbluser.Location = new Point(251, 39);
                    lblpassword.Location = new Point(256, 117);
                    btnshowpassword.Location = new Point(68, 142);
                    foreach (Control control in this.Controls)
                    {
                        string name = Convert.ToString(control.Tag);
                        control.Tag = control.Text;
                        control.Text = name;
                    }
                    foreach (Control control in pnltop.Controls)
                    {
                        string name = Convert.ToString(control.Tag);
                        control.Tag = control.Text;
                        control.Text = name;
                    }
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
                    pnltop.RightToLeft = RightToLeft.No;
                    pnltools.RightToLeft = RightToLeft.No;
                    lbltitel.Location = new Point(5, 8);
                    btnexit.Location = new Point(362, 1);
                    btnrestart.Location = new Point(323, 1);
                    lbluser.Location = new Point(29, 39);
                    lblpassword.Location = new Point(29, 117);
                    btnshowpassword.Location = new Point(264, 142);
                    foreach (Control control in this.Controls)
                    {
                        string name = Convert.ToString(control.Tag);
                        control.Tag = control.Text;
                        control.Text = name;
                    }
                    foreach (Control control in pnltop.Controls)
                    {
                        string name = Convert.ToString(control.Tag);
                        control.Tag = control.Text;
                        control.Text = name;
                    }
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
                Application.Exit();
            }
            catch (Exception ex)
            {
                lblerror.Text = "Exit() " + ex.Message;
            }
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            try
            {
                GetSalesAndTheme();
                lblerror.BackColor = Color.Transparent;
                lblerror.ForeColor = Color.FromArgb(255, 0, 126, 255);
                lblerror.AutoSize = true;
                lblerror.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Regular);
                this.Controls.Add(lblerror);
                lblerror.Location = new Point(12, 521);
                _BackColor = MainColor[json.MainColorNum];
                ChangeColor();
                ChangeLanguage();
                btnstartconection.Focus();
                btnstartconection.Select();
            }
            catch (Exception ex)
            {
                Show();
                lblerror.Text = "Load() " + ex.Message;
            }
        }
        private void LoginForm_VisibleChanged(object sender, EventArgs e)
        {
            try
            {
                if (Error)
                    lblerror.Invoke((MethodInvoker)delegate
                    {
                        lblerror.Text = "Please Restart The Application";
                    });
                _BackColor = MainColor[json.MainColorNum];
                ClearTools();
                ChangeColor();
                ChangeLanguage();
                if (Empty)
                {
                    btnsignup.Visible = true;
                    btnsignin.Enabled = false;
                }
                else
                {
                    btnsignup.Visible = false;
                    btnsignin.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                Show();
                Error = true;
                lblerror.Text = "VisibleChanged() " + ex.Message;
            }
        }
        private void btnsignin_Click(object sender, EventArgs e)
        {
            try
            {

                if (Error) return;
                lblerror.Text = "";
                if (!DataBase)
                {
                    UserName = txtusername._Text;
                    Password = txtpassword._Text;
                    if (UserName.Trim() == DefulteUserame.Trim())
                    {
                        if (Password == DefultePassword)
                        {

                            Account = AccountType.Defult;
                            Hide();
                            MainForm1 = new MainForm();
                            MainForm1.Show();
                        }
                    }
                }
                else if (txtusername._Text.Trim() != "")
                {
                    if (txtpassword._Text.Trim() != "")
                    {
                        UserName = txtusername._Text.Trim();
                        Password = txtpassword._Text.Trim();
                        if (CheckAccount(UserName, Password))
                        {
                            Hide();
                            MainForm1 = new MainForm();
                            MainForm1.Show();

                        }

                        else lblerror.Text = "The UserName Or The Password Dosn't Match With The Database.";
                    }
                    else lblerror.Text = "Plese Fill The Passord Filde.";
                }
                else lblerror.Text = "Plese Fill The UserName Filde.";
            }
            catch (Exception ex)
            {
                lblerror.Text = "Signin() " + ex.Message;
            }
        }
        private void btnshowpassword_Click(object sender, EventArgs e)
        {
            try
            {
                if (ShowPassword)
                {
                    txtpassword.PasswordChar = true;
                    ShowPassword = false;
                }
                else
                {
                    txtpassword.PasswordChar = false;
                    ShowPassword = true;
                }
            }
            catch (Exception ex)
            {
                lblerror.Text = "ShowPassword() " + ex.Message;
            }
        }
        private void txtusername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                txtpassword.Focus();
        }
        private void txtpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                btnsignin.PerformClick();
        }
        private void btnsignup_Click(object sender, EventArgs e)
        {
            if (Error) return;
            Hide();
            MainForm1.Show();
        }
        private void btnrestart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        private void btnstartconection_Click(object sender, EventArgs e)
        {
            if (Working)
                lblerror.Invoke((MethodInvoker)delegate
                {
                    lblerror.Text = "Working!...";
                });
            else
            {
                backworker.RunWorkerAsync();
                Working = true;
            }
        }
        private void backworker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            try
            {
                Progress += 10;
                backworker.ReportProgress(Progress);
                Progress += 10;
                backworker.ReportProgress(Progress);
                Thread.Sleep(200);
                Progress += 10;
                backworker.ReportProgress(Progress);
                Start2:
                Progress += 5;
                backworker.ReportProgress(Progress);
                Thread.Sleep(200);
                lblerror.Invoke((MethodInvoker)delegate
                {
                    lblerror.Text = "CreatConnection()";
                });
                CreatConnection();
                Progress += 5;
                backworker.ReportProgress(Progress);
                if (IsFinshed[1])
                {
                    Progress += 5;
                    backworker.ReportProgress(Progress);
                    lblerror.Invoke((MethodInvoker)delegate
                    {
                        lblerror.Text = "FillSalesTable()";
                    });
                    FillSalesTable();
                    Thread.Sleep(200);
                    Progress += 10;
                    backworker.ReportProgress(Progress);
                    lblerror.Invoke((MethodInvoker)delegate
                    {
                        lblerror.Text = "CheckForLowQTYs()";
                    });
                    CheckForLowQTYs();
                    Thread.Sleep(200);
                    Progress += 10;
                    backworker.ReportProgress(Progress);
                    lblerror.Invoke((MethodInvoker)delegate
                    {
                        lblerror.Text = "FillAccountsTable()";
                    });
                    FillAccountsTable();
                    Thread.Sleep(200);
                    Progress += 10;
                    backworker.ReportProgress(Progress);
                    lblerror.Invoke((MethodInvoker)delegate
                    {
                        lblerror.Text = "FillEmployeesTable()";
                    });
                    FillEmployeesTable();
                    Thread.Sleep(200);
                    Progress += 10;
                    backworker.ReportProgress(Progress);
                }
                else
                {
                    Thread.Sleep(200);
                    goto Start2;
                }
                mainprogress.Invoke((MethodInvoker)delegate
                {
                    mainprogress.Visible = false;
                });
                Thread.Sleep(300);
                btnstartconection.Invoke((MethodInvoker)delegate
                {
                    btnstartconection.Visible = false;
                });
                Progress += 10;
                backworker.ReportProgress(Progress);
                lblerror.Invoke((MethodInvoker)delegate
                {
                    lblerror.Text = "GetThingsRady()";
                });
                GetThingsRady();
                Progress += 5;
                backworker.ReportProgress(Progress);
            }
            catch (Exception ex)
            {
                lblerror.Invoke((MethodInvoker)delegate
                {
                    lblerror.Text = "BackWorker() " + ex.Message;
                });
            }
        }
        private void backworker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            mainprogress.Value = e.ProgressPercentage;
        }
        private void backworker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (lblerror.Text == "Working!...")
            {
                lblerror.Text = "";
            }
            else if (lblerror.Text == "GetThingsRady()")
            {
                lblerror.Text = "";
            }
        }
        #endregion
    }

}