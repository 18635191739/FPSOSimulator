using System;
using System.Collections.Generic;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;
//using System.Runtime.InteropServices;

namespace FPSOSimulator
{
    public class SQLDBMode
    {

        //private static readonly string connString = "Data Source=(local);Database=MyTest;Uid=sa;Pwd=123456";
        #region 数据库表格 私有构造函数
        //缺陷上报信息表
        public static readonly string[] DefectInfoColStrs = new string[153] {"OUT_ID" ,
                                                                    "LNKNUM"  ,
                                                                    "LNKCOMP" ,
                                                                    "LNKDATETIME" ,
                                                                    "LNKOPER" ,
                                                                    "LNKSHIFT"    ,
                                                                    "LNKRESULT"   ,
                                                                    "LNKTOTAL"    ,
                                                                    "FAULTTYPE01"    ,
                                                                    "FAULTNAME01"    ,
                                                                    "FAULTPOSX01"    ,
                                                                    "FAULTPOSY01"    ,
                                                                    "FAULTWIDTH01"   ,
                                                                    "FAULTHEIGHT01"  ,
                                                                    "FAULTFILENAME01"    ,
                                                                    "FAULTTYPE02" ,
                                                                    "FAULTNAME02" ,
                                                                    "FAULTPOSX02" ,
                                                                    "FAULTPOSY02" ,
                                                                    "FAULTWIDTH02"    ,
                                                                    "FAULTHEIGHT02"   ,
                                                                    "FAULTFILENAME02" ,
                                                                    "FAULTTYPE03" ,
                                                                    "FAULTNAME03" ,
                                                                    "FAULTPOSX03" ,
                                                                    "FAULTPOSY03" ,
                                                                    "FAULTWIDTH03"    ,
                                                                    "FAULTHEIGHT03"   ,
                                                                    "FAULTFILENAME03" ,
                                                                    "FAULTTYPE04" ,
                                                                    "FAULTNAME04" ,
                                                                    "FAULTPOSX04" ,
                                                                    "FAULTPOSY04" ,
                                                                    "FAULTWIDTH04"    ,
                                                                    "FAULTHEIGHT04"   ,
                                                                    "FAULTFILENAME04" ,
                                                                    "FAULTTYPE05" ,
                                                                    "FAULTNAME05" ,
                                                                    "FAULTPOSX05" ,
                                                                    "FAULTPOSY05" ,
                                                                    "FAULTWIDTH05"    ,
                                                                    "FAULTHEIGHT05"   ,
                                                                    "FAULTFILENAME05" ,
                                                                    "FAULTTYPE06" ,
                                                                    "FAULTNAME06" ,
                                                                    "FAULTPOSX06" ,
                                                                    "FAULTPOSY06" ,
                                                                    "FAULTWIDTH06"    ,
                                                                    "FAULTHEIGHT06"   ,
                                                                    "FAULTFILENAME06" ,
                                                                    "FAULTTYPE07" ,
                                                                    "FAULTNAME07" ,
                                                                    "FAULTPOSX07" ,
                                                                    "FAULTPOSY07" ,
                                                                    "FAULTWIDTH07"    ,
                                                                    "FAULTHEIGHT07"   ,
                                                                    "FAULTFILENAME07" ,
                                                                    "FAULTTYPE08" ,
                                                                    "FAULTNAME08" ,
                                                                    "FAULTPOSX08" ,
                                                                    "FAULTPOSY08" ,
                                                                    "FAULTWIDTH08"    ,
                                                                    "FAULTHEIGHT08"   ,
                                                                    "FAULTFILENAME08" ,
                                                                    "FAULTTYPE09" ,
                                                                    "FAULTNAME09" ,
                                                                    "FAULTPOSX09" ,
                                                                    "FAULTPOSY09" ,
                                                                    "FAULTWIDTH09"    ,
                                                                    "FAULTHEIGHT09"   ,
                                                                    "FAULTFILENAME09" ,
                                                                    "FAULTTYPE10" ,
                                                                    "FAULTNAME10" ,
                                                                    "FAULTPOSX10" ,
                                                                    "FAULTPOSY10" ,
                                                                    "FAULTWIDTH10"    ,
                                                                    "FAULTHEIGHT10"   ,
                                                                    "FAULTFILENAME10" ,
                                                                    "FAULTTYPE11" ,
                                                                    "FAULTNAME11" ,
                                                                    "FAULTPOSX11" ,
                                                                    "FAULTPOSY11" ,
                                                                    "FAULTWIDTH11"    ,
                                                                    "FAULTHEIGHT11"   ,
                                                                    "FAULTFILENAME11" ,
                                                                    "FAULTTYPE12" ,
                                                                    "FAULTNAME12" ,
                                                                    "FAULTPOSX12" ,
                                                                    "FAULTPOSY12" ,
                                                                    "FAULTWIDTH12"    ,
                                                                    "FAULTHEIGHT12"   ,
                                                                    "FAULTFILENAME12" ,
                                                                    "FAULTTYPE13" ,
                                                                    "FAULTNAME13" ,
                                                                    "FAULTPOSX13" ,
                                                                    "FAULTPOSY13" ,
                                                                    "FAULTWIDTH13"    ,
                                                                    "FAULTHEIGHT13"   ,
                                                                    "FAULTFILENAME13" ,
                                                                    "FAULTTYPE14" ,
                                                                    "FAULTNAME14" ,
                                                                    "FAULTPOSX14" ,
                                                                    "FAULTPOSY14" ,
                                                                    "FAULTWIDTH14"    ,
                                                                    "FAULTHEIGHT14"   ,
                                                                    "FAULTFILENAME14" ,
                                                                    "FAULTTYPE15" ,
                                                                    "FAULTNAME15" ,
                                                                    "FAULTPOSX15" ,
                                                                    "FAULTPOSY15" ,
                                                                    "FAULTWIDTH15"    ,
                                                                    "FAULTHEIGHT15"   ,
                                                                    "FAULTFILENAME15" ,
                                                                    "FAULTTYPE16" ,
                                                                    "FAULTNAME16" ,
                                                                    "FAULTPOSX16" ,
                                                                    "FAULTPOSY16" ,
                                                                    "FAULTWIDTH16"    ,
                                                                    "FAULTHEIGHT16"   ,
                                                                    "FAULTFILENAME16" ,
                                                                    "FAULTTYPE17" ,
                                                                    "FAULTNAME17" ,
                                                                    "FAULTPOSX17" ,
                                                                    "FAULTPOSY17" ,
                                                                    "FAULTWIDTH17"    ,
                                                                    "FAULTHEIGHT17"   ,
                                                                    "FAULTFILENAME17" ,
                                                                    "FAULTTYPE18" ,
                                                                    "FAULTNAME18" ,
                                                                    "FAULTPOSX18" ,
                                                                    "FAULTPOSY18" ,
                                                                    "FAULTWIDTH18"    ,
                                                                    "FAULTHEIGHT18"   ,
                                                                    "FAULTFILENAME18" ,
                                                                    "FAULTTYPE19" ,
                                                                    "FAULTNAME19" ,
                                                                    "FAULTPOSX19" ,
                                                                    "FAULTPOSY19" ,
                                                                    "FAULTWIDTH19"    ,
                                                                    "FAULTHEIGHT19"   ,
                                                                    "FAULTFILENAME19" ,
                                                                    "FAULTTYPE20" ,
                                                                    "FAULTNAME20" ,
                                                                    "FAULTPOSX20" ,
                                                                    "FAULTPOSY20" ,
                                                                    "FAULTWIDTH20"    ,
                                                                    "FAULTHEIGHT20"   ,
                                                                    "FAULTFILENAME20" ,
                                                                    "TOC_DATE"    ,
                                                                    "TOC_TIME"    ,
                                                                    "TOC_FLAG"    ,
                                                                    "MES_FLAG",
                                                                     "Comment"};



        public class DefectInfoParas
        {
            public string OUT_ID;
            public int LNKNUM;
            public int LNKCOMP;
            public string LNKDATETIME;
            public string LNKOPER;
            public string LNKSHIFT;
            public int LNKRESULT;
            public int LNKTOTAL;

            public string[] FAULTTYPE = new string[21];
            public string[] FAULTNAME = new string[21];
            public int[] FAULTPOSX = new int[21];
            public int[] FAULTPOSY = new int[21];
            public int[] FAULTWIDTH = new int[21];
            public int[] FAULTHEIGHT = new int[21];
            public string[] FAULTFILENAME = new string[21];
            public int[] IsFusion = new int[21];
            public int[] IsMainPic = new int[21];
            //public string[] FAULTFILEPath = new string[21];

            public string TOC_DATE;
            public string TOC_TIME;
            public int TOC_FLAG;
            public int MES_FLAG;

            public bool IsSaved;
            public bool IsGet;

            public bool InfoUpdate;

            public string FileAimPath;

            public int[] LU_X = new int[21];
            public int[] LU_Y = new int[21];

        }

