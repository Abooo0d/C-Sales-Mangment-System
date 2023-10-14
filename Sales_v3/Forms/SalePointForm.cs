using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Collections.Generic;
using System.IO;
using AboodTools_v5;
using System.ComponentModel;
using System.Drawing.Printing;
using Sales_v3.Class;
using static Sales_v3.Class.JsonServices;

namespace Sales_v3.Forms
{
    public partial class SalePointForm : Form
    {
        //Fields
        #region Fields
        public static DateTime date = DateTime.Now;
        public static DataServices json = new DataServices();
        public static PrintingServcies printing = new PrintingServcies();
        public bool Database = false;
        public bool Dragging = false;
        public bool Loading = false;
        public static string SalesRoot = (Environment.GetFolderPath
           (Environment.SpecialFolder.UserProfile)) + "\\AppData\\Local\\Sales\\Sales\\";
        public Point StartPoint = new Point(0, 0);
        public static int PreHeight = 0;
        public bool Error = false;
        public bool In = true;
        public int timer = 0;
        public bool Runing = false;
        public bool Showpanel = true;
        public bool ShowSearch = false;
        public int OrderNumber = 1;
        public static object[] row = new object[5];
        public static Control[] Tools;
        public static int[] ToolsOrder;
        public object Customer = 0 + ";";
        public object[] Customers = new object[4] { null, null, null, null };
        public int Total = 0;
        public static List<string> Sales = new List<string>();
        public string sale = "";
        public double[] MatsQTY;
        public string[] ArabicNames = new string[26] {
        "نقطة البيع",
        "اسم المستخدم:","المجموع:",
        "رقم الطلب:","طباعة",
        "إزالة الأخطاء","تعديل السعر",
        "تعديل الكمية","المبيعات",
        "حفظ المبيعات","حذف مادة",
        "حذف الطلب","زبون:",
        "زبون 1","زبون 2",
        "زبون 3 ","زبون 4",
        "الرقم","اسم المادة",
        "الكمية","السعر",
        "السعر الإجمالي","إنذارات",
        "تسجيل خروج","عرض قائمة المواد",
        "عرض مربع البحث"};
        public string[] EnglishNames = new string[26] {
        "Sale Point",
        "User Name:","Total:",
        "Order Number:","Print",
        "CLear Error","Edite Price",
        "Edite QTY","Sales",
        "Save Sales","Delete Matrial",
        "Delete Order","Customer:",
        "Customer 1","Customer 2",
        "Customer 3","Customer 4",
        "Num","MatrialName",
        "QTY","Price",
        "Sub Total","Warnings",
        "Log Out","Show Search Box",
        "Show Tools Panel"};
        public AutoCompleteStringCollection CompleteSource = new AutoCompleteStringCollection();
        public static Color _BackColor = new Color();
        public Color Dark1 = Color.FromArgb(255, 43, 43, 43);
        public Color Dark2 = Color.FromArgb(255, 50, 50, 50);
        public Color Light1 = Color.FromArgb(255, 213, 213, 213);
        public Color Light2 = Color.FromArgb(255, 230, 230, 230);
        public enum Languages { Arabic,English}
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
        public SalePointForm()
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
        public void CreatSalesFile()
        {
            try
            {
                if (Error) return;
                if (OrderNumber == 1) return;
                int num = json.SalesFileName;
                StreamWriter StreamSales = new StreamWriter($"{ SalesRoot }sale { num }.txt");
                for (int i = 0; i < Sales.Count; i++)
                {
                    StreamSales.WriteLine(Sales[i]);
                }
                Sales.Clear();
                num++;
                json.SalesFileName = num;
                sale = "";
                Customer = 1 + ";";
                Customers = new object[4] { null, null, null, null };
                lblcustomer.Text = "1";
                Total = 0;
                lbltotal.Text = Total.ToString();
                OrderNumber = 1;
                lblordernumber.Text = OrderNumber.ToString();
                dgvsales.Rows.Clear();
                StreamSales.Close();
                json.SalesFileName = num;
                WriteDataFile(json, LoginForm.DataRoot);
            }
            catch (Exception ex)
            {
                Error = true;
                lblerror.Invoke((MethodInvoker)delegate
                {
                    lblerror.Text = "CreatSalesFile() " + ex.Message;
                });
            }
        }
        public void MoveBetweenCustomer(object sender, EventArgs e)
        {
            try
            {
                if (Error) return;
                Total = 0;
                dgvsales.Rows.Clear();
                int CurrentCustomer = Convert.ToInt32((Customer.ToString()).Substring(0, 1));
                int NextCustomer = Convert.ToInt32(((AboodButton)sender).Tag);
                Customers[CurrentCustomer] = Customer;
                if (Customers[NextCustomer] == null)
                {
                    Customer = NextCustomer + ";";
                    lbltotal.Text = "0";
                    Total = 0;
                }
                else
                {
                    Customer = Convert.ToString(Customers[NextCustomer]);
                    string[] DataArray = (Customer.ToString()).Split(';');
                    for (int i = 1; i < DataArray.Length - 5; i += 5)
                    {
                        object id = DataArray[i];
                        object name = DataArray[i + 1];
                        object qty = DataArray[i + 2];
                        object price = DataArray[i + 3];
                        object subtotal = DataArray[i + 4];
                        Total += Convert.ToInt32(subtotal);
                        object[] row = { id, name, qty, price, subtotal };
                        dgvsales.Rows.Add(row);
                    }
                }
                lbltotal.Text = Total.ToString();
                lblcustomer.Text = (NextCustomer + 1).ToString();
            }
            catch (Exception ex)
            {
                Error = true;
                lblerror.Invoke((MethodInvoker)delegate
                {
                    lblerror.Text = "MoveBetweenCustomer() " + ex.Message;
                });
            }
        }
        public void ClearTools()
        {
            try
            {
                dgvsales.Rows.Clear();
                txtnumbers._Text = "";
                lbltotal.Text = "0";
                Customer = 0 + ";";
                Customers = new object[4] { null, null, null, null };
                lblcustomer.Text = "1";
            }
            catch (Exception ex)
            {
                Error = true;
                lblerror.Invoke((MethodInvoker)delegate
                {
                    lblerror.Text = "ClearTools() " + ex.Message;
                });
            }
        }
        public void ChangeColor()
        {
            try
            {
                pnldgvsales.BackColor = _BackColor;
                pnlcontainernums.BackColor = _BackColor;
                pnlcontainertools.BackColor = _BackColor;
                pnlcontainermats.BackColor = _BackColor;
                pnlcontainercustomer.BackColor = _BackColor;
                pnltop.BackColor = _BackColor;
                dgvsales.HeaderBgColor = _BackColor;
                btnsearch.BackColor = _BackColor;
                txtsearch.FocusColor = _BackColor;
                pnlsidenav.BackColor = _BackColor;
                btnnavoutside.BackColor = _BackColor;

                if (json.Theme == "Dark")
                {
                    BackColor = Dark1;
                    pnlmats.BackColor = Dark2;
                    pnltools.BackColor = Dark2;
                    pnlcustomers.BackColor = Dark2;
                    pnlnumbers.BackColor = Dark2;
                    txtnumbers.BackColor = Dark2;
                    txtsearch.BackColor = Dark1;
                    foreach (Control c in pnlnumbers.Controls)
                    {
                        if (c is AboodButton && c.Text != "C")
                        {
                            c.BackColor = Dark2;
                        }
                    }
                    btnclear.BackColor = Dark1;
                    btnclearall.BackColor = Dark1;
                    btnenter.BackColor = Dark1;
                    pnlnav.BackColor = Dark1;

                }
                else if (json.Theme == "Light")
                {
                    BackColor = Light1;
                    pnlmats.BackColor = Light2;
                    pnltools.BackColor = Light2;
                    pnlcustomers.BackColor = Light2;
                    pnlnumbers.BackColor = Light2;
                    txtnumbers.BackColor = Light2;
                    txtsearch.BackColor = Light1;
                    foreach (Control c in pnlnumbers.Controls)
                    {
                        if (c is AboodButton)
                        {
                            c.BackColor = Light2;
                        }
                    }
                    btnclear.BackColor = Light1;
                    btnclearall.BackColor = Light1;
                    btnenter.BackColor = Light1;
                    pnlnav.BackColor = Light2;
                }
            }
            catch (Exception ex)
            {
                Error = true;
                lblerror.Invoke((MethodInvoker)delegate
                {
                    lblerror.Text = "ChangeColor() " + ex.Message;
                });

            }
        }
        public void BtnEvent_Click(AboodButton btnmat)
        {
            try
            {
                bool enabled = true;
                if (Error) return;
                int x = Convert.ToInt32(btnmat.Tag);
                int id = Convert.ToInt32(LoginForm.SalesTable.Rows[x]["Id"]);
                row[0] = id;
                string name = LoginForm.SalesTable.Rows[x]["Material_Name"].ToString();
                row[1] = name;
                double matqty = Convert.ToDouble(LoginForm.SalesTable.Rows[x]["QTY"]);
                double qty = 0;
                if (txtnumbers._Text == "")
                {
                    if (MatsQTY[x] <= 0)
                    {
                        btnmat.Enabled = false;
                        return;
                    }
                    else if (MatsQTY[x] < 1)
                    {
                        qty = Math.Round(MatsQTY[x], 3);
                        MatsQTY[x] -= qty;
                        enabled = false;
                    }
                    else if (MatsQTY[x] == 1)
                    {
                        qty = 1;
                        MatsQTY[x] -= qty;
                        enabled = false;
                    }
                    else
                    {
                        MatsQTY[x]--;
                        qty = 1;
                    }
                }
                else if (txtnumbers._Text.Trim() != "")
                {
                    if (MatsQTY[x] <= 0)
                    {
                        btnmat.Enabled = false;
                        return;
                    }
                    else
                    {
                        qty = Convert.ToDouble(txtnumbers._Text);
                        if (qty >= MatsQTY[x])
                        {
                            qty = Math.Round(MatsQTY[x], 3);
                            MatsQTY[x] -= qty;
                            enabled = false;
                        }
                        else
                        {
                            MatsQTY[x] -= qty;
                        }
                    }
                }
                row[2] = qty;
                int price = Convert.ToInt32(LoginForm.SalesTable.Rows[x]["Price"]);
                row[3] = price;
                double subtotal = price * qty;
                row[4] = subtotal;
                Total += Convert.ToInt32(subtotal);
                lbltotal.Text = Total.ToString();
                txtnumbers._Text = "";
                Customer += id + ";" + name + ";" + qty + ";" + price + ";" + subtotal + ";";
                dgvsales.Rows.Add(row);
                if (!enabled)
                {
                    btnmat.Enabled = false;
                }

            }
            catch (Exception ex)
            {
                Error = true;
                lblerror.Invoke((MethodInvoker)delegate
                {
                    lblerror.Text = "BtnEvent_Click() " + ex.Message;
                });
            }
        }
        public void CreatTools()
        {
            try
            {
                if (!Database)
                {
                    lblerror.Invoke((MethodInvoker)delegate
                    {
                        lblerror.Text = "No DataBsae Detacted!.";
                    });
                    return;
                }
                if (Error)
                {
                    return;
                }
                pnlmats.Controls.Clear();
                Tools = new Control[LoginForm.SalesTable.Rows.Count];
                ToolsOrder = new int[LoginForm.SalesTable.Rows.Count];
                MatsQTY = new double[LoginForm.SalesTable.Rows.Count];
                for (int i = 0; i < LoginForm.SalesTable.Rows.Count; i++)
                {
                    MatsQTY[i] = Convert.ToDouble(LoginForm.SalesTable.Rows[i]["QTY"]);
                    AboodButton btnmat = new AboodButton
                    {
                        Text = LoginForm.SalesTable.Rows[i]["Material_Name"].ToString(),
                        TextAlign = ContentAlignment.MiddleCenter,
                        BackColor = Color.FromName(LoginForm.SalesTable.Rows[i]["Color"].ToString()),
                        BorderColor = Color.FromName(LoginForm.SalesTable.Rows[i]["Border_Color"].ToString()),
                        Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular, GraphicsUnit.Pixel),
                        Tag = i.ToString(),
                        Size = new Size(120, 50),
                        BorderRadius = 15,
                    };
                    if (MatsQTY[i] <= 0)
                    {
                        btnmat.Enabled = false;
                    }
                    else if (MatsQTY[i] > 0)
                    {
                        btnmat.Enabled = true;
                    }
                    string _Button = Convert.ToString(LoginForm.SalesTable.Rows[i]["Button"]).ToLower();
                    string _Border = Convert.ToString(LoginForm.SalesTable.Rows[i]["Border"]).ToLower();
                    int toolOrder = Convert.ToInt32(LoginForm.SalesTable.Rows[i]["Tool_Order"]);
                    if (_Border == "true")
                        btnmat.BorderSize = 2;
                    else
                        btnmat.BorderSize = 0;
                    btnmat.Click += delegate { BtnEvent_Click(btnmat); };
                    if (_Button == "true")
                    {
                        Tools[i] = btnmat;
                        ToolsOrder[i] = toolOrder;
                    }
                    else { }
                }
            }
            catch (Exception ex)
            {

                Error = true;
                lblerror.Invoke((MethodInvoker)delegate
                {
                    lblerror.Text = "CreatTools() " + ex.Message;
                });
            }

        }
        public void NumbersEvent(object sender, EventArgs e)
        {
            try
            {
                if (Error) return;
                string num = Convert.ToString(((AboodButton)sender).Tag);
                txtnumbers._Text += num.ToString();
            }
            catch (Exception ex)
            {
                Error = true;
                lblerror.Invoke((MethodInvoker)delegate
                {
                    lblerror.Text = "NumbersEvent() " + ex.Message;
                });
            }
        }
        public void CheckWarning()
        {
            try
            {
                if (LoginForm.WarningsNum > 0)
                {
                    btnwarnings.Invoke((MethodInvoker)delegate
                    {
                        if (json.Language == "Arabic")
                        {
                            btnwarnings.RightToLeft = RightToLeft.Yes;
                            btnwarnings.Text = $"الإنذارات: {LoginForm.WarningsNum}";
                        }
                        else if (json.Language == "English")
                        {
                            btnwarnings.RightToLeft = RightToLeft.No;
                            btnwarnings.Text = $"Warnings: {LoginForm.WarningsNum}";
                        }
                        btnwarnings.BackColor = Color.Crimson;
                    });
                }
                else
                {
                    btnwarnings.Invoke((MethodInvoker)delegate
                    {
                        if (json.Language == "Arabic")
                        {
                            btnwarnings.RightToLeft = RightToLeft.Yes;
                            btnwarnings.Text = "لا إنذارات.";
                        }
                        else if (json.Language == "English")
                        {
                            btnwarnings.RightToLeft = RightToLeft.No;
                            btnwarnings.Text = "No Warnings.";
                        }
                        btnwarnings.BackColor = Color.FromArgb(255, 0, 126, 255);
                    });
                }
            }
            catch (Exception ex)
            {
                Error = true;
                lblerror.Invoke((MethodInvoker)delegate
                {
                    lblerror.Text = "CheckWarning() " + ex.Message;
                });
            }
        }
        public void CheckTools()
        {
            try
            {
                for (int i = 0; i < MatsQTY.Length; i++)
                {
                    foreach (Control control in pnlmats.Controls)
                    {
                        if (control is AboodButton)
                        {
                            if ((Convert.ToInt32(control.Tag)) == i)
                            {
                                if (MatsQTY[i] > 0)
                                    control.Enabled = true;
                                else
                                    control.Enabled = false;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Error = true;
                lblerror.Invoke((MethodInvoker)delegate
                {
                    lblerror.Text = "CheckTools() " + ex.Message;
                });
            }
        }
        public void GetAutoCompletArray()
        {

            for (int i = 0; i < LoginForm.SalesTable.Rows.Count; i++)
            {
                CompleteSource.Add(Convert.ToString(LoginForm.SalesTable.Rows[i]["Material_Name"]));
            }
            txtsearch.AutoCompleteCustomSource = CompleteSource;
        }
        public void ChangeLanguage()
        {
            if (json.Language == "Arabic")
            {
                if (language == Languages.English )
                {
                    RightToLeft = RightToLeft.Yes;
                    pnlcustomers.RightToLeft = RightToLeft.Yes;
                    lbltitle.Text = ArabicNames[0];
                    lbltotaltitle.Text = ArabicNames[2];
                    lblordernumbertitle.Text = ArabicNames[3];
                    lblcustomertitle.Text = ArabicNames[12];
                    btncustomer1.Text = ArabicNames[13];
                    btncustomer2.Text = ArabicNames[14];
                    btncustomer3.Text = ArabicNames[15];
                    btncustomer4.Text = ArabicNames[16];
                    colnum.HeaderText = ArabicNames[17];
                    colname.HeaderText = ArabicNames[18];
                    colqty.HeaderText = ArabicNames[19];
                    colprice.HeaderText = ArabicNames[20];
                    colsubtotal.HeaderText = ArabicNames[21];
                    btnexit.Location = new Point(5, 1);
                    btnresize.Location = new Point(43, 1);
                    btnrestart.Location = new Point(81, 1);
                    lbltitle.Location = new Point(pnltop.Width - lbltitle.Width-5, 8);
                    lbltitle.Anchor = AnchorStyles.Right;
                    lblordernumbertitle.Location = new Point(155, 47);
                    lbltotaltitle.Location = new Point(320, 43);
                    lblcustomertitle.Location = new Point(60, 9);
                    lblcustomer.Location = new Point(25, 9);
                    btnexit.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                    btnrestart.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                    btnresize.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                    lbltitle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                    foreach (Control control in pnltools.Controls)
                    {
                        string name = Convert.ToString(control.Tag);
                        control.Tag = control.Text;
                        control.Text = name;
                    }
                    foreach (Control control in pnlnav.Controls)
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
                    RightToLeft = RightToLeft.No;
                    pnlcustomers.RightToLeft = RightToLeft.No;
                    lbltitle.Text = EnglishNames[0];
                    lbltotaltitle.Text = EnglishNames[2];
                    lblordernumbertitle.Text = EnglishNames[3];
                    lblcustomertitle.Text = EnglishNames[12];
                    btncustomer1.Text = EnglishNames[13];
                    btncustomer2.Text = EnglishNames[14];
                    btncustomer3.Text = EnglishNames[15];
                    btncustomer4.Text = EnglishNames[16];
                    colnum.HeaderText = EnglishNames[17];
                    colname.HeaderText = EnglishNames[18];
                    colqty.HeaderText = EnglishNames[19];
                    colprice.HeaderText = EnglishNames[20];
                    colsubtotal.HeaderText = EnglishNames[21];
                    btnexit.Location = new Point(862, 1);
                    btnresize.Location = new Point(824, 1);
                    btnrestart.Location = new Point(786, 1);
                    lbltitle.Location = new Point(5, 8);
                    lbltitle.Anchor = AnchorStyles.Left;
                    lbltotaltitle.Location = new Point(248, 45);
                    lblordernumbertitle.Location = new Point(12, 47);
                    btnexit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                    btnrestart.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                    btnresize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                    lbltitle.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                    foreach (Control control in pnltools.Controls)
                    {
                        string name = Convert.ToString(control.Tag);
                        control.Tag = control.Text;
                        control.Text = name;
                    }
                    foreach (Control control in pnlnav.Controls)
                    {
                        string name = Convert.ToString(control.Tag);
                        control.Tag = control.Text;
                        control.Text = name;
                    }
                    language = Languages.English;
                }
            }
            pnlmats.RightToLeft = RightToLeft.No;
            btnnavoutside.RightToLeft = RightToLeft.No;
        }
        public void CheckControlBox()
        {
            Showpanel = json.ToolsPanel;
            ShowSearch = json.SearchBox;
            if (Showpanel)
                pnlcontainermats.Visible = true;
            else
                pnlcontainermats.Visible = false;

            if (ShowSearch)
            {
                txtsearch.Visible = true;
                btnsearch.Visible = true;
            }
            else
            {
                txtsearch.Visible = false;
                btnsearch.Visible = false;
            }
        }
        public void SetQTYsAndCustomer()
        {
            int cu = Convert.ToInt32((Customer.ToString()).Substring(0, 1));
            Customer = cu + ";";
            foreach (Control c in pnlcustomers.Controls)
            {
                if (c is AboodButton)
                {
                    if (c.Tag == (object)cu)
                    {
                        Customers[cu] = null;
                    }
                }
            }
            int[] IDs = new int[dgvsales.Rows.Count];
            double[] QTYs = new double[dgvsales.Rows.Count];
            for (int x = 0; x < dgvsales.Rows.Count; x++)
            {
                IDs[x] = Convert.ToInt32(dgvsales.Rows[x].Cells[0].Value);
                QTYs[x] = Convert.ToDouble(dgvsales.Rows[x].Cells[2].Value);
            }
            for (int y = 0; y < IDs.Length; y++)
            {
                for (int x = 0; x < LoginForm.SalesTable.Rows.Count; x++)
                {
                    if (Convert.ToInt32(LoginForm.SalesTable.Rows[x]["Id"]) == IDs[y])
                    {
                        double oldqty = Convert.ToDouble(LoginForm.SalesTable.Rows[x]["QTY"]);
                        double newqty = oldqty - QTYs[y];
                        if (newqty == 0)
                            foreach (Control item in pnlmats.Controls)
                            {
                                if (item is AboodButton)
                                {
                                    if (((AboodButton)item).Tag == (object)x)
                                    {
                                        item.Enabled = false;
                                    }
                                }
                            }
                        LoginForm.SalesTable.Rows[x]["QTY"] = Math.Round(newqty, 3);
                    }
                }
            }
            LoginForm.SalesAdapter.Update(LoginForm.SalesTable);
            LoginForm.CheckForLowQTYs();
            OrderNumber++;
            lblordernumber.Text = OrderNumber.ToString();
            dgvsales.Rows.Clear();
            Total = 0;
            lbltotal.Text = Total.ToString();
        }
        public void PrintFirstPart(object sender, PrintPageEventArgs e)
        {
            int LineTop = 0;
            Brush MainBrush = Brushes.Black;
            Pen MainPen = Pens.Black;
            if (printing.PrintCompanyName.Enabled)
            {
                int nametop = printing.PrintCompanyName.Top,
                    nameleft = printing.PrintCompanyName.Left;
                Point namelocation = new Point(nameleft, nametop);
                string nametext = printing.PrintCompanyName.Text;
                int namefs = printing.PrintCompanyName.FS;
                FontStyle namestyle = FontStyle.Regular;
                if (printing.PrintCompanyName.Bold)
                    namestyle = FontStyle.Bold;
                Font namefont = new Font("Arial", namefs, namestyle);
                e.Graphics.DrawString(nametext, namefont, MainBrush, namelocation);
            }
            StartLogo:;
            if (printing.PrintLogo.Enabled)
            {
                int logotop = printing.PrintLogo.Top,
                    logoleft = printing.PrintLogo.Left;
                Point logolocation = new Point(logoleft, logotop);
                int logowidth = printing.PrintLogo.Width,
                    logoheight = printing.PrintLogo.Height;
                Size logosize = new Size(logowidth, logoheight);
                string logourl = printing.PrintLogo.Url;
                Image logoimage = Image.FromFile(logourl);
                if (!File.Exists(logourl))
                {
                    printing.PrintLogo.Enabled = false;
                    goto StartLogo;
                }
                Rectangle logorect = new Rectangle(logolocation, logosize);
                e.Graphics.DrawImage(logoimage, logorect);
            }
            if (printing.PrintTime.Enabled)
            {
                int timetop = printing.PrintTime.Top,
                    timeleft = printing.PrintTime.Left;
                Point timelocation = new Point(timeleft, timetop);
                int timeheight = timetop,
                    timefs = printing.PrintTime.FS;
                FontStyle timestyle = FontStyle.Regular;
                Font timefont = new Font("Arial", timefs, timestyle);
                string timetext = date.ToShortTimeString(),
                       datetext = date.ToShortDateString();
                if (printing.PrintTime.AddTime)
                {
                    SizeF timetextsize = e.Graphics.MeasureString(timetext, timefont);
                    e.Graphics.DrawString(timetext, timefont, MainBrush, timelocation);
                    timeheight += Convert.ToInt32(timetextsize.Height);
                    timelocation = new Point(timeleft, timeheight);
                }
                if (printing.PrintTime.AddDate)
                {
                    e.Graphics.DrawString(datetext, timefont, MainBrush, timelocation);
                }
            }
            if (printing.PrintOrder.Enabled)
            {
                int ordertop = printing.PrintOrder.Top,
                    orderleft = printing.PrintOrder.Left;
                Point orderlocation = new Point(orderleft, ordertop);
                string ordertext = $"Order: {OrderNumber}";
                if (json.Language == "Arabic")
                    ordertext = $"الطلب:{OrderNumber}";
                int orderfs = printing.PrintOrder.FS;
                FontStyle orderstyle = FontStyle.Regular;
                if (printing.PrintOrder.Bold)
                    orderstyle = FontStyle.Bold;
                Font orderfont = new Font("Arial", orderfs, orderstyle);
                e.Graphics.DrawString(ordertext, orderfont, MainBrush, orderlocation);
            }

            int columnsfs = printing.PrintColumns.FS;
            FontStyle columnsstyle = FontStyle.Regular;
            if (printing.PrintColumns.Bold)
                columnsstyle = FontStyle.Bold;
            Font columnsfont = new Font("Arial", columnsfs, columnsstyle);
            PrintingServcies.Language lang = PrintingServcies.Language.English;
            if (printing.PrintColumns.Laneguage == PrintingServcies.Language.Arabic)
                lang = PrintingServcies.Language.Arabic;
            string colid = "Id",
                   colname = "Name",
                   colqty = "QTY",
                   colsubtotal = "SubTotal",
                   coltotal = "Total";
            if (lang == PrintingServcies.Language.Arabic)
            {
                colid = "الرقم";
                colname = "الاسم";
                colqty = "الكمية";
                colsubtotal = "السعر الإفرادي";
                coltotal = "السعر الإجمالي";
            }
            int paddingvertical = printing.PrintPadding.Vertical,
                paddinghorizontal = printing.PrintPadding.Horizontal;
            if (printing.PrintColumns.Id.Enabled)
            {
                int idtop = printing.PrintColumns.Id.Top,
                    idleft = printing.PrintColumns.Id.Left;
                Point idlocation = new Point(idleft, idtop);
                e.Graphics.DrawString(colid, columnsfont, MainBrush, idlocation);
            }
            if (printing.PrintColumns.Name.Enabled)
            {
                int nametop = printing.PrintColumns.Name.Top,
                    nameleft = printing.PrintColumns.Name.Left;
                Point namelocation = new Point(nameleft, nametop);
                SizeF namesize = e.Graphics.MeasureString(colname, columnsfont);
                e.Graphics.DrawString(colname, columnsfont, MainBrush, namelocation);
                PreHeight = Convert.ToInt32(nametop + namesize.Height + paddingvertical);
                LineTop = Convert.ToInt32(nametop + namesize.Height + paddingvertical);
            }
            if (printing.PrintColumns.QTY.Enabled)
            {
                int qtytop = printing.PrintColumns.QTY.Top,
                    qtyleft = printing.PrintColumns.QTY.Left;
                Point qtylocation = new Point(qtyleft, qtytop);
                e.Graphics.DrawString(colqty, columnsfont, MainBrush, qtylocation);
            }
            if (printing.PrintColumns.SubTotal.Enabled)
            {
                int subtotaltop = printing.PrintColumns.SubTotal.Top,
                    subtotalleft = printing.PrintColumns.SubTotal.Left;
                Point subtotallocation = new Point(subtotalleft, subtotaltop);
                e.Graphics.DrawString(colsubtotal, columnsfont, MainBrush, subtotallocation);
            }
            if (printing.PrintColumns.Total.Enabled)
            {
                int totaltop = printing.PrintColumns.Total.Top,
                    totalleft = printing.PrintColumns.Total.Left;
                Point totallocation = new Point(totalleft, totaltop);
                e.Graphics.DrawString(coltotal, columnsfont, MainBrush, totallocation);
            }
            if (printing.PrintColumns.AddLine)
            {
                Point startline = new Point(paddinghorizontal, LineTop);
                Point endline = new Point(e.PageBounds.Width - paddinghorizontal, LineTop);
                e.Graphics.DrawLine(MainPen, startline, endline);
                PreHeight = LineTop + paddingvertical;
            }
            PrintSecoundPart(e);
        }
        public void PrintSecoundPart(PrintPageEventArgs e)
        {
            int paddingvertical = printing.PrintPadding.Vertical,
              paddinghorizontal = printing.PrintPadding.Horizontal;
            int HeightToAdd = 0;
            int fs = printing.PrintColumns.FS;
            FontStyle style = FontStyle.Regular;
            if (printing.PrintColumns.Bold)
                style = FontStyle.Bold;
            Font font = new Font("Arial", fs, style);
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
            for (int i = 0; i < dgvsales.Rows.Count; i++)
            {
                if (i > 0)
                { PreHeight += paddingvertical; }
                //Id Section
                if (printing.PrintColumns.Id.Enabled)
                {
                    string id = Convert.ToString(dgvsales.Rows[i].Cells[0].Value);
                    SizeF idsize = e.Graphics.MeasureString(id, font);
                    int idleft = Convert.ToInt32(((startid - endid - idsize.Width) / 2) + endid);
                    Point idlocation = new Point(idleft, PreHeight);
                    e.Graphics.DrawString(id, font, brush, idlocation);
                }
                //Name Section
                if (printing.PrintColumns.Name.Enabled)
                {
                    string name = Convert.ToString(dgvsales.Rows[i].Cells[1].Value);
                    SizeF namesize = e.Graphics.MeasureString(name, font);
                    int nameleft = Convert.ToInt32(((startname - endname - namesize.Width) / 2) + endname);
                    Point namelocation = new Point(nameleft, PreHeight);
                    e.Graphics.DrawString(name, font, brush, namelocation);
                    HeightToAdd = Convert.ToInt32(namesize.Height + paddingvertical);
                }
                //QTY Section 
                if (printing.PrintColumns.QTY.Enabled)
                {
                    string qty = Convert.ToString(dgvsales.Rows[i].Cells[2].Value);
                    SizeF qtysize = e.Graphics.MeasureString(qty, font);
                    int qtyleft = Convert.ToInt32(((startqty - endqty - qtysize.Width) / 2) + endqty);
                    Point qtylocation = new Point(qtyleft, PreHeight);
                    e.Graphics.DrawString(qty, font, brush, qtylocation);
                }
                //SubTotal Section
                if (printing.PrintColumns.SubTotal.Enabled)
                {
                    string subtotal = Convert.ToString(dgvsales.Rows[i].Cells[3].Value);
                    SizeF subtotalsize = e.Graphics.MeasureString(subtotal, font);
                    int subtotalleft = Convert.ToInt32(((startsubtotal - endsubtotal - subtotalsize.Width) / 2) + endsubtotal);
                    Point subtotallocation = new Point(subtotalleft, PreHeight);
                    e.Graphics.DrawString(subtotal, font, brush, subtotallocation);
                }
                //Total Section
                if (printing.PrintColumns.Total.Enabled)
                {
                    string total = Convert.ToString(dgvsales.Rows[i].Cells[4].Value);
                    SizeF totalsize = e.Graphics.MeasureString(total, font);
                    int totalleft = Convert.ToInt32(((starttotal - endtotal - totalsize.Width) / 2) + endtotal);
                    Point totallocation = new Point(totalleft, PreHeight);
                    e.Graphics.DrawString(total, font, brush, totallocation);
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
            PrintTheardPart(e);
        }
        public void PrintTheardPart(PrintPageEventArgs e)
        {
            
            int paddingvertical = printing.PrintPadding.Vertical,
                paddinghorizontal = printing.PrintPadding.Horizontal;
            if (printing.PrintColumns.AddBorder)
            {
                int nametop = printing.PrintColumns.Name.Top;
                Point p1 = new Point(paddinghorizontal, nametop - paddingvertical);
                Point p2 = new Point(e.PageBounds.Width - paddinghorizontal, nametop - paddingvertical);
                Point p3 = new Point(e.PageBounds.Width - paddinghorizontal, PreHeight);
                Point p4 = new Point(paddinghorizontal, PreHeight);
                Point[] p = new Point[] { p1, p2, p3, p4, p1 };
                e.Graphics.DrawLines(Pens.Black, p);
            }
            Pen pen = Pens.Black;
            if (printing.PrintColumns.Id.AddLine)
            {
                int lineleft = printing.PrintColumns.Id.LineLeft;
                Point startline = new Point(lineleft, printing.PrintColumns.Id.Top - paddingvertical);
                Point endline = new Point(lineleft, PreHeight);
                e.Graphics.DrawLine(pen, startline, endline);
            }
            if (printing.PrintColumns.Name.AddLine)
            {
                int lineleft = printing.PrintColumns.Name.LineLeft;
                Point startline = new Point(lineleft, printing.PrintColumns.Name.Top - paddingvertical);
                Point endline = new Point(lineleft, PreHeight);
                e.Graphics.DrawLine(pen, startline, endline);
            }
            if (printing.PrintColumns.QTY.AddLine)
            {
                int lineleft = printing.PrintColumns.QTY.LineLeft;
                Point startline = new Point(lineleft, printing.PrintColumns.QTY.Top - paddingvertical);
                Point endline = new Point(lineleft, PreHeight);
                e.Graphics.DrawLine(pen, startline, endline);
            }
            if (printing.PrintColumns.SubTotal.AddLine)
            {
                int lineleft = printing.PrintColumns.SubTotal.LineLeft;
                Point startline = new Point(lineleft, printing.PrintColumns.SubTotal.Top - paddingvertical);
                Point endline = new Point(lineleft, PreHeight);
                e.Graphics.DrawLine(pen, startline, endline);
            }
            if (printing.PrintColumns.Total.AddLine)
            {
                int lineleft = printing.PrintColumns.Total.LineLeft;
                Point startline = new Point(lineleft, printing.PrintColumns.Total.Top - paddingvertical);
                Point endline = new Point(lineleft, PreHeight);
                e.Graphics.DrawLine(pen, startline, endline);
            }

            if (printing.PrintTotal.Enabled)
            {
                PreHeight += paddingvertical;
                int totalfs = printing.PrintTotal.FS;
                FontStyle totalstyle = FontStyle.Regular;
                if (printing.PrintTotal.Bold)
                    totalstyle = FontStyle.Bold;
                Font totalfont = new Font("Arial", totalfs, totalstyle);
                string totaltext = "Total: " + Convert.ToString(Total);
                string convertiedtotal = Convert.ToString(ConvertNumbersToString(Total) + " ليرة سورية ");
                SizeF totalstringsize = e.Graphics.MeasureString(convertiedtotal, totalfont);
                SizeF totalsize = e.Graphics.MeasureString(totaltext, totalfont);
                Point totallocation = new Point(printing.PrintTotal.left, PreHeight);
                PreHeight += Convert.ToInt32(totalsize.Height + paddingvertical);
                Point totalstringlocation = new Point(Convert.ToInt32(e.PageBounds.Width - totalstringsize.Width - paddinghorizontal), PreHeight);
                e.Graphics.DrawString(totaltext, totalfont, Brushes.Black, totallocation);
                e.Graphics.DrawString(convertiedtotal, totalfont, Brushes.Black, totalstringlocation);
                PreHeight += Convert.ToInt32(totalstringsize.Height + paddingvertical);
            }
            if (printing.PrintQuot.Enabled)
            {
                int width = e.PageBounds.Width;
                Point startline = new Point((width / 5), PreHeight);
                Point endline = new Point((width - (width / 5)), PreHeight);
                e.Graphics.DrawLine(Pens.Black, startline, endline);
                PreHeight += paddingvertical;
                int fs = printing.PrintQuot.FS;
                FontStyle style = FontStyle.Regular;
                if (printing.PrintQuot.Bold)
                    style = FontStyle.Bold;
                Font font = new Font("Arial", fs, style);
                string quot = printing.PrintQuot.Text;
                SizeF quotsize = e.Graphics.MeasureString(quot, font);
                int quotleft = Convert.ToInt32((e.PageBounds.Width - quotsize.Width) / 2);
                Point quotlocation = new Point(quotleft, PreHeight);
                e.Graphics.DrawString(quot, font, Brushes.Black, quotlocation);
            }
            SetQTYsAndCustomer();
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
        private void SalePointForm_Load(object sender, EventArgs e)
        {
            try
            {
                Database = LoginForm.DataBase;
                Loading = true;
                json = MainForm.json;
                printing = MainForm.printing;
                _BackColor = LoginForm.MainColor[json.MainColorNum];
                CheckControlBox();
                lbldate.Text = date.ToShortDateString();
                lbltime.Text = date.ToShortTimeString();
                lblusername.Text = LoginForm.UserName;
                GetAutoCompletArray();
                ChangeColor();
                ChangeLanguage();
                CheckWarning();

                if (backworker.IsBusy)
                {
                    lblerror.Invoke((MethodInvoker)delegate
                    {
                        lblerror.Text = "Running!";
                    });
                }
                else
                {
                    backworker.RunWorkerAsync();
                }
            }
            catch (Exception ex)
            {
                Error = true;
                Loading = false;
                lblerror.Invoke((MethodInvoker)delegate
                {
                    lblerror.Text = "Load() " + ex.Message;
                });

            }
        }
        private void btnexit_Click(object sender, EventArgs e)
        {
            try
            {
                if (Loading) return;
                MainForm.json = json;
                if (Error) return;
                Close();
                Application.OpenForms[1].Show();
            }
            catch (Exception ex)
            {
                Error = true;
                lblerror.Invoke((MethodInvoker)delegate
                {
                    lblerror.Text = "Exit() " + ex.Message;
                });
            }
        }
        private void btnresize_Click(object sender, EventArgs e)
        {
            if (Loading) return;
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Normal;
            pnlnav.Size = new Size(210, this.Height - 35);
        }
        private void btnrestart_Click(object sender, EventArgs e)
        {
            try
            {
                if (Loading) return;
                this.Close();
                Thread.Sleep(1000);
                LoginForm.SalePointForm1 = new SalePointForm();
                LoginForm.SalePointForm1.Show();
            }
            catch (Exception ex)
            {
                Error = true;
                lblerror.Invoke((MethodInvoker)delegate
                {
                    lblerror.Text = "Restart() " + ex.Message;
                });
            }
        }
        private void btnclear_Click(object sender, EventArgs e)
        {
            if (Loading) return;
            if (txtnumbers._Text.Length > 0)
                txtnumbers._Text = txtnumbers._Text.Substring(0, txtnumbers._Text.Length - 1);
        }
        private void btnclearall_Click(object sender, EventArgs e)
        {
            if (Loading) return;
            txtnumbers._Text = "";
        }
        private void btnenter_Click(object sender, EventArgs e)
        {
            try
            {
                if (Loading) return;
                if (Error) return;
                if (txtnumbers._Text != "")
                {
                    bool found = false;
                    int x = 0;
                    string mat = txtnumbers._Text;
                    for (int i = 0; i < LoginForm.SalesTable.Rows.Count; i++)
                    {
                        if (mat == LoginForm.SalesTable.Rows[i]["Id"].ToString())
                        {
                            x = i;
                            found = true;
                            break;
                        }
                    }
                    if (found)
                    {
                        int id = Convert.ToInt32(LoginForm.SalesTable.Rows[x]["id"]);
                        string name = Convert.ToString(LoginForm.SalesTable.Rows[x]["Material_Name"]);
                        int price = Convert.ToInt32(LoginForm.SalesTable.Rows[x]["Price"]);
                        double qty = 0;
                        if (MatsQTY[x] > 1)
                        {
                            qty = 1;
                            MatsQTY[x] -= qty;
                            CheckTools();
                        }
                        else if (MatsQTY[x] == 1)
                        {
                            qty = 1;
                            MatsQTY[x] -= 1;
                            CheckTools();
                        }
                        else if (MatsQTY[x] < 1 && MatsQTY[x] != 0)
                        {
                            qty = MatsQTY[x];
                            MatsQTY[x] -= qty;
                            CheckTools();
                        }
                        else if (MatsQTY[x] == 0)
                        {
                            CheckTools();
                            txtnumbers._Text = "";
                            return;
                        }
                        double subtotal = qty * price;
                        object[] data = {id,name,qty,price,subtotal
                        };
                        Customer += id + ";" + name + ";" + qty + ";" + price + ";" + subtotal + ";";
                        dgvsales.Rows.Add(data);
                        txtnumbers._Text = "";
                        Total += Convert.ToInt32(LoginForm.SalesTable.Rows[x]["Price"]);
                        lbltotal.Text = Total.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Error = true;
                lblerror.Invoke((MethodInvoker)delegate
                {
                    lblerror.Text = "Enter() " + ex.Message;
                });
            }
        }
        private void btneditqty_Click(object sender, EventArgs e)
        {
            try
            {
                if (Loading) return;
                if (Error) return;
                if (txtnumbers._Text.Trim() == "") return;
                string matid = Convert.ToString(dgvsales.CurrentRow.Cells[0].Value);
                int index = 1;
                double oldqty = Convert.ToDouble(dgvsales.CurrentRow.Cells[2].Value);
                for (int i = 0; i < LoginForm.SalesTable.Rows.Count; i++)
                {
                    if (Convert.ToString(LoginForm.SalesTable.Rows[i]["Id"]) == matid)
                    {
                        index = i;
                        break;
                    }
                }
                MatsQTY[index] += oldqty;
                Total = 0;
                double newqty = Convert.ToDouble(txtnumbers._Text.Trim());
                float price = float.Parse((dgvsales.CurrentRow.Cells[3].Value).ToString());
                if (newqty > MatsQTY[index])
                {
                    newqty = MatsQTY[index];
                    MatsQTY[index] -= newqty;
                    CheckTools();
                }
                else if (newqty == MatsQTY[index])
                {
                    MatsQTY[index] -= newqty;
                    CheckTools();
                }
                else if (newqty < MatsQTY[index])
                {
                    MatsQTY[index] -= newqty;
                    CheckTools();
                }
                dgvsales.CurrentRow.Cells[2].Value = newqty;
                dgvsales.CurrentRow.Cells[4].Value = newqty * price;
                txtnumbers._Text = "";
                foreach (DataGridViewRow row in dgvsales.Rows)
                {
                    Total += Convert.ToInt32((row.Cells[4].Value));
                }
                lbltotal.Text = Total.ToString();
                Customer = ((Customer.ToString()).Substring(0, 1)) + ";";
                foreach (DataGridViewRow row in dgvsales.Rows)
                {
                    string id = Convert.ToString(row.Cells[0].Value);
                    string name = Convert.ToString(row.Cells[1].Value);
                    string qty = Convert.ToString(row.Cells[2].Value);
                    string pric = Convert.ToString(row.Cells[3].Value);
                    string subtotal = Convert.ToString(row.Cells[4].Value);
                    Customer += id + ";" + name + ";" + qty + ";" + pric + ";" + subtotal + ";";
                }
                CheckTools();
            }
            catch (Exception ex)
            {
                Error = true;
                lblerror.Invoke((MethodInvoker)delegate
                {
                    lblerror.Text = "EditeQTY() " + ex.Message;
                });
            }
        }
        private void btnediteprice_Click(object sender, EventArgs e)
        {
            try
            {
                if (Loading) return;
                if (Error) return;
                if (txtnumbers._Text.Trim() == "") return;
                string matid = Convert.ToString(dgvsales.CurrentRow.Cells[0].Value);
                int index = 1;
                double newsubtotal = Convert.ToInt32(txtnumbers._Text.Trim());
                double price = Convert.ToDouble(dgvsales.CurrentRow.Cells[3].Value);
                double oldqty = Convert.ToDouble(dgvsales.CurrentRow.Cells[2].Value);
                for (int i = 0; i < LoginForm.SalesTable.Rows.Count; i++)
                {
                    if (Convert.ToString(LoginForm.SalesTable.Rows[i]["Id"]).Trim() == matid)
                    {
                        index = i;
                        break;
                    }
                }
                MatsQTY[index] += oldqty;
                double newqty = Math.Round(newsubtotal / price, 3);
                if (newqty > MatsQTY[index])
                {
                    newqty = Math.Round(MatsQTY[index], 3);
                    newsubtotal = price * newqty;
                    MatsQTY[index] -= newqty;
                    CheckTools();
                }
                else if (newqty == MatsQTY[index])
                {
                    MatsQTY[index] -= newqty;
                    CheckTools();
                }
                else if (newqty < MatsQTY[index])
                {
                    MatsQTY[index] -= newqty;
                    CheckTools();
                }
                dgvsales.CurrentRow.Cells[4].Value = newsubtotal;
                dgvsales.CurrentRow.Cells[2].Value = newqty;
                txtnumbers._Text = "";
                Total = 0;
                foreach (DataGridViewRow row in dgvsales.Rows)
                {
                    Total += Convert.ToInt32((row.Cells[4].Value));
                }
                lbltotal.Text = Total.ToString();
                Customer = ((Customer.ToString()).Substring(0, 1)) + ";";
                foreach (DataGridViewRow row in dgvsales.Rows)
                {
                    string id = Convert.ToString(row.Cells[0].Value);
                    string name = Convert.ToString(row.Cells[1].Value);
                    string qty = Convert.ToString(row.Cells[2].Value);
                    string pric = Convert.ToString(row.Cells[3].Value);
                    string subtotal = Convert.ToString(row.Cells[4].Value);
                    Customer += id + ";" + name + ";" + qty + ";" + pric + ";" + subtotal + ";";
                }
                CheckTools();
            }
            catch (Exception ex)
            {
                Error = true;
                lblerror.Invoke((MethodInvoker)delegate
                {
                    lblerror.Text = "EditePrice() " + ex.Message;
                });
            }
        }
        private void btndeletemat_Click(object sender, EventArgs e)
        {
            try
            {
                if (Loading) return;
                if (Error) return;
                if (dgvsales.CurrentRow == null) return;
                else
                {
                    int x = Convert.ToInt32(dgvsales.CurrentRow.Cells[0].Value);
                    double oldqty = Convert.ToDouble(dgvsales.CurrentRow.Cells[2].Value);
                    int index = 0;
                    for (int i = 0; i < LoginForm.SalesTable.Rows.Count; i++)
                    {
                        if (Convert.ToInt32(LoginForm.SalesTable.Rows[i]["Id"]) == x)
                        {
                            index = i;
                        }

                    }
                    MatsQTY[index] += oldqty;
                    dgvsales.Rows.Remove(dgvsales.CurrentRow);
                    Total = 0;
                    for (int i = 0; i < dgvsales.Rows.Count; i++)
                    {
                        Total += Convert.ToInt32(dgvsales.Rows[i].Cells[4].Value);
                    }
                    lbltotal.Text = Total.ToString();
                    Customer = ((Customer.ToString()).Substring(0, 1)) + ";";
                    foreach (DataGridViewRow row in dgvsales.Rows)
                    {
                        string id = Convert.ToString(row.Cells[0].Value);
                        string name = Convert.ToString(row.Cells[1].Value);
                        string qty = Convert.ToString(row.Cells[2].Value);
                        string pric = Convert.ToString(row.Cells[3].Value);
                        string subtotal = Convert.ToString(row.Cells[4].Value);
                        Customer += id + ";" + name + ";" + qty + ";" + pric + ";" + subtotal + ";";
                    }
                    CheckTools();
                }
            }
            catch (Exception ex)
            {
                Error = true;
                lblerror.Invoke((MethodInvoker)delegate
                {
                    lblerror.Text = "DeleteMat() " + ex.Message;
                });
            }
        }
        private void btndeleteorder_Click(object sender, EventArgs e)
        {
            try
            {
                if (Loading) return;
                if (Error) return;
                int cu = Convert.ToInt32((Customer.ToString()).Substring(0, 1));
                Customer = cu + ";";
                dgvsales.Rows.Clear();
                Total = 0;
                lbltotal.Text = Total.ToString();
                Customers[cu] = null;
                CreatTools();
            }
            catch (Exception ex)
            {
                Error = true;
                lblerror.Invoke((MethodInvoker)delegate
                {
                    lblerror.Text = "DeleteOrder() " + ex.Message;
                });
            }
        }
        private void txtnumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (Loading) return;
                if (Error) return;
                if ((!char.IsDigit(e.KeyChar))
                    && (!char.IsControl(e.KeyChar))
                    && (!char.IsPunctuation(e.KeyChar)))
                    e.Handled = true;
                if (e.KeyChar == (char)Keys.Enter)
                {
                    btnenter.PerformClick();
                }
            }
            catch (Exception ex)
            {
                Error = true;
                lblerror.Invoke((MethodInvoker)delegate
                {
                    lblerror.Text = "txtNumbers() " + ex.Message;
                });
            }
        }
        private void btnclearerror_Click(object sender, EventArgs e)
        {
            if (Loading) return;
            txtnumbers._Text = "";
            Error = false;
            lblerror.Text = "";
        }
        private void btnprint_Click(object sender, EventArgs e)
        {
            try
            {
                if (Loading) return;
                if (Error) return;
                //if (dgvsales.Rows.Count == 0) return;
                ((Form)printpreview).WindowState = FormWindowState.Maximized;
                if (printpreview.ShowDialog() == DialogResult.OK)
                    printdocument.Print();
            }
            catch (Exception ex)
            {
                Error = true;
                lblerror.Invoke((MethodInvoker)delegate
                {
                    lblerror.Text = "Print() " + ex.Message;
                });
            }
        }
        private void printdocument_PrintPage(object sender, PrintPageEventArgs e)
        {

            //        /////////////////////////// Invoic Content///////////////////////////////////
            //        for (int x = 0; x < dgvsales.Rows.Count; x++)
            //        {
            //            string Id = dgvsales.Rows[x].Cells[0].Value.ToString();
            //            SizeF IdSize = e.Graphics.MeasureString(Id, f);
            //            float IdSize1 = 80 - 0;
            //            float IdSize2 = IdSize1 - IdSize.Width;
            //            float IdSize3 = IdSize2 / 2;
            //            e.Graphics.DrawString(Id, f, Brushes.Black, e.PageBounds.Width - margin - 80 + (int)IdSize3, preHeight + 10);

            //            string Matrial = dgvsales.Rows[x].Cells[1].Value.ToString();
            //            SizeF MatrialSize = e.Graphics.MeasureString(Matrial, f);
            //            float MatrialSize1 = 430 - 80;
            //            float MatrialSize2 = MatrialSize1 - MatrialSize.Width;
            //            float MatrialSize3 = MatrialSize2 / 2;
            //            e.Graphics.DrawString(Matrial, f, Brushes.Black, e.PageBounds.Width - margin - 430 + (int)MatrialSize3, preHeight + 10);

            //            string Qty = dgvsales.Rows[x].Cells[2].Value.ToString();
            //            SizeF QtySize = e.Graphics.MeasureString(Qty, f);
            //            float QtySize1 = 525 - 430;
            //            float QtySize2 = QtySize1 - QtySize.Width;
            //            float QtySize3 = QtySize2 / 2;
            //            e.Graphics.DrawString(Qty, f, Brushes.Black, e.PageBounds.Width - margin - 525 + (int)QtySize3, preHeight + 10);

            //            string Price = dgvsales.Rows[x].Cells[3].Value.ToString();
            //            SizeF PriceSize = e.Graphics.MeasureString(Price, f);
            //            float Price1 = 660 - 525;
            //            float Price2 = Price1 - PriceSize.Width;
            //            float Price3 = Price2 / 2;
            //            e.Graphics.DrawString(Price, f, Brushes.Black, e.PageBounds.Width - margin - 660 + (int)Price3, preHeight + 10);

            //            string SubTotal = dgvsales.Rows[x].Cells[4].Value.ToString();
            //            SizeF SubTotalSize = e.Graphics.MeasureString(SubTotal, f);
            //            float Sub1 = (e.PageBounds.Width - margin) - 660;
            //            float Sub2 = Sub1 - SubTotalSize.Width;
            //            float Sub3 = Sub2 / 2;
            //            e.Graphics.DrawString(SubTotal, f, Brushes.Black, margin + (int)Sub3, preHeight + 10);

            //            //Last Line
            //            e.Graphics.DrawLine(p, margin, preHeight + 60, e.PageBounds.Width - margin, preHeight + 60);
            //            sale = Id + ";" + Matrial + ";" + Qty + ";" + Price + ";" + SubTotal + ";" + OrderNumber + ";";
            //            Sales.Add(sale);
            //            preHeight += 60;
            //        }
            //        //ID Line
            //        e.Graphics.DrawLine(p, e.PageBounds.Width - margin - 80, start, e.PageBounds.Width - margin - 80, preHeight);
            //        //Type Line
            //        e.Graphics.DrawLine(p, e.PageBounds.Width - margin - 430, start, e.PageBounds.Width - margin - 430, preHeight);
            //        //Qty Line
            //        e.Graphics.DrawLine(p, e.PageBounds.Width - margin - 525, start, e.PageBounds.Width - margin - 525, preHeight);
            //        //Price Line
            //        e.Graphics.DrawLine(p, e.PageBounds.Width - margin - 660, start, e.PageBounds.Width - margin - 660, preHeight);
            //        //Draw The Rectangle 
            //        e.Graphics.DrawLine(p, margin, start, e.PageBounds.Width - margin, start);
            //        e.Graphics.DrawLine(p, margin, start, margin, preHeight);
            //        e.Graphics.DrawLine(p, e.PageBounds.Width - margin, start, e.PageBounds.Width - margin, preHeight);
            //        e.Graphics.DrawLine(p, margin, preHeight, e.PageBounds.Width - margin, preHeight);

            //        preHeight += 30;
            //        e.Graphics.DrawString("Total:", f, Brushes.Black, margin + 30, preHeight);
            //        e.Graphics.DrawString(Total.ToString() + "S.P", f, Brushes.Black, margin + 110, preHeight);

            //        int cu = Convert.ToInt32((Customer.ToString()).Substring(0, 1));
            //        Customer = cu + ";";
            //        foreach (Control c in pnlcustomers.Controls)
            //        {
            //            if (c is  AboodButton)
            //            {
            //                if (c.Tag == (object)cu)
            //                {
            //                    Customers[cu] = null;
            //                }
            //            }
            //        }
            //        int[] IDs = new int[dgvsales.Rows.Count];
            //        double[] QTYs = new double[dgvsales.Rows.Count];
            //        for (int i = 0; i < dgvsales.Rows.Count; i++)
            //        {
            //            IDs[i] = Convert.ToInt32(dgvsales.Rows[i].Cells[0].Value);
            //            QTYs[i] = Convert.ToDouble(dgvsales.Rows[i].Cells[2].Value);
            //        }
            //        for (int i = 0; i < IDs.Length; i++)
            //        {
            //            for (int x = 0; x < LoginForm.SalesTable.Rows.Count; x++)
            //            {
            //                if (Convert.ToInt32(LoginForm.SalesTable.Rows[x]["Id"]) == IDs[i])
            //                {
            //                    double oldqty = Convert.ToDouble(LoginForm.SalesTable.Rows[x]["QTY"]);
            //                    double newqty = oldqty - QTYs[i];
            //                    if (newqty == 0)
            //                        foreach (Control item in pnlmats.Controls)
            //                        {
            //                            if (item is  AboodButton)
            //                            {
            //                                if ((( AboodButton)item).Tag == (object)x)
            //                                {
            //                                    item.Enabled = false;
            //                                }
            //                            }
            //                        }
            //                    LoginForm.SalesTable.Rows[x]["QTY"] = Math.Round(newqty, 3);
            //                }
            //            }
            //        }
            //        LoginForm.SalesAdapter.Update(LoginForm.SalesTable);
            //        LoginForm.CheckForLowQTYs();
            //        OrderNumber++;
            //        lblordernumber.Text = OrderNumber.ToString();
            //        dgvsales.Rows.Clear();
            //        Total = 0;
            //        lbltotal.Text = Total.ToString();
            //    }
        }
        private void btnsales_Click(object sender, EventArgs e)
        {
            try
            {
                if (Loading) return;
                if (Error) return;
                SalesForm Sales = new SalesForm();
                Sales.ShowDialog();
            }
            catch (Exception ex)
            {
                Error = true;
                lblerror.Invoke((MethodInvoker)delegate
                {
                    lblerror.Text = "Sales() " + ex.Message;
                });
            }
        }
        private void btnsavesales_Click(object sender, EventArgs e)
        {
            try
            {
                if (Loading) return;
                if (Error) return;
                CreatSalesFile();
            }
            catch (Exception ex)
            {
                Error = true;
                lblerror.Invoke((MethodInvoker)delegate
                {
                    lblerror.Text = "SaveSales() " + ex.Message;
                });
            }
        }
        private void btnwarning_Click(object sender, EventArgs e)
        {
            try
            {
                if (Loading) return;
                if (LoginForm.WarningsNum == 0) return;
                if (Error) return;
                WarningsForm WarningsForm1 = new WarningsForm();
                WarningsForm1.Show();
            }
            catch (Exception ex)
            {
                Error = true;
                lblerror.Invoke((MethodInvoker)delegate
                {
                    lblerror.Text = "Warnings() " + ex.Message;
                });
            }
        }
        private void btnlogout_Click(object sender, EventArgs e)
        {
            if (Loading) return;
            LoginForm.json = json;
            this.Close();
            Application.OpenForms[1].Close();
            Application.OpenForms[0].Show();
        }
        private void backworker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                pnldgvsales.Invoke((MethodInvoker)delegate
                {
                    pnldgvsales.Visible = true;
                });
                Thread.Sleep(200);
                pnlcontainernums.Invoke((MethodInvoker)delegate
                {
                    pnlcontainernums.Visible = true;
                });
                Thread.Sleep(200);
                pnlcontainertools.Invoke((MethodInvoker)delegate
                {
                    pnlcontainertools.Visible = true;
                });
                Thread.Sleep(200);
                pnlcontainercustomer.Invoke((MethodInvoker)delegate
                {
                    pnlcontainercustomer.Visible = true;
                });
                CreatTools();
                CheckTools();
                CheckWarning();
                //for (int x = 0; x < Tools.Length; x++)
                //{
                //    for (int y = 0; y < Tools.Length; y++)
                //    {
                //        if (ToolsOrder[y] == x + 1)
                //        {

                //            pnlmats.Invoke((MethodInvoker)delegate
                //            {
                //                pnlmats.Controls.Add(Tools[y]);
                //            });
                //            Thread.Sleep(100);
                //        }
                //    }
                //}
                bool[] toolsadded = new bool[LoginForm.SalesTable.Rows.Count];
                for (int x = 0; x < toolsadded.Length; x++)
                {
                    toolsadded[x] = false;
                }
                int pre1 = 0;
                Control pre2 = null;
                for (int i = 0; i < ToolsOrder.Length; i++)
                {
                    for (int j = i + 1; j < ToolsOrder.Length; j++)
                    {
                        if (ToolsOrder[i] > ToolsOrder[j])
                        {
                            pre1 = ToolsOrder[i];
                            ToolsOrder[i] = ToolsOrder[j];
                            ToolsOrder[j] = pre1;

                            pre2 = Tools[i];
                            Tools[i] = Tools[j];
                            Tools[j] = pre2;
                        }
                    }
                }
                foreach (Control con in Tools)
                {
                    pnlmats.Invoke((MethodInvoker)delegate
                    {
                        pnlmats.Controls.Add(con);
                    });
                    Thread.Sleep(100);
                }
                Thread.Sleep(500);
                Loading = false;
            }
            catch (Exception ex)
            {
                Loading = false;
                Error = true;
                lblerror.Invoke((MethodInvoker)delegate
                {
                    lblerror.Text = "BackWorker()" + ex.Message;
                });
            }
        }
        private void backworker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lblerror.Invoke((MethodInvoker)delegate
            {
                if (Error) { }
                else
                {
                    lblerror.Text = "";
                }
            });
        }
        private void tiemrnav_Tick(object sender, EventArgs e)
        {
            if (In)
            {
                pnlnav.Location = new Point(pnlnav.Location.X - 15, pnlnav.Location.Y);
                btnnavoutside.Location = new Point(btnnavoutside.Location.X - 15, btnnavoutside.Location.Y);
                timer += 1;
                if (timer == 14)
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
            if (Loading) return;
            if (Runing) return;
            Runing = true;
            timernav.Start();
        }
        private void btnshowtoolspnl_Click(object sender, EventArgs e)
        {
            if (Loading) return;
            if (Showpanel)
                json.ToolsPanel = false;
            else
                json.ToolsPanel = true;
            CheckControlBox();
            WriteDataFile(json, LoginForm.DataRoot);
        }
        private void btnshowsearch_Click(object sender, EventArgs e)
        {
            if (Loading) return;
            if (ShowSearch)
                json.SearchBox = false;
            else
                json.SearchBox = true;
            CheckControlBox();
            WriteDataFile(json, LoginForm.DataRoot);
        }
        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (Loading) return;
            string name = txtsearch._Text;
            string mat;
            int index = 0;
            bool found = false;
            for (int i = 0; i < LoginForm.SalesTable.Rows.Count; i++)
            {
                mat = Convert.ToString(LoginForm.SalesTable.Rows[i]["Material_Name"]);
                if (name == mat)
                {
                    index = i;
                    found = true;
                    break;
                }
            }
            if (found)
            {
                int id = Convert.ToInt32(LoginForm.SalesTable.Rows[index]["id"]);
                string matname = Convert.ToString(LoginForm.SalesTable.Rows[index]["Material_Name"]);
                int price = Convert.ToInt32(LoginForm.SalesTable.Rows[index]["Price"]);
                double qty = 0;
                if (txtnumbers._Text == "")
                {
                    if (MatsQTY[index] > 1)
                    {
                        qty = 1;
                        MatsQTY[index] -= qty;
                        CheckTools();
                    }
                    else if (MatsQTY[index] == 1)
                    {
                        qty = 1;
                        MatsQTY[index] -= 1;
                        CheckTools();
                    }
                    else if (MatsQTY[index] < 1 && MatsQTY[index] != 0)
                    {
                        qty = MatsQTY[index];
                        MatsQTY[index] -= qty;
                        CheckTools();
                    }
                    else if (MatsQTY[index] == 0)
                    {
                        CheckTools();
                        txtnumbers._Text = "";
                        return;
                    }
                }
                else if (txtnumbers._Text.Trim() != "")
                {
                    qty = Convert.ToDouble(txtnumbers._Text);
                    MatsQTY[index] -= qty;
                    CheckTools();
                }
                double subtotal = qty * price;
                object[] data = { id, matname, qty, price, subtotal };
                Customer += id + ";" + matname + ";" + qty + ";" + price + ";" + subtotal + ";";
                dgvsales.Rows.Add(data);
                txtsearch._Text = "";
                txtnumbers._Text = "";
                Total += Convert.ToInt32(subtotal);
                lbltotal.Text = Total.ToString();
            }
        }
        #endregion
    }
}
