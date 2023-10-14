using System;
using System.Collections.Generic;
using AboodTools_v5;
using System.Windows.Forms;
using System.Drawing.Printing;
using Sales_v3.Class;
using static Sales_v3.Class.JsonServices;
using static Sales_v3.Class.PrintingServcies;
using System.Drawing;
using System.Threading;
using System.IO;

namespace Sales_v3.Forms
{
    public partial class PrintingForm : Form
    {
        //Fields
        public List<string> PrinterList;
        public static DataServices json = new DataServices();
        public static PrintingServcies printing = new PrintingServcies();
        public static Language ColumnsLanguage = Language.Arabic;
        public static string LogoUrl = "";
        public bool Dragging = false;
        public Point StartPoint = new Point(0, 0);
        public bool In = true;
        public int timer = 0;
        public bool Runing = false;
        public int PreHeight = 0;
        public string[] order1 = new string[5] { "1", "Test Name", "QTY", "subtotal", "Total" };
        public Color _BackColor;
        public Color Light1 = Color.FromArgb(255, 213, 213, 213);
        public Color Light2 = Color.FromArgb(255, 230, 230, 230);
        public Color Dark1 = Color.FromArgb(255, 43, 43, 43);
        public Color Dark2 = Color.FromArgb(255, 50, 50, 50);
        public enum Languages { Arabic, English };
        public Languages language = Languages.English;
        //Drop Shadow
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
        //Methods
        public PrintingForm()
        {
            InitializeComponent();
        }
        public string ConvertNumbersToString(int num)
        {
            string[] ArabicOnes = new string[] { "صفر", "واحد", "اثنان", "ثلاثة", "أربعة", "خمسة", "ستة", "سبعة", "ثمانية", "تسعة", "عشرة", "أحد عشر", "إثنا عشر", "ثلاثة عشر", "أربعة عشر", "خمسة عشر", "ستة عشر", "سبعة عشر", "ثمانية عشر", "تسعة عشر" };
            string[] ArabicTens = new string[] { "صفر", "عشرة", "عشرون", "ثلاثون", "أربعون", "خمسون", "ستون", "سبعون", "ثمانون", "تسعون" };
            string[] ArabicHundred = new string[] { "صفر", "مئة", "مئتان", "ثلاثمائة", "أربعمائة", "خمسمائة", "ستمائة", "سبعمائة", "ثمانمائة", "تسعمائة" };
            string[] ArabicThounds = new string[] { "صفر", "ألف", "ألفان", "ثلاثة ألاف", "أربعة ألاف", "خمسة ألاف", "ستة ألاف", "سبعة ألاف", "ثمانة ألاف", "تسعة الاف", "عشرة ألاف", "أحد عشر ألفاً", "إثنا عشر ألفاً", "ثلاثة عشر ألفاً", "أربعة عشر ألفاً", "خمسة عشر ألفاً", "ستة عشر ألفاً", "سبعة عشر ألفا", "ثمانية عشر ألفاً", "تسعة عشر ألفاً", "عشرون ألفاً" };
            string[] ArabicMilloins = new string[] { "صفر", "مليون", "مليونان", "ثلاثة ملايين", "أربعة ملايين", "خمسة مليين", "ستة مليين", "سبعة ملايين", "تمانية ملايين", "تسعة ملايين", "عشرة ملايين", "أحد عشر مليوناً", "إثنا عشر مليوناً", "ثلالة عشر مليوناً", "أربعة عشر مليوناً", "خمسة عشر ملوناً", "ستة عشر مليوناً", "سبعة عشر ملوناً", "ثمانية عشر مليونا", "تسعة عشر مليوناً", "عشرون مليوناً" };
            string word = "";
            if ((num / 1000000) > 0)
            {
                if ((num / 1000000) >= 100)
                {
                    if (word != "")
                        word += " و " + ArabicHundred[((num / 1000000) / 100)];
                    else
                        word += ArabicHundred[((num / 1000000) / 100)];
                    num %= 100000000;
                }
                if ((num / 1000000) >= 20)
                {
                    if (((num / 1000000) % 10) > 0)
                    {
                        if (word != "")
                            word += " و " + ArabicOnes[((num / 1000000) % 10)];
                        else
                            word += ArabicOnes[((num / 1000000) % 10)];
                    }
                    if (word != "")
                        word += " و " + ArabicTens[((num / 1000000) / 10)];
                    else
                        word += ArabicTens[((num / 1000000) / 10)];
                }
                if ((num / 1000000) < 20)
                {
                    if (word != "")
                        word += " و " + ArabicMilloins[(num / 1000000)];
                    else
                        word += ArabicMilloins[(num / 1000000)];
                }
                else word += " مليون";
                num %= 1000000;
            }
            if ((num / 1000) > 0)
            {
                if ((num / 1000) >= 100)
                {
                    if (word != "")
                        word += " و " + ArabicHundred[((num / 1000) / 100)];
                    else
                        word += ArabicHundred[((num / 1000) / 100)];
                    num %= 100000;
                }
                if ((num / 1000) >= 20)
                {
                    if (((num / 1000) % 10) > 0)
                    {
                        if (word != "")
                            word += " و " + ArabicOnes[((num / 1000) % 10)];
                        else
                            word += ArabicOnes[((num / 1000) % 10)];
                    }
                    if (word != "")
                        word += " و " + ArabicTens[((num / 1000) / 10)];
                    else
                        word += ArabicTens[((num / 1000) / 10)];
                    num %= 1000;
                }
                if ((num / 1000) < 20 && (num / 1000 > 0))
                {
                    if (word != "")
                        word += " و " + ArabicThounds[(num / 1000)];
                    else
                        word += ArabicThounds[(num / 1000)];

                }
                else if ((num / 1000) == 0)
                {
                    word += " الف";
                }
                num %= 1000;

            }
            if ((num / 100) > 0)
            {
                if (word != "")
                    word += " و " + ArabicHundred[(num / 100)];
                else
                    word += ArabicHundred[(num / 100)];
                num %= 100;
            }
            if (num > 0)
            {
                if (num < 20)
                {
                    if (word != "")
                        word += " و " + ArabicOnes[num];
                    else
                        word += ArabicOnes[num];
                }
                else
                {

                    if ((num % 10) > 0)
                    {
                        if (word != "")
                            word += " و " + ArabicOnes[num % 10];
                        else
                            word += ArabicOnes[num % 10];
                    }
                    word += " و " + ArabicTens[num / 10];
                }
            }

            return word;


        }
        public List<string> GetPrinterList()
        {
            List<string> PrinterName = new List<string>();
            foreach (string printer in PrinterSettings.InstalledPrinters)
            {
                PrinterName.Add(printer);
            }
            return PrinterName;
        }
        public void SetInfo()
        {
            togglecomname.Tag = pnlcomname;
            togglelogo.Tag = pnllogo;
            togglequot.Tag = pnlquate;
            toggletime.Tag = pnltime;
            toggletotal.Tag = pnltotla;
            toggleorder.Tag = pnlorder;
        }
        public void Enable(object sender, EventArgs e)
        {
            bool Statse;
            Panel pnl = (Panel)(((AboodToggleButton)sender).Tag);
            AboodToggleButton toggle = (AboodToggleButton)sender;
            if (toggle.CheckState == CheckState.Checked)
                Statse = true;
            else
                Statse = false;
            if (Statse)
            {
                foreach (Control con in pnl.Controls)
                {
                    if (con.Name == toggle.Name) continue;
                    con.Enabled = true;
                }
                Statse = false;
            }
            else if (!Statse)
            {
                foreach (Control con in pnl.Controls)
                {
                    if (con.Name == toggle.Name) continue;
                    con.Enabled = false;
                }
                Statse = true;
            }
        }
        public void GetData()
        {
            //Company Name Section
            #region CompanyName
            if (printing.PrintCompanyName.Enabled)
            {
                togglecomname.Checked = true;
                txtcomname._Text = printing.PrintCompanyName.Text;
                numcomnameleft.Value = printing.PrintCompanyName.Left;
                numcomnametop.Value = printing.PrintCompanyName.Top;
                numcomnamefs.Value = printing.PrintCompanyName.FS;
                cbcomnamebold.Checked = printing.PrintCompanyName.Bold;
            }
            else
            {
                togglecomname.Checked = false;
                txtcomname._Text = "";
                numcomnameleft.Value = 0;
                numcomnametop.Value = 0;
                numcomnamefs.Value = 1;
                cbcomnamebold.Checked = false;
            }
            #endregion
            //Logo Section
            #region Logo
            Start1:;
            if (printing.PrintLogo.Enabled)
            {
                togglelogo.Checked = true;
                LogoUrl = printing.PrintLogo.Url;
                if (LogoUrl == "")
                    piclogo.Image = null;
                else
                {
                    if (File.Exists(LogoUrl))
                        piclogo.Image = Image.FromFile(printing.PrintLogo.Url);
                    else
                    {
                        printing.PrintLogo.Enabled = false;
                        goto Start1;
                    }
                }
                numlogoheight.Value = printing.PrintLogo.Height;
                numlogowidth.Value = printing.PrintLogo.Width;
                numlogoleft.Value = printing.PrintLogo.Left;
                numlogotop.Value = printing.PrintLogo.Top;
            }
            else
            {
                togglelogo.Checked = false;
                piclogo.Image = null;
                numlogoheight.Value = 100;
                numlogowidth.Value = 100;
                numlogoleft.Value = 0;
                numlogotop.Value = 0;
            }
            #endregion
            //Qout Section 
            #region Quot
            if (printing.PrintQuot.Enabled)
            {
                togglequot.Checked = true;
                txtquot._Text = printing.PrintQuot.Text;
                numquotfs.Value = printing.PrintQuot.FS;
                cbquotbold.Checked = printing.PrintQuot.Bold;
            }
            else
            {
                togglequot.Checked = false;
                txtquot._Text = "";
                numquotfs.Value = 1;
                cbquotbold.Checked = false;
            }
            #endregion
            //Time Section
            #region Time
            if (printing.PrintTime.Enabled)
            {
                toggletime.Checked = true;
                ckdate.Checked = printing.PrintTime.AddDate;
                cktime.Checked = printing.PrintTime.AddTime;
                numtimeleft.Value = printing.PrintTime.Left;
                numtimetop.Value = printing.PrintTime.Top;
                numtimefs.Value = printing.PrintTime.FS;
                cbtimebold.Checked = printing.PrintTime.Bold;
            }
            else
            {
                toggletime.Checked = false;
                ckdate.Checked = false;
                cktime.Checked = false;
                numtimeleft.Value = 0;
                numtimetop.Value = 0;
                numtimefs.Value = 1;
                cbtimebold.Checked = false;
            }
            #endregion
            //padding Section
            #region Padding
            numpaddingvertical.Value = printing.PrintPadding.Vertical;
            numpaddinghorizontal.Value = printing.PrintPadding.Horizontal;
            #endregion
            //Total Section
            #region Total
            if (printing.PrintTotal.Enabled)
            {
                toggletotal.Checked = true;
                nummaintotalleft.Value = printing.PrintTotal.left;
                numtotalfs.Value = printing.PrintTotal.FS;
                cbtotalbold.Checked = printing.PrintTotal.Bold;
            }
            else
            {
                toggletotal.Checked = false;
                nummaintotalleft.Value = 0;
                numtotalfs.Value = 1;
                cbtotalbold.Checked = false;
            }
            #endregion
            //OrderNumber Section
            #region OrderNumber
            if (printing.PrintOrder.Enabled)
            {
                toggleorder.Checked = printing.PrintOrder.Enabled;
                numordertop.Value = printing.PrintOrder.Top;
                numorderleft.Value = printing.PrintOrder.Left;
                numorderfs.Value = printing.PrintOrder.FS;
                cborderbold.Checked = printing.PrintOrder.Bold;
            }
            else
            {
                toggleorder.Checked = printing.PrintOrder.Enabled;
                numordertop.Value = 0;
                numorderleft.Value = 0;
                numorderfs.Value = 1;
                cborderbold.Checked = false;
            }
            #endregion
            //Columns Section
            #region Columns

            colid.Checked = printing.PrintColumns.Id.Enabled;
            numidleft.Value = printing.PrintColumns.Id.Left;
            numidtop.Value = printing.PrintColumns.Id.Top;
            cbidline.Checked = printing.PrintColumns.Id.AddLine;
            numidlineleft.Value = printing.PrintColumns.Id.LineLeft;

            colname.Checked = printing.PrintColumns.Name.Enabled;
            numnameleft.Value = printing.PrintColumns.Name.Left;
            numnametop.Value = printing.PrintColumns.Name.Top;
            cbnameline.Checked = printing.PrintColumns.Name.AddLine;
            numnamelineleft.Value = printing.PrintColumns.Name.LineLeft;

            colqty.Checked = printing.PrintColumns.QTY.Enabled;
            numqtyleft.Value = printing.PrintColumns.QTY.Left;
            numqtytop.Value = printing.PrintColumns.QTY.Top;
            cbqtyline.Checked = printing.PrintColumns.QTY.AddLine;
            numqtylineleft.Value = printing.PrintColumns.QTY.LineLeft;


            colsubtotal.Checked = printing.PrintColumns.SubTotal.Enabled;
            numsubtotalleft.Value = printing.PrintColumns.SubTotal.Left;
            numsubtotaltop.Value = printing.PrintColumns.SubTotal.Top;
            cbsubtotalline.Checked = printing.PrintColumns.SubTotal.AddLine;
            numsubtotallineleft.Value = printing.PrintColumns.SubTotal.LineLeft;

            coltotal.Checked = printing.PrintColumns.Total.Enabled;
            numtotalleft.Value = printing.PrintColumns.Total.Left;
            numtotaltop.Value = printing.PrintColumns.Total.Top;
            cbtotalline.Checked = printing.PrintColumns.Total.AddLine;
            numtotallineleft.Value = printing.PrintColumns.Total.LineLeft;

            if (printing.PrintColumns.Laneguage == Language.Arabic)
            {
                radarabic.Checked = true;
                ColumnsLanguage = Language.Arabic;
            }
            else if (printing.PrintColumns.Laneguage == Language.English)
            {
                radenglish.Checked = true;
                ColumnsLanguage = Language.English;
            }
            numcolumnsfs.Value = printing.PrintColumns.FS;
            cbcolumnsbold.Checked = printing.PrintColumns.Bold;
            cbaddborder.Checked = printing.PrintColumns.AddBorder;
            cbline.Checked = printing.PrintColumns.AddLine;
            cblinebetweenmats.Checked = printing.PrintColumns.AddLineBetweenMats;
            #endregion

        }
        public void SetData()
        {
            //CompanyName Name Section
            printing.PrintCompanyName.Enabled = togglecomname.Checked;
            printing.PrintCompanyName.Text = txtcomname._Text;
            printing.PrintCompanyName.Left = Convert.ToInt32(numcomnameleft.Value);
            printing.PrintCompanyName.Top = Convert.ToInt32(numcomnametop.Value);
            printing.PrintCompanyName.FS = Convert.ToInt32(numcomnamefs.Value);
            printing.PrintCompanyName.Bold = cbcomnamebold.Checked;

            //Logo Section
            printing.PrintLogo.Enabled = togglelogo.Checked;
            printing.PrintLogo.Url = LogoUrl;
            printing.PrintLogo.Height = Convert.ToInt32(numlogoheight.Value);
            printing.PrintLogo.Width = Convert.ToInt32(numlogowidth.Value);
            printing.PrintLogo.Left = Convert.ToInt32(numlogoleft.Value);
            printing.PrintLogo.Top = Convert.ToInt32(numlogotop.Value);

            //Quot Section
            printing.PrintQuot.Enabled = togglequot.Checked;
            printing.PrintQuot.Text = txtquot._Text;
            printing.PrintQuot.FS = Convert.ToInt32(numquotfs.Value);
            printing.PrintQuot.Bold = cbquotbold.Checked;

            //Time Section
            printing.PrintTime.Enabled = toggletime.Checked;
            printing.PrintTime.AddDate = ckdate.Checked;
            printing.PrintTime.AddTime = cktime.Checked;
            printing.PrintTime.Left = Convert.ToInt32(numtimeleft.Value);
            printing.PrintTime.Top = Convert.ToInt32(numtimetop.Value);
            printing.PrintTime.FS = Convert.ToInt32(numtimefs.Value);
            printing.PrintTime.Bold = cbtimebold.Checked;

            //Pdding Section
            printing.PrintPadding.Vertical = Convert.ToInt32(numpaddingvertical.Value);
            printing.PrintPadding.Horizontal = Convert.ToInt32(numpaddinghorizontal.Value);

            //Total Section
            printing.PrintTotal.Enabled = toggletotal.Checked;
            printing.PrintTotal.left = Convert.ToInt32(nummaintotalleft.Value);
            printing.PrintTotal.FS = Convert.ToInt32(numtotalfs.Value);
            printing.PrintTotal.Bold = cbtotalbold.Checked;

            //OrderNumber Section
            printing.PrintOrder.Enabled = toggleorder.Checked;
            printing.PrintOrder.Top = Convert.ToInt32(numordertop.Value);
            printing.PrintOrder.Left = Convert.ToInt32(numorderleft.Value);
            printing.PrintOrder.FS = Convert.ToInt32(numorderfs.Value);
            printing.PrintOrder.Bold = cborderbold.Checked;



            //Columns Section
            //Id
            printing.PrintColumns.Id.Enabled = colid.Checked;
            printing.PrintColumns.Id.Left = Convert.ToInt32(numidleft.Value);
            printing.PrintColumns.Id.Top = Convert.ToInt32(numidtop.Value);
            printing.PrintColumns.Id.AddLine = cbidline.Checked;
            printing.PrintColumns.Id.LineLeft = Convert.ToInt32(numidlineleft.Value);
            //Name
            printing.PrintColumns.Name.Enabled = colname.Checked;
            printing.PrintColumns.Name.Left = Convert.ToInt32(numnameleft.Value);
            printing.PrintColumns.Name.Top = Convert.ToInt32(numnametop.Value);
            printing.PrintColumns.Name.AddLine = cbnameline.Checked;
            printing.PrintColumns.Name.LineLeft = Convert.ToInt32(numnamelineleft.Value);
            //QTY
            printing.PrintColumns.QTY.Enabled = colqty.Checked;
            printing.PrintColumns.QTY.Left = Convert.ToInt32(numqtyleft.Value);
            printing.PrintColumns.QTY.Top = Convert.ToInt32(numqtytop.Value);
            printing.PrintColumns.QTY.AddLine = cbqtyline.Checked;
            printing.PrintColumns.QTY.LineLeft = Convert.ToInt32(numqtylineleft.Value);
            //SubTotal
            printing.PrintColumns.SubTotal.Enabled = colsubtotal.Checked;
            printing.PrintColumns.SubTotal.Left = Convert.ToInt32(numsubtotalleft.Value);
            printing.PrintColumns.SubTotal.Top = Convert.ToInt32(numsubtotaltop.Value);
            printing.PrintColumns.SubTotal.AddLine = cbsubtotalline.Checked;
            printing.PrintColumns.SubTotal.LineLeft = Convert.ToInt32(numsubtotallineleft.Value);
            //Total
            printing.PrintColumns.Total.Enabled = coltotal.Checked;
            printing.PrintColumns.Total.Left = Convert.ToInt32(numtotalleft.Value);
            printing.PrintColumns.Total.Top = Convert.ToInt32(numtotaltop.Value);
            printing.PrintColumns.Total.AddLine = cbtotalline.Checked;
            printing.PrintColumns.Total.LineLeft = Convert.ToInt32(numtotallineleft.Value);

            //Columns Language
            printing.PrintColumns.Laneguage = ColumnsLanguage;
            printing.PrintColumns.FS = Convert.ToInt32(numcolumnsfs.Value);
            printing.PrintColumns.Bold = cbtimebold.Checked;

            printing.PrintColumns.AddBorder = cbaddborder.Checked;

            printing.PrintColumns.AddLine = cbline.Checked;
            printing.PrintColumns.AddLineBetweenMats = cblinebetweenmats.Checked;

        }
        public void SetDefulteData()
        {
            LogoUrl = "";

            //Company Name Section
            printing.PrintCompanyName.Enabled = true;
            printing.PrintCompanyName.Text = "Abood";
            printing.PrintCompanyName.Left = 0;
            printing.PrintCompanyName.Top = 0;
            printing.PrintCompanyName.FS = 0;
            printing.PrintCompanyName.Bold = false;
            //Logo Section
            printing.PrintLogo.Enabled = false;
            printing.PrintLogo.Url = "";
            printing.PrintLogo.Height = 100;
            printing.PrintLogo.Width = 100;
            printing.PrintLogo.Left = 0;
            printing.PrintLogo.Top = 0;

            //Quot Section
            printing.PrintQuot.Enabled = false;
            printing.PrintQuot.Text = "";
            printing.PrintQuot.FS = 0;
            printing.PrintQuot.Bold = false;

            //Time Section
            printing.PrintTime.Enabled = false;
            printing.PrintTime.AddDate = false;
            printing.PrintTime.AddTime = false;
            printing.PrintTime.Left = 0;
            printing.PrintTime.Top = 0;

            //Padding Sectin
            printing.PrintPadding.Vertical = 10;
            printing.PrintPadding.Horizontal = 10;

            //Total Section 
            printing.PrintTotal.Enabled = true;
            printing.PrintTotal.left = 0;
            printing.PrintTotal.FS = 0;
            printing.PrintTotal.Bold = false;

            //OrderNumber Section 
            printing.PrintOrder.Enabled = false;
            printing.PrintOrder.Top = 0;
            printing.PrintOrder.Left = 0;
            printing.PrintOrder.FS = 1;
            printing.PrintOrder.Bold = false;

            //Columns Section
            //Id
            printing.PrintColumns.Id.Enabled = false;
            printing.PrintColumns.Id.Left = 0;
            printing.PrintColumns.Id.Top = 0;
            printing.PrintColumns.Id.AddLine = false;
            printing.PrintColumns.Id.LineLeft = 0;
            //Name
            printing.PrintColumns.Name.Enabled = false;
            printing.PrintColumns.Name.Left = 0;
            printing.PrintColumns.Name.Top = 0;
            printing.PrintColumns.Name.AddLine = false;
            printing.PrintColumns.Name.LineLeft = 0;
            //QTY
            printing.PrintColumns.QTY.Enabled = false;
            printing.PrintColumns.QTY.Left = 0;
            printing.PrintColumns.QTY.Top = 0;
            printing.PrintColumns.QTY.AddLine = false;
            printing.PrintColumns.QTY.LineLeft = 0;
            //SubTotal
            printing.PrintColumns.SubTotal.Enabled = false;
            printing.PrintColumns.SubTotal.Left = 0;
            printing.PrintColumns.SubTotal.Top = 0;
            printing.PrintColumns.SubTotal.AddLine = false;
            printing.PrintColumns.SubTotal.LineLeft = 0;
            //Total
            printing.PrintColumns.Total.Enabled = false;
            printing.PrintColumns.Total.Left = 0;
            printing.PrintColumns.Total.Top = 0;
            printing.PrintColumns.Total.AddLine = false;
            printing.PrintColumns.Total.LineLeft = 0;
            //Language
            ColumnsLanguage = Language.Arabic;
            printing.PrintColumns.Laneguage = ColumnsLanguage;
            printing.PrintColumns.FS = 0;
            printing.PrintColumns.Bold = false;

            printing.PrintColumns.AddBorder = false;

            printing.PrintColumns.AddLine = false;
            printing.PrintColumns.AddLineBetweenMats = false;
        }
        public void ChangeColors()
        {
            pnltop.BackColor = _BackColor;
            pnlcontainer.BackColor = _BackColor;
            btnnavoutside.BackColor = _BackColor;
            pnlsideline.BackColor = _BackColor;
            if (json.Theme == "Dark")
            {
                BackColor = Dark1;
                pnltools.BackColor = Dark2;
                pnlnav.BackColor = Dark1;
                foreach (Control con in pnltools.Controls)
                {
                    if (con is Panel)
                    {
                        if (con.Name == "pnltools") continue;
                        con.BackColor = Dark1;
                        foreach (Control c in con.Controls)
                        {
                            if (c is AboodToggleButton || c is AboodButton) continue;
                            c.BackColor = Dark1;
                        }
                    }
                }
            }
            else if (json.Theme == "Light")
            {
                BackColor = Light1;
                pnltools.BackColor = Light2;
                pnlnav.BackColor = Light1;
                foreach (Control con in pnltools.Controls)
                {
                    if (con.Name == "pnltools") continue;
                    if (con is Panel)
                    {
                        con.BackColor = Light1;
                        foreach (Control c in con.Controls)
                        {
                            if (c is AboodToggleButton || c is AboodButton) continue;
                            c.BackColor = Light1;
                        }
                    }
                }
            }
        }
        public void PrintPreview(object sende, PrintPageEventArgs e)
        {
            int paddingvertical = printing.PrintPadding.Vertical,
                paddinghorizontal = printing.PrintPadding.Horizontal;
            if (printing.PrintCompanyName.Enabled)
            {
                int namefontsize = printing.PrintCompanyName.FS;
                FontStyle namestyle = FontStyle.Regular;
                if (printing.PrintCompanyName.Bold)
                    namestyle = FontStyle.Bold;
                Font font = new Font("Arialf", namefontsize, namestyle);
                string name = printing.PrintCompanyName.Text;
                int nameleft = printing.PrintCompanyName.Left;
                int nametop = printing.PrintCompanyName.Top;
                Point namelocation = new Point(nameleft, nametop);
                e.Graphics.DrawString(name, font, Brushes.Black, namelocation);
            }

            if (printing.PrintLogo.Enabled)
            {
                if (LogoUrl == "") { }
                else
                {
                    string logourl = printing.PrintLogo.Url;
                    int logoheight = printing.PrintLogo.Height;
                    int logowidth = printing.PrintLogo.Width;
                    int logoleft = printing.PrintLogo.Left;
                    int logotop = printing.PrintLogo.Top;
                    Image logoimg = Image.FromFile(logourl);
                    Point logolocation = new Point(logoleft, logotop);
                    Size logorecsize = new Size(logowidth, logoheight);
                    Rectangle logorec = new Rectangle(logolocation, logorecsize);
                    e.Graphics.DrawImage(logoimg, logorec);
                }
            }
            if (printing.PrintTime.Enabled)
            {
                DateTime d = DateTime.Now;
                int timeleft = printing.PrintTime.Left;
                int timetop = printing.PrintTime.Top;
                int preheight = timetop;
                string Date = d.ToShortDateString();
                string Time = d.ToShortTimeString();
                int timefontsize = printing.PrintTime.FS;
                FontStyle timestyle = FontStyle.Regular;
                if (printing.PrintTime.Bold)
                    timestyle = FontStyle.Bold;
                Font timefont = new Font("Arial", timefontsize, timestyle);
                Point timelocation = new Point();
                if (printing.PrintTime.AddDate)
                {
                    SizeF DateSize = e.Graphics.MeasureString(Date, timefont);
                    timelocation = new Point(timeleft, preheight);
                    e.Graphics.DrawString(Date, timefont, Brushes.Black, timelocation);
                    preheight += Convert.ToInt32(DateSize.Height);
                }
                if (printing.PrintTime.AddTime)
                {
                    timelocation = new Point(timeleft, preheight);
                    e.Graphics.DrawString(Time, timefont, Brushes.Black, timelocation);
                }
            }
            if (printing.PrintOrder.Enabled)
            {
                int orderleft = printing.PrintOrder.Left;
                int ordertop = printing.PrintOrder.Top;
                int orderfs = printing.PrintOrder.FS;
                string ordertext = "TestOrderNum,123";
                FontStyle orderstyle = FontStyle.Regular;
                if (printing.PrintOrder.Bold)
                    orderstyle = FontStyle.Bold;
                Font orderfont = new Font("Arial", orderfs, orderstyle);
                Point orderlocation = new Point(orderleft, ordertop);
                e.Graphics.DrawString(ordertext, orderfont, Brushes.Black, orderlocation);
            }
            string colid = "Id";
            string colname = "Name";
            string colqty = "QTY";
            string colsubtotal = "Sub Total";
            string coltotal = "Total";
            if (printing.PrintColumns.Laneguage == Language.Arabic)
            {
                colid = "الرقم";
                colname = "الاسم";
                colqty = "الكمية";
                colsubtotal = "اسعر الإفرادي";
                coltotal = "السعر الإجمالي";
            }
            else if (printing.PrintColumns.Laneguage == Language.English)
            {
                colid = "Id";
                colname = "Name";
                colqty = "QTY";
                colsubtotal = "Sub Total";
                coltotal = "Total";
            }
            int columnsfontsize = printing.PrintColumns.FS;
            FontStyle columnstyle = FontStyle.Regular;
            if (printing.PrintColumns.Bold)
                columnstyle = FontStyle.Bold;
            Font columnsfont = new Font("Arial", columnsfontsize, columnstyle);
            if (printing.PrintColumns.Id.Enabled)
            {
                int idleft = printing.PrintColumns.Id.Left;
                int idtop = printing.PrintColumns.Id.Top;
                Point idlocation = new Point(idleft, idtop);
                e.Graphics.DrawString(colid, columnsfont, Brushes.Black, idlocation);
            }
            if (printing.PrintColumns.Name.Enabled)
            {
                int nameleft = printing.PrintColumns.Name.Left;
                int nametop = printing.PrintColumns.Name.Top;
                Point namelocation = new Point(nameleft, nametop);
                SizeF namesize = e.Graphics.MeasureString(colname, columnsfont);
                e.Graphics.DrawString(colname, columnsfont, Brushes.Black, namelocation);
                PreHeight = Convert.ToInt32(nametop + namesize.Height + paddingvertical);
            }
            if (printing.PrintColumns.QTY.Enabled)
            {
                int qtyleft = printing.PrintColumns.QTY.Left;
                int qtytop = printing.PrintColumns.QTY.Top;
                Point qtylocation = new Point(qtyleft, qtytop);
                e.Graphics.DrawString(colqty, columnsfont, Brushes.Black, qtylocation);
            }
            if (printing.PrintColumns.SubTotal.Enabled)
            {
                int subtotalleft = printing.PrintColumns.SubTotal.Left;
                int subtotaltop = printing.PrintColumns.SubTotal.Top;
                Point subtotallocation = new Point(subtotalleft, subtotaltop);
                e.Graphics.DrawString(colsubtotal, columnsfont, Brushes.Black, subtotallocation);
            }
            if (printing.PrintColumns.Total.Enabled)
            {
                int totalleft = printing.PrintColumns.Total.Left;
                int totaltop = printing.PrintColumns.Total.Top;
                Point namelocation = new Point(totalleft, totaltop);
                e.Graphics.DrawString(coltotal, columnsfont, Brushes.Black, namelocation);
            }
            if (printing.PrintColumns.AddLine)
            {
                Point startmainline = new Point(paddinghorizontal, PreHeight);
                Point endmainline = new Point(e.PageBounds.Width - paddinghorizontal, PreHeight);
                e.Graphics.DrawLine(Pens.Black, startmainline, endmainline);
                PreHeight = endmainline.Y + paddingvertical;
            }
            int paddingverticaltest = printing.PrintPadding.Vertical,
            paddinghorizontaltest = printing.PrintPadding.Horizontal;
            int HeightToAdd = 0;
            int fs = printing.PrintColumns.FS;
            FontStyle style = FontStyle.Regular;
            if (printing.PrintColumns.Bold)
                style = FontStyle.Bold;
            Font fonttest = new Font("Arial", fs, style);
            Brush brush = Brushes.Black;
            Pen pen = Pens.Black;
            int startid = e.PageBounds.Width - paddingvertical,
                endid = printing.PrintColumns.Id.LineLeft,
                startname = endid,
                endname = printing.PrintColumns.Name.LineLeft,
                startqty = endname,
                endqty = printing.PrintColumns.QTY.LineLeft,
                startsubtotal = endqty,
                endsubtotal = printing.PrintColumns.SubTotal.LineLeft,
                starttotal = endsubtotal,
                endtotal = paddinghorizontal;
            for (int i = 0; i < 5; i++)
            {
                if (i > 0)
                { PreHeight += paddingvertical; }
                //Id Section
                if (printing.PrintColumns.Id.Enabled)
                {
                    string id = Convert.ToString(order1[0]);
                    SizeF idsize = e.Graphics.MeasureString(id, fonttest);
                    int idleft = Convert.ToInt32(((startid - endid - idsize.Width) / 2) + endid);
                    Point idlocation = new Point(idleft, PreHeight);
                    e.Graphics.DrawString(id, fonttest, brush, idlocation);
                }
                //Name Section
                if (printing.PrintColumns.Name.Enabled)
                {
                    string name = Convert.ToString(order1[1]);
                    SizeF namesize = e.Graphics.MeasureString(name, fonttest);
                    int nameleft = Convert.ToInt32(((startname - endname - namesize.Width) / 2) + endname);
                    Point namelocation = new Point(nameleft, PreHeight);
                    e.Graphics.DrawString(name, fonttest, brush, namelocation);
                    HeightToAdd = Convert.ToInt32(namesize.Height + paddingvertical);
                }
                //QTY Section 
                if (printing.PrintColumns.QTY.Enabled)
                {
                    string qty = Convert.ToString(order1[2]);
                    SizeF qtysize = e.Graphics.MeasureString(qty, fonttest);
                    int qtyleft = Convert.ToInt32(((startqty - endqty - qtysize.Width) / 2) + endqty);
                    Point qtylocation = new Point(qtyleft, PreHeight);
                    e.Graphics.DrawString(qty, fonttest, brush, qtylocation);
                }
                //SubTotal Section
                if (printing.PrintColumns.SubTotal.Enabled)
                {
                    string subtotal = Convert.ToString(order1[3]);
                    SizeF subtotalsize = e.Graphics.MeasureString(subtotal, fonttest);
                    int subtotalleft = Convert.ToInt32(((startsubtotal - endsubtotal - subtotalsize.Width) / 2) + endsubtotal);
                    Point subtotallocation = new Point(subtotalleft, PreHeight);
                    e.Graphics.DrawString(subtotal, fonttest, brush, subtotallocation);
                }
                //Total Section
                if (printing.PrintColumns.Total.Enabled)
                {
                    string total = Convert.ToString(order1[4]);
                    SizeF totalsize = e.Graphics.MeasureString(total, fonttest);
                    int totalleft = Convert.ToInt32(((starttotal - endtotal - totalsize.Width) / 2) + endtotal);
                    Point totallocation = new Point(totalleft, PreHeight);
                    e.Graphics.DrawString(total, fonttest, brush, totallocation);
                }
                //Add Line After The Row
                PreHeight += HeightToAdd;
                if (printing.PrintColumns.AddLineBetweenMats)
                {
                    Point startline = new Point(paddinghorizontal, PreHeight);
                    Point endline = new Point(e.PageBounds.Width - paddinghorizontal, PreHeight);
                    e.Graphics.DrawLine(pen, startline, endline);
                }
            }
            if (printing.PrintColumns.Id.AddLine)
            {
                int idlineleft = printing.PrintColumns.Id.LineLeft;
                Point idlinestart = new Point(idlineleft, printing.PrintColumns.Id.Top - paddingvertical);
                Point idlineend = new Point(idlineleft, PreHeight);
                e.Graphics.DrawLine(Pens.Black, idlinestart, idlineend);
            }
            if (printing.PrintColumns.Name.AddLine)
            {
                int namelineleft = printing.PrintColumns.Name.LineLeft;
                Point namestartline = new Point(namelineleft, printing.PrintColumns.Name.Top - paddingvertical);
                Point nameendline = new Point(namelineleft, PreHeight);
                e.Graphics.DrawLine(Pens.Black, namestartline, nameendline);
            }
            if (printing.PrintColumns.QTY.AddLine)
            {
                int qtylineleft = printing.PrintColumns.QTY.LineLeft;
                Point qtystartline = new Point(qtylineleft, printing.PrintColumns.QTY.Top - paddingvertical);
                Point qtyendline = new Point(qtylineleft, PreHeight);
                e.Graphics.DrawLine(Pens.Black, qtystartline, qtyendline);
            }
            if (printing.PrintColumns.SubTotal.AddLine)
            {
                int subtotallineleft = printing.PrintColumns.SubTotal.LineLeft;
                Point subtotalstartline = new Point(subtotallineleft, printing.PrintColumns.SubTotal.Top - paddingvertical);
                Point subtotalendline = new Point(subtotallineleft, PreHeight);
                e.Graphics.DrawLine(Pens.Black, subtotalstartline, subtotalendline);
            }
            if (printing.PrintColumns.Total.AddLine)
            {
                int totallineleft = printing.PrintColumns.Total.LineLeft;
                Point totalstartline = new Point(totallineleft, printing.PrintColumns.Total.Top - paddingvertical);
                Point totalendline = new Point(totallineleft, PreHeight);
                e.Graphics.DrawLine(Pens.Black, totalstartline, totalendline);
            }
            if (printing.PrintColumns.AddBorder)
            {
                Point border1 = new Point(paddinghorizontal, printing.PrintColumns.Name.Top - paddingvertical);
                Point border2 = new Point(e.PageBounds.Width - paddinghorizontal, printing.PrintColumns.Name.Top - paddingvertical);
                Point border3 = new Point(e.PageBounds.Width - paddinghorizontal, PreHeight);
                Point border4 = new Point(paddinghorizontal, PreHeight);
                e.Graphics.DrawLine(Pens.Black, border1, border2);
                e.Graphics.DrawLine(Pens.Black, border2, border3);
                e.Graphics.DrawLine(Pens.Black, border3, border4);
                e.Graphics.DrawLine(Pens.Black, border4, border1);
            }

            if (printing.PrintTotal.Enabled)
            {
                PreHeight += paddingvertical;
                int totalfontsize = printing.PrintTotal.FS;
                string totalnums = "12345678";
                FontStyle totalstyle = FontStyle.Regular;
                if (printing.PrintTotal.Bold)
                    totalstyle = FontStyle.Bold;
                Font totalfont = new Font("Arial", totalfontsize, totalstyle);
                SizeF totalsize = e.Graphics.MeasureString(totalnums, totalfont);
                int totalleft = printing.PrintTotal.left;
                Point totallocation = new Point(totalleft, PreHeight);
                e.Graphics.DrawString("Total: " + totalnums, totalfont, Brushes.Black, totallocation);
                string totaltext = ConvertNumbersToString(int.Parse(totalnums));
                SizeF totaltextsize = e.Graphics.MeasureString(totaltext, totalfont);
                PreHeight += Convert.ToInt32(paddingvertical + totalsize.Height);
                int totaltextleft = Convert.ToInt32(e.PageBounds.Width - paddinghorizontal - totaltextsize.Width),
                    totaltexttop = PreHeight;
                Point totaltextlocation = new Point(totaltextleft, totaltexttop);
                e.Graphics.DrawString(totaltext, totalfont, Brushes.Black, totaltextlocation);
                PreHeight += Convert.ToInt32((paddingvertical * 2) + totaltextsize.Height);
            }
            if (printing.PrintQuot.Enabled)
            {
                int quotfontsize = printing.PrintQuot.FS;
                FontStyle quotstyle = FontStyle.Regular;
                if (printing.PrintQuot.Bold)
                    quotstyle = FontStyle.Bold;
                Font quotfont = new Font("Arial", quotfontsize, quotstyle);
                string quot = printing.PrintQuot.Text;
                SizeF quotsize = e.Graphics.MeasureString(quot, quotfont);
                int quotleft = Convert.ToInt32((e.PageBounds.Width - quotsize.Width) / 2);
                Point quotlocation = new Point(quotleft, PreHeight);
                Point p1 = new Point((e.PageBounds.Width - 500) / 2, PreHeight - paddingvertical);
                Point p2 = new Point(e.PageBounds.Width - p1.X, PreHeight - paddingvertical);
                e.Graphics.DrawLine(Pens.Black, p1, p2);
                e.Graphics.DrawString(quot, quotfont, Brushes.Black, quotlocation);
            }

        }
        public void ChangeLanguage()
        {
            if (json.Language == "Arabic")
            {
                if (language == Languages.English)
                {
                    string title = Convert.ToString(lbltitle.Tag);
                    lbltitle.Tag = lbltitle.Text;
                    lbltitle.Text = title;
                    foreach (Panel pnl in pnltools.Controls)
                    {
                        foreach (Control control in pnl.Controls)
                        {
                            if (control is NumericUpDown) continue;
                            string name = Convert.ToString(control.Tag);
                            control.Tag = control.Text;
                            control.Text = name;
                        }
                    }
                    foreach (Control control in pnlnav.Controls)
                    {
                        string name = Convert.ToString(control.Tag);
                        control.Tag = control.Text;
                        control.Text = name;
                    }
                    btnexit.Location = new Point(5, 1);
                    lbltitle.Location = new Point((pnltop.Width - lbltitle.Width) - 5, 8);
                }
                language = Languages.Arabic;
            }
            else if (json.Language == "English")
            {
                if (language == Languages.Arabic)
                {
                    string title = Convert.ToString(lbltitle.Tag);
                    lbltitle.Tag = lbltitle.Text;
                    lbltitle.Text = title;
                    foreach (Panel pnl in pnltools.Controls)
                    {
                        foreach (Control control in pnl.Controls)
                        {
                            if (control is NumericUpDown) continue;
                            string name = Convert.ToString(control.Tag);
                            control.Tag = control.Text;
                            control.Text = name;
                        }
                    }
                    foreach (Control control in pnlnav.Controls)
                    {
                        string name = Convert.ToString(control.Tag);
                        control.Tag = control.Text;
                        control.Text = name;
                    }
                    btnexit.Location = new Point(pnltop.Width - 38, 1);
                    lbltitle.Location = new Point(5, 8);
                }
                language = Languages.English;
            }
        }
        //Events
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
            //Application.Exit();
            MainForm.printing = printing;
            this.Close();
            Application.OpenForms[1].Show();
        }
        private void PrintingForm_Load(object sender, EventArgs e)
        {
            //ReadPrintingFile(ref printing, LoginForm.PrintingRoot);
            //ReadDataFile(ref json, LoginForm.DataRoot);
            json = MainForm.json;
            printing = MainForm.printing;
            _BackColor = LoginForm.MainColor[json.MainColorNum];
            ChangeColors();
            ChangeLanguage();
            SetInfo();
            GetData();
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            SetData();
            WritePrintingFile(printing, LoginForm.PrintingRoot);
        }
        private void btnlogobrows_Click(object sender, EventArgs e)
        {
            ofdlogo.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ofdlogo.Filter = "Images:|*.png;*.jpg|All:|*.*";

            ofdlogo.Title = "Chose An Image!";
            if (ofdlogo.ShowDialog() == DialogResult.OK)
            {
                LogoUrl = ofdlogo.FileName;
                piclogo.Image = Image.FromFile(LogoUrl);
            }
        }
        private void btnlogodelete_Click(object sender, EventArgs e)
        {
            LogoUrl = "";
            piclogo.Image = null;
        }
        private void btndefulte_Click(object sender, EventArgs e)
        {
            SetDefulteData();
            WritePrintingFile(printing, LoginForm.PrintingRoot);
            GetData();
        }
        private void printdocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            PrintPreview(sender, e);
        }
        private void btnpreview_Click(object sender, EventArgs e)
        {
            ((Form)printpreview).WindowState = FormWindowState.Maximized;
            if (printpreview.ShowDialog() == DialogResult.OK)
            {
                printdocument.Print();
            }
        }
        private void radarabic_CheckedChanged(object sender, EventArgs e)
        {
            ColumnsLanguage = Language.Arabic;
        }
        private void radenglish_CheckedChanged(object sender, EventArgs e)
        {
            ColumnsLanguage = Language.English;
        }
        private void tiemrnav_Tick(object sender, EventArgs e)
        {
            if (In)
            {
                pnlnav.Location = new Point(pnlnav.Location.X - 15, pnlnav.Location.Y);
                btnnavoutside.Location = new Point(btnnavoutside.Location.X - 15, btnnavoutside.Location.Y);
                timer += 1;
                if (timer == 10)
                {
                    In = false;
                    timernav.Stop();
                    Runing = false;
                }
            }
            else if (!In)
            {
                pnlnav.Location = new Point(pnlnav.Location.X + 15, pnlnav.Location.Y);
                btnnavoutside.Location = new Point(btnnavoutside.Location.X + 15, btnnavoutside.Location.Y);
                timer -= 1;
                if (timer == 0)
                {
                    In = true;
                    timernav.Stop();
                    Runing = false;
                }
            }
        }
        private void btnnavoutside_Click(object sender, EventArgs e)
        {
            if (Runing) return;
            Runing = true;
            timernav.Start();
        }
    }
}
