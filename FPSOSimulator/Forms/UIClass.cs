using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using FPSOSimulator.Forms;

namespace FPSOSimulator
{
    /// <summary>
    /// class of ui to control the position... of forms
    /// </summary>
    public class UIClass
    {
        private static UIClass myUIClass;
        private const string dbName = "user.mdb";
        private string dbPath = Application.StartupPath + "\\";
        private const string tbName = "UITable";
        private const string tbField = "UIValue";
        private string[] ChineseFontNames = new string[] { "宋体", "黑体", "微软雅黑", "新宋体", "仿宋", "楷体" };
        private string[] EngFontNames = new string[] { "Arial", "Calibri" };

        /// <summary>
        /// 界面设计时窗体长度
        /// </summary>
        public const int OldLen = 1366;
        /// <summary>
        /// 界面设计时窗体高度
        /// </summary>
        public const int OldHt = 768;

        #region "UI position and size Property"

        private static int mUILf;
        /// <summary>
        /// left of ui
        /// </summary>
        public static int UILf
        {
            get
            {
                return mUILf;
            }
            set
            {
                mUILf = value;
            }
        }
        
        private static int mUITp;
        /// <summary>
        /// top of ui
        /// </summary>
        public static int UITp
        {
            get
            {
                return mUITp;
            }
            set
            {
                mUITp = value;
            }
        }

        private static int mUILen;
        /// <summary>
        /// Length of UI
        /// </summary>       
        public static int UILen
        {
            get
            {
                return mUILen;
            }
            set
            {
                mUILen = value;
            }
        }

        private static int mUIHt;
        /// <summary>
        /// height of ui
        /// </summary>
        public static int UIHt
        {
            get
            {
                return mUIHt;
            }
            set
            {
                mUIHt = value;
            }
        }
        #endregion

        private static bool muiInitFlag = false;
        /// <summary>
        /// init from database falg
        /// </summary>
        public static bool uiInitFlag
        {
            get
            {
                return muiInitFlag;
            }
            set
            {
                muiInitFlag = value;
            }
        }

        private string mChineseFontName;
        /// <summary>
        /// chinese Font Name
        /// </summary>
        public string ChineseFontName
        {
            get
            {
                return mChineseFontName;
            }
            set
            {
                mChineseFontName = value;
            }
        }

        private string mEnglishFontName;
        /// <summary>
        /// English Font Name
        /// </summary>
        public string EnglishFontName
        {
            get
            {
                return mEnglishFontName;
            }
            set
            {
                mEnglishFontName = value;
            }
        }

        private int mBigFontNum;
        /// <summary>
        /// size of big font
        /// </summary>
        public int BigFontNum
        {
            get
            {
                return mBigFontNum;
            }
            set
            {
                mBigFontNum = value;
            }
        }

        private int mSmallFontNum;
        /// <summary>
        /// size of small font
        /// </summary>
        public int SmallFontNum
        {
            get
            {
                return mSmallFontNum;
            }
            set
            {
                mSmallFontNum = value;
            }
        }

        /// <summary>
        /// class constructure
        /// </summary>
        private UIClass()
        {
            DataRead();
            muiInitFlag = true;
        }

        public static UIClass GetUIClass()
        {
            if(myUIClass==null)
            {
                myUIClass = new UIClass();
            }
            return myUIClass;
        }

        /// <summary>
        /// operation of database
        /// </summary>
        private void DataRead()
        {
            try
            {
                UIDataBase uiDB = new UIDataBase(dbPath, dbName, tbName);
                
                uiDB.OpenConn();
                uiDB.CreateSelectCmd(true, true, "Index");
                uiDB.ExecuteReader();

                int[] uiDbValues = new int[8];
                
                for (int i = 0; i <= 7; ++i)
                {
                    uiDbValues[i] = (int)uiDB.DbReadLine(tbField);
                }
                uiDB.CloseReader();
                uiDB.CloseConn();
               
                //前四个数据是界面大小和位置，有使用，后面的数据关于字体暂时没使用
                mUILf = uiDbValues[0];
                mUITp = uiDbValues[1];
                mUILen = uiDbValues[2];
                mUIHt = uiDbValues[3];

                if (uiDbValues[4] < ChineseFontNames.Length)
                {
                    ChineseFontName = ChineseFontNames[uiDbValues[4]];
                }

                if (uiDbValues[5] < EngFontNames.Length)
                {
                    EnglishFontName = EngFontNames[uiDbValues[5]];
                }

                BigFontNum = uiDbValues[6];
                SmallFontNum = uiDbValues[7];
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "注意", MessageBoxButtons.OK);
            }
        }

    }
}
