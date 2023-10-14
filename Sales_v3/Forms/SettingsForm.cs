using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using Sales_v3.Class;
using static Sales_v3.Class.JsonServices;

namespace Sales_v3.Forms
{
    public partial class SettingsForm : Form
    {
        //Fields
        #region Fields
        public bool Loading = false;
        public bool Database = false;
        public static DataServices json = new DataServices();
        public bool Dragging = false;
        public Point StartPoint = new Point(0, 0);
        public static string DataBaseRoot;
        static string Theme;
        static string Language;
        static int MainColorNum;
        static bool Wait = false;
        public static bool Error = false;
        public static bool DataBaseChanged = false;
        public bool Restart = false;
        public Color _BackColor = new Color();
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
        public SettingsForm()
        {
            InitializeComponent();
        }
        public void ChangeColor()
        {
            try
            {
                pnltop.BackColor = _BackColor;
                pnlcontainer.BackColor = _BackColor;
                if (Theme == "Dark")
                {
                    BackColor = Dark1;
                    pnltools.BackColor = Dark2;
                    pnldatabase.BackColor = Dark1;
                    pnltheme.BackColor = Dark1;
                    pnlmaincolor.BackColor = Dark1;
                    pnllanguage.BackColor = Dark1;
                    txtdatabaseroot.BackColor = Dark1;
                    lbldark.BackColor = Dark1;
                    lbllight.BackColor = Light1;
                    lblarabic.BackColor = Light1;
                    lblenglish.BackColor = Dark1;
                }
                else if (Theme == "Light")
                {
                    BackColor = Light1;
                    pnltools.BackColor = Light2;
                    pnldatabase.BackColor = Light1;
                    pnltheme.BackColor = Light1;
                    pnlmaincolor.BackColor = Light1;
                    pnllanguage.BackColor = Light1;
                    txtdatabaseroot.BackColor = Light1;
                    lbldark.BackColor = Dark1;
                    lbllight.BackColor = Light1;
                    lblarabic.BackColor = Light1;
                    lblenglish.BackColor = Dark1;
                }
            }
            catch (Exception ex)
            {
                Error = true;
                lblerror.Text = "ChangeColor() " + ex.Message;
            }
        }
        public void GetData()
        {
            try
            {
                DataBaseRoot = json.DataBaseRoot;
                Theme = json.Theme;
                Language = json.Language;
                MainColorNum = json.MainColorNum;
            }
            catch (Exception ex)
            {
                Error = true;
                lblerror.Invoke((MethodInvoker)delegate
                {
                    lblerror.Text = "GetData() " + ex.Message;
                });
            }
        }
        public void FillData()
        {
            try
            {
                txtdatabaseroot._Text = DataBaseRoot;
                if (Theme == "Dark")
                    toggletheme.CheckState = CheckState.Unchecked;
                else if (Theme == "Light")
                    toggletheme.CheckState = CheckState.Checked;
                if (Language == "English")
                    togglelanguage.CheckState = CheckState.Unchecked;
                else if (Language == "Arabic")
                    togglelanguage.CheckState = CheckState.Checked;
                foreach (Control color in pnlmaincolor.Controls)
                {
                    if (color is Panel)
                    {
                        if (MainColorNum == Convert.ToInt32(color.Tag))
                        {
                            color.Location = new Point(color.Location.X, 52);
                        }
                        else color.Location = new Point(color.Location.X, 62);
                    }
                }
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
        public void SaveChanges()
        {
            try
            {
                Wait = true;
                json.DataBaseRoot = DataBaseRoot;
                json.Theme = Theme;
                json.Language = Language;
                json.MainColorNum = MainColorNum;
                WriteDataFile(json, LoginForm.DataRoot);
                if (DataBaseChanged)
                {
                    Restart = true;
                    btnsearch.Enabled = false;
                    btnclear.Enabled = false;
                    btnrestartapp.Visible = true;
                    lblerror.Text = "Please Restart The Application!";
                }
                Wait = false;
                DataBaseChanged = false;
            }
            catch (Exception ex)
            {
                Error = true;
                Wait = false;
                DataBaseChanged = false;
                lblerror.Text = "SaveChanges() " + ex.Message;
            }
        }
        public void PnlColorEvent(object sender, EventArgs e)
        {
            try
            {
                if (Restart) return;
                MainColorNum = Convert.ToInt32(((Panel)sender).Tag);
                _BackColor = LoginForm.MainColor[MainColorNum];
                ChangeColor();
                FillData();
            }
            catch (Exception ex)
            {
                Error = true;
                lblerror.Text = "PnlColorEvent() " + ex.Message;
            }
        }
        public void ChangeLanguage()
        {
            if (Language == "Arabic")
            {
                if (language == Languages.English)
                {
                    pnltop.RightToLeft = RightToLeft.Yes;
                    pnldatabase.RightToLeft = RightToLeft.Yes;
                    pnltheme.RightToLeft = RightToLeft.Yes;
                    pnllanguage.RightToLeft = RightToLeft.Yes;
                    pnlmaincolor.RightToLeft = RightToLeft.Yes;
                    foreach (Control con in pnltools.Controls)
                    {
                        if (con is Panel)
                        {
                            foreach (Control control in con.Controls)
                            {
                                if (control is Panel) {  }
                                else
                                {
                                    string name = Convert.ToString(control.Tag);
                                    control.Tag = control.Text;
                                    control.Text = name;
                                }
                            }
                        }
                        else
                        {
                            string name = Convert.ToString(con.Tag);
                            con.Tag = con.Text;
                            con.Text = name;
                        }
                    }
                    foreach (Control control in pnltop.Controls)
                    {
                        string name = Convert.ToString(control.Tag);
                        control.Tag = control.Text;
                        control.Text = name;
                    }
                    btnexit.Location = new Point(5, 1);
                    btnrestart.Location = new Point(43, 1);
                    btnrestartapp.Location = new Point(101, 1);
                    lbltitel.Location = new Point(pnltop.Width - lbltitel.Width - 5, 8);
                    lbldatabase.Location = new Point(462, 12);
                    lbltheme.Location = new Point(187, 12);
                    lblmaincolor.Location = new Point(188, 20);
                    lbllanguage.Location = new Point(210, 12);
                    lblprinter.Location = new Point(162, 12);
                }
                language = Languages.Arabic;
            }
            else if (Language == "English")
            {
                if (language == Languages.Arabic)
                {
                    pnltop.RightToLeft = RightToLeft.No;
                    pnldatabase.RightToLeft = RightToLeft.No;
                    pnltheme.RightToLeft = RightToLeft.No;
                    pnllanguage.RightToLeft = RightToLeft.No;
                    pnlmaincolor.RightToLeft = RightToLeft.No;
                    btnexit.Location = new Point(572, 1);
                    btnrestart.Location = new Point(534, 1);
                    btnrestartapp.Location = new Point(408, 1);
                    lbltitel.Location = new Point(5, 8);
                    lbldatabase.Location = new Point(12, 12);
                    lbltheme.Location = new Point(12, 12);
                    lblmaincolor.Location = new Point(12, 12);
                    lbllanguage.Location = new Point(12, 12);
                    foreach (Control con in pnltools.Controls)
                    {
                        if (con is Panel)
                        {
                            foreach (Control control in con.Controls)
                            {
                                if (control is Panel) { }
                                else
                                {
                                    string name = Convert.ToString(control.Tag);
                                    control.Tag = control.Text;
                                    control.Text = name;
                                }
                            }
                        }
                        else
                        {
                            string name = Convert.ToString(con.Tag);
                            con.Tag = con.Text;
                            con.Text = name;
                        }
                    }
                    foreach (Control control in pnltop.Controls)
                    {
                        string name = Convert.ToString(control.Tag);
                        control.Tag = control.Text;
                        control.Text = name;
                    }
                    btnexit.Location = new Point(692, 1);
                    btnrestart.Location = new Point(654, 1);
                    btnrestartapp.Location = new Point(528, 1);
                    lbltitel.Location = new Point(5, 8);
                    lbldatabase.Location = new Point(12, 12);
                    lbltheme.Location = new Point(12, 12);
                    lblmaincolor.Location = new Point(12, 12);
                    lbllanguage.Location = new Point(12, 12);
                    lblprinter.Location = new Point(12,12);
                }
                language = Languages.English;
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
        private void SettingsForm_Load(object sender, EventArgs e)
        {
            try
            {
                Database = LoginForm.DataBase;
                Loading = true;
                json = MainForm.json;
                _BackColor = LoginForm.MainColor[json.MainColorNum];
                GetData();
                ChangeColor();
                ChangeLanguage();
                FillData();
                if (backworker.IsBusy)
                {
                    lblerror.Invoke((MethodInvoker)delegate { lblerror.Text = "Runing!"; });
                }
                else { backworker.RunWorkerAsync(); }
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
                MainForm.json = json;
                Close();
                Application.OpenForms[1].Show();
            }
            catch (Exception ex)
            {
                Error = true;
                lblerror.Text = "Exit()" + ex.Message;
            }
        }
        private void toggletheme_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (Loading) return;
                if (Restart) return;
                if (Error) return;
                if (Wait) return;
                if (toggletheme.CheckState == CheckState.Checked)
                    Theme = "Light";
                else if (toggletheme.CheckState == CheckState.Unchecked)
                    Theme = "Dark";
                FillData();
                ChangeColor();
            }
            catch (Exception ex)
            {
                Error = true;
                lblerror.Text = "ChangeTheme() " + ex.Message;
            }
        }
        private void togglelanguage_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (Loading) return;
                if (Restart) return;
                if (Error) return;
                if (Wait) return;
                MessageBox.Show("1");
                if (togglelanguage.CheckState == CheckState.Checked)
                    Language = "Arabic";
                else if (togglelanguage.CheckState == CheckState.Unchecked)
                    Language = "English";
                MessageBox.Show("2");
                FillData();
                ChangeLanguage();
                MessageBox.Show("3");
            }
            catch (Exception ex)
            {
                Error = true;
                lblerror.Text = "ChangeLanguage() " + ex.Message;
            }
        }
        private void btncancel_Click(object sender, EventArgs e)
        {
            try
            {
                if (Loading) return;
                if (Restart) return;
                if (Error) return;
                if (Wait) return;
                GetData();
                FillData();
            }
            catch (Exception ex)
            {
                Error = true;
                lblerror.Text = "Cancel() " + ex.Message;
            }
        }
        private void btndefulte_Click(object sender, EventArgs e)
        {
            try
            {
                if (Loading) return;
                if (Restart) return;
                if (Error) return;
                if (Wait) return;
                DataBaseChanged = true;
                DataBaseRoot = "";
                Theme = "Dark";
                Language = "English";
                MainColorNum = 0;
                ChangeColor();
                FillData();
            }
            catch (Exception ex)
            {
                Error = true;
                lblerror.Text = "Defulte() " + ex.Message;
            }
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (Loading) return;
                if (Restart) return;
                if (Error) return;
                if (Wait) return;
                SaveChanges();
            }
            catch (Exception ex)
            {
                Error = true;
                lblerror.Text = "Save() " + ex.Message;
            }
        }
        private void btnclear_Click(object sender, EventArgs e)
        {
            try
            {
                if (Loading) return;
                if (Restart) return;
                if (Error) return;
                if (Wait) return;
                DataBaseChanged = true;
                txtdatabaseroot._Text = "";
                DataBaseRoot = "";
                FillData();
            }
            catch (Exception ex)
            {
                Error = true;
                lblerror.Text = "Clear() " + ex.Message;
            }
        }
        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {

                if (Error) return;
                if (Wait) return;
                DataBaseChanged = true;
                ofddatabase.InitialDirectory = (Environment.GetFolderPath
               (Environment.SpecialFolder.UserProfile)) + "\\AppData\\Local\\Sales";
                ofddatabase.Filter = "Data Base|*.mdf";
                if (ofddatabase.ShowDialog() == DialogResult.OK)
                {
                    txtdatabaseroot._Text = ofddatabase.FileName;
                    DataBaseRoot = txtdatabaseroot._Text;
                }
            }
            catch (Exception ex)
            {
                Error = true;
                lblerror.Text = "Search() " + ex.Message;
            }
        }
        private void btnrestart_Click(object sender, EventArgs e)
        {
            try
            {
                if (Loading) return;
                if (Restart) return;
                LoginForm.SettingsForm1.Close();
                Thread.Sleep(1000);
                LoginForm.SettingsForm1 = new SettingsForm();
                LoginForm.SettingsForm1.Show();
            }
            catch (Exception ex)
            {
                Error = true;
                lblerror.Text = "Restart() " + ex.Message;
            }
        }
        private void btnrestartapp_Click(object sender, EventArgs e)
        {
            if (Loading) return;
            Application.Restart();
        }
        private void backworker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            try
            {
                pnlcontainer.Invoke((MethodInvoker)delegate
                {
                    pnlcontainer.Visible = true;
                });
                Thread.Sleep(100);
                pnldatabase.Invoke((MethodInvoker)delegate
                {
                    pnldatabase.Visible = true;
                });
                Thread.Sleep(100);
                pnltheme.Invoke((MethodInvoker)delegate
                {
                    pnltheme.Visible = true;
                });
                Thread.Sleep(100);
                pnlmaincolor.Invoke((MethodInvoker)delegate
                {
                    pnlmaincolor.Visible = true;
                });
                Thread.Sleep(100);
                pnllanguage.Invoke((MethodInvoker)delegate
                {
                    pnllanguage.Visible = true;
                });
                Thread.Sleep(100);
                btnsave.Invoke((MethodInvoker)delegate
                {
                    btnsave.Visible = true;
                });
                Thread.Sleep(100);
                btncancel.Invoke((MethodInvoker)delegate
                {
                    btncancel.Visible = true;
                });
                Thread.Sleep(100);
                btndefulte.Invoke((MethodInvoker)delegate
                {
                    btndefulte.Visible = true;
                });
                Thread.Sleep(500);
                Loading = false;
            }
            catch (Exception ex)
            {
                Loading = false;
                lblerror.Invoke((MethodInvoker)delegate
                {
                    lblerror.Text = "BackWorker() " + ex.Message;
                });
            }
        }
        #endregion
    }
}
/*
  public void GetPrinter()
        {
            PrinterList = GetPrinterList();
            foreach (string i in PrinterList)
            {
                cbxprinter.Items.Add(i);
            }
        }*/
