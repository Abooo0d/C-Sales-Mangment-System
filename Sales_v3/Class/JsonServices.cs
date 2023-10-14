using Newtonsoft.Json;
using System.IO;

namespace Sales_v3.Class
{
    public static class JsonServices
    {
        public static void ReadDataFile(ref DataServices json, string file)
        {
            json = JsonConvert.DeserializeObject<DataServices>(File.ReadAllText(file));
        }
        public static void WriteDataFile(DataServices json, string file)
        {
            string jsonFile = JsonConvert.SerializeObject(json);
            StreamWriter StreamJson = new StreamWriter(file, false);
            StreamJson.WriteLine(jsonFile);
            StreamJson.Close();
            StreamJson.Dispose();
        }
        public static void ReadPrintingFile(ref PrintingServcies printing, string file)
        {
            printing = JsonConvert.DeserializeObject<PrintingServcies>(File.ReadAllText(file));
        }
        public static void WritePrintingFile(PrintingServcies printing, string file)
        {
            string jsonFile = JsonConvert.SerializeObject(printing);
            StreamWriter StreamJson = new StreamWriter(file, false);
            StreamJson.WriteLine(jsonFile);
            StreamJson.Close();
            StreamJson.Dispose();
        }
    }
    public class DataServices
    {
        private string _DataBaseRoot;
        private string _Theme;
        private int _SalesFileName;
        private int _MainColorNum;
        private string _Language;
        private bool _ToolsPanel;
        private bool _SearchBox;

        public DataServices()
        {
            DataBaseRoot = "";
            Theme = "";
            SalesFileName = 0;
            MainColorNum = 0;
            Language = "English";
            ToolsPanel = true;
            SearchBox = false;
        }
        [JsonProperty("DataBaseRoot")]
        public string DataBaseRoot
        {
            get
            {
                return _DataBaseRoot;
            }

            set
            {
                _DataBaseRoot = value;
            }
        }
        [JsonProperty("Theme")]
        public string Theme
        {
            get
            {
                return _Theme;
            }

            set
            {
                _Theme = value;
            }
        }
        [JsonProperty("SalesFileName")]
        public int SalesFileName
        {
            get
            {
                return _SalesFileName;
            }

            set
            {
                _SalesFileName = value;
            }
        }
        [JsonProperty("MainColorNum")]
        public int MainColorNum
        {
            get
            {
                return _MainColorNum;
            }

            set
            {
                _MainColorNum = value;
            }
        }
        [JsonProperty("language")]
        public string Language
        {
            get
            {
                return _Language;
            }

            set
            {
                _Language = value;
            }
        }
        [JsonProperty("ToolsPanel")]
        public bool ToolsPanel
        {
            get
            {
                return _ToolsPanel;
            }

            set
            {
                _ToolsPanel = value;
            }
        }
        [JsonProperty("SearchBox")]
        public bool SearchBox
        {
            get
            {
                return _SearchBox;
            }

            set
            {
                _SearchBox = value;
            }
        }
    }
    public class PrintingServcies
    {
        public PrintingServcies()
        {
            PrintCompanyName = new CompanyName();
            PrintColumns = new Columns();
            PrintLogo = new Logo();
            PrintPadding = new Padding();
            PrintQuot = new Quot();
            PrintTime = new Time();
            PrintTotal = new Total();
            PrintOrder = new OrderNumber();
        }
        //Fields
        private CompanyName _PrintCompanyName;
        private Columns _PrintColumns;
        private Logo _PrintLogo;
        private Padding _PrintPadding;
        private Quot _PrintQuot;
        private Time _PrintTime;
        private Total _PrintTotal;
        private OrderNumber _PrintOrder;
        [JsonProperty("PrintCompanyName")]
        public CompanyName PrintCompanyName
        {
            get
            {
                return _PrintCompanyName;
            }

            set
            {
                _PrintCompanyName = value;
            }
        }
        [JsonProperty("PrintColumns")]
        public Columns PrintColumns
        {
            get
            {
                return _PrintColumns;
            }

            set
            {
                _PrintColumns = value;
            }
        }
        [JsonProperty("PrintLogo")]
        public Logo PrintLogo
        {
            get
            {
                return _PrintLogo;
            }

            set
            {
                _PrintLogo = value;
            }
        }
        [JsonProperty("PrintPadding")]
        public Padding PrintPadding
        {
            get
            {
                return _PrintPadding;
            }

            set
            {
                _PrintPadding = value;
            }
        }
        [JsonProperty("PrintQuot")]
        public Quot PrintQuot
        {
            get
            {
                return _PrintQuot;
            }

            set
            {
                _PrintQuot = value;
            }
        }
        [JsonProperty("PrintTime")]
        public Time PrintTime
        {
            get
            {
                return _PrintTime;
            }

            set
            {
                _PrintTime = value;
            }
        }
        [JsonProperty("PrintTotal")]
        public Total PrintTotal
        {
            get
            {
                return _PrintTotal;
            }

            set
            {
                _PrintTotal = value;
            }
        }
        [JsonProperty("PrintOrderNumber")]
        public OrderNumber PrintOrder
        {
            get
            {
                return _PrintOrder;
            }

            set
            {
                _PrintOrder = value;
            }
        }

