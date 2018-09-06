using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using FPSOSimulator;
using FPSOSimulator.Forms;

namespace FPSOSimulator
{
    public partial class FrmClient : FrmBase
    {

        public FrmClient()
        {
            InitializeComponent();
            //掩耳盗铃线程控制UI控件
            CheckForIllegalCrossThreadCalls = false;

            FrmInit();
            //获取本机IP
            //TxtIp.Text = Dns.GetHostByName(Dns.GetHostName()).AddressList[0].ToString();
        }



        public override void FrmInit()
        {
            ClientStart();
        }

        public override void FrmRefresh()
        {
            //time in the panel
            DateTime current = DateTime.Now;

            //top time
            lblDate.Text = string.Format("{0:yyyy-MM-dd dddd tt hh:mm:ss}", current);




        }




        /// <summary>
        /// 显示窗体，并添加刷新委托
        /// </summary>
        public override void FrmShow()
        {
            Program.myFrmFresh.DelegateAdd(this.FrmRefresh);
            this.Show();
        }

        /// <summary>
        /// 关闭窗体
        /// </summary>
        public override void FrmClose()
        {

            Program.myFrmFresh.DelegateRemove(this.FrmRefresh);
            F_CloseClient();
            this.Close();
        }

        /// <summary>
        /// 隐藏窗体，并去掉刷新委托
        /// </summary>
        public override void FrmHide()
        {
            Program.myFrmFresh.DelegateRemove(this.FrmRefresh);
            this.Hide();
        }

        /// <summary>
        /// Timer for refresh the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            Program.myFrmFresh.ExecFrmFresh();


        }


        //public void F_CloseClient(bool isclose)
        //{
        //    if (isclose)
        //    {
        //        axTcpClient1.StopConnection();
        //        axTcpClient2.StopConnection();
        //        axTcpClient3.StopConnection();
        //        axTcpClient4.StopConnection();
        //    }

        //    //throw new NotImplementedException();
        //}

        /// <summary>
        /// 初始化并连接TCPClient
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnConClick(object sender, EventArgs e)
        {

        }


        internal void ClientStart()
        {

            axTcpClient1.ServerIp = TxtIp.Text;
            axTcpClient1.ServerPort = int.Parse(TxtPort.Text);
            axTcpClient1.StartConnection();

            axTcpClient2.ServerIp = textBox3.Text;
            axTcpClient2.ServerPort = int.Parse(textBox2.Text);
            axTcpClient2.StartConnection();

            //axTcpClient3.ServerIp = textBox6.Text;
            //axTcpClient3.ServerPort = int.Parse(textBox5.Text);
            //axTcpClient3.StartConnection();

            //axTcpClient4.ServerIp = textBox9.Text;
            //axTcpClient4.ServerPort = int.Parse(textBox8.Text);
            //axTcpClient4.StartConnection();
            //throw new NotImplementedException();
        }

        public void F_CloseClient()
        {
            axTcpClient1.StopConnection();
            axTcpClient2.StopConnection();
            //axTcpClient3.StopConnection();
            //axTcpClient4.StopConnection();
            //throw new NotImplementedException();
        }

        /// <summary>
        /// 关闭连接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCloseTcpClientClick(object sender, EventArgs e)
        {
            //axTcpClient1.StopConnection();
            //axTcpClient2.StopConnection();
            //axTcpClient3.StopConnection();
            //axTcpClient4.StopConnection();
        }
        /// <summary>
        /// 接收数据
        /// </summary>
        /// <param name="date"></param>
        private void axTcpClient1_OnReceviceByte(byte[] date)
        {
            try
            {
                string msg = "";
                if (checkBox1.Checked)
                {
                    //以十六进制格式显示数据
                    msg = IntegerOrString.HexByteArrayToString(date);
                }
                else
                {
                    ////以文本转ASCIIEncoding转码形式显示数据
                    msg = Encoding.Default.GetString(date);
                    GetStr(1, msg);
                }
                if (MsgInfomationList.Items.Count > 50)
                    MsgInfomationList.Items.Clear();
                //自定义处理接收Socket数据
                MsgInfomationList.Items.Add(msg);
            }
            catch
            {

            }
        }

        private void axTcpClient2_OnReceviceByte(byte[] date)
        {
            try
            {
                string msg = "";
                if (checkBox4.Checked)
                {
                    //以十六进制格式显示数据
                    msg = IntegerOrString.HexByteArrayToString(date);
                }
                else
                {
                    ////以文本转ASCIIEncoding转码形式显示数据
                    msg = Encoding.Default.GetString(date);
                    GetStr(2, msg);
                }
                if (listBox3.Items.Count > 10)
                    listBox3.Items.Clear();
                //自定义处理接收Socket数据
                listBox3.Items.Add(msg);
            }
            catch
            {

            }
        }

