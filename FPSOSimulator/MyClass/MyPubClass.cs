using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPSOSimulator.MyClass
{
    public class MyPubClass
    {

        public class DefectImgInfo
        {
            public string OUT_ID;
            public int LNKNUM;
            public int LNKCOMP;
            public string LNKDATETIME;
            public string LNKOPER;
            public string LNKSHIFT;
            public string FAULTTYPE;
            public string FAULTNAME;
            public string FileAimPath;
            public int FileIsSaved;
            public int FAULTPOSX;
            public int FAULTPOSY;
            public int FAULTWIDTH;
            public int FAULTHEIGHT;
            public string FAULTFILENAME;
            public bool IsGet;
            public int IsFusion;
            public int IsMainPic;

        }

        public class DefectDataGridInfo
        {
            public string OUT_ID; //工件ID
            public string IsIntegrity;
            public string DEF_RESULT; //判定结果
            public string DEF_NUM; //缺陷图片总数
            public string LNKDATETIME;//生产日期时间
            public string LNKOPER;//操作员工号
            public string LNKSHIFT;//操作员班组信息
        }

        public class Info_PLC
        {

            public string Substrate_Out_ID; //离开检测机产品ID
            public string ID_RD_FLG;//服务器读取ID标志
            public string Substrate_Out_Timestamp; //产品离开检测机时间点
            public string Substrate_Out_Result; //离开检测机时的产品状态
            public string SEMI_Status; //检测设备状态
            public string Current_User; //正在登陆的用户
            public string Current_Timestamp; //实时时间点
            public string Lifebit; // Ping信号 （生活信号）
            public string Alarm_Detected_ID; //设备报警发生的报警 ID
            public string Alarm_Detected_Text; //设备报警发生的报警描述
            public string Alarm_Detected_Timestamp; //设备报警的发生时间
            public string Alarm_Cleared_ID; //设备报警处理的报警 ID
            public string Alarm_Cleared_Text; //设备报警处理的报警描述
            public string Alarm_Cleared_Timestamp; //设备报警的处理时间
            public string Handshake; //握手信号

            //public string Substrate_Out_ID;
            //public string ID_RD_FLG;
            //public string Substrate_Out_Timestamp;
            //public string Substrate_Out_Result;
            //public string SEMI_Status;
            //public string Current_User;
            //public string Current_Timestamp;
            //public string Lifebit;
            //public string Alarm_Detected_ID;
            //public string Alarm_Detected_Text;
            //public string Alarm_Detected_Timestamp;
            //public string Alarm_Cleared_ID;
            //public string Alarm_Cleared_Text;
            //public string Alarm_Cleared_Timestamp;
            //public string Handshake;

        }

       
    }
}