        private static readonly string[] SetParaColStrs = new string[12] {"DefectThreshold " ,
                                                                            "DefectPicShowMode"   ,
                                                                            "Camera1XcoordOffset" ,
                                                                            "Camera2XcoordOffset" ,
                                                                            "Camera3XcoordOffset" ,
                                                                            "Camera4XcoordOffset" ,
                                                                            "DefectOverlapXcoordThreshold"    ,
                                                                            "DefectOverlapYcoordThreshold"    ,
                                                                            "DefectFusionPix" ,
                                                                            "TOC_DATE"    ,
                                                                            "TOC_TIME"    ,
                                                                            "MES_FLAG" };
        public class SetParas
        {
            public int DefectThreshold;
            public int DefectPicShowMode;
            public int Camera1XcoordOffset;
            public int Camera2XcoordOffset;
            public int Camera3XcoordOffset;
            public int Camera4XcoordOffset;
            public int DefectOverlapXcoordThreshold;
            public int DefectOverlapYcoordThreshold;
            public int DefectFusionPix;
            public string TOC_DATE;
            public string TOC_TIME;
            public int MES_FLAG;
        }

        private static readonly string[] SystemFailureColStrs = new string[17] {"IPC1FailureFlag" ,
                                                                                "IPC2FailureFlag" ,
                                                                                "IPC3FailureFlag" ,
                                                                                "IPC4FailureFlag" ,
                                                                                "Camera1FailureFlag"  ,
                                                                                "Camera2FailureFlag"  ,
                                                                                "Camera3FailureFlag"  ,
                                                                                "Camera4FailureFlag" ,
                                                                                "ContinuousDefectFlag"    ,
                                                                                "PicSeverPLCCommFailure"  ,
                                                                                "PicSeverIPC1CommFailure" ,
                                                                                "PicSeverIPC2CommFailure" ,
                                                                                "PicSeverIPC3CommFailure" ,
                                                                                "PicSeverIPC4CommFailure" ,
                                                                                "TOC_DATE"    ,
                                                                                "TOC_TIME"    ,
                                                                                "MES_FLAG"    };
        public class SystemFailureParas
        {
            public int IPC1FailureFlag = 0;
            public int IPC2FailureFlag = 0;
            public int IPC3FailureFlag = 0;
            public int IPC4FailureFlag = 0;
            public int Camera1FailureFlag = 0;
            public int Camera2FailureFlag = 0;
            public int Camera3FailureFlag = 0;
            public int Camera4FailureFlag = 0;
            public int ContinuousDefectFlag = 0;
            public int PicSeverPLCCommFailure = 0;
            public int PicSeverIPC1CommFailure = 0;
            public int PicSeverIPC2CommFailure = 0;
            public int PicSeverIPC3CommFailure = 0;
            public int PicSeverIPC4CommFailure = 0;
            public string TOC_DATE;
            public string TOC_TIME;
            public int MES_FLAG;

        }
        private static readonly string[] MESInterfaceColStrs = new string[17] {"Substrate_Out_ID" ,
                                                                        "Substrate_Out_Timestamp" ,
                                                                        "Substrate_Out_Result"    ,
                                                                        "SEMI_Status" ,
                                                                        "CurrentUser"    ,
                                                                        "CurrentTimestamp"   ,
                                                                        "Lifebit" ,
                                                                        "AlarmDetected_ID"    ,
                                                                        "AlarmDetected_Text"  ,
                                                                        "AlarmDetected_Timestamp" ,
                                                                        "AlarmCleared_ID" ,
                                                                        "AlarmCleared_Text"   ,
                                                                        "AlarmCleared_Timestamp"  ,
                                                                        "HandShake"   ,
                                                                        "TOC_DATE"    ,
                                                                        "TOC_TIME"    ,
                                                                        "MES_FLAG"     };
        public class MESInterfaceParas
        {

            //public string Substrate_Out_ID; //离开检测机产品ID
            //public string ID_RD_FLG;//服务器读取ID标志
            //public string Substrate_Out_Timestamp; //产品离开检测机时间点
            //public string Substrate_Out_Result; //离开检测机时的产品状态
            //public string SEMI_Status; //检测设备状态
            //public string Current_User; //正在登陆的用户
            //public string Current_Timestamp; //实时时间点
            //public string Lifebit; // Ping信号 （生活信号）
            //public string Alarm_Detected_ID; //设备报警发生的报警 ID
            //public string Alarm_Detected_Text; //设备报警发生的报警描述
            //public string Alarm_Detected_Timestamp; //设备报警的发生时间
            //public string Alarm_Cleared_ID; //设备报警处理的报警 ID
            //public string Alarm_Cleared_Text; //设备报警处理的报警描述
            //public string Alarm_Cleared_Timestamp; //设备报警的处理时间
            //public string Handshake; //握手信号
            public string ID_RD_FLG;//服务器读取ID标志
            public string Substrate_Out_ID;    //	varchar(18)
            public string Substrate_Out_Timestamp; //	char(23)
            public int Substrate_Out_Result;    //	tinyint
            public int SEMI_Status; //	int
            public string CurrentUser;    //	varchar(10)
            public string CurrentTimestamp;   //	char(23)
            public int Lifebit; //	tinyint
            public string AlarmDetected_ID;    //	char(3)
            public string AlarmDetected_Text;  //	varchar(30)
            public string AlarmDetected_Timestamp; //	char(23)
            public string AlarmCleared_ID; //	char(10)
            public string AlarmCleared_Text;   //	varchar(50)
            public string AlarmCleared_Timestamp;  //	char(23)
            public string HandShake;   //	varchar(20)
            public string TOC_DATE;    //	date
            public string TOC_TIME;    //	time
            public int MES_FLAG;	//	int
        }


        private static readonly string[] ALMHistoryColStrs = new string[4] {"ALMDescription" ,
                                                                    "ALMDateTime" ,
                                                                    "ALMValue"    ,
                                                                    "ALMNote"  };
        public class ALMHistoryParas
        {
            public string ALMDescription;  //	Varchar(60)
            public string ALMDateTime; //	Datetime
            public int ALMValue;    //	int
            public string ALMNote;	//	varchar(100)
        }



        #endregion

        #region 数据库公共函数&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&
        public static bool IsTableExist(string tablename)
        {
            string cmdStr = "select * from sys.tables where name ='" + tablename + "'";

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString);

            conn.Open();

            SqlCommand cmd = new SqlCommand(cmdStr, conn);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows == false)//返回值为true，存在，false不存在（SqlDataReader 的HasRows ，判断是否有数据）