        private void axTcpClient3_OnReceviceByte(byte[] date)
        {
            try
            {
                string msg = "";
                if (checkBox6.Checked)
                {
                    //以十六进制格式显示数据
                    msg = IntegerOrString.HexByteArrayToString(date);
                }
                else
                {
                    ////以文本转ASCIIEncoding转码形式显示数据
                    msg = Encoding.Default.GetString(date);
                    GetStr(3, msg);
                }
                if (listBox6.Items.Count > 10)
                    listBox6.Items.Clear();
                //自定义处理接收Socket数据
                listBox6.Items.Add(msg);
            }
            catch
            {

            }
        }

        private void axTcpClient4_OnReceviceByte(byte[] date)
        {
            try
            {
                string msg = "";
                if (checkBox8.Checked)
                {
                    //以十六进制格式显示数据
                    msg = IntegerOrString.HexByteArrayToString(date);
                }
                else
                {
                    ////以文本转ASCIIEncoding转码形式显示数据
                    msg = Encoding.Default.GetString(date);

                    GetStr(4, msg);
                }
                if (listBox9.Items.Count > 10)
                    listBox9.Items.Clear();
                //自定义处理接收Socket数据
                listBox9.Items.Add(msg);
            }
            catch
            {

            }
        }
        ////public string[] infovalue = new string[150];
        ////public string[] infoname = new string[150];
        //public static string defect_msg1 = "";
        //public static bool defect_msg1_start = false;
        //public static bool defect_msg1_ready = false;
        //public static string defect_msg1_last = "";
        //public string GetStr_1(string msgStr)
        //{
        //    msgStr = defect_msg1_last + msgStr ;
        //    string[] sArray = msgStr.Split(';');
        //    int startidx = 0;
        //    int sArray_len = sArray.Length;
        //    foreach (string StartFlag in sArray)
        //    {

        //        if (StartFlag == "START")
        //        {
        //            if (startidx != 0)
        //            {
        //                msgStr = "";
        //                for (int i = startidx; i < sArray_len; i++)
        //                {
        //                    msgStr = msgStr + sArray[i] + ";";
        //                }
        //            }

        //            defect_msg1_start = true;
        //            break;
        //        }
        //        startidx = startidx + 1;
        //    }

        //    if (defect_msg1_start)
        //    {
        //        defect_msg1 = defect_msg1 + msgStr;
        //    }

        //    int endidx = 0;
        //    foreach (string EndFlag in sArray)
        //    {
        //        if (EndFlag == "END" && defect_msg1_start == true)
        //        {
        //            defect_msg1_start = false;
        //            defect_msg1_ready = true;
        //            if (endidx <= (sArray_len - 1) && endidx > (startidx - 1))
        //            {
        //                for (int i = endidx + 1; i < sArray_len; i++)
        //                {
        //                    defect_msg1_last = defect_msg1_last + sArray[i] + ";";
        //                }

        //            }
        //            else
        //            {
        //                defect_msg1_last = "";
        //            }
        //            break;
        //        }
        //        endidx = endidx + 1;
        //    }
        //    ///判断数据包是否完整
        //    /// 时间判断原则 包头 包尾 时间戳


        //    return defect_msg1;
        //}
        //public void DecodeMsg(int idx,string msgStr)
        //{
        //    //string str = "abcdefghigkceofuecto";

        //    string[] sArray = msgStr.Split(';');
        //    int mylen = sArray.Length;
        //    string[] infovalue = new string[152];
        //    string[] infoname = new string[152];
        //    string[] name_val = new string[3];
        //    //foreach (string i in sArray)
        //    for (int i = 1; i < mylen - 2; i++)
        //    {
        //        name_val = sArray[i].Split('=');
        //        infoname[i] = name_val[0];
        //        infovalue[i] = name_val[1];
        //    }

        //    SQLDBMode.DefectInfoParas myRecordParas = new SQLDBMode.DefectInfoParas();
        //    frmMain.ProductInfo[idx].OUT_ID = "456";
        //    frmMain.ProductInfo[idx].LNKNUM = int.Parse(infovalue[1]);
        //    frmMain.ProductInfo[idx].LNKCOMP = int.Parse(infovalue[2]);
        //    frmMain.ProductInfo[idx].LNKDATETIME = infovalue[3];
        //    frmMain.ProductInfo[idx].LNKOPER = infovalue[4];
        //    frmMain.ProductInfo[idx].LNKSHIFT = infovalue[5];
        //    frmMain.ProductInfo[idx].LNKRESULT = int.Parse(infovalue[6]);
        //    frmMain.ProductInfo[idx].LNKTOTAL = int.Parse(infovalue[7]);

