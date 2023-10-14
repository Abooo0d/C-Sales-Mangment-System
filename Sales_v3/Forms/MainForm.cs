using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using AboodTools_v5;
using System.ComponentModel;
using Sales_v3.Class;

namespace Sales_v3.Forms
{
    public partial class MainForm : Form
    {
        //Fildes
        #region Fields
        public static DataServices json = new DataServices();
        public static PrintingServcies printing = new PrintingServcies();
        public bool Dragging = false;
        public Point StartPoint = new Point(0, 0);
        public bool Loading = false;
        public bool Database = false;
        public Color Dark1 = Color.FromArgb(255, 43, 43, 43);
        public Color Dark2 = Color.FromArgb(255, 50, 50, 50);
        public Color Light1 = Color.FromArgb(255, 213, 213, 213);
        public Color Light2 = Color.FromArgb(255, 230, 230, 230);
        public static Color _BackColor = new Color();
        public enum Languages { Arabic, English };
        public static Languages language = Languages.English;
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
        public MainForm()
        {
            InitializeComponent();
        }
        public void ChangeColor()
        {
            pnltop.BackColor = _BackColor;
            pnlcontainer.BackColor = _BackColor;
            if (json.Theme == "Dark")
            {
                BackColor = Dark1;
                pnltools.BackColor = Dark2;
            }
            else if (json.Theme == "Light")
            {
                BackColor = Light1;
                pnltools.BackColor = Light2;
            }
        }
        public void CheckAccounts()
        {
            if (!Database)
            {
                if (LoginForm.Account == LoginForm.AccountType.Defult)
                {
                    foreach (AboodButton btn in pnltools.Controls)
                    {
                        btn.Enabled = false;
                    }
                    btnsettings.Enabled = true;
                }
            }
            else if (LoginForm.Empty)
            {
                foreach (AboodButton btn in pnltools.Controls)
                {
                    btn.Enabled = false;
                }
                btnaccounts.Enabled = true;
            }
            else
            {
                if (LoginForm.Account == LoginForm.AccountType.Manager)
                {
                    foreach (AboodButton btn in pnltools.Controls)
                    {
                        btn.Enabled = true;
                    }
                }
                else if (LoginForm.Account == LoginForm.AccountType.Accountant)
                {
                    foreach (AboodButton btn in pnltools.Controls)
                    {
                        btn.Enabled = false;
                    }
                    btnstorage.Enabled = true;
                    btnsalepoint.Enabled = true;
                    btntoolsmangmaent.Enabled = true;
                }
            }
        }
        public void ChangeLanguage()
        {
            if (json.Language == "Arabic")
            {
                btnexit.Location = new Point(5, 1);
                lbltitle.Location = new Point(550, 8);
                if (language == Languages.English)
                {
                    string title = Convert.ToString(lbltitle.Tag);
                    lbltitle.Tag = lbltitle.Text;
                    lbltitle.Text = title;
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
                btnexit.Location = new Point(613, 1);
                lbltitle.Location = new Point(8, 8);
                if (language == Languages.Arabic)
                {
                    string title = Convert.ToString(lbltitle.Tag);
                    lbltitle.Tag = lbltitle.Text;
                    lbltitle.Text = title;
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
            if (Loading) return;
            LoginForm.json = json;
            LoginForm.printing = printing;
            Close();
            Application.OpenForms[0].Show();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            Database = LoginForm.DataBase;
            Loading = true;
            json = LoginForm.json;
            printing = LoginForm.printing;
            _BackColor = LoginForm.MainColor[json.MainColorNum];
            ChangeColor();
            CheckAccounts();
            ChangeLanguage();
            backworker.RunWorkerAsync();
        }
        private void MainForm_VisibleChanged(object sender, EventArgs e)
        {
            _BackColor = LoginForm.MainColor[json.MainColorNum];
            ChangeColor();
            ChangeLanguage();
            CheckAccounts();
        }
        private void backworker_DoWork(object sender, DoWorkEventArgs e)
        {

            pnlcontainer.Invoke((MethodInvoker)delegate
            {
                pnlcontainer.Visible = true;
            });
            Thread.Sleep(100);
            btnsalepoint.Invoke((MethodInvoker)delegate
            {
                btnsalepoint.Visible = true;
            });
            Thread.Sleep(100);
            btnstorage.Invoke((MethodInvoker)delegate
            {
                btnstorage.Visible = true;
            });
            Thread.Sleep(100);
            btnaccounts.Invoke((MethodInvoker)delegate
            {
                btnaccounts.Visible = true;
            });
            Thread.Sleep(100);
            btnemployees.Invoke((MethodInvoker)delegate
            {
                btnemployees.Visible = true;
            });
            Thread.Sleep(100);
            btnsettings.Invoke((MethodInvoker)delegate
            {
                btnsettings.Visible = true;
            });
            Thread.Sleep(100);
            btntoolsmangmaent.Invoke((MethodInvoker)delegate
            {
                btntoolsmangmaent.Visible = true;
            });
            Thread.Sleep(100);
            btnempty.Invoke((MethodInvoker)delegate
            {
                btnempty.Visible = true;
            });
            Loading = false;
        }
        #region OpenForms
        private void btnsalepoint_Click(object sender, EventArgs e)
        {
            if (Loading) return;
            Hide();
            LoginForm.SalePointForm1 = new SalePointForm();
            LoginForm.SalePointForm1.Show();
        }
        private void btntoolsmangmaent_Click(object sender, EventArgs e)
        {
            if (Loading) return;
            Hide();
            LoginForm.ToolsMangmentForms1 = new ToolsMangmentForms();
            LoginForm.ToolsMangmentForms1.Show();
        }
        private void btnstorage_Click(object sender, EventArgs e)
        {
            if (Loading) return;
            Hide();
            LoginForm.StorageForm1 = new StorageForm();
            LoginForm.StorageForm1.Show();
        }
        private void btnsettings_Click(object sender, EventArgs e)
        {
            if (Loading) return;
            Hide();
            LoginForm.SettingsForm1 = new SettingsForm();
            LoginForm.SettingsForm1.Show();
        }
        private void btnemployees_Click(object sender, EventArgs e)
        {
            if (Loading) return;
            Hide();
            LoginForm.EmployeesForm1 = new EmployeesForm();
            LoginForm.EmployeesForm1.Show();
        }
        private void btnaccounts_Click(object sender, EventArgs e)
        {
            if (Loading) return;
            Hide();
            LoginForm.AccountsForm1 = new AccountsForm();
            LoginForm.AccountsForm1.Show();
        }
        private void btnempty_Click(object sender, EventArgs e)
        {
            if (Loading) return;
            Hide();
            LoginForm.PrintingForm1 = new PrintingForm();
            LoginForm.PrintingForm1.Show();
        }

        #endregion
        #endregion
    }
}
