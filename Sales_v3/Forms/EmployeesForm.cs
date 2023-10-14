using System;
using System.Drawing;
using System.Windows.Forms;
using AboodTools_v5;
using System.Threading;
using Sales_v3.Class;

namespace Sales_v3.Forms
{
    public partial class EmployeesForm : Form
    {
        //Fields
        #region Fields
        public bool Loading = false;
        public bool Database = false;
        public static DataServices json = new DataServices();
        public Color _BackColor = new Color();
        public Point StartPoint = new Point(0, 0);
        public bool Dragging = false;
        public bool Error = false;
        public int Counter = 0;
        public string Id, FName, LName, Address, Phone,
            Workshift, Salary, Division, Profession;
        public bool Out = false;
        public string[] ArabicNames = new string[2] { "الموظفين", "الموظفين", };
        public string[] EnglishNames = new string[2] { "Employees", "Employees" };
        public Color Dark1 = Color.FromArgb(255, 43, 43, 43);
        public Color Dark2 = Color.FromArgb(255, 50, 50, 50);
        public Color Light1 = Color.FromArgb(255, 213, 213, 213);
        public Color Light2 = Color.FromArgb(255, 230, 230, 230);
        public enum Languages { Arabic, English };
        public Languages language = Languages.English;
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
        public EmployeesForm()
        {
            InitializeComponent();
        }
        public void ClearInfo()
        {
            try
            {
                txtfname._Text = "";
                txtlname._Text = "";
                txtphone._Text = "";
                txtaddress._Text = "";
                txtworkshift._Text = "";
                txtsalary._Text = "";
                txtdivision._Text = "";
                txtprofession._Text = "";
            }
            catch (Exception ex)
            {
                Error = true;
                lblerror.Text = "ClearInfo() " + ex.Message;
            }
        }
        public void ChangeColor()
        {
            try
            {
                pnltop.BackColor = _BackColor;
                pnlcontaineremp.BackColor = _BackColor;
                pnlcontaineremployees.BackColor = _BackColor;
                pnlcontainerinfo.BackColor = _BackColor;
                if (json.Theme == "Dark")
                {
                    BackColor = Dark1;
                    pnlemployees.BackColor = Dark2;
                    pnlemp.BackColor = Dark1;
                    flowpnlemp.BackColor = Dark1;
                    pnlinfo.BackColor = Dark1;
                    txtphone.BackColor = Dark1;
                    txtfname.BackColor = Dark1;
                    txtlname.BackColor = Dark1;
                    txtaddress.BackColor = Dark1;
                    txtworkshift.BackColor = Dark1;
                    txtsalary.BackColor = Dark1;
                    txtdivision.BackColor = Dark1;
                    txtprofession.BackColor = Dark1;
                }
                else if (json.Theme == "Light")
                {
                    BackColor = Light1;
                    pnlemployees.BackColor = Light2;
                    pnlemp.BackColor = Light1;
                    flowpnlemp.BackColor = Light1;
                    pnlinfo.BackColor = Light1;
                    txtphone.BackColor = Light1;
                    txtfname.BackColor = Light1;
                    txtlname.BackColor = Light1;
                    txtaddress.BackColor = Light1;
                    txtworkshift.BackColor = Light1;
                    txtsalary.BackColor = Light1;
                    txtdivision.BackColor = Light1;
                    txtprofession.BackColor = Light1;
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
                if (!Database) return;
                if (LoginForm.EmployeesTable.Rows.Count == 0) return;
                FName = Convert.ToString(LoginForm.EmployeesTable.Rows[Counter]["F_Name"]);
                LName = Convert.ToString(LoginForm.EmployeesTable.Rows[Counter]["L_Name"]);
                Address = Convert.ToString(LoginForm.EmployeesTable.Rows[Counter]["Address"]);
                Phone = Convert.ToString(LoginForm.EmployeesTable.Rows[Counter]["Phone"]);
                Workshift = Convert.ToString(LoginForm.EmployeesTable.Rows[Counter]["Workshift"]);
                Salary = Convert.ToString(LoginForm.EmployeesTable.Rows[Counter]["Salary"]);
                Division = Convert.ToString(LoginForm.EmployeesTable.Rows[Counter]["Division"]);
                Profession = Convert.ToString(LoginForm.EmployeesTable.Rows[Counter]["Profession"]);
                txtfname._Text = FName;
                txtlname._Text = LName;
                txtaddress._Text = Address;
                txtphone._Text = Phone;
                txtworkshift._Text = Workshift;
                txtsalary._Text = Salary;
                txtdivision._Text = Division;
                txtprofession._Text = Profession;
                ChangeEmployeesColor();
            }
            catch (Exception ex)
            {
                Error = true;
                lblerror.Text = "FillData() " + ex.Message;
            }
        }
        public void GetEmployees()
        {
            try
            {
                Thread.Sleep(500);
                if (!Database) return;
                if (LoginForm.EmployeesTable.Rows.Count == 0) return;
                flowpnlemp.Controls.Clear();
                for (int i = 0; i < LoginForm.EmployeesTable.Rows.Count; i++)
                {
                    AboodButton btnemp = new AboodButton
                    {
                        Text = Convert.ToString(LoginForm.EmployeesTable.Rows[i]["F_Name"]),
                        BackColor = Color.FromArgb(255, 50, 50, 50),
                        BorderColor = Color.DarkOrange,
                        BorderSize = 2,
                        BorderRadius = 10,
                        Size = new Size(108, 95),
                        Tag = i,
                        ForeColor = Color.White,
                        Margin = new Padding(3)
                    };
                    if (json.Theme == "Dark")
                    {
                        btnemp.ForeColor = Light2;
                        btnemp.BackColor = Dark2;
                    }
                    else if (json.Theme == "Light")
                    {
                        btnemp.ForeColor = Dark2;
                        btnemp.BackColor = Light2;
                    }
                    Counter = i;
                    btnemp.Click += delegate { BtnEvent(btnemp); };
                    flowpnlemp.Invoke((MethodInvoker)delegate
                    {
                        flowpnlemp.Controls.Add(btnemp);
                    });
                    Thread.Sleep(100);
                }
            }
            catch (Exception ex)
            {
                Error = true;
                lblerror.Invoke((MethodInvoker)delegate
                {
                    lblerror.Text = "GetEmployees() " + ex.Message;
                });
            }
        }
        public void BtnEvent(AboodButton btn)
        {
            try
            {
                if (!Database) return;
                if (LoginForm.EmployeesTable.Rows.Count == 0) return;
                Out = false;
                Counter = Convert.ToInt32(btn.Tag);
                FillData();
            }
            catch (Exception ex)
            {
                Error = true;
                lblerror.Text = "BtnEmpEvent() " + ex.Message;
            }
        }
        public void ChangeEmployeesColor()
        {
            try
            {
                if (!Database) return;
                if (LoginForm.EmployeesTable.Rows.Count == 0) return;
                if (Out)
                {
                    foreach (AboodButton btn in flowpnlemp.Controls)
                    {
                        btn.BorderColor = Color.DarkOrange;
                    }
                    return;
                }
                foreach (AboodButton btn in flowpnlemp.Controls)
                {
                    if (Convert.ToInt32(btn.Tag) == Counter)
                        btn.BorderColor = _BackColor;
                    else
                        btn.BorderColor = Color.DarkOrange;
                }
            }
            catch (Exception ex)
            {
                Error = true;
                lblerror.Text = "ChangeEmployeesColor() " + ex.Message;
            }
        }
        public bool FillVars()
        {
            try
            {
                if (LoginForm.EmployeesTable.Rows.Count == 0) return false;
                if (txtfname._Text.Trim() != "")
                    FName = txtfname._Text;
                else
                {
                    lblerror.Text = "Plese Fill All The Fields!";
                    return false;
                }
                if (txtlname._Text.Trim() != "")
                    LName = txtlname._Text;
                else
                {
                    lblerror.Text = "Plese Fill All The Fields!";
                    return false;
                }
                if (txtworkshift._Text.Trim() != "")
                    Workshift = txtworkshift._Text;
                else Workshift = "none";
                if (txtaddress._Text.Trim() != "")
                    Address = txtaddress._Text;
                else Address = "none";
                if (txtphone._Text.Trim() != "")
                    Phone = txtphone._Text;
                else Phone = "none";
                if (txtsalary._Text.Trim() != "")
                    Salary = txtsalary._Text;
                else Salary = "none";
                if (txtdivision._Text.Trim() != "")
                    Division = txtdivision._Text;
                else Division = "none";
                if (txtprofession._Text.Trim() != "")
                    Profession = txtprofession._Text;
                else Profession = "none";
                return true;
            }
            catch (Exception ex)
            {
                Error = true;
                lblerror.Text = "FillVars() " + ex.Message;
                return false;
            }
        }
        public void DeleteRow()
        {
            try
            {
                if (!Database) return;
                for (int i = Counter; i < LoginForm.SalesTable.Rows.Count - 1; i++)
                {
                    LoginForm.EmployeesTable.Rows[i]["F_Name"] = LoginForm.EmployeesTable.Rows[i + 1]["F_Name"];
                    LoginForm.EmployeesTable.Rows[i]["L_Name"] = LoginForm.EmployeesTable.Rows[i + 1]["L_Name"];
                    LoginForm.EmployeesTable.Rows[i]["Address"] = LoginForm.EmployeesTable.Rows[i + 1]["Address"];
                    LoginForm.EmployeesTable.Rows[i]["Phone"] = LoginForm.EmployeesTable.Rows[i + 1]["Phone"];
                    LoginForm.EmployeesTable.Rows[i]["Workshift"] = LoginForm.EmployeesTable.Rows[i + 1]["Workshift"];
                    LoginForm.EmployeesTable.Rows[i]["Salary"] = LoginForm.EmployeesTable.Rows[i + 1]["Salary"];
                    LoginForm.EmployeesTable.Rows[i]["Division"] = LoginForm.EmployeesTable.Rows[i + 1]["Division"];
                    LoginForm.EmployeesTable.Rows[i]["Profession"] = LoginForm.EmployeesTable.Rows[i + 1]["Profession"];
                }
                int index = LoginForm.EmployeesTable.Rows.Count - 1;
                LoginForm.EmployeesTable.Rows[index].Delete();
                LoginForm.EmployeesAdapter.Update(LoginForm.EmployeesTable);
                LoginForm.FillEmployeesTable();
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
                    pnlinfo.RightToLeft = RightToLeft.Yes;
                    pnltop.RightToLeft = RightToLeft.Yes;
                    lblemptitle.RightToLeft = RightToLeft.Yes;
                    lbltitle.Text = ArabicNames[0];
                    lblemptitle.Text = ArabicNames[1];
                    lbltitle.Location = new Point(pnltop.Width - lbltitle.Width - 5, 8);
                    btnexit.Location = new Point(5, 1);
                    btnrestart.Location = new Point(43, 1);
                    lblemptitle.Location = new Point(pnlemp.Width - lblemptitle.Width - 12, 12);
                    lblinfo.Location = new Point(222, 12);
                    lblfname.Location = new Point(281, 52);
                    lbllname.Location = new Point(280, 122);
                    lbladdress.Location = new Point(272, 192);
                    lblphone.Location = new Point(115, 192);
                    lblsalary.Location = new Point(274, 262);
                    lblworkshift.Location = new Point(111, 262);
                    lblprofession.Location = new Point(279, 332);
                    lbldivision.Location = new Point(115, 332);
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
                pnlinfo.RightToLeft = RightToLeft.No;
                pnltop.RightToLeft = RightToLeft.No;
                lblemptitle.RightToLeft = RightToLeft.Yes;
                lbltitle.Text = EnglishNames[0];
                lblemptitle.Text = EnglishNames[1];
                lbltitle.Location = new Point(5, 8);
                btnexit.Location = new Point(901, 1);
                btnrestart.Location = new Point(863, 1);
                lblemptitle.Location = new Point(12, 12);
                lblinfo.Location = new Point(12, 12);
                lblfname.Location = new Point(12, 52);
                lbllname.Location = new Point(12, 122);
                lbladdress.Location = new Point(170, 192);
                lblphone.Location = new Point(12, 192);
                lblsalary.Location = new Point(170, 262);
                lblworkshift.Location = new Point(12, 262);
                lblprofession.Location = new Point(170, 332);
                lbldivision.Location = new Point(12, 332);
                foreach (Control control in pnlinfo.Controls)
                {
                    string name = Convert.ToString(control.Tag);
                    control.Tag = control.Text;
                    control.Text = name;
                }
                language = Languages.English;
            }
        }
        #endregion
        //Events
        #region Events
        #region Draggigng
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
        private void EmployeesForm_Load(object sender, EventArgs e)
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
                FillData();

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
            try
            {
                if (Loading) return;
                if (Error) return;
                if (!Database) return;
                Counter = LoginForm.EmployeesTable.Rows.Count + 1;
                if (FillVars())
                {
                    object[] row = new object[]
                    { Counter, FName, LName, Address, Phone, Workshift, Salary, Division, Profession };
                    LoginForm.EmployeesTable.Rows.Add(row);
                    LoginForm.EmployeesAdapter.Update(LoginForm.EmployeesTable);
                    Counter = LoginForm.EmployeesTable.Rows.Count - 1;
                    Out = false;
                    GetEmployees();
                    FillData();
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
                if (!Database) return;
                if (LoginForm.EmployeesTable.Rows.Count == 0) return;
                bool result = FillVars();
                if (result)
                {
                    LoginForm.EmployeesTable.Rows[Counter]["F_Name"] = FName;
                    LoginForm.EmployeesTable.Rows[Counter]["L_Name"] = LName;
                    LoginForm.EmployeesTable.Rows[Counter]["Address"] = Address;
                    LoginForm.EmployeesTable.Rows[Counter]["Workshift"] = Workshift;
                    LoginForm.EmployeesTable.Rows[Counter]["Salary"] = Salary;
                    LoginForm.EmployeesTable.Rows[Counter]["Division"] = Division;
                    LoginForm.EmployeesTable.Rows[Counter]["Profession"] = Profession;
                    LoginForm.EmployeesAdapter.Update(LoginForm.EmployeesTable);
                    FillData();
                    GetEmployees();
                    ChangeEmployeesColor();
                }
            }
            catch (Exception ex)
            {
                Error = true;
                lblerror.Text = "Edit() " + ex.Message;
            }
        }
        private void btnclear_Click(object sender, EventArgs e)
        {
            if (Loading) return;
            Out = true;
            ClearInfo();
            ChangeEmployeesColor();
        }
        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (Loading) return;
                if (Error) return;
                if (!Database) return;
                if (LoginForm.EmployeesTable.Rows.Count == 0) return;
                DeleteRow();
                GetEmployees();
                FillData();
                Counter = 0;
                ChangeEmployeesColor();
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
                LoginForm.EmployeesForm1 = new EmployeesForm();
                Thread.Sleep(1000);
                LoginForm.EmployeesForm1.Show();
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
                pnlcontaineremp.Invoke((MethodInvoker)delegate
                {
                    pnlcontaineremp.Visible = true;
                });
                Thread.Sleep(200);
                pnlcontaineremployees.Invoke((MethodInvoker)delegate
                {
                    pnlcontaineremployees.Visible = true;
                });
                Thread.Sleep(200);
                pnlcontainerinfo.Invoke((MethodInvoker)delegate
                {
                    pnlcontainerinfo.Visible = true;
                });
                GetEmployees();
                Thread.Sleep(500);
                Loading = false;
            }
            catch (Exception ex)
            {
                lblerror.Invoke((MethodInvoker)delegate
                {
                    Loading = false;
                    Error = true;
                    lblerror.Text = "BackWorker() " + ex.Message;
                });
            }
        }
        #endregion
    }
}