        //    for (int i = 0; i < 20; i++)
        //    {
        //        frmMain.ProductInfo[idx].FAULTTYPE[i] = infovalue[8 + i * 7];
        //        frmMain.ProductInfo[idx].FAULTNAME[i] = infovalue[9 + i * 7];
        //        frmMain.ProductInfo[idx].FAULTPOSX[i] = int.Parse(infovalue[10 + i * 7]);
        //        frmMain.ProductInfo[idx].FAULTPOSY[i] = int.Parse(infovalue[11 + i * 7]);
        //        frmMain.ProductInfo[idx].FAULTWIDTH[i] = int.Parse(infovalue[12 + i * 7]);
        //        frmMain.ProductInfo[idx].FAULTHEIGHT[i] = int.Parse(infovalue[13 + i * 7]);
        //        frmMain.ProductInfo[idx].FAULTFILENAME[i] = infovalue[14 + i * 7];
        //    }

        //    frmMain.ProductInfo[idx].TOC_DATE = infovalue[148];
        //    frmMain.ProductInfo[idx].TOC_TIME = infovalue[149];
        //    frmMain.ProductInfo[idx].TOC_FLAG = int.Parse(infovalue[150]);
        //    frmMain.ProductInfo[idx].MES_FLAG = int.Parse(infovalue[151]);

        //    SQLDBMode.InsertDefectInfoRecord("mytest", frmMain.ProductInfo[idx]);

        //    //Response.Write( + "</br>");
        //}


        //On Error Resume Next
        //' This procedure is used for decoding
        //   Dim i As Long
        //   PPTItems = 0

        //   For i = 1 To Len(GotString)
        //       If Mid(GotString, i, 1) = ";" Then
        //          PPTItems = PPTItems + 1
        //          ReDim Preserve SemiPos(PPTItems) As Long
        //          SemiPos(PPTItems) = i
        //       End If
        //   Next i

        //   ReDim PPTItem(PPTItems) As String
        //   ReDim PPTName(PPTItems) As String
        //   ReDim PPTValue(PPTItems) As Variant

        //   For i = 1 To PPTItems
        //       StartPos = SemiPos(i - 1) + 1
        //       LenStr = SemiPos(i) - SemiPos(i - 1) - 1
        //       PPTItem(i) = Mid(GotString, StartPos, LenStr)
        //       EqualPos = InStr(PPTItem(i), "=")
        //       If EqualPos<> 0 And EqualPos <> LenStr Then
        //         PPTName(i) = Mid(PPTItem(i), 1, EqualPos - 1)
        //         PPTValue(i) = Mid(PPTItem(i), EqualPos + 1)
        //       End If
        //   Next i
        //  ' AssignValues       'Call procedure to assign values to relative variables

        //End Sub



        /// <summary>
        /// 接收状态数据
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="state">状态码</param>
        private void StateInfoCallBack(string msg, SocketState state)
        {
            try
            {
                if (StateInfoList.Items.Count > 50)
                    StateInfoList.Items.Clear();
                //自定义处理状态数据
                StateInfoList.Items.Add(msg);

                if (state == SocketState.Connected)
                {
                    //frmMain.IsCamConnected[1] = 1;
                    //frmMain.IsCamConnected[2] = 1;
                    label24.BackColor = Color.Lime;
                }
                else
                {
                    //frmMain.IsCamConnected[1] = 0;
                    //frmMain.IsCamConnected[2] = 0;
                    label24.BackColor = Color.LightSlateGray;
                }

            }
            catch
            {

            }
        }

        private void axTcpClient2_OnStateInfo(string msg, SocketState state)
        {
            try
            {
                if (listBox2.Items.Count > 50)
                    listBox2.Items.Clear();
                //自定义处理状态数据
                listBox2.Items.Add(msg);
                if (state == SocketState.Connected)
                {
                    //frmMain.IsCamConnected[3] = 1;
                    //frmMain.IsCamConnected[4] = 1;
                    label25.BackColor = Color.Lime;
                }
                else
                {
                    //frmMain.IsCamConnected[3] = 0;
                    //frmMain.IsCamConnected[4] = 0;
                    label25.BackColor = Color.LightSlateGray;
                }



            }
            catch
            {

            }
        }