        //Enum Data Type
        public enum Language
        {
            Arabic,
            English
        }
        //Sub Class
        public class CompanyName
        {
            public CompanyName()
            {
                Enabled = false;
                Text = "Abood";
                Left = 0;
                Top = 0;
                FS = 16;
                Bold = false;
            }
            private bool _CompanyNameEnabled;
            private string _CompanyNameText;
            private int _CompanyLeft;
            private int _CompanyTop;
            private int _CompanyFS;
            private bool _CompanyBold;


            [JsonProperty("CompanyNameEnabled")]
            public bool Enabled
            {
                get
                {
                    return _CompanyNameEnabled;
                }

                set
                {
                    _CompanyNameEnabled = value;
                }
            }
            [JsonProperty("CompanyNameText")]
            public string Text
            {
                get
                {
                    return _CompanyNameText;
                }

                set
                {
                    _CompanyNameText = value;
                }
            }
            [JsonProperty("CompanyLeft")]
            public int Left
            {
                get
                {
                    return _CompanyLeft;
                }

                set
                {
                    _CompanyLeft = value;
                }
            }
            [JsonProperty("CompanyTop")]
            public int Top
            {
                get
                {
                    return _CompanyTop;
                }

                set
                {
                    _CompanyTop = value;
                }
            }
            [JsonProperty("ConpanyFontSize")]
            public int FS
            {
                get
                {
                    return _CompanyFS;
                }

                set
                {
                    _CompanyFS = value;
                }
            }
            [JsonProperty("CompanyBold")]
            public bool Bold
            {
                get
                {
                    return _CompanyBold;
                }

                set
                {
                    _CompanyBold = value;
                }
            }
        }
        public class Columns
        {
            public Columns()
            {
                Id = new ColumnId();
                Name = new ColumnName();
                QTY = new ColumnQTY();
                SubTotal = new ColumnSubTotal();
                Total = new ColumnTotal();
                Laneguage = Language.English;
                FS = 16;
                Bold = false;
                AddBorder = false;
                AddLine = false;
                AddLineBetweenMats = false;
            }
            private ColumnId _Id;
            private ColumnName _Name;
            private ColumnQTY _QTY;
            private ColumnSubTotal _SubTotal;
            private ColumnTotal _Total;
            private Language _Language;
            private int _ColumnsFS;
            private bool _ColumnsBold;
            private bool _AddBorder;
            private bool _AddLine;
            private bool _AddLineBetweenMats;
            [JsonProperty("ColumnId")]
            public ColumnId Id
            {
                get
                {
                    return _Id;
                }

                set
                {
                    _Id = value;
                }
            }
            [JsonProperty("ColumnName")]
            public ColumnName Name
            {
                get
                {
                    return _Name;
                }

                set
                {
                    _Name = value;
                }
            }
            [JsonProperty("ColumnQTY")]
            public ColumnQTY QTY
            {
                get
                {
                    return _QTY;
                }

                set
                {
                    _QTY = value;
                }
            }
            [JsonProperty("ColumnSubTotal")]
            public ColumnSubTotal SubTotal
            {
                get
                {
                    return _SubTotal;
                }

                set
                {
                    _SubTotal = value;
                }
            }
            [JsonProperty("ColumnTotal")]
            public ColumnTotal Total
            {
                get
                {
                    return _Total;
                }

                set
                {
                    _Total = value;
                }
            }
            [JsonProperty("ColumnLanguage")]
            public Language Laneguage
            {
                get
                {
                    return _Language;
                }

                set
                {
                    _Language = value;
                }
            }
            [JsonProperty("ColumnsFontSize")]
            public int FS
            {
                get
                {
                    return _ColumnsFS;
                }

                set
                {
                    _ColumnsFS = value;
                }
            }
            [JsonProperty("ColumnsBold")]
            public bool Bold
            {
                get
                {
                    return _ColumnsBold;
                }

                set
                {
                    _ColumnsBold = value;
                }
            }
            [JsonProperty("AddBorder")]
            public bool AddBorder
            {
                get
                {
                    return _AddBorder;
                }

                set
                {
                    _AddBorder = value;
                }
            }
            [JsonProperty("AddLineAnderTheColumnsNames")]
            public bool AddLine
            {
                get
                {
                    return _AddLine;
                }

                set
                {
                    _AddLine = value;
                }
            }
            [JsonProperty("AddLineAfterTheMaterails")]
            public bool AddLineBetweenMats
            {
                get
                {
                    return _AddLineBetweenMats;
                }

                set
                {
                    _AddLineBetweenMats = value;
                }
            }