            {
                return false;  //该表不存在

            }
            else
            {
                return true;//该表存在
            }
        }


        /// <summary>
        /// 添加新表
        /// </summary>
        /// 
        public static void AddNewTable(string tablename, string colstr)
        {


            if (SQLDBMode.IsTableExist(tablename) == false)
            {

                //string colstr = GetSetParaColString();
                string createString = "create table " + tablename + "(" + colstr + ")";

                try
                {
                    using (SqlConnection con = SqlHelper.GetConnection())
                    {
                        SqlHelper.ExecuteNonQuery(con, CommandType.Text, createString);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            };
        }


        public static string GetCommString(string tablename, string[] ColStrs, int colnum, bool IsInsert)
        {
            //insert strings ***************************************************
            string insertcolstr = "";
            //colstr = "id,";
            for (int i = 0; i < colnum - 1; i++)
            {
                insertcolstr = insertcolstr + ColStrs[i] + ",";
            }
            insertcolstr = "(" + insertcolstr + ColStrs[colnum - 1] + ")";

            string valcolstr = "";
            //valcolstr = "@id,";
            for (int i = 0; i < colnum - 1; i++)
            {
                valcolstr = valcolstr + "@" + ColStrs[i] + ",";
            }
            valcolstr = "(" + valcolstr + "@" + ColStrs[colnum - 1] + ")";

            //update strings *********************************************************
            string updatestr = "";
            for (int i = 0; i < colnum - 1; i++)
            {
                updatestr = updatestr + ColStrs[i] + " = @" + ColStrs[i] + ",";
            }
            updatestr = updatestr + ColStrs[colnum - 1] + " = @" + ColStrs[colnum - 1];

            string CommString = "";
            if (IsInsert)
            {
                CommString = "insert into " + tablename + insertcolstr + " values" + valcolstr;
            }
            else
            {
                //string updateString = "update T_Person set p_name = @name,p_age = @age where p_id = @id";
                CommString = "update " + tablename + " set " + updatestr + " where id = 1";
            }

            return CommString;
        }
        //"update MESInterface set Substrate_Out_ID = @Substrate_Out_ID,Substrate_Out_Timestamp = @Substrate_Out_Timestamp,Substrate_Out_Result = @Substrate_Out_Result,SEMI_Status = @SEMI_Status,CurrentUser = @CurrentUser,CurrentTimestamp = @CurrentTimestamp,Lifebit = @Lifebit,AlarmDetected_ID = @AlarmDetected_ID,AlarmDetected_Text = @AlarmDetected_Text,AlarmDetected_Timestamp = @AlarmDetected_Timestamp,AlarmCleared_ID = @AlarmCleared_ID,AlarmCleared_Text = @AlarmCleared_Text,AlarmCleared_Timestamp = @AlarmCleared_Timestamp,HandShake = @HandShake,TOC_DATE = @TOC_DATE,TOC_TIME = @TOC_TIME,MES_FLAG = @MES_FLAG where id = 1"
        //"update MESInterface set Substrate_Out_ID = @Substrate_Out_ID,Substrate_Out_Timestamp = @Substrate_Out_Timestamp,Substrate_Out_Result = @Substrate_Out_Result,SEMI_Status = @SEMI_Status,CurrentUser = @CurrentUser,CurrentTimestamp = @CurrentTimestamp,Lifebit = @Lifebit,AlarmDetected_ID = @AlarmDetected_ID,AlarmDetected_Text = @AlarmDetected_Text,AlarmDetected_Timestamp = @AlarmDetected_Timestamp,AlarmCleared_ID = @AlarmCleared_ID,AlarmCleared_Text = @AlarmCleared_Text,AlarmCleared_Timestamp = @AlarmCleared_Timestamp,HandShake = @HandShake,TOC_DATE = @TOC_DATE,TOC_TIME = @TOC_TIME,MES_FLAG = @MES_FLAGwhere id = 1"
        public static string CheckDatetimeString(int dttype, string inputTime)
        {
            //判断一个string型的时间格式是否正确
            //string inputTime = "2014年05月20日";
            DateTime dateTime = new DateTime();
            string checkDatetimeString = "";
            bool convertResult = DateTime.TryParse(inputTime, out dateTime);
            //如果转换失败，dateTime的值为'01,1,1',,插入到Sql Server数据库中会报日期范围的错误，所以还是自己做一下处理比较好。

            if (!convertResult)
            {
                dateTime = new DateTime(1900, 1, 1);//转换失败，错误的时间格式，赋默认值.
                switch (dttype)
                {
                    case 0:
                        //Console.WriteLine("日期时间！");
                        checkDatetimeString = dateTime.ToString("yyyy-MM-dd HH:mm:ss");
                        break;
                    case 1:
                        //Console.WriteLine("日期");
                        checkDatetimeString = dateTime.ToString("yyyy-MM-dd");
                        break;
                    case 2:
                        //Console.WriteLine("时间");
                        checkDatetimeString = dateTime.ToString("HH:mm:ss");
                        break;
                    default:
                        //Console.WriteLine("无效的字符");
                        break;
                }

            }
            else
            {
                checkDatetimeString = inputTime;
            }

            return checkDatetimeString;
        }


        #endregion 数据库公共函数&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&

        #region 缺陷上报信息表 数据处理*****************************************************************************
        //缺陷上报信息表 
        public static string GetDefectInfoColString()
        {

            string[] colstring = new string[200];
            colstring[0] = "id 	int IDENTITY (1,1) PRIMARY KEY";
            colstring[1] = "OUT_ID 	varchar(18)	 ";
            colstring[2] = "LNKNUM	tinyint	 ";
            colstring[3] = "LNKCOMP	tinyint	 ";
            colstring[4] = "LNKDATETIME	datetime	 ";
            colstring[5] = "LNKOPER	varchar(6)	 ";
            colstring[6] = "LNKSHIFT	varchar(2)	 ";
            colstring[7] = "LNKRESULT	tinyint	 ";
            colstring[8] = "LNKTOTAL	tinyint	 ";
            colstring[9] = "FAULTTYPE01 	varchar(6)	 ";
            colstring[10] = "FAULTNAME01 	varchar(20)	 ";
            colstring[11] = "FAULTPOSX01 	int	 ";
            colstring[12] = "FAULTPOSY01 	int	 ";
            colstring[13] = "FAULTWIDTH01 	int	 ";
            colstring[14] = "FAULTHEIGHT01 	int	 ";
            colstring[15] = "FAULTFILENAME01 	varchar(30)	 ";
            colstring[16] = "FAULTTYPE02	varchar(6)	 ";
            colstring[17] = "FAULTNAME02	varchar(20)	 ";
            colstring[18] = "FAULTPOSX02	int	 ";
            colstring[19] = "FAULTPOSY02	int	 ";
            colstring[20] = "FAULTWIDTH02	int	 ";
            colstring[21] = "FAULTHEIGHT02	int	 ";
            colstring[22] = "FAULTFILENAME02	varchar(30)	 ";
            colstring[23] = "FAULTTYPE03	varchar(6)	 ";
            colstring[24] = "FAULTNAME03	varchar(20)	 ";
            colstring[25] = "FAULTPOSX03	int	 ";
            colstring[26] = "FAULTPOSY03	int	 ";
            colstring[27] = "FAULTWIDTH03	int	 ";
            colstring[28] = "FAULTHEIGHT03	int	 ";
            colstring[29] = "FAULTFILENAME03	varchar(30)	 ";
            colstring[30] = "FAULTTYPE04	varchar(6)	 ";
            colstring[31] = "FAULTNAME04	varchar(20)	 ";
            colstring[32] = "FAULTPOSX04	int	 ";
            colstring[33] = "FAULTPOSY04	int	 ";
            colstring[34] = "FAULTWIDTH04	int	 ";
            colstring[35] = "FAULTHEIGHT04	int	 ";
            colstring[36] = "FAULTFILENAME04	varchar(30)	 ";
            colstring[37] = "FAULTTYPE05	varchar(6)	 ";
            colstring[38] = "FAULTNAME05	varchar(20)	 ";
            colstring[39] = "FAULTPOSX05	int	 ";
            colstring[40] = "FAULTPOSY05	int	 ";
            colstring[41] = "FAULTWIDTH05	int	 ";
            colstring[42] = "FAULTHEIGHT05	int	 ";
            colstring[43] = "FAULTFILENAME05	varchar(30)	 ";
            colstring[44] = "FAULTTYPE06	varchar(6)	 ";
            colstring[45] = "FAULTNAME06	varchar(20)	 ";
            colstring[46] = "FAULTPOSX06	int	 ";
            colstring[47] = "FAULTPOSY06	int	 ";
            colstring[48] = "FAULTWIDTH06	int	 ";
            colstring[49] = "FAULTHEIGHT06	int	 ";
            colstring[50] = "FAULTFILENAME06	varchar(30)	 ";
            colstring[51] = "FAULTTYPE07	varchar(6)	 ";
            colstring[52] = "FAULTNAME07	varchar(20)	 ";
            colstring[53] = "FAULTPOSX07	int	 ";
            colstring[54] = "FAULTPOSY07	int	 ";
            colstring[55] = "FAULTWIDTH07	int	 ";
            colstring[56] = "FAULTHEIGHT07	int	 ";
            colstring[57] = "FAULTFILENAME07	varchar(30)	 ";
            colstring[58] = "FAULTTYPE08	varchar(6)	 ";
            colstring[59] = "FAULTNAME08	varchar(20)	 ";
            colstring[60] = "FAULTPOSX08	int	 ";
            colstring[61] = "FAULTPOSY08	int	 ";
            colstring[62] = "FAULTWIDTH08	int	 ";
            colstring[63] = "FAULTHEIGHT08	int	 ";
            colstring[64] = "FAULTFILENAME08	varchar(30)	 ";
            colstring[65] = "FAULTTYPE09	varchar(6)	 ";
            colstring[66] = "FAULTNAME09	varchar(20)	 ";
            colstring[67] = "FAULTPOSX09	int	 ";
            colstring[68] = "FAULTPOSY09	int	 ";
            colstring[69] = "FAULTWIDTH09	int	 ";
            colstring[70] = "FAULTHEIGHT09	int	 ";
            colstring[71] = "FAULTFILENAME09	varchar(30)	 ";
            colstring[72] = "FAULTTYPE10	varchar(6)	 ";
            colstring[73] = "FAULTNAME10	varchar(20)	 ";
            colstring[74] = "FAULTPOSX10	int	 ";
            colstring[75] = "FAULTPOSY10	int	 ";
            colstring[76] = "FAULTWIDTH10	int	 ";
            colstring[77] = "FAULTHEIGHT10	int	 ";
            colstring[78] = "FAULTFILENAME10	varchar(30)	 ";
            colstring[79] = "FAULTTYPE11	varchar(6)	 ";
            colstring[80] = "FAULTNAME11	varchar(20)	 ";
            colstring[81] = "FAULTPOSX11	int	 ";
            colstring[82] = "FAULTPOSY11	int	 ";
            colstring[83] = "FAULTWIDTH11	int	 ";
            colstring[84] = "FAULTHEIGHT11	int	 ";
            colstring[85] = "FAULTFILENAME11	varchar(30)	 ";
            colstring[86] = "FAULTTYPE12	varchar(6)	 ";
            colstring[87] = "FAULTNAME12	varchar(20)	 ";
            colstring[88] = "FAULTPOSX12	int	 ";
            colstring[89] = "FAULTPOSY12	int	 ";
            colstring[90] = "FAULTWIDTH12	int	 ";
            colstring[91] = "FAULTHEIGHT12	int	 ";
            colstring[92] = "FAULTFILENAME12	varchar(30)	 ";
            colstring[93] = "FAULTTYPE13	varchar(6)	 ";
            colstring[94] = "FAULTNAME13	varchar(20)	 ";
            colstring[95] = "FAULTPOSX13	int	 ";
            colstring[96] = "FAULTPOSY13	int	 ";
            colstring[97] = "FAULTWIDTH13	int	 ";
            colstring[98] = "FAULTHEIGHT13	int	 ";
            colstring[99] = "FAULTFILENAME13	varchar(30)	 ";
            colstring[100] = "FAULTTYPE14	varchar(6)	 ";
            colstring[101] = "FAULTNAME14	varchar(20)	 ";
            colstring[102] = "FAULTPOSX14	int	 ";
            colstring[103] = "FAULTPOSY14	int	 ";
            colstring[104] = "FAULTWIDTH14	int	 ";
            colstring[105] = "FAULTHEIGHT14	int	 ";
            colstring[106] = "FAULTFILENAME14	varchar(30)	 ";
            colstring[107] = "FAULTTYPE15	varchar(6)	 ";
            colstring[108] = "FAULTNAME15	varchar(20)	 ";
            colstring[109] = "FAULTPOSX15	int	 ";
            colstring[110] = "FAULTPOSY15	int	 ";
            colstring[111] = "FAULTWIDTH15	int	 ";
            colstring[112] = "FAULTHEIGHT15	int	 ";
            colstring[113] = "FAULTFILENAME15	varchar(30)	 ";
            colstring[114] = "FAULTTYPE16	varchar(6)	 ";
            colstring[115] = "FAULTNAME16	varchar(20)	 ";
            colstring[116] = "FAULTPOSX16	int	 ";
            colstring[117] = "FAULTPOSY16	int	 ";
            colstring[118] = "FAULTWIDTH16	int	 ";
            colstring[119] = "FAULTHEIGHT16	int	 ";
            colstring[120] = "FAULTFILENAME16	varchar(30)	 ";
            colstring[121] = "FAULTTYPE17	varchar(6)	 ";
            colstring[122] = "FAULTNAME17	varchar(20)	 ";
            colstring[123] = "FAULTPOSX17	int	 ";
            colstring[124] = "FAULTPOSY17	int	 ";
            colstring[125] = "FAULTWIDTH17	int	 ";
            colstring[126] = "FAULTHEIGHT17	int	 ";
            colstring[127] = "FAULTFILENAME17	varchar(30)	 ";
            colstring[128] = "FAULTTYPE18	varchar(6)	 ";
            colstring[129] = "FAULTNAME18	varchar(20)	 ";
            colstring[130] = "FAULTPOSX18	int	 ";
            colstring[131] = "FAULTPOSY18	int	 ";
            colstring[132] = "FAULTWIDTH18	int	 ";
            colstring[133] = "FAULTHEIGHT18	int	 ";
            colstring[134] = "FAULTFILENAME18	varchar(30)	 ";
            colstring[135] = "FAULTTYPE19	varchar(6)	 ";
            colstring[136] = "FAULTNAME19	varchar(20)	 ";
            colstring[137] = "FAULTPOSX19	int	 ";
            colstring[138] = "FAULTPOSY19	int	 ";
            colstring[139] = "FAULTWIDTH19	int	 ";
            colstring[140] = "FAULTHEIGHT19	int	 ";
            colstring[141] = "FAULTFILENAME19	varchar(30)	 ";
            colstring[142] = "FAULTTYPE20	varchar(6)	 ";
            colstring[143] = "FAULTNAME20	varchar(20)	 ";
            colstring[144] = "FAULTPOSX20	int	 ";
            colstring[145] = "FAULTPOSY20	int	 ";
            colstring[146] = "FAULTWIDTH20	int	 ";
            colstring[147] = "FAULTHEIGHT20	int	 ";
            colstring[148] = "FAULTFILENAME20	varchar(30)	 ";
            colstring[149] = "TOC_DATE	date	 ";
            colstring[150] = "TOC_TIME	time	 ";
            colstring[151] = "TOC_FLAG	tinyint	 ";
            colstring[152] = "MES_FLAG	tinyint	 ";
            colstring[153] = "Comment	varchar(50)	 ";


            string colstr = "";
            for (int i = 0; i < 154; i++)
            {
                if (i < 153)
                {
                    colstr = colstr + colstring[i] + ",";
                }
                else
                {
                    colstr = colstr + colstring[i];
                }

            }
            return colstr;
        }

        public static string CheckStringLen(string inputstr, int maxlen)
        {
            string checkStringLen = "";
            if (inputstr.Length > maxlen)
            {
                checkStringLen = inputstr.Substring(0, maxlen);
            }
            else
            {
                checkStringLen = inputstr;
            }
            return checkStringLen;
        }

        public static int CheckTinyInt(int inputval)
        {
            int checkTinyInt = 0;
            if (inputval > 0 && inputval <= 255)
            {

                checkTinyInt = inputval;
            }

            return checkTinyInt;
        }


        /// <summary>
        /// 插入数据
        /// </summary>
        public static bool InsertDefectInfoRecord(string tablename, DefectInfoParas myRecordParas,bool IsInsert)
        {
            string colstr = "";
            bool insertDefectInfoRecord = true;
            //colstr = "id,";
            for (int i = 0; i < 151; i++)
            {
                colstr = colstr + DefectInfoColStrs[i] + ",";
            }
            colstr = "(" + colstr + DefectInfoColStrs[151] + ")";

            string valcolstr = "";
            //valcolstr = "@id,";
            for (int i = 0; i < 151; i++)
            {
                valcolstr = valcolstr + "@" + DefectInfoColStrs[i] + ",";
            }
            valcolstr = "(" + valcolstr + "@" + DefectInfoColStrs[151] + ")";

            //update strings *********************************************************
            string updatestr = "";
            for (int i = 0; i < 151; i++)
            {
                updatestr = updatestr + DefectInfoColStrs[i] + " = @" + DefectInfoColStrs[i] + ",";
            }
            updatestr = updatestr + DefectInfoColStrs[151] + " = @" + DefectInfoColStrs[151];


            //string insertString = "insert into nihao";
            string insertString = null;
            if (IsInsert)
            {
                insertString = "insert into " + tablename + colstr + " values" + valcolstr ;
            }
            else
            {
                //string updateString = "update T_Person set p_name = @name,p_age = @age where p_id = @id";
                insertString = "update " + tablename + " set " + updatestr + " where LNKNUM = " + myRecordParas.LNKNUM + " and OUT_ID = " + myRecordParas.OUT_ID + " and LNKDATETIME = '" + myRecordParas.LNKDATETIME +"'";
            }

            //string insertString = "insert into " + tablename + colstr + " values" + valcolstr;
            //SqlHelper.ExecuteNonQuery(con, CommandType.Text, "insert into student values( ,'Ghazi',21)");
            SqlParameter[] cmdParameter = {
                //new SqlParameter("@id", SqlDbType.Int ),
                new SqlParameter("@OUT_ID", SqlDbType.VarChar ),
                new SqlParameter("@LNKNUM", SqlDbType.TinyInt ),
                new SqlParameter("@LNKCOMP", SqlDbType.TinyInt ),
                new SqlParameter("@LNKDATETIME", SqlDbType.DateTime),
                new SqlParameter("@LNKOPER", SqlDbType.VarChar ),
                new SqlParameter("@LNKSHIFT", SqlDbType.VarChar ),
                new SqlParameter("@LNKRESULT", SqlDbType.TinyInt ),
                new SqlParameter("@LNKTOTAL", SqlDbType.TinyInt ),
                new SqlParameter("@FAULTTYPE01", SqlDbType.VarChar ),
                new SqlParameter("@FAULTNAME01", SqlDbType.VarChar ),
                new SqlParameter("@FAULTPOSX01", SqlDbType.Int ),
                new SqlParameter("@FAULTPOSY01", SqlDbType.Int ),
                new SqlParameter("@FAULTWIDTH01", SqlDbType.Int ),
                new SqlParameter("@FAULTHEIGHT01", SqlDbType.Int ),
                new SqlParameter("@FAULTFILENAME01", SqlDbType.VarChar ),
                new SqlParameter("@FAULTTYPE02", SqlDbType.VarChar ),
                new SqlParameter("@FAULTNAME02", SqlDbType.VarChar ),
                new SqlParameter("@FAULTPOSX02", SqlDbType.Int ),
                new SqlParameter("@FAULTPOSY02", SqlDbType.Int ),
                new SqlParameter("@FAULTWIDTH02", SqlDbType.Int ),
                new SqlParameter("@FAULTHEIGHT02", SqlDbType.Int ),
                new SqlParameter("@FAULTFILENAME02", SqlDbType.VarChar ),
                new SqlParameter("@FAULTTYPE03", SqlDbType.VarChar ),
                new SqlParameter("@FAULTNAME03", SqlDbType.VarChar ),
                new SqlParameter("@FAULTPOSX03", SqlDbType.Int ),
                new SqlParameter("@FAULTPOSY03", SqlDbType.Int ),
                new SqlParameter("@FAULTWIDTH03", SqlDbType.Int ),
                new SqlParameter("@FAULTHEIGHT03", SqlDbType.Int ),
                new SqlParameter("@FAULTFILENAME03", SqlDbType.VarChar ),
                new SqlParameter("@FAULTTYPE04", SqlDbType.VarChar ),
                new SqlParameter("@FAULTNAME04", SqlDbType.VarChar ),
                new SqlParameter("@FAULTPOSX04", SqlDbType.Int ),
                new SqlParameter("@FAULTPOSY04", SqlDbType.Int ),
                new SqlParameter("@FAULTWIDTH04", SqlDbType.Int ),
                new SqlParameter("@FAULTHEIGHT04", SqlDbType.Int ),
                new SqlParameter("@FAULTFILENAME04", SqlDbType.VarChar ),
                new SqlParameter("@FAULTTYPE05", SqlDbType.VarChar ),
                new SqlParameter("@FAULTNAME05", SqlDbType.VarChar ),
                new SqlParameter("@FAULTPOSX05", SqlDbType.Int ),
                new SqlParameter("@FAULTPOSY05", SqlDbType.Int ),
                new SqlParameter("@FAULTWIDTH05", SqlDbType.Int ),
                new SqlParameter("@FAULTHEIGHT05", SqlDbType.Int ),
                new SqlParameter("@FAULTFILENAME05", SqlDbType.VarChar ),
                new SqlParameter("@FAULTTYPE06", SqlDbType.VarChar ),
                new SqlParameter("@FAULTNAME06", SqlDbType.VarChar ),
                new SqlParameter("@FAULTPOSX06", SqlDbType.Int ),
                new SqlParameter("@FAULTPOSY06", SqlDbType.Int ),
                new SqlParameter("@FAULTWIDTH06", SqlDbType.Int ),
                new SqlParameter("@FAULTHEIGHT06", SqlDbType.Int ),
                new SqlParameter("@FAULTFILENAME06", SqlDbType.VarChar ),
                new SqlParameter("@FAULTTYPE07", SqlDbType.VarChar ),
                new SqlParameter("@FAULTNAME07", SqlDbType.VarChar ),
                new SqlParameter("@FAULTPOSX07", SqlDbType.Int ),
                new SqlParameter("@FAULTPOSY07", SqlDbType.Int ),
                new SqlParameter("@FAULTWIDTH07", SqlDbType.Int ),
                new SqlParameter("@FAULTHEIGHT07", SqlDbType.Int ),
                new SqlParameter("@FAULTFILENAME07", SqlDbType.VarChar ),
                new SqlParameter("@FAULTTYPE08", SqlDbType.VarChar ),
                new SqlParameter("@FAULTNAME08", SqlDbType.VarChar ),
                new SqlParameter("@FAULTPOSX08", SqlDbType.Int ),
                new SqlParameter("@FAULTPOSY08", SqlDbType.Int ),
                new SqlParameter("@FAULTWIDTH08", SqlDbType.Int ),
                new SqlParameter("@FAULTHEIGHT08", SqlDbType.Int ),
                new SqlParameter("@FAULTFILENAME08", SqlDbType.VarChar ),
                new SqlParameter("@FAULTTYPE09", SqlDbType.VarChar ),
                new SqlParameter("@FAULTNAME09", SqlDbType.VarChar ),
                new SqlParameter("@FAULTPOSX09", SqlDbType.Int ),
                new SqlParameter("@FAULTPOSY09", SqlDbType.Int ),
                new SqlParameter("@FAULTWIDTH09", SqlDbType.Int ),
                new SqlParameter("@FAULTHEIGHT09", SqlDbType.Int ),
                new SqlParameter("@FAULTFILENAME09", SqlDbType.VarChar ),
                new SqlParameter("@FAULTTYPE10", SqlDbType.VarChar ),
                new SqlParameter("@FAULTNAME10", SqlDbType.VarChar ),
                new SqlParameter("@FAULTPOSX10", SqlDbType.Int ),
                new SqlParameter("@FAULTPOSY10", SqlDbType.Int ),
                new SqlParameter("@FAULTWIDTH10", SqlDbType.Int ),
                new SqlParameter("@FAULTHEIGHT10", SqlDbType.Int ),
                new SqlParameter("@FAULTFILENAME10", SqlDbType.VarChar ),
                new SqlParameter("@FAULTTYPE11", SqlDbType.VarChar ),
                new SqlParameter("@FAULTNAME11", SqlDbType.VarChar ),
                new SqlParameter("@FAULTPOSX11", SqlDbType.Int ),
                new SqlParameter("@FAULTPOSY11", SqlDbType.Int ),
                new SqlParameter("@FAULTWIDTH11", SqlDbType.Int ),
                new SqlParameter("@FAULTHEIGHT11", SqlDbType.Int ),
                new SqlParameter("@FAULTFILENAME11", SqlDbType.VarChar ),
                new SqlParameter("@FAULTTYPE12", SqlDbType.VarChar ),
                new SqlParameter("@FAULTNAME12", SqlDbType.VarChar ),
                new SqlParameter("@FAULTPOSX12", SqlDbType.Int ),
                new SqlParameter("@FAULTPOSY12", SqlDbType.Int ),
                new SqlParameter("@FAULTWIDTH12", SqlDbType.Int ),
                new SqlParameter("@FAULTHEIGHT12", SqlDbType.Int ),
                new SqlParameter("@FAULTFILENAME12", SqlDbType.VarChar ),
                new SqlParameter("@FAULTTYPE13", SqlDbType.VarChar ),
                new SqlParameter("@FAULTNAME13", SqlDbType.VarChar ),
                new SqlParameter("@FAULTPOSX13", SqlDbType.Int ),
                new SqlParameter("@FAULTPOSY13", SqlDbType.Int ),
                new SqlParameter("@FAULTWIDTH13", SqlDbType.Int ),
                new SqlParameter("@FAULTHEIGHT13", SqlDbType.Int ),
                new SqlParameter("@FAULTFILENAME13", SqlDbType.VarChar ),
                new SqlParameter("@FAULTTYPE14", SqlDbType.VarChar ),
                new SqlParameter("@FAULTNAME14", SqlDbType.VarChar ),
                new SqlParameter("@FAULTPOSX14", SqlDbType.Int ),
                new SqlParameter("@FAULTPOSY14", SqlDbType.Int ),
                new SqlParameter("@FAULTWIDTH14", SqlDbType.Int ),
                new SqlParameter("@FAULTHEIGHT14", SqlDbType.Int ),
                new SqlParameter("@FAULTFILENAME14", SqlDbType.VarChar ),
                new SqlParameter("@FAULTTYPE15", SqlDbType.VarChar ),
                new SqlParameter("@FAULTNAME15", SqlDbType.VarChar ),
                new SqlParameter("@FAULTPOSX15", SqlDbType.Int ),
                new SqlParameter("@FAULTPOSY15", SqlDbType.Int ),
                new SqlParameter("@FAULTWIDTH15", SqlDbType.Int ),
                new SqlParameter("@FAULTHEIGHT15", SqlDbType.Int ),
                new SqlParameter("@FAULTFILENAME15", SqlDbType.VarChar ),
                new SqlParameter("@FAULTTYPE16", SqlDbType.VarChar ),
                new SqlParameter("@FAULTNAME16", SqlDbType.VarChar ),
                new SqlParameter("@FAULTPOSX16", SqlDbType.Int ),
                new SqlParameter("@FAULTPOSY16", SqlDbType.Int ),
                new SqlParameter("@FAULTWIDTH16", SqlDbType.Int ),
                new SqlParameter("@FAULTHEIGHT16", SqlDbType.Int ),
                new SqlParameter("@FAULTFILENAME16", SqlDbType.VarChar ),
                new SqlParameter("@FAULTTYPE17", SqlDbType.VarChar ),
                new SqlParameter("@FAULTNAME17", SqlDbType.VarChar ),
                new SqlParameter("@FAULTPOSX17", SqlDbType.Int ),
                new SqlParameter("@FAULTPOSY17", SqlDbType.Int ),
                new SqlParameter("@FAULTWIDTH17", SqlDbType.Int ),
                new SqlParameter("@FAULTHEIGHT17", SqlDbType.Int ),
                new SqlParameter("@FAULTFILENAME17", SqlDbType.VarChar ),
                new SqlParameter("@FAULTTYPE18", SqlDbType.VarChar ),
                new SqlParameter("@FAULTNAME18", SqlDbType.VarChar ),
                new SqlParameter("@FAULTPOSX18", SqlDbType.Int ),
                new SqlParameter("@FAULTPOSY18", SqlDbType.Int ),
                new SqlParameter("@FAULTWIDTH18", SqlDbType.Int ),
                new SqlParameter("@FAULTHEIGHT18", SqlDbType.Int ),
                new SqlParameter("@FAULTFILENAME18", SqlDbType.VarChar ),
                new SqlParameter("@FAULTTYPE19", SqlDbType.VarChar ),
                new SqlParameter("@FAULTNAME19", SqlDbType.VarChar ),
                new SqlParameter("@FAULTPOSX19", SqlDbType.Int ),
                new SqlParameter("@FAULTPOSY19", SqlDbType.Int ),
                new SqlParameter("@FAULTWIDTH19", SqlDbType.Int ),
                new SqlParameter("@FAULTHEIGHT19", SqlDbType.Int ),
                new SqlParameter("@FAULTFILENAME19", SqlDbType.VarChar ),
                new SqlParameter("@FAULTTYPE20", SqlDbType.VarChar ),
                new SqlParameter("@FAULTNAME20", SqlDbType.VarChar ),
                new SqlParameter("@FAULTPOSX20", SqlDbType.Int ),
                new SqlParameter("@FAULTPOSY20", SqlDbType.Int ),
                new SqlParameter("@FAULTWIDTH20", SqlDbType.Int ),
                new SqlParameter("@FAULTHEIGHT20", SqlDbType.Int ),
                new SqlParameter("@FAULTFILENAME20", SqlDbType.VarChar ),
                new SqlParameter("@TOC_DATE", SqlDbType.Date    ),
                new SqlParameter("@TOC_TIME", SqlDbType.Time    ),
                new SqlParameter("@TOC_FLAG", SqlDbType.TinyInt ),
                new SqlParameter("@MES_FLAG", SqlDbType.TinyInt )
        };
            ////字符串限制长度
            cmdParameter[0].Value = CheckStringLen(myRecordParas.OUT_ID, 18);
            cmdParameter[1].Value = CheckTinyInt(myRecordParas.LNKNUM);
            cmdParameter[2].Value = CheckTinyInt(myRecordParas.LNKCOMP);
            cmdParameter[3].Value = CheckDatetimeString(0, myRecordParas.LNKDATETIME);
            cmdParameter[4].Value = CheckStringLen(myRecordParas.LNKOPER, 6);
            cmdParameter[5].Value = CheckStringLen(myRecordParas.LNKSHIFT, 2);
            cmdParameter[6].Value = CheckTinyInt(myRecordParas.LNKRESULT);
            cmdParameter[7].Value = CheckTinyInt(myRecordParas.LNKTOTAL);

            for (int i = 0; i < 20; i++)
            {
                cmdParameter[8 + 7 * i].Value = CheckStringLen(myRecordParas.FAULTTYPE[i], 6);
                cmdParameter[9 + 7 * i].Value = CheckStringLen(myRecordParas.FAULTNAME[i], 20);
                cmdParameter[10 + 7 * i].Value = myRecordParas.FAULTPOSX[i];
                cmdParameter[11 + 7 * i].Value = myRecordParas.FAULTPOSY[i];
                cmdParameter[12 + 7 * i].Value = myRecordParas.FAULTWIDTH[i];
                cmdParameter[13 + 7 * i].Value = myRecordParas.FAULTHEIGHT[i];
                cmdParameter[14 + 7 * i].Value = CheckStringLen(myRecordParas.FAULTFILENAME[i], 30);
            }
            //string.Format("{0:yyyy-MM-dd HH:mm:ss.fff}", CheckDatetimeString(myRecordParas.TOC_DATE));
            cmdParameter[148].Value =DateTime.Now.ToString("yyyy-MM-dd"); // CheckDatetimeString(1, myRecordParas.TOC_DATE); //
            cmdParameter[149].Value = DateTime.Now.ToString("HH:mm:ss"); //CheckDatetimeString(2, myRecordParas.TOC_TIME);// 
            cmdParameter[150].Value = 0; //CheckTinyInt(myRecordParas.TOC_FLAG);
            cmdParameter[151].Value = 1; //CheckTinyInt(myRecordParas.MES_FLAG);

            try
            {
                using (SqlConnection con = SqlHelper.GetConnection())
                {
                    SqlHelper.ExecuteNonQuery(con, CommandType.Text, insertString, cmdParameter);
                }

            }
            catch (Exception ex)
            {
                insertDefectInfoRecord = false;
                //Console.WriteLine(ex.ToString());
            }

            return insertDefectInfoRecord;
        }
        #endregion


        #region  参数设定数据表 数据处理******************************************************************
        // //参数设定数据表
        public static string GetSetParaColString()
        {

            string[] colstring = new string[12];
            colstring[0] = "DefectThreshold 		int";
            colstring[1] = "DefectPicShowMode		Int";
            colstring[2] = "Camera1XcoordOffset		int";
            colstring[3] = "Camera2XcoordOffset		int";
            colstring[4] = "Camera3XcoordOffset		int";
            colstring[5] = "Camera4XcoordOffset		int";
            colstring[6] = "DefectOverlapXcoordThreshold		int	";
            colstring[7] = "DefectOverlapYcoordThreshold		int	";
            colstring[8] = "DefectFusionPix		int";
            colstring[9] = "TOC_DATE		date";
            colstring[10] = "TOC_TIME		time";
            colstring[11] = "MES_FLAG		int";

            string colstr = "";
            for (int i = 0; i < 11; i++)
            {
                colstr = colstr + colstring[i] + ",";
            }
            colstr = colstr + colstring[11];
            return colstr;
        }

        /// <summary>
        /// 插入数据 OR  修改参数
        /// </summary>
        public static void InsertOrUpdateSetParaRecord(string tablename, SetParas myRecordParas, bool IsInsert)
        {

            string CommString = GetCommString(tablename, SetParaColStrs, 12, IsInsert);
            //cmdParameter  *********************************************************
            SqlParameter[] cmdParameter = {new SqlParameter("@DefectThreshold", SqlDbType.Int ),
                                            new SqlParameter("@DefectPicShowMode", SqlDbType.Int ),
                                            new SqlParameter("@Camera1XcoordOffset", SqlDbType.Int ),
                                            new SqlParameter("@Camera2XcoordOffset", SqlDbType.Int ),
                                            new SqlParameter("@Camera3XcoordOffset", SqlDbType.Int ),
                                            new SqlParameter("@Camera4XcoordOffset", SqlDbType.Int ),
                                            new SqlParameter("@DefectOverlapXcoordThreshold", SqlDbType.Int ),
                                            new SqlParameter("@DefectOverlapYcoordThreshold", SqlDbType.Int ),
                                            new SqlParameter("@DefectFusionPix", SqlDbType.Int ),
                                            new SqlParameter("@TOC_DATE", SqlDbType.Date ),
                                            new SqlParameter("@TOC_TIME", SqlDbType.Time ),
                                            new SqlParameter("@MES_FLAG", SqlDbType.Int ) };

            cmdParameter[0].Value = myRecordParas.DefectThreshold;
            cmdParameter[1].Value = myRecordParas.DefectPicShowMode;
            cmdParameter[2].Value = myRecordParas.Camera1XcoordOffset;
            cmdParameter[3].Value = myRecordParas.Camera2XcoordOffset;
            cmdParameter[4].Value = myRecordParas.Camera3XcoordOffset;
            cmdParameter[5].Value = myRecordParas.Camera4XcoordOffset;
            cmdParameter[6].Value = myRecordParas.DefectOverlapXcoordThreshold;
            cmdParameter[7].Value = myRecordParas.DefectOverlapYcoordThreshold;
            cmdParameter[8].Value = myRecordParas.DefectFusionPix;
            cmdParameter[9].Value = DateTime.Now.ToString("yyyy-MM-dd"); //myRecordParas.TOC_DATE;
            cmdParameter[10].Value = DateTime.Now.ToString("HH:mm:ss"); //myRecordParas.TOC_TIME;
            cmdParameter[11].Value = myRecordParas.MES_FLAG;

            try
            {
                using (SqlConnection con = SqlHelper.GetConnection())
                {
                    SqlHelper.ExecuteNonQuery(con, CommandType.Text, CommString, cmdParameter);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region 通讯异常状态表 数据处理******************************************************
        public static string GetSystemFailureColString()
        {

            string[] colstring = new string[18];
            colstring[0] = "id 	int IDENTITY (1,1) PRIMARY KEY";
            colstring[1] = "IPC1FailureFlag		int";
            colstring[2] = "IPC2FailureFlag		Int";
            colstring[3] = "IPC3FailureFlag		int";
            colstring[4] = "IPC4FailureFlag		int";
            colstring[5] = "Camera1FailureFlag		int";
            colstring[6] = "Camera2FailureFlag		int";
            colstring[7] = "Camera3FailureFlag		int";
            colstring[8] = "Camera4FailureFlag		int";
            colstring[9] = "ContinuousDefectFlag		int";
            colstring[10] = "PicSeverPLCCommFailure		int";
            colstring[11] = "PicSeverIPC1CommFailure		int";
            colstring[12] = "PicSeverIPC2CommFailure		int";
            colstring[13] = "PicSeverIPC3CommFailure		int";
            colstring[14] = "PicSeverIPC4CommFailure		int";
            colstring[15] = "TOC_DATE		date";
            colstring[16] = "TOC_TIME		time";
            colstring[17] = "MES_FLAG		int";

            string colstr = "";
            for (int i = 0; i < 17; i++)
            {
                colstr = colstr + colstring[i] + ",";
            }
            colstr = colstr + colstring[17];
            return colstr;
        }

        /// <summary>
        /// 插入数据 OR  修改参数
        /// </summary>
        public static void InsertOrUpdateSystemFailureRecord(string tablename, SystemFailureParas myRecordParas, bool IsInsert)
        {
            string CommString = GetCommString(tablename, SystemFailureColStrs, 17, IsInsert);
            //cmdParameter  *********************************************************
            SqlParameter[] cmdParameter = {new SqlParameter("@IPC1FailureFlag", SqlDbType.Int ),
                                            new SqlParameter("@IPC2FailureFlag", SqlDbType.Int ),
                                            new SqlParameter("@IPC3FailureFlag", SqlDbType.Int ),
                                            new SqlParameter("@IPC4FailureFlag", SqlDbType.Int ),
                                            new SqlParameter("@Camera1FailureFlag", SqlDbType.Int ),
                                            new SqlParameter("@Camera2FailureFlag", SqlDbType.Int ),
                                            new SqlParameter("@Camera3FailureFlag", SqlDbType.Int ),
                                            new SqlParameter("@Camera4FailureFlag", SqlDbType.Int ),
                                            new SqlParameter("@ContinuousDefectFlag", SqlDbType.Int ),
                                            new SqlParameter("@PicSeverPLCCommFailure", SqlDbType.Int ),
                                            new SqlParameter("@PicSeverIPC1CommFailure", SqlDbType.Int ),
                                            new SqlParameter("@PicSeverIPC2CommFailure", SqlDbType.Int ),
                                            new SqlParameter("@PicSeverIPC3CommFailure", SqlDbType.Int ),
                                            new SqlParameter("@PicSeverIPC4CommFailure", SqlDbType.Int ),
                                            new SqlParameter("@TOC_DATE", SqlDbType.Date ),
                                            new SqlParameter("@TOC_TIME", SqlDbType.Time ),
                                            new SqlParameter("@MES_FLAG", SqlDbType.Int ) };


            cmdParameter[0].Value = myRecordParas.IPC1FailureFlag;
            cmdParameter[1].Value = myRecordParas.IPC2FailureFlag;
            cmdParameter[2].Value = myRecordParas.IPC3FailureFlag;
            cmdParameter[3].Value = myRecordParas.IPC4FailureFlag;
            cmdParameter[4].Value = myRecordParas.Camera1FailureFlag;
            cmdParameter[5].Value = myRecordParas.Camera2FailureFlag;
            cmdParameter[6].Value = myRecordParas.Camera3FailureFlag;
            cmdParameter[7].Value = myRecordParas.Camera4FailureFlag;
            cmdParameter[8].Value = myRecordParas.ContinuousDefectFlag;
            cmdParameter[9].Value = myRecordParas.PicSeverPLCCommFailure;
            cmdParameter[10].Value = myRecordParas.PicSeverIPC1CommFailure;
            cmdParameter[11].Value = myRecordParas.PicSeverIPC2CommFailure;
            cmdParameter[12].Value = myRecordParas.PicSeverIPC3CommFailure;
            cmdParameter[13].Value = myRecordParas.PicSeverIPC4CommFailure;
            cmdParameter[14].Value = DateTime.Now.ToString("yyyy-MM-dd"); // myRecordParas.TOC_DATE;
            cmdParameter[15].Value = DateTime.Now.ToString("HH:mm:ss"); // myRecordParas.TOC_TIME;
            cmdParameter[16].Value = myRecordParas.MES_FLAG;

            try
            {
                using (SqlConnection con = SqlHelper.GetConnection())
                {
                    SqlHelper.ExecuteNonQuery(con, CommandType.Text, CommString, cmdParameter);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion


        #region MES接口数据表 数据处理******************************************************
        public static string GetMESInterfaceColString()
        {

            string[] colstring = new string[18];
            colstring[0] = "id 	int IDENTITY (1,1) PRIMARY KEY";
            colstring[1] = "Substrate_Out_ID		    varchar(18)";
            colstring[2] = "Substrate_Out_Timestamp		char(23)";
            colstring[3] = "Substrate_Out_Result		tinyint";
            colstring[4] = "SEMI_Status	              	int";
            colstring[5] = "CurrentUser		varchar(10)";
            colstring[6] = "CurrentTimestamp		char(23)";
            colstring[7] = "Lifebit		tinyint";
            colstring[8] = "AlarmDetected_ID		char(3)";
            colstring[9] = "AlarmDetected_Text		varchar(30)";
            colstring[10] = "AlarmDetected_Timestamp		char(23)";
            colstring[11] = "AlarmCleared_ID		char(10)";
            colstring[12] = "AlarmCleared_Text		varchar(50)";
            colstring[13] = "AlarmCleared_Timestamp		char(23)";
            colstring[14] = "HandShake		varchar(20)";
            colstring[15] = "TOC_DATE		date";
            colstring[16] = "TOC_TIME		time";
            colstring[17] = "MES_FLAG		int";


            string colstr = "";
            for (int i = 0; i < 17; i++)
            {
                colstr = colstr + colstring[i] + ",";
            }
            colstr = colstr + colstring[17];
            return colstr;
        }

        /// <summary>
        /// 插入数据 OR  修改参数
        /// </summary>
        public static void InsertOrUpdateMESInterfaceRecord(string tablename, MESInterfaceParas myRecordParas, bool IsInsert)
        {
            string CommString = GetCommString(tablename, MESInterfaceColStrs, 17, IsInsert);
            //cmdParameter  *********************************************************
            SqlParameter[] cmdParameter = {new SqlParameter("@Substrate_Out_ID", SqlDbType.VarChar ),	//	varchar(18)
                                            new SqlParameter("@Substrate_Out_Timestamp", SqlDbType.Char ),	//	char(23)
                                            new SqlParameter("@Substrate_Out_Result", SqlDbType.TinyInt ),	//	tinyint
                                            new SqlParameter("@SEMI_Status", SqlDbType.Int ),	//	int
                                            new SqlParameter("@CurrentUser", SqlDbType.VarChar ),	//	varchar(10)
                                            new SqlParameter("@CurrentTimestamp", SqlDbType.Char ),	//	char(23)
                                            new SqlParameter("@Lifebit", SqlDbType.TinyInt ),	//	tinyint
                                            new SqlParameter("@AlarmDetected_ID", SqlDbType.Char ),	//	char(3)
                                            new SqlParameter("@AlarmDetected_Text", SqlDbType.VarChar ),	//	varchar(30)
                                            new SqlParameter("@AlarmDetected_Timestamp", SqlDbType.Char ),	//	char(23)
                                            new SqlParameter("@AlarmCleared_ID", SqlDbType.Char ),	//	char(10)
                                            new SqlParameter("@AlarmCleared_Text", SqlDbType.VarChar ),	//	varchar(50)
                                            new SqlParameter("@AlarmCleared_Timestamp", SqlDbType.Char ),	//	char(23)
                                            new SqlParameter("@HandShake", SqlDbType.VarChar ),	//	varchar(20)
                                            new SqlParameter("@TOC_DATE", SqlDbType.Date ),	//	date
                                            new SqlParameter("@TOC_TIME", SqlDbType.Time ),	//	time
                                            new SqlParameter("@MES_FLAG", SqlDbType.Int )};	//	int

            cmdParameter[0].Value = myRecordParas.Substrate_Out_ID;
            cmdParameter[1].Value = myRecordParas.Substrate_Out_Timestamp;
            cmdParameter[2].Value = myRecordParas.Substrate_Out_Result;
            cmdParameter[3].Value = myRecordParas.SEMI_Status;
            cmdParameter[4].Value = myRecordParas.CurrentUser;
            cmdParameter[5].Value = myRecordParas.CurrentTimestamp;
            cmdParameter[6].Value = myRecordParas.Lifebit;
            cmdParameter[7].Value = myRecordParas.AlarmDetected_ID;
            cmdParameter[8].Value = myRecordParas.AlarmDetected_Text;
            cmdParameter[9].Value = myRecordParas.AlarmDetected_Timestamp;
            cmdParameter[10].Value = myRecordParas.AlarmCleared_ID;
            cmdParameter[11].Value = myRecordParas.AlarmCleared_Text;
            cmdParameter[12].Value = myRecordParas.AlarmCleared_Timestamp;
            cmdParameter[13].Value = myRecordParas.HandShake;
            cmdParameter[14].Value = DateTime.Now.ToString("yyyy-MM-dd"); // myRecordParas.TOC_DATE;
            cmdParameter[15].Value = DateTime.Now.ToString("HH:mm:ss"); //  myRecordParas.TOC_TIME;
            cmdParameter[16].Value = myRecordParas.MES_FLAG;



            try
            {
                using (SqlConnection con = SqlHelper.GetConnection())
                {
                    SqlHelper.ExecuteNonQuery(con, CommandType.Text, CommString, cmdParameter);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion


        #region 报警历史记录表 数据处理******************************************************
        public static string GetALMHistoryColString()
        {

            string[] colstring = new string[5];
            colstring[0] = "id 	int IDENTITY (1,1) PRIMARY KEY";
            colstring[1] = "ALMDescription		varchar(60)";
            colstring[2] = "ALMDateTime		datetime";
            colstring[3] = "ALMValue		int";
            colstring[4] = "ALMNote		varchar(100)";


            string colstr = "";
            for (int i = 0; i < 4; i++)
            {
                colstr = colstr + colstring[i] + ",";
            }
            colstr = colstr + colstring[4];
            return colstr;
        }

        /// <summary>
        /// 插入数据 OR  修改参数
        /// </summary>
        public static void InsertOrUpdateALMHistoryRecord(string tablename, ALMHistoryParas myRecordParas, bool IsInsert)
        {
            string CommString = GetCommString(tablename, ALMHistoryColStrs, 4, IsInsert);
            //cmdParameter  *********************************************************
            SqlParameter[] cmdParameter = {new SqlParameter("@ALMDescription", SqlDbType.VarChar),	//	Varchar(60)
                                            new SqlParameter("@ALMDateTime", SqlDbType.DateTime),	//	Datetime
                                            new SqlParameter("@ALMValue", SqlDbType.Int ),	//	int
                                            new SqlParameter("@ALMNote", SqlDbType.VarChar )};  //	varchar(100)


            cmdParameter[0].Value = myRecordParas.ALMDescription;
            cmdParameter[1].Value = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");// myRecordParas.ALMDateTime;
            cmdParameter[2].Value = myRecordParas.ALMValue;
            cmdParameter[3].Value = myRecordParas.ALMNote;

            try
            {
                using (SqlConnection con = SqlHelper.GetConnection())
                {
                    SqlHelper.ExecuteNonQuery(con, CommandType.Text, CommString, cmdParameter);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="person">要添加的用户</param>
        //public static void AddPerson(Person person)
        //{

        //    string insertString = "insert into T_Person(p_name,p_age) values(@name,@age)";

        //    SqlParameter[] cmdParameter = {
        //    new SqlParameter("@name", SqlDbType.VarChar),
        //    new SqlParameter("@age", SqlDbType.Int)
        //    };

        //    cmdParameter[0].Value = person.Name;
        //    cmdParameter[1].Value = person.Age;

        //    try
        //    {
        //        SqlHelper.ExecuteNonQuery(new SqlConnection(connString), CommandType.Text, insertString, cmdParameter);
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.ToString());
        //    }
        //}

        ///// <summary>
        ///// 通过用户ID删除用户
        ///// </summary>
        ///// <param name="id">要删除的用户的ID</param>
        //public static void DeletePersonByID(int id)
        //{

        //    string deleteString = "delete from T_Person where p_id = @id";

        //    SqlParameter[] cmdParameter = {
        //        new SqlParameter("@id", SqlDbType.Int)
        //    };

        //    cmdParameter[0].Value = id;

        //    try
        //    {
        //        SqlHelper.ExecuteNonQuery(new SqlConnection(connString), CommandType.Text, deleteString, cmdParameter);
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.ToString());
        //    }

        //}

        ///// <summary>
        ///// 更新用户
        ///// </summary>
        ///// <param name="person">要更新的用户</param>
        //public static void UpdatePerson(Person person)
        //{

        //    string updateString = "update T_Person set p_name = @name,p_age = @age where p_id = @id";

        //    SqlParameter[] sqlParameter = {
        //        new SqlParameter("@id",SqlDbType.Int),
        //        new SqlParameter("@name",SqlDbType.VarChar),
        //        new SqlParameter("@age", SqlDbType.Int)
        //    };

        //    sqlParameter[0].Value = person.Id; 
        //    sqlParameter[1].Value = person.Name;
        //    sqlParameter[2].Value = person.Age;

        //    try
        //    {
        //        SqlHelper.ExecuteNonQuery(new SqlConnection(connString), CommandType.Text, updateString, sqlParameter);
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.ToString());
        //    }
        //}

        ///// <summary>
        ///// 通过id取得用户
        ///// </summary>
        ///// <param name="id">要取得的用户的id</param>
        ///// <returns>取得的用户</returns>
        //public static Person GetPersonByID(int id)
        //{
        //    if (!PersonIsExistById(id))
        //    {
        //        return null;
        //    }

        //    Person person = new Person();

        //    string selectString = "select * from T_Person where p_id = @id";

        //    SqlParameter[] sqlPara = {
        //        new SqlParameter("@id",SqlDbType.Int)
        //    };

        //    sqlPara[0].Value = id;


        //    SqlDataReader dr = SqlHelper.ExecuteReader(connString, CommandType.Text, selectString, sqlPara);

        //    try
        //    {
        //        while (dr.Read())
        //        {
        //            person.Id = Convert.ToInt32(dr["p_id"]);
        //            person.Name = dr["p_name"].ToString();
        //            person.Age = Convert.ToInt32(dr["p_age"]);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.ToString());
        //        return null;
        //    }

        //    return person;


        //}

        ///// <summary>
        ///// 取得最大的id
        ///// </summary>
        ///// <returns>如果返回-1表示数据库中没有数据，否则返回的就是最大的id</returns>
        //public static int GetMaxPersonID()
        //{

        //    string selectString = "select max(p_id) as maxID from T_Person";

        //    object obj = null;

        //    obj = SqlHelper.ExecuteScalar(new SqlConnection(connString), CommandType.Text, selectString, null);

        //    if (!TableHasRecord())
        //    {
        //        return -1;
        //    }
        //    else
        //    {
        //        return Convert.ToInt32(obj);
        //    }
        //}

        ///// <summary>
        ///// 根据id判断用户是否存在
        ///// </summary>
        ///// <param name="id">要判断的用户的id</param>
        ///// <returns>返回true表示该用户存在，返回false表示该用户不存在</returns>
        //public static bool PersonIsExistById(int id)
        //{

        //    string selectString = "select * from T_Person where p_id = @id";

        //    SqlParameter[] sqlPara = {
        //        new SqlParameter("@id",SqlDbType.Int)
        //    };

        //    sqlPara[0].Value = id;

        //    SqlDataReader dr = SqlHelper.ExecuteReader(connString, CommandType.Text, selectString, sqlPara);

        //    while (dr.Read())
        //    {
        //        return true;
        //    }

        //    return false;
        //}

        ///// <summary>
        ///// 判断表中是否有数据
        ///// </summary>
        ///// <returns>返回true表示有数据，返回false表示没有数据</returns>
        //public static bool TableHasRecord()
        //{

        //    string selectString = "select * from T_Person";

        //    SqlDataReader dr = SqlHelper.ExecuteReader(connString, CommandType.Text, selectString, null);

        //    while (dr.Read())
        //    {
        //        return true;
        //    }

        //    return false;
        //}

        ///// <summary>
        ///// 取得所有用户
        ///// </summary>
        ///// <returns>所有用户的集合</returns>
        //public static List<Person> GetManyPersons()
        //{
        //    string selectString = "select * from T_Person";

        //    List<Person> lstPerson = new List<Person>();

        //    Person person = null;

        //    DataSet ds = SqlHelper.ExecuteDataSet(connString, CommandType.Text, selectString, null);

        //    if (ds.Tables[0].Rows.Count > 0)
        //    {
        //        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        //        {

        //            person = new Person();

        //            person.Id = Convert.ToInt32(ds.Tables[0].Rows[0]["p_id"].ToString());
        //            person.Name = ds.Tables[0].Rows[0]["p_name"].ToString();
        //            person.Age = Convert.ToInt32(ds.Tables[0].Rows[0]["p_age"].ToString());

        //            lstPerson.Add(person);
        //        }
        //    }

        //    return lstPerson;
        //}

        #region 数据库测试代码*****************************

        //MESInterface ALMHistory

        //this.dGViewExcel.Rows[index].Cells[1].Value = "2";
        //this.dGViewExcel.Rows[index].Cells[2].Value = "监听";

        //连接数据库
        //SqlConnection con = SqlHelper.GetConnection();
        //Console.WriteLine("数据库连接成功");

        //建立一张表
        //DataSet ds = SqlHelper.ExecuteDataset(con, CommandType.Text, "select* from student");


        //if (SQLDBMode.IsTableExist("student"))
        //{


        //}

        //else
        //{
        //    SqlHelper.ExecuteNonQuery(con, CommandType.Text, "create table DataList(id int primary key,filename varchar(40),age int)");
        //    Console.WriteLine("建表成功");
        //}



        ////插入数据
        //SqlHelper.ExecuteNonQuery(con, CommandType.Text, "insert into student values( ,'Ghazi',21)");
        //SqlHelper.ExecuteNonQuery(con, CommandType.Text, "insert into student values( ,'Jack',20)");
        //Console.WriteLine("数据插入成功");

        ////查询
        //ds = SqlHelper.ExecuteDataset(con, CommandType.Text, "select* from student");
        //foreach (DataRow col in ds.Tables[0].Rows)
        //{
        //    for (int i = 0; i < 3; i++)
        //    {
        //        Console.WriteLine(col[i].ToString());
        //    }
        //}

        ////修改
        //SqlHelper.ExecuteNonQuery(con, CommandType.Text, "update student set age=22 where id=2");
        //Console.WriteLine("数据修改成功");

        //DataSet ds1 = SqlHelper.ExecuteDataset(con, CommandType.Text, "select* from student");
        //foreach (DataRow col in ds1.Tables[0].Rows)
        //{
        //    for (int i = 0; i < 3; i++)
        //    {
        //        Console.WriteLine(col[i].ToString());
        //    }
        //}

        ////删除
        //SqlHelper.ExecuteNonQuery(con, CommandType.Text, "delete from student where id=2");
        //Console.WriteLine("数据删除成功");

        //DataSet ds2 = SqlHelper.ExecuteDataset(con, CommandType.Text, "select* from student");
        //foreach (DataRow col in ds2.Tables[0].Rows)
        //{
        //    for (int i = 0; i < 3; i++)
        //    {
        //        Console.WriteLine(col[i].ToString());
        //    }
        //}
        #endregion 数据库测试代码*****************************

    }
}