        private void axTcpClient3_OnStateInfo(string msg, SocketState state)
        {
            try
            {
                if (listBox5.Items.Count > 50)
                    listBox5.Items.Clear();
                //自定义处理状态数据
                listBox5.Items.Add(msg);

            }
            catch
            {

            }
        }

        private void axTcpClient4_OnStateInfo(string msg, SocketState state)
        {
            try
            {
                if (listBox8.Items.Count > 50)
                    listBox8.Items.Clear();
                //自定义处理状态数据
                listBox8.Items.Add(msg);

                //if (state == SocketState.Connected)
                //{
                //    frmMain.IsCamConnected[4] = 1;
                //    label27.BackColor = Color.Lime;
                //}
                //else
                //{
                //    frmMain.IsCamConnected[1] = 0;
                //    label27.BackColor = Color.LightSlateGray;
                //}

            }
            catch
            {

            }
        }

        /// <summary>
        /// 接收错误数据
        /// </summary>
        /// <param name="msg"></param>
        private void ErrorMsgCallBack(string msg)
        {
            try
            {
                if (ErrorMsgList.Items.Count > 50)
                    ErrorMsgList.Items.Clear();
                //自定义处理错误数据
                ErrorMsgList.Items.Add(msg);
            }
            catch
            {
            }
        }

        private void axTcpClient2_OnErrorMsg(string msg)
        {
            try
            {
                if (listBox1.Items.Count > 50)
                    listBox1.Items.Clear();
                //自定义处理错误数据
                listBox1.Items.Add(msg);
            }
            catch
            {
            }
        }

        private void axTcpClient3_OnErrorMsg(string msg)
        {
            try
            {
                if (listBox4.Items.Count > 50)
                    listBox4.Items.Clear();
                //自定义处理错误数据
                listBox4.Items.Add(msg);
            }
            catch
            {
            }
        }

        private void axTcpClient4_OnErrorMsg(string msg)
        {
            try
            {
                if (listBox7.Items.Count > 50)
                    listBox7.Items.Clear();
                //自定义处理错误数据
                listBox7.Items.Add(msg);
            }
            catch
            {
            }
        }


        /// <summary>
        /// 发送Socket数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSendClick(object sender, EventArgs e)
        {
            try
            {
                string sendmsg = TxtSendMsg.Text;
                byte[] sendByte;
                if (checkBox2.Checked)
                {
                    //以十六进制字符串发送
                    sendByte = IntegerOrString.StringToHexByteArray(sendmsg);
                }
                else
                {
                    //以ASCIIEncoding转码形式发送
                    sendByte = Encoding.Default.GetBytes(sendmsg);
                }
                axTcpClient1.SendCommand(sendByte);
            }
            catch
            {
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string sendmsg = textBox1.Text;
                byte[] sendByte;
                if (checkBox2.Checked)
                {
                    //以十六进制字符串发送
                    sendByte = IntegerOrString.StringToHexByteArray(sendmsg);
                }
                else
                {
                    //以ASCIIEncoding转码形式发送
                    sendByte = Encoding.Default.GetBytes(sendmsg);
                }
                axTcpClient1.SendCommand(sendByte);
            }
            catch
            {
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                string sendmsg = textBox4.Text;
                byte[] sendByte;
                if (checkBox2.Checked)
                {
                    //以十六进制字符串发送
                    sendByte = IntegerOrString.StringToHexByteArray(sendmsg);
                }
                else
                {
                    //以ASCIIEncoding转码形式发送
                    sendByte = Encoding.Default.GetBytes(sendmsg);
                }
                axTcpClient1.SendCommand(sendByte);
            }
            catch
            {
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                string sendmsg = textBox7.Text;
                byte[] sendByte;
                if (checkBox2.Checked)
                {
                    //以十六进制字符串发送
                    sendByte = IntegerOrString.StringToHexByteArray(sendmsg);
                }
                else
                {
                    //以ASCIIEncoding转码形式发送
                    sendByte = Encoding.Default.GetBytes(sendmsg);
                }
                axTcpClient1.SendCommand(sendByte);
            }
            catch
            {
            }
        }