            public class ColumnId
            {
                public ColumnId()
                {
                    Enabled = true;
                    Left = 0;
                    Top = 0;
                    AddLine = false;
                    LineLeft = 0;
                }
                private bool _IdEnabled;
                private int _IdLeft;
                private int _IdTop;
                private bool _AddLine;
                private int _LineLeft;
                [JsonProperty("IdEnabled")]
                public bool Enabled
                {
                    get
                    {
                        return _IdEnabled;
                    }

                    set
                    {
                        _IdEnabled = value;
                    }
                }
                [JsonProperty("IdLeft")]
                public int Left
                {
                    get
                    {
                        return _IdLeft;
                    }

                    set
                    {
                        _IdLeft = value;
                    }
                }
                [JsonProperty("IdTop")]
                public int Top
                {
                    get
                    {
                        return _IdTop;
                    }

                    set
                    {
                        _IdTop = value;
                    }
                }
                [JsonProperty("AddLine")]
                public bool AddLine
                {
                    get
                    {
                        return _AddLine;
                    }

                    set
                    {
                        _AddLine = value;
                    }
                }
                [JsonProperty("lineLeft")]
                public int LineLeft
                {
                    get
                    {
                        return _LineLeft;
                    }

                    set
                    {
                        _LineLeft = value;
                    }
                }
            }
            public class ColumnName
            {
                public ColumnName()
                {
                    Enabled = true;
                    Left = 0;
                    Top = 0;
                    AddLine = false;
                    LineLeft = 0;
                }
                private bool _NameEnabled;
                private int _NameLeft;
                private int _NameTop;
                private bool _AddLine;
                private int _LineLeft;
                [JsonProperty("NameEnabled")]
                public bool Enabled
                {
                    get
                    {
                        return _NameEnabled;
                    }

                    set
                    {
                        _NameEnabled = value;
                    }
                }
                [JsonProperty("NameLeft")]
                public int Left
                {
                    get
                    {
                        return _NameLeft;
                    }

                    set
                    {
                        _NameLeft = value;
                    }
                }
                [JsonProperty("NameTop")]
                public int Top
                {
                    get
                    {
                        return _NameTop;
                    }

                    set
                    {
                        _NameTop = value;
                    }
                }
                [JsonProperty("AddLine")]
                public bool AddLine
                {
                    get
                    {
                        return _AddLine;
                    }

                    set
                    {
                        _AddLine = value;
                    }
                }
                [JsonProperty("lineLeft")]
                public int LineLeft
                {
                    get
                    {
                        return _LineLeft;
                    }

                    set
                    {
                        _LineLeft = value;
                    }
                }
            }
            public class ColumnQTY
            {
                public ColumnQTY()
                {
                    Enabled = false;
                    Left = 0;
                    Top = 0;
                    AddLine = false;
                    LineLeft = 0;
                }
                private bool _QTYEnabled;
                private int _QTYLeft;
                private int _QTYTop;
                private bool _AddLine;
                private int _LineLeft;
                [JsonProperty("QTYEnabled")]
                public bool Enabled
                {
                    get
                    {
                        return _QTYEnabled;
                    }

                    set
                    {
                        _QTYEnabled = value;
                    }
                }
                [JsonProperty("QTYLeft")]
                public int Left
                {
                    get
                    {
                        return _QTYLeft;
                    }

                    set
                    {
                        _QTYLeft = value;
                    }
                }
                [JsonProperty("QTYTop")]
                public int Top
                {
                    get
                    {
                        return _QTYTop;
                    }

                    set
                    {
                        _QTYTop = value;
                    }
                }
                [JsonProperty("AddLine")]
                public bool AddLine
                {
                    get
                    {
                        return _AddLine;
                    }

                    set
                    {
                        _AddLine = value;
                    }
                }
                [JsonProperty("lineLeft")]
                public int LineLeft
                {
                    get
                    {
                        return _LineLeft;
                    }

                    set
                    {
                        _LineLeft = value;
                    }
                }
            }
            public class ColumnSubTotal
            {
                public ColumnSubTotal()
                {
                    Enabled = true;
                    Left = 0;
                    Top = 0;
                    AddLine = false;
                    LineLeft = 0;
                }
                private bool _SubTotalEnabled;
                private int _SubTotalLeft;
                private int _SubTotalTop;
                private bool _AddLine;
                private int _LineLeft;
                [JsonProperty("SubTotalEnabeld")]
                public bool Enabled
                {
                    get
                    {
                        return _SubTotalEnabled;
                    }

                    set
                    {
                        _SubTotalEnabled = value;
                    }
                }
                [JsonProperty("SubTotalLeft")]
                public int Left
                {
                    get
                    {
                        return _SubTotalLeft;
                    }

                    set
                    {
                        _SubTotalLeft = value;
                    }
                }
                [JsonProperty("SubTotalTop")]
                public int Top
                {
                    get
                    {
                        return _SubTotalTop;
                    }

                    set
                    {
                        _SubTotalTop = value;
                    }
                }
                [JsonProperty("AddLine")]
                public bool AddLine
                {
                    get
                    {
                        return _AddLine;
                    }

                    set
                    {
                        _AddLine = value;
                    }
                }
                [JsonProperty("lineLeft")]
                public int LineLeft
                {
                    get
                    {
                        return _LineLeft;
                    }

                    set
                    {
                        _LineLeft = value;
                    }
                }
            }
            public class ColumnTotal
            {
                public ColumnTotal()
                {
                    Enabled = true;
                    Left = 0;
                    Top = 0;
                    AddLine = false;
                    LineLeft = 0;
                }
                private bool _TotalEnabled;
                private int _TotalLeft;
                private int _TotalTop;
                private bool _AddLine;
                private int _LineLeft;
                [JsonProperty("TotalEnabled")]
                public bool Enabled
                {
                    get
                    {
                        return _TotalEnabled;
                    }

                    set
                    {
                        _TotalEnabled = value;
                    }
                }
                [JsonProperty("TotalLeft")]
                public int Left
                {
                    get
                    {
                        return _TotalLeft;
                    }

                    set
                    {
                        _TotalLeft = value;
                    }
                }
                [JsonProperty("TotalTop")]
                public int Top
                {
                    get
                    {
                        return _TotalTop;
                    }

                    set
                    {
                        _TotalTop = value;
                    }
                }
                [JsonProperty("AddLine")]
                public bool AddLine
                {
                    get
                    {
                        return _AddLine;
                    }

                    set
                    {
                        _AddLine = value;
                    }
                }
                [JsonProperty("lineLeft")]
                public int LineLeft
                {
                    get
                    {
                        return _LineLeft;
                    }

                    set
                    {
                        _LineLeft = value;
                    }
                }
            }
        }
        public class Logo
        {
            public Logo()
            {
                Enabled = false;
                Url = "Empty";
                Height = 100;
                Width = 100;
                Left = 0;
                Top = 0;
            }
            private bool _LogoEnabled;
            private string _LogoUrl;
            private int _LogoHeight;
            private int _LogoWidth;
            private int _LogoLeft;
            private int _LogoTop;
            [JsonProperty("LogoEnabled")]
            public bool Enabled
            {
                get
                {
                    return _LogoEnabled;
                }

                set
                {
                    _LogoEnabled = value;
                }
            }
            [JsonProperty("LogoUrl")]
            public string Url
            {
                get
                {
                    return _LogoUrl;
                }

                set
                {
                    _LogoUrl = value;
                }
            }
            [JsonProperty("LogoHeight")]
            public int Height
            {
                get
                {
                    return _LogoHeight;
                }

                set
                {
                    _LogoHeight = value;
                }
            }
            [JsonProperty("LogoWidth")]
            public int Width
            {
                get
                {
                    return _LogoWidth;
                }

                set
                {
                    _LogoWidth = value;
                }
            }
            [JsonProperty("LogoLeft")]
            public int Left
            {
                get
                {
                    return _LogoLeft;
                }

                set
                {
                    _LogoLeft = value;
                }
            }
            [JsonProperty("LogoTop")]
            public int Top
            {
                get
                {
                    return _LogoTop;
                }

                set
                {
                    _LogoTop = value;
                }
            }
        }
        public class Padding
        {
            public Padding()
            {
                Vertical = 10;
                Horizontal = 10;
                
            }
            private int _PaddingTop;
            private int _PaddingLeft;
            [JsonProperty("Vertical")]
            public int Vertical
            {
                get
                {
                    return _PaddingTop;
                }

                set
                {
                    _PaddingTop = value;
                }
            }
            [JsonProperty("Horizontal")]
            public int Horizontal
            {
                get
                {
                    return _PaddingLeft;
                }

                set
                {
                    _PaddingLeft = value;
                }
            }
        }
        public class Quot
        {
            public Quot()
            {
                Enabled = false;
                Text = "Empty";
                FS = 16;
                Bold = false;
            }
            private bool _QoutEnabled;
            private string _QoutText;
            private int _QuotFS;
            private bool _QuotBold;
            [JsonProperty("QuotEnabled")]
            public bool Enabled
            {
                get
                {
                    return _QoutEnabled;
                }

                set
                {
                    _QoutEnabled = value;
                }
            }
            [JsonProperty("QoutText")]
            public string Text
            {
                get
                {
                    return _QoutText;
                }

                set
                {
                    _QoutText = value;
                }
            }
            [JsonProperty("QoutFontSize")]
            public int FS
            {
                get
                {
                    return _QuotFS;
                }

                set
                {
                    _QuotFS = value;
                }
            }
            [JsonProperty("QuotBold")]
            public bool Bold
            {
                get
                {
                    return _QuotBold;
                }

                set
                {
                    _QuotBold = value;
                }
            }
        }
        public class Time
        {
            public Time()
            {
                Enabled = false;
                AddDate = false;
                AddTime = false;
                Left = 0;
                Top = 0;
                FS = 16;
                Bold = false;
            }
            private bool _TimeEnabled;
            private bool _TimeAddDate;
            private bool _TiameAddTime;
            private int _TimeLeft;
            private int _TimeTop;
            private int _TimeFS;
            private bool _TimeBold;
            [JsonProperty("TimeEnabled")]
            public bool Enabled
            {
                get
                {
                    return _TimeEnabled;
                }

                set
                {
                    _TimeEnabled = value;
                }
            }
            [JsonProperty("TimeAddDate")]
            public bool AddDate
            {
                get
                {
                    return _TimeAddDate;
                }

                set
                {
                    _TimeAddDate = value;
                }
            }
            [JsonProperty("TimeAddTime")]
            public bool AddTime
            {
                get
                {
                    return _TiameAddTime;
                }

                set
                {
                    _TiameAddTime = value;
                }
            }
            [JsonProperty("TimeLeft")]
            public int Left
            {
                get
                {
                    return _TimeLeft;
                }

                set
                {
                    _TimeLeft = value;
                }
            }
            [JsonProperty("TimeTop")]
            public int Top
            {
                get
                {
                    return _TimeTop;
                }

                set
                {
                    _TimeTop = value;
                }
            }
            [JsonProperty("TimeFontSize")]
            public int FS
            {
                get
                {
                    return _TimeFS;
                }

                set
                {
                    _TimeFS = value;
                }
            }
            [JsonProperty("TimeBold")]
            public bool Bold
            {
                get
                {
                    return _TimeBold;
                }

                set
                {
                    _TimeBold = value;
                }
            }
        }
        public class Total
        {
            public Total()
            {
                Enabled = false;
                left = 0;
                FS = 16;
                Bold = false;
            }
            private bool _TotalEnabled;
            private int _TotalLeft;
            private int _TotalFS;
            private bool _TotalBold;
            [JsonProperty("TotalEnabled")]
            public bool Enabled
            {
                get
                {
                    return _TotalEnabled;
                }

                set
                {
                    _TotalEnabled = value;
                }
            }
            [JsonProperty("TotalLeft")]
            public int left
            {
                get
                {
                    return _TotalLeft;
                }

                set
                {
                    _TotalLeft = value;
                }
            }
            [JsonProperty("TotalFontSize")]
            public int FS
            {
                get
                {
                    return _TotalFS;
                }

                set
                {
                    _TotalFS = value;
                }
            }
            [JsonProperty("TotalBold")]
            public bool Bold
            {
                get
                {
                    return _TotalBold;
                }

                set
                {
                    _TotalBold = value;
                }
            }
        }
        public class OrderNumber
        {
            public OrderNumber()
            {
                Enabled = false;
                Left = 0;
                Top = 0;
                FS = 1;
                Bold = false;
            }
            private bool _Enabled;
            private int _Left;
            private int _Top;
            private int _FS;
            private bool _Bold;
            [JsonProperty("OrderEnabled")]
            public bool Enabled
            {
                get
                {
                    return _Enabled;
                }

                set
                {
                    _Enabled = value;
                }
            }
            [JsonProperty("OrderLeft")]
            public int Left
            {
                get
                {
                    return _Left;
                }

                set
                {
                    _Left = value;
                }
            }
            [JsonProperty("OrderTop")]
            public int Top
            {
                get
                {
                    return _Top;
                }

                set
                {
                    _Top = value;
                }
            }
            [JsonProperty("OrderFs")]
            public int FS
            {
                get
                {
                    return _FS;
                }

                set
                {
                    _FS = value;
                }
            }
            [JsonProperty("OrderBold")]
            public bool Bold
            {
                get
                {
                    return _Bold;
                }

                set
                {
                    _Bold = value;
                }
            }
        }
    }
}
