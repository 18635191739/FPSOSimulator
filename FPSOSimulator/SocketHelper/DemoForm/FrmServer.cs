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
    public partial class FrmServer : FrmBase
    {
        //TCPServer server; 
        public FrmServer()
        {
            InitializeComponent();
            //掩耳盗铃线程控制UI控件
            CheckForIllegalCrossThreadCalls = false;
            //DelegateHelper.TcpServerErrorMsg = ErrorMsgData;
            ////DelegateHelper.TcpServerReceive = ReceviedData;
            //DelegateHelper.TcpServerStateInfo = StateInfoData;
            //DelegateHelper.ReturnClientCountCallBack = GetClientCount;
            //DelegateHelper.TcpServerAddClient = AddClient;
            //DelegateHelper.TcpServerDelClient = DelClient;


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
        public void ServerStart()
        {
            //server = new TCPServer(int.Parse(TxtPort.Text));
            //server.Start();
            axTcpServer1.ServerPort = int.Parse(TxtPort.Text);
            axTcpServer1.ServerIp = TxtIp.Text;
            axTcpServer1.Start();

            axTcpServer2.ServerPort = int.Parse(textBox2.Text);
            axTcpServer2.ServerIp = textBox3.Text;
            axTcpServer2.Start();

            axTcpServer3.ServerPort = int.Parse(textBox5.Text);
            axTcpServer3.ServerIp = textBox6.Text;
            axTcpServer3.Start();

            axTcpServer4.ServerPort = int.Parse(textBox8.Text);
            axTcpServer4.ServerIp = textBox9.Text;
            axTcpServer4.Start();

            //frmMain frmMainf = new frmMain();
            //frmMainf.CloseSeverNow += new ProductDefectServer.Forms.CloseFormSever(F_CloseSever1);
            //f.CloseSeverNow += F_CloseSever1;
        }

        

        public void F_CloseSever(bool isclose)
        {
            if (isclose)
            {
                axTcpServer1.Stop();
                axTcpServer2.Stop();
                axTcpServer3.Stop();
                axTcpServer4.Stop();
            }

            //throw new NotImplementedException();
        }

        private void BtnCon_Click(object sender, EventArgs e)
        {
            //ServerConnect();
        }

        private void GetClientCount(int count)
        {
            try
            {
                label5.Text = (string.Format("客户端数量：{0}", count));
            }
            catch
            {
            }
        }



        /// <summary>
        /// 接收数据
        /// </summary>
        /// <param name="temp"></param>
        /// <param name="dataBytes"></param>
        private void ReceviceByteData(Socket temp, byte[] dataBytes)
        {
            try
            {
                string msg = "";
                if (checkBox1.Checked)
                {
                    msg = IntegerOrString.HexByteArrayToString(dataBytes);
                }
                else
                {
                    msg = Encoding.Default.GetString(dataBytes);
                    GetStr(1, msg);
                }
                string ip = ((IPEndPoint)temp.RemoteEndPoint).Address.ToString();
                string port = ((IPEndPoint)temp.RemoteEndPoint).Port.ToString();
                if (MsgInfomationList.Items.Count > 10)
                {
                    MsgInfomationList.Items.Clear();
                }
                MsgInfomationList.Items.Add(string.Format("IP：{0}-端口：{1}=>{2}发来消息：{3}", ip, port, DateTime.Now.ToString("HH:mm:ss"), msg));
            }
            catch
            {
            }

        }

        
        /// <summary>
        /// 状态返回数据
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="state"></param>
        private void StateInfoData(string msg, SocketState state)
        {
            try
            {
                StateInfoList.Items.Add(string.Format("状态消息：{0}", msg));
           

                if (state == SocketState.ClientOnline)
                {
                    //frmMain.IsCamConnected[1] = 1;
                    label21.BackColor = Color.Lime;
                }
                else
                {
                    //frmMain.IsCamConnected[1] = 0;
                    label21.BackColor = Color.LightSlateGray;
                }
            
            }
            catch
            {
            }
        }
        /// <summary>
        /// 错误返回数据
        /// </summary>
        /// <param name="msg"></param>
        private void ErrorMsgData(string msg)
        {
            try
            {
                ErrorMsgList.Items.Add(string.Format("错误消息：{0}", msg));
            }
            catch
            {
            }
        }
        /// <summary>
        /// 客户端上线通知
        /// </summary>
        /// <param name="temp"></param>
        private void AddClient(Socket temp)
        {
            try
            {
                string ip = ((IPEndPoint)temp.RemoteEndPoint).Address.ToString();
                string port = ((IPEndPoint)temp.RemoteEndPoint).Port.ToString();
                ClientList.Items.Add(string.Format("{0}:{1}", ip, port));
            }
            catch
            {
            }
        }
        /// <summary>
        /// 客户端下线通知
        /// </summary>
        /// <param name="temp"></param>
        private void DelClient(Socket temp)
        {
            try
            {
                string ip = ((IPEndPoint)temp.RemoteEndPoint).Address.ToString();
                string port = ((IPEndPoint)temp.RemoteEndPoint).Port.ToString();
                ClientList.Items.Remove(string.Format("{0}:{1}", ip, port));
            }
            catch
            {
            }
        }

        /// <summary>
        /// 打开客户端
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            ThreadPool.QueueUserWorkItem(client =>
            {
                try
                {
                    //FrmClient frmClent = new FrmClient();
                    //frmClent.ShowDialog();
                }
                catch
                {
                }
            });
        }

        /// <summary>
        /// 关闭窗体是关闭监听
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmServer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (axTcpServer1 != null)
                axTcpServer1.Stop();
            //System.Environment.Exit(0);
        }

        /// <summary>
        /// 发送按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSend_Click(object sender, EventArgs e)
        {
            if (ClientList.SelectedItem != null)
            {
                try
                {
                    byte[] senddata;
                    ///axTcpServer1 *****************************************************************************
                    if (checkBox2.Checked)
                    {
                        senddata = IntegerOrString.StringToHexByteArray(TxtSendMsg.Text);
                    }
                    else
                    {
                        senddata = Encoding.Default.GetBytes(TxtSendMsg.Text);
                    }
                    string[] strArr = ClientList.Items[ClientList.SelectedIndex].ToString().Split(':');
                    axTcpServer1.SendData(strArr[0], int.Parse(strArr[1]), senddata);
                }
                catch
                {
                }
            }
        }

        private void FrmServer_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            //frmMain f = new frmMain();
            //f.CloseSever += F_CloseSever;
            //axTcpServer1.Stop();
            //F_CloseSever();
        }



        private void BtnMsgclear_Click(object sender, EventArgs e)
        {
            MsgInfomationList.Items.Clear();
        }

        private void BtnStateinfoclear_Click(object sender, EventArgs e)
        {
            StateInfoList.Items.Clear();
        }

        private void BtnErrorclear_Click(object sender, EventArgs e)
        {
            ErrorMsgList.Items.Clear();
        }

        private void FrmServer_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// axTcpServer2
        /// </summary>
        /// <param name="msg"></param>
        private void axTcpServer2_OnErrorMsg(string msg)
        {
            try
            {
                listBox1.Items.Add(string.Format("错误消息：{0}", msg));
            }
            catch
            {
            }
        }

        private void axTcpServer2_OnOfflineClient(Socket temp)
        {
            try
            {
                string ip = ((IPEndPoint)temp.RemoteEndPoint).Address.ToString();
                string port = ((IPEndPoint)temp.RemoteEndPoint).Port.ToString();
                listBox2.Items.Remove(string.Format("{0}:{1}", ip, port));
            }
            catch
            {
            }
        }

        private void axTcpServer2_OnOnlineClient(Socket temp)
        {
            try
            {
                string ip = ((IPEndPoint)temp.RemoteEndPoint).Address.ToString();
                string port = ((IPEndPoint)temp.RemoteEndPoint).Port.ToString();
                listBox2.Items.Add(string.Format("{0}:{1}", ip, port));
            }
            catch
            {
            }
        }

        private void axTcpServer2_OnReceviceByte(Socket temp, byte[] dataBytes)
        {
            try
            {
                string msg = "";
                if (checkBox4.Checked)
                {
                    msg = IntegerOrString.HexByteArrayToString(dataBytes);
                }
                else
                {
                    msg = Encoding.Default.GetString(dataBytes);
                    GetStr(2, msg);
                }
                string ip = ((IPEndPoint)temp.RemoteEndPoint).Address.ToString();
                string port = ((IPEndPoint)temp.RemoteEndPoint).Port.ToString();
                if (listBox4.Items.Count > 10)
                {
                    listBox4.Items.Clear();
                }
                listBox4.Items.Add(string.Format("IP：{0}-端口：{1}=>{2}发来消息：{3}", ip, port, DateTime.Now.ToString("HH:mm:ss"), msg));
            }
            catch
            {
            }
        }

        private void axTcpServer2_OnReturnClientCount(int count)
        {
            try
            {
                label7.Text = (string.Format("客户端数量：{0}", count));
            }
            catch
            {
            }
        }

        private void axTcpServer2_OnStateInfo(string msg, SocketState state)
        {
            try
            {
                listBox3.Items.Add(string.Format("状态消息：{0}", msg));

                if (state == SocketState.ClientOnline)
                {
                    //frmMain.IsCamConnected[2] = 1;
                    label22.BackColor = Color.Lime;
                }
                else
                {
                    //frmMain.IsCamConnected[2] = 0;
                    label22.BackColor = Color.LightSlateGray;
                }
            }
            catch
            {
            }
        }

        /// <summary>
        /// axTcpServer3
        /// </summary>
        /// <param name="msg"></param>
        private void axTcpServer3_OnErrorMsg(string msg)
        {
            try
            {
                listBox5.Items.Add(string.Format("错误消息：{0}", msg));
            }
            catch
            {
            }
        }

        private void axTcpServer3_OnOfflineClient(Socket temp)
        {
            try
            {
                string ip = ((IPEndPoint)temp.RemoteEndPoint).Address.ToString();
                string port = ((IPEndPoint)temp.RemoteEndPoint).Port.ToString();
                listBox6.Items.Remove(string.Format("{0}:{1}", ip, port));
            }
            catch
            {
            }
        }

        private void axTcpServer3_OnOnlineClient(Socket temp)
        {
            try
            {
                string ip = ((IPEndPoint)temp.RemoteEndPoint).Address.ToString();
                string port = ((IPEndPoint)temp.RemoteEndPoint).Port.ToString();
                listBox6.Items.Add(string.Format("{0}:{1}", ip, port));
            }
            catch
            {
            }
        }

        private void axTcpServer3_OnReceviceByte(Socket temp, byte[] dataBytes)
        {
            try
            {
                string msg = "";
                if (checkBox6.Checked)
                {
                    msg = IntegerOrString.HexByteArrayToString(dataBytes);
                }
                else
                {
                    msg = Encoding.Default.GetString(dataBytes);
                    GetStr(3, msg);
                }
                string ip = ((IPEndPoint)temp.RemoteEndPoint).Address.ToString();
                string port = ((IPEndPoint)temp.RemoteEndPoint).Port.ToString();
                if (listBox8.Items.Count > 10)
                {
                    listBox8.Items.Clear();
                }
                listBox8.Items.Add(string.Format("IP：{0}-端口：{1}=>{2}发来消息：{3}", ip, port, DateTime.Now.ToString("HH:mm:ss"), msg));
            }
            catch
            {
            }
        }

        private void axTcpServer3_OnReturnClientCount(int count)
        {
            try
            {
                label12.Text = (string.Format("客户端数量：{0}", count));
            }
            catch
            {
            }
        }

        private void axTcpServer3_OnStateInfo(string msg, SocketState state)
        {
            try
            {
                listBox7.Items.Add(string.Format("状态消息：{0}", msg));
                if (state == SocketState.ClientOnline)
                {
                    //frmMain.IsCamConnected[3] = 1;
                    label23.BackColor = Color.Lime;
                }
                else
                {
                    //frmMain.IsCamConnected[3] = 0;
                    label23.BackColor = Color.LightSlateGray;
                }
            }
            catch
            {
            }
        }

        /// <summary>
        /// axTcpServer4
        /// </summary>
        /// <param name="msg"></param>
        private void axTcpServer4_OnErrorMsg(string msg)
        {
            try
            {
                listBox9.Items.Add(string.Format("错误消息：{0}", msg));
            }
            catch
            {
            }
        }

        private void axTcpServer4_OnOfflineClient(Socket temp)
        {
            try
            {
                string ip = ((IPEndPoint)temp.RemoteEndPoint).Address.ToString();
                string port = ((IPEndPoint)temp.RemoteEndPoint).Port.ToString();
                listBox10.Items.Remove(string.Format("{0}:{1}", ip, port));
            }
            catch
            {
            }
        }

        private void axTcpServer4_OnOnlineClient(Socket temp)
        {
            try
            {
                string ip = ((IPEndPoint)temp.RemoteEndPoint).Address.ToString();
                string port = ((IPEndPoint)temp.RemoteEndPoint).Port.ToString();
                listBox10.Items.Add(string.Format("{0}:{1}", ip, port));
            }
            catch
            {
            }
        }


        private void axTcpServer4_OnReceviceByte(Socket temp, byte[] dataBytes)
        {
            try
            {
                string msg = "";
                if (checkBox6.Checked)
                {
                    msg = IntegerOrString.HexByteArrayToString(dataBytes);
                }
                else
                {
                    msg = Encoding.Default.GetString(dataBytes);
                    GetStr(4, msg);
                }
                string ip = ((IPEndPoint)temp.RemoteEndPoint).Address.ToString();
                string port = ((IPEndPoint)temp.RemoteEndPoint).Port.ToString();
                if (listBox12.Items.Count > 10)
                {
                    listBox12.Items.Clear();
                }
                listBox12.Items.Add(string.Format("IP：{0}-端口：{1}=>{2}发来消息：{3}", ip, port, DateTime.Now.ToString("HH:mm:ss"), msg));
            }
            catch
            {
            }
        }


        private void axTcpServer4_OnReturnClientCount(int count)
        {
            try
            {
                label17.Text = (string.Format("客户端数量：{0}", count));
            }
            catch
            {
            }
        }


        private void axTcpServer4_OnStateInfo(string msg, SocketState state)
        {
            try
            {
                listBox11.Items.Add(string.Format("状态消息：{0}", msg));
                if (state == SocketState.ClientOnline)
                {
                    //frmMain.IsCamConnected[4] = 1;
                    label24.BackColor = Color.Lime;
                }
                else
                {
                    //frmMain.IsCamConnected[4] = 0;
                    label24.BackColor = Color.LightSlateGray;
                }
            }
            catch
            {
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //frmMain myfrmMain = new frmMain();
            //bool isexit = ProductDefectServer.Forms.frmMain.IsExitNow();
            //if (isexit)
            //{
            //    F_CloseSever(isexit);
            //    timer1.Enabled = false;
            //    return;
            //}
            for (int i = 1; i < 5; i++)
            {
                if (defect_msg_ready[i])
                {
                    //FPSOSimulator.Forms.frmMain.DecodeMsg(i, defect_msg[i]);
                    defect_msg_ready[i] = false;
                    defect_msg[i] = "";
                    //ProductDefectServer.Forms.frmMain.ProductInfoReady = true;
                }
            }

            //textBox11.Text = REVSTR;
        }

        /// <summary>
        /// 数据包拼接
        /// </summary>
        public static string[] defect_msg = new string[5] { "", "", "", "", "" };
        public static bool[] defect_msg_start = new bool[5] { false, false, false, false, false };
        public static bool[] defect_msg_ready = new bool[5] { false, false, false, false, false };
        public static string[] defect_msg_last = new string[5] { "", "", "", "", "" };
        public static String REVSTR = "";
        public static string GetStr(int idx, string msgStr)
        {
            if (idx == 1)
            {
                 REVSTR = REVSTR + msgStr;
                
            }
            
            msgStr = defect_msg_last[idx] + msgStr;
            string[] sArray = msgStr.Split(';');
            int startidx = 0;
            int sArray_len = sArray.Length;
            foreach (string StartFlag in sArray)
            {

                if (StartFlag == "START")
                {
                    if (startidx != 0)
                    {
                        msgStr = "";
                        for (int i = startidx; i < sArray_len; i++)
                        {
                            msgStr = msgStr + sArray[i] + ";";
                        }
                    }

                    defect_msg_start[idx] = true;
                    break;
                }
                startidx = startidx + 1;
            }

            if (defect_msg_start[idx])
            {
                defect_msg[idx] = defect_msg[idx] + msgStr;
            }

            int endidx = 0;
            foreach (string EndFlag in sArray)
            {
                if (EndFlag == "END" && defect_msg_start[idx] == true)
                {
                    defect_msg_start[idx] = false;
                    defect_msg_ready[idx] = true;
                    if (endidx <= (sArray_len - 1) && endidx > (startidx - 1))
                    {
                        for (int i = endidx + 1; i < sArray_len; i++)
                        {
                            defect_msg_last[idx] = defect_msg_last[idx] + sArray[i] + ";";
                        }

                    }
                    else
                    {
                        defect_msg_last[idx] = "";
                    }
                    break;
                }
                endidx = endidx + 1;
            }


            return defect_msg[idx];
        }

    }
}