        /// <summary>
        /// 窗体关闭时关闭连接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Enabled = false;
            BtnCloseTcpClientClick(null, null);
            //F_CloseClient(true);
        }


        //禁用窗体的关闭按钮 
        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }


        private void FrmClient_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 数据包拼接
        /// </summary>
        //public static string[,] defect_msg= new string[2,10]; //{ "", "", "", "", "" };
        public static string[] defect_msg = new string[5] { "", "", "", "", "" };
        //public static string[] defect_msg_2 = new string[100];
        public static bool[] defect_msg_start = new bool[5] { false, false, false, false, false };
        public static bool[] defect_msg_ready = new bool[5] { false, false, false, false, false };
        public static bool[] cam_msg_ready = new bool[5] { false, false, false, false, false };
        public static string[] cam_msg = new string[5] { "", "", "", "", "" };
        //public static bool defect_msg_ready_n =false ;
        //public static bool defect_msg_start_n = false;
        public static string[] defect_msg_last = new string[5] { "", "", "", "", "" };
        public static String REVSTR = "";
        public string GetStr(int idx, string msgStr)
        {

            //string msgStr = msgStr_1.Replace(" ", "");
            msgStr = defect_msg_last[idx] + msgStr;
            string[] sArray = msgStr.Split(';');
            int startidx = 0;
            int sArray_len = sArray.Length;
            foreach (string StartFlag in sArray)
            {

                if (StartFlag == "START")
                {
                    //if (startidx != 0)
                    //{
                    //    msgStr = "";
                    //    for (int i = startidx; i < sArray_len; i++)
                    //    {
                    //        msgStr = msgStr + sArray[i] + ";";
                    //    }
                    //}

                    defect_msg_start[idx] = true;
                    break;
                }
                startidx = startidx + 1;
            }

            //if (defect_msg_start[idx])
            //{
            //    defect_msg[idx] = defect_msg[idx] + msgStr;
            //}
            defect_msg_last[idx] = "";
            defect_msg_last[idx] = msgStr;
            int endidx = 0;
            foreach (string EndFlag in sArray)
            {
                if (EndFlag == "END" && defect_msg_start[idx] == true)
                {


                    defect_msg_start[idx] = false;
                    defect_msg_ready[idx] = true;
                    defect_msg_ready[idx] = false;
                    //defect_msg[idx] = "";
                    //ProductDefectServer.Forms.frmMain.DecodeMsg(idx, defect_msg[idx]);
                    //defect_msg_ready[idx] = false;
                    //defect_msg[idx] = "";

                    string sendstr = "";
                    for (int i = 0; i < endidx + 1; i++)
                    {
                        sendstr = sendstr + sArray[i] + ";";
                    }
                    string[] sArray_1 = sendstr.Split(';');

                    defect_msg_last[idx] = "";

                    if (endidx <= (sArray_len - 1))
                    {



                        for (int i = endidx + 1; i < sArray_len; i++)
                        {

                            if (i < sArray_len - 1)
                            {
                                defect_msg_last[idx] = defect_msg_last[idx] + sArray[i] + ";";
                            }
                            else
                            {
                                if (sArray[sArray_len - 1] != "")
                                {
                                    defect_msg_last[idx] = defect_msg_last[idx] + sArray[i];
                                }

                            }

                            if (sArray[i] == "END")
                            {
                                if (sArray[endidx + 1] == "START")
                                {
                                    string[] sArray_3 = sArray[endidx + 2].Split('=');
                                    int mynum1 = int.Parse(sArray_3[1]);
                                    cam_msg_ready[mynum1] = true;
                                    cam_msg[mynum1] = defect_msg_last[idx];// defect_msg[idx];
                                    defect_msg_last[idx] = "";
                                }


                            }

                        }

                    }



                    string[] sArray_2 = sArray_1[1].Split('=');
                    int mynum = int.Parse(sArray_2[1]);
                    cam_msg_ready[mynum] = true;
                    cam_msg[mynum] = sendstr;// defect_msg[idx];
                    //if (mynum == 1)
                    //{
                    //    textBox10.Text = cam_msg[mynum];
                    //}
                    //if (mynum == 2)
                    //{
                    //    textBox11.Text = cam_msg[mynum];
                    //}




                    defect_msg[idx] = "";
                    break;
                }
                endidx = endidx + 1;
            }


            return defect_msg[idx];
        }

        private void timer2_Tick(object sender, EventArgs e)
        {


        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            for (int i = 1; i < 5; i++)
            {
                if (cam_msg_ready[i])
                {
                    //FPSOSimulator.Forms.frmMain.DecodeMsg(i, cam_msg[i]);
                    cam_msg_ready[i] = false;
                    cam_msg[i] = "";
                    //ProductDefectServer.Forms.frmMain.ProductInfoReady = true;
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Program.myFrmFresh.SetFrmType(FrmFresh.FrmTypes.frmMain);
        }
    }

}
