using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Diagnostics;
using Microsoft.Office.Interop.Excel;
using System.Data.OleDb;
using ADOX;
using System.Data.SqlClient;

namespace FPSOSimulator.Forms
{
    public partial class NFRMAlarm : FrmBase
    {

        public NFRMAlarm()
        {
            InitializeComponent();
            this.FrmInit();
        }

        public static int PLCError = 0;


        public override void FrmInit()
        {
            //this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer | ControlStyles.UserPaint, true);
            //this.UpdateStyles();

            //if (UIClass.uiInitFlag)
            //{
            //    this.Location = new System.Drawing.Point(UIClass.UILf, UIClass.UITp);
            //    this.Size = new Size(UIClass.UILen, UIClass.UIHt);
            //    InitCtrlSizeLocation(this);
            //    InitCtrlSizeLocation(pnlTop);

            //}

        }



        /// <summary>
        /// Set the titles and axis labels
        /// </summary>
        private void InitGraphTitles()
        {
            //base.InitGraphTitles(zgc, title, strX, strY);
            //GraphPane myPane = zgc.GraphPane;
        }

        /// <summary>
        /// 显示窗体，并添加刷新委托
        /// </summary>
        public override void FrmShow()
        {

            Program.myFrmFresh.DelegateAdd(this.FrmRefresh);
            //this.Location = new Point(UIClass.UILf, UIClass.UITp);
            this.Show();
        }

        /// <summary>
        /// 关闭窗体
        /// </summary>
        public override void FrmClose()
        {
            Program.myFrmFresh.DelegateRemove(this.FrmRefresh);
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
        /// refresh me
        /// </summary>
        public override void FrmRefresh()
        {
            //time in the panel
            DateTime current = DateTime.Now;
            //top time
            lblDate.Text = string.Format("{0:yyyy-MM-dd dddd tt hh:mm:ss}", current);

            //string faultstr = null;
            //Program.s7Server.read_plc_fault(out faultstr);

            //if (faultstr != null)
            //{
            //    string[] fault_temp = faultstr.Split(';');
            //    int strnum = fault_temp.Length;
            //    if (strnum == 9)
            //    {

            //        frmMain.FailureParas.IPC1FailureFlag = int.Parse(fault_temp[0]);
            //        frmMain.FailureParas.IPC2FailureFlag = int.Parse(fault_temp[1]);
            //        frmMain.FailureParas.IPC3FailureFlag = int.Parse(fault_temp[2]);
            //        frmMain.FailureParas.IPC4FailureFlag = int.Parse(fault_temp[3]);
            //        frmMain.FailureParas.Camera1FailureFlag = int.Parse(fault_temp[4]);
            //        frmMain.FailureParas.Camera2FailureFlag = int.Parse(fault_temp[5]);
            //        frmMain.FailureParas.Camera3FailureFlag = int.Parse(fault_temp[6]);
            //        frmMain.FailureParas.Camera4FailureFlag = int.Parse(fault_temp[7]);
            //        frmMain.FailureParas.ContinuousDefectFlag = int.Parse(fault_temp[8]);

            //    }
            //}

            //if (frmMain.FailureParas.IPC1FailureFlag ==1)
            //{
            //    label10.BackColor = Color.Red;
            //}
            //else
            //{
            //    label10.BackColor = Color.LightSlateGray;
            //}

            //if (frmMain.FailureParas.IPC2FailureFlag == 1)
            //{
            //    label11.BackColor = Color.Red;
            //}
            //else
            //{
            //    label11.BackColor = Color.LightSlateGray;
            //}

            //if (frmMain.FailureParas.IPC3FailureFlag == 1)
            //{
            //    label12.BackColor = Color.Red;
            //}
            //else
            //{
            //    label12.BackColor = Color.LightSlateGray;
            //}

            //if (frmMain.FailureParas.IPC4FailureFlag == 1)
            //{
            //    label13.BackColor = Color.Red;
            //}
            //else
            //{
            //    label13.BackColor = Color.LightSlateGray;
            //}

            //if (frmMain.FailureParas.Camera1FailureFlag == 1)
            //{
            //    label14.BackColor = Color.Red;
            //}
            //else
            //{
            //    label14.BackColor = Color.LightSlateGray;
            //}

            //if (frmMain.FailureParas.Camera2FailureFlag == 1)
            //{
            //    label15.BackColor = Color.Red;
            //}
            //else
            //{
            //    label15.BackColor = Color.LightSlateGray;
            //}

            //if (frmMain.FailureParas.Camera3FailureFlag == 1)
            //{
            //    label16.BackColor = Color.Red;
            //}
            //else
            //{
            //    label16.BackColor = Color.LightSlateGray;
            //}

            //if (frmMain.FailureParas.Camera4FailureFlag == 1)
            //{
            //    label17.BackColor = Color.Red;
            //}
            //else
            //{
            //    label17.BackColor = Color.LightSlateGray;
            //}

            //if (frmMain.ProductInfoErrorFlag == 1)
            //{
            //    label18.BackColor = Color.Red;
            //}
            //else
            //{
            //    label18.BackColor = Color.LightSlateGray;
            //}

            //if (PLCError == 1)
            //{
            //    label19.BackColor = Color.Red;
            //}
            //else
            //{
            //    label19.BackColor = Color.LightSlateGray;
            //}

            //if (frmMain.IsCamConnected[1] == 0)
            //{
            //    label20.BackColor = Color.Red;
            //}
            //else
            //{
            //    label20.BackColor = Color.LightSlateGray;
            //}

            //if (frmMain.IsCamConnected[2] == 0)
            //{
            //    label21.BackColor = Color.Red;
            //}
            //else
            //{
            //    label21.BackColor = Color.LightSlateGray;
            //}

            //if (frmMain.IsCamConnected[3] == 0)
            //{
            //    label22.BackColor = Color.Red;
            //}
            //else
            //{
            //    label22.BackColor = Color.LightSlateGray;
            //}

            //if (frmMain.IsCamConnected[4] == 0)
            //{
            //    label23.BackColor = Color.Red;
            //}
            //else
            //{
            //    label23.BackColor = Color.LightSlateGray;
            //}
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Program.myFrmFresh.SetFrmType(FrmFresh.FrmTypes.frmMain);
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cccButton4_Click(object sender, EventArgs e)
        {
            Program.s7Server.PLC_ADDR = "192.168.0.1";
            int PLCErrorReturn = Program.s7Server.ConnectOPCServer();
            if (PLCErrorReturn == -1)
            {
                PLCError = 1;
            }

            if (PLCErrorReturn == 1)
            {
                PLCError = 0;
            }
        }

        private void cccButton1_Click(object sender, EventArgs e)
        {
            Program.s7Server.disConnectOPCServer();
        }
    }
}
