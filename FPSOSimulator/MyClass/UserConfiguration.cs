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
    public class UserConfiguration
    {
        private static UserConfiguration myUserConfiguration;
        private const string dbName = "user.mdb";
        private string dbPath = Application.StartupPath + "\\";
        private const string tbName = "UserConfiguration";
        private const string tbName1 = "DefectPictureSet";
        private const string tbName2 = "DefectProductSet";
        private const string tbField = "Settings";


        #region "UserConfiguration Settings"


        public class PointMAX
        {
            private int mMAX_X;
            private int mMAX_Y;


            public int MAX_X
            {
                set { mMAX_X = value; }
                get { return mMAX_X; }
            }

            public int MAX_Y
            {
                set { mMAX_Y = value; }
                get { return mMAX_Y; }
            }
        }

        public class OverlapArea
        {
            private int mwidth;
            private int mheight;


            public int width
            {
                set { mwidth = value; }
                get { return mwidth; }
            }

            public int height
            {
                set { mheight = value; }
                get { return mheight; }
            }
        }

        public class MYCamera
        {

            //定义字段信息  
            private string mRemoteIP;
            private string mRemotePort;

            private string mUserName;
            private string mPassWord;

            private string mShareFoldName;
            private string mAimPath;



            //定义一个 RemoteIP 属性来操作 mRemoteIP 字段  
            public string RemoteIP
            {
                set { mRemoteIP = value; }
                get { return mRemoteIP; }
            }

            //定义一个 RemotePort 属性来操作 mRemotePort 字段  
            public string RemotePort
            {
                set { mRemotePort = value; }
                get { return mRemotePort; }
            }



            //定义一个 UserName 属性来操作 mUserName 字段  
            public string UserName
            {
                set { mUserName = value; }
                get { return mUserName; }
            }

            //定义一个 PassWord 属性来操作 mPassWord 字段  
            public string PassWord
            {
                set { mPassWord = value; }
                get { return mPassWord; }
            }


            //定义一个 ShareFoldName 属性来操作 mShareFoldName 字段  
            public string ShareFoldName
            {
                set { mShareFoldName = value; }
                get { return mShareFoldName; }
            }
            //定义一个 AimPath 属性来操作 mAimPath 字段  
            public string AimPath
            {
                set { mAimPath = value; }
                get { return mAimPath; }
            }


        }
        public static MYCamera[] DefCamera = new MYCamera[5];
        public static PointMAX PicPoint = new PointMAX();
        public static PointMAX CamPoint = new PointMAX();
        public static OverlapArea PicOverlapArea = new OverlapArea();
        public static int DefectProductNum = 0;
        #endregion

        /// <summary>
        /// class constructure
        /// </summary>
        private UserConfiguration()
        {
            for (int i = 0; i < 5; i++)
            {
                DefCamera[i] = new MYCamera();
            }
            DataRead();
            //muiInitFlag = true;
        }

        public static UserConfiguration GetUserConfiguration()
        {
            if (myUserConfiguration == null)
            {
                myUserConfiguration = new UserConfiguration();
            }
            return myUserConfiguration;
        }

        /// <summary>
        /// operation of database
        /// </summary>
        private void DataRead()
        {
            try
            {
                UIDataBase setDB = new UIDataBase(dbPath, dbName, tbName);

                setDB.OpenConn();
                setDB.CreateSelectCmd(true, true, "Index");
                setDB.ExecuteReader();

                //string[,] setDBValues = new string[4, 6];
                object[] mysetDBValues = new object[6];
                string[] FieldName = new string[6] { "RemoteIP", "RemotePort", "UserName", "PassWord", "ShareFoldName", "AimPath" };

                for (int i = 0; i <= 3; ++i)
                {
                    mysetDBValues = setDB.DbReadLine(7);
                    DefCamera[i + 1].RemoteIP = mysetDBValues[1].ToString();
                    DefCamera[i + 1].RemotePort = mysetDBValues[2].ToString();
                    DefCamera[i + 1].UserName = mysetDBValues[3].ToString();
                    DefCamera[i + 1].PassWord = mysetDBValues[4].ToString();
                    DefCamera[i + 1].ShareFoldName = mysetDBValues[5].ToString();
                    DefCamera[i + 1].AimPath = mysetDBValues[6].ToString();
                }


                setDB.CloseReader();
                setDB.CloseConn();


                UIDataBase setDB1 = new UIDataBase(dbPath, dbName, tbName1);

                setDB1.OpenConn();
                setDB1.CreateSelectCmd(true, true, "Index");
                setDB1.ExecuteReader();

                //string[,] setDBValues = new string[4, 6];
                object[] mysetDBValues1 = new object[3];
                //string[] FieldName1 = new string[6] { "", "", "", "", "", "" };

                for (int i = 0; i < 3; ++i)
                {
                    mysetDBValues1 = setDB1.DbReadLine(3);


                    if (i == 0)
                    {
                        PicPoint.MAX_X = int.Parse(mysetDBValues1[1].ToString());
                        PicPoint.MAX_Y = int.Parse(mysetDBValues1[2].ToString());
                    }

                    if (i == 1)
                    {
                        CamPoint.MAX_X = int.Parse(mysetDBValues1[1].ToString());
                        CamPoint.MAX_Y = int.Parse(mysetDBValues1[2].ToString());
                    }

                    if (i == 2)
                    {
                        PicOverlapArea.width = int.Parse(mysetDBValues1[1].ToString());
                        PicOverlapArea.height = int.Parse(mysetDBValues1[2].ToString());
                    }
                }


                setDB1.CloseReader();
                setDB1.CloseConn();


                //
                
                int x_1 = CamPoint.MAX_X * 4 - PicPoint.MAX_X;
                int x_2 = x_1 / 3;
                for (int i = 0; i < 4; i++)
                {
                    //frmMain.X_offset[i+1] = Convert.ToInt32((CamPoint.MAX_X - x_2)* i );//* frmMain.BackImgScale
                }

                UIDataBase setDB2 = new UIDataBase(dbPath, dbName, tbName2);

                setDB2.OpenConn();
                setDB2.CreateSelectCmd(true, true, "Index");
                setDB2.ExecuteReader();

                //string[,] setDBValues = new string[4, 6];
                object[] mysetDBValues2 = new object[3];
                //string[] FieldName1 = new string[6] { "", "", "", "", "", "" };

                for (int i = 0; i < 1; ++i)
                {
                    mysetDBValues2 = setDB2.DbReadLine(2);


                    DefectProductNum = int.Parse(mysetDBValues2[1].ToString());

                }


                setDB2.CloseReader();
                setDB2.CloseConn();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "注意", MessageBoxButtons.OK);
            }
        }

    }
}
