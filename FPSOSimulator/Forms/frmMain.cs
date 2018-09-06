using System;
using System.Drawing;
using System.Windows.Forms;

//using System.Collections.Generic;
//using System.ComponentModel;
using System.Data;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
using System.Linq;
using System.ComponentModel;
using FPSOSimulator.MyClass;
using System.Threading;
//using ProductDefectServer;
//using ProductDefectServer;
//using ProductDefectServer.Demo;

namespace FPSOSimulator.Forms
{
    public delegate void CloseFormSever(bool isclose);
    //public delegate void CloseFormClient();

    public partial class frmMain : FrmBase
    {

        public frmMain()
        {
            //this.DoubleBuffered = true;//设置本窗体
            //SetStyle(ControlStyles.UserPaint, true);
            //SetStyle(ControlStyles.AllPaintingInWmPaint, true); // 禁止擦除背景.
            //SetStyle(ControlStyles.DoubleBuffer, true); // 双缓冲
            //SetStyle(ControlStyles.DoubleBuffer | ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
            //UpdateStyles();

            InitializeComponent();
            this.FrmInit();

            //if (!IsExit)
            //{
            //    FrmServer frmServer = new FrmServer();
            //    frmServer.ServerStart();
            //    CloseSeverNow += new ProductDefectServer.Forms.CloseFormSever(frmServer.F_CloseSever);
            //    frmServer.Show();
            //}

            //if (!IsExit)
            //{
            //    //FrmClient frmClient = new FrmClient();
            //    //frmClient.ClientStart();
            //    //CloseClientNow += new CloseFormClient(FrmClient.F_CloseClient);
            //    //frmClient.Show();

            //}


            

          

        }

        public double FH = 2000; //  '∶   热物流流量,Kg/h；
        public double FC = 3000; //  '∶     冷物流流量, Kg/h；
        public double FHO = 1800; //   '∶    热物流正常流量, Kg/h；
        public double FCO = 2600; //   '∶    冷物流正常流量, Kg/h；
        public double THI = 45; //    '∶  热物流进口温度, ℃；
        public double THO = 35; //     '∶  热物流出口温度, ℃；
        public double TCI = 20; //     '∶  冷物流入口温度, ℃；
        public double TCO = 22; //     '∶  冷物流出口温度, ℃；
        public double Q = 4000; //     '∶    传热量,KJ；
        public double CPH = 0; //   '∶   热物流比热,Kcal/(Kg· ℃ )；
        public double CPC = 0; //   '∶   冷物流比热，Kcal/(Kg· ℃ )；
        public double SA = 30; //   '∶    换热器的传热面积,m ；
        public double CFH = 0.3; //     '∶ 热物流流量补偿系数，一般取热物流正常流量的 0.1-0.5；
        public double CFC = 0.3; //   '∶   冷物流流量补偿系数，一般取冷物流正常流量的 0.1-0.5；
        public double XNH = 0.8; //     '∶ 热流量对给热系数K的影响指数，通常 As Sing  le '∶  管程 0.8，壳程 0.5—0.6；
        public double XNC = 0.6; //     '∶ 冷流量对给热系数K的影响指数；
        public double K = 32.05; //     '∶   传热系数；
        public double SHCH = 1.55; //   '∶  热物流出口比热校正系数；
        public double SHCW = 0.005; //   '∶  冷物流出口比热校正系数；
        public double VTCH = 10; //   '∶  热物流出口温度动态补偿系数；
        public double VTCW = 50; //   '∶  冷物流出口温度动态补偿系数；
        public double TC = 2; //   '∶    动态补偿系数；
        public double DT = 1; //   '∶    时间步长,S；
        public double NHVI = 0; //   '∶  换热器热物流前后阀有无标志(NHVI=0.0 热物流进换热器前计算流量； NHVI=1.0 热物流出换热器后计算流量)；
        public double NCVI = 0; //   '∶  换热器热物流前后阀有无标志(NCVI=0.0 冷物流进换热器前计算流量；NCVI=1.0 冷物流出换热器后计算流量)；
        public double ACSI = 0; //    '∶ 故障标志；
        public double ACDE = 0; //     '∶ 故障程度；
        public double JG = 0; //   '∶     结垢故障时流量，Kg/h；
        public double HTTOCD = 0; //   '∶  热物流串进冷物流流量，Kg/h；
        public double CDTOHT = 0; //   '∶  冷物流串进热物流流量，Kg/h；



        public double Qs = 0;
        public double TA = 0;
        public double Vtx1 = 0;
        public double FHI4 = 0;
        public double FHO4 = 0;
        public double FCO4 = 0;
        public double Th1 = 0;
        public double FHI1 = 0;
        public double Tc1 = 0;
        public double FCI1 = 0;
        public double Tf0;
        public double Tw0;
        public double FHO0 = 0;
        public double FHO2 = 0;
        public double FHI2 = 0;
        public double FCO0 = 0;
        public double FCO2 = 0;
        public double FCI2 = 0;
        public double Vtx2 = 0;
        public double FHO1 = 0;
        public double FCO1 = 0;

        public double Dt1 = 0;
        public double Dt2 = 0;
        public double Dtm = 0;
        public double T = 0;
        public double P1 = 0;
        public double FHI0 = 0;
        public double FH0 = 0;
        public double P2 = 0;
        public double FCI0 = 0;
        public double FC0 = 0;
        public double Qfc = 0;
        public double Aux = 0;
        public double QD = 0;
        public double Qfh = 0;
        public void HeaterTest()
        {

            //'冷热物流进口温度差：
             Dt1 = THI - TCO;

            //'冷热物流出口温度差:
             Dt2 = THO - TCI;


            if (System.Math.Abs(Dt1 - Dt2) <= 0.1 && (Dt1 * Dt2) <= 0.1)
            {
                Dtm = (Dt1 + Dt2) / 2;
            }
            else if (System.Math.Abs(Dt1 - Dt2) > 0.1 && (Dt1 * Dt2) > 0.1)
            {
                T = Dt1 / Dt2;
                //s = Format(T, "####0.000");
                //Dtm = (Dt1 - Dt2) / Math.Log(s);
                Dtm = (Dt1 - Dt2) / Math.Log(T);
            }

            //If Abs(Dt1 - Dt2) <= 0.1 And Dt1 * Dt2 <= 0.1 Then
            //    Dtm = (Dt1 + Dt2) / 2
            //ElseIf Abs(Dt1 - Dt2) > 0.1 And Dt1 * Dt2 > 0.1 Then
            //    T = Dt1 / Dt2
            //    s = Format(T, "####0.000")
            //    Dtm = (Dt1 - Dt2) / Log(s)
            //End If
            
            P1 = (FHI0 - HTTOCD + CDTOHT - CFH) / (FH0 + CFH);

            //P1 = (FHI0 - HTTOCD + CDTOHT - CFH) / (FH0 + CFH)

            
            if (P1 <= 0)
            {
                Qfh = 0;
            }
            else
            {
                //Qfh = P1 ^ XNH;
                Qfh = Math.Pow(P1, XNH);
            }
            //If P1 <= 0 Then
            //    Qfh = 0
            //Else
            //    Qfh = P1 ^ XNH
            //End If

            
            P2 = (FCI0 + HTTOCD - CDTOHT + CFC) / (FC0 + CFC);
            //P2 = (FCI0 + HTTOCD - CDTOHT + CFC) / (FC0 + CFC)

            
            if (P2 <= 0)
            {
                Qfc = 0;
            }
            else
            {
                //Qfh = P1 ^ XNH;
                Qfc = Math.Pow(P2, XNC);
            }

            //If(P2 <= 0) Then
            //    Qfc = 0
            //Else
            //    Qfc = P2 ^ XNC
            //End If

             Aux = K * JG * SA * Qfh * Qfc;
            //Aux = K * JG * SA * Qfh * Qfc
            
            QD = QD + (Aux * Dtm - QD) / 5;
            //QD = QD + (Aux * Dtm - QD) / 5


            if (QD > Math.Pow(10, 15))
            {
                QD = Math.Pow(10, 15);
            }
            //If QD > 1E+15 Then QD = 1E+15

            if (QD > -0.00001 && QD < 0.00001)
            {
                QD = 0;
            }
            //If QD > -0.00001 And QD < 0.00001 Then QD = 0

            if (QD < -Math.Pow(10, 15))
            {
                QD = -Math.Pow(10, 15);
            }
            //If QD < -1E+15 Then QD = -1E+15
            //Qs = 0

            if (FHI0 + FCI0 <= 0.1)
            {
                Qs = 0.01 * Aux * (THI + TCO) - 2 * TA;
            }
            //If FHI0 + FCI0 <= 0.1 Then Qs = 0.01 * Aux * (Tc1 + TCO) - 2 * TA


            Vtx1 = Aux * 5 + FHI0 * FHI4;
            //Vtx1 = Aux * 5 + FHI0 * FHI4

            if (FHI0 > 0)
            {
                if (Vtx1 > (50 * FHI0 * FHI4))
                {
                    Vtx1 = 50 * FHI0 * FHI4;
                }
                if (Vtx1 < (10 * FHI0 * FHI4))
                {
                    Vtx1 = 10 * FHI0 * FHI4;
                }
            }

            //If FHI0 > 0 Then
            //    If Vtx1 > 50 * FHI0 * FHI4 Then Vtx1 = 50 * FHI0 * FHI4
            //    If Vtx1 < 10 * FHI0 * FHI4 Then Vtx1 = 10 * FHI0 * FHI4
            //End If


            if (SHCW <= 0)
            {
                SHCW = 1;
            }
            //If SHCW <= 0 Then SHCW = 1

            if (VTCH <= 0)
            {
                VTCH = 1;
            }
            //If VTCH <= 0 Then VTCH = 1

            if (VTCW <= 0)
            {
                VTCW = 1;
            }
            //If VTCW <= 0 Then VTCW = 1

            if (ACSI <= 0 || ACSI > 3)
            {
                ACSI = 0;
            }
            //If ACSI <= 0 Then ACSI = 0
            //If ACSI > 3 Then ACSI = 0

            if (ACDE <= 0)
            {
                ACDE = 0;
            }
            //If ACDE <= 0 Then ACDE = 0

            if (ACDE > 100)
            {
                ACDE = 100;
            }
            //If ACDE > 100 Then ACDE = 100

            if (FHI4 <= 0)
            {
                FHI4 = 1;
            }
            //If FHI4 <= 0 Then FHI4 = 1


            double FCI4 = 0;
            if (FCI4 < 0)
            {
                FCI4 = 1;
            }
            //If FCI4 < 0 Then FCI4 = 1


            FHO4 = FHI4;
            FCO4 = FCI4;
            //FHO4 = FHI4
            //FCO4 = FCI4

            if (ACSI == 1)
            {
                JG = (1 - ACDE / 100) * 0.8;
            }
            //If ACSI = 1 Then JG = (1 - ACDE / 100) * 0.8

            if (ACSI == 2)
            {
                HTTOCD = ACDE * FHI0;
            }
            //If ACSI = 2 Then HTTOCD = ACDE * FHI0

            if (ACSI == 1)
            {
                CDTOHT = ACDE * FCI0;
            }
            //If ACSI = 3 Then CDTOHT = ACDE * FCI0


            if (FHI0 < 0.001)
            {
                FHI0 = 0;
                Th1 = THO;
            }
            else
            {
                Th1 = FHI1;
            }
            //If FHI0 < 0.001 Then
            //    FHI0 = 0
            //    Th1 = THO
            //Else
            //    Th1 = FHI1
            //End If


            if (FCI0 <= 0.001)
            {
                FCI0 = 0;
                Tc1 = TCO;
            }
            else
            {
                Tc1 = FCI1;
            }
            //If FCI0 <= 0.001 Then
            //    FCI0 = 0
            //    Tc1 = TCO
            //Else
            //    Tc1 = FCI1
            //End If


            if (Th1 >= Tc1)
            {
                Tf0 = Th1;
                Tw0 = Tc1;
            }
            else
            {
                Tf0 = Tc1;
                Tw0 = Th1;
            }
            //If Th1 >= Tc1 Then
            //    Tf0 = Th1
            //    Tw0 = Tc1
            //Else
            //    Tf0 = Tc1
            //    Tw0 = Th1
            //End If

            if ((FHI0 + FCI0) <= 0.1)
            {
                Tw0 = TA;
            }
            //If(FHI0 + FCI0) <= 0.1 Then Tw0 = TA

            if (NHVI <= 0)
            {
                NHVI = 0;
            }
            if (NHVI >= 1)
            {
                NHVI = 1;
            }
            //If NHVI <= 0 Then NHVI = 0
            //If NHVI >= 1 Then NHVI = 1

            if (NCVI <= 0)
            {
                NCVI = 0;
            }
            if (NCVI >= 1)
            {
                NCVI = 1;
            }
            //If NCVI <= 0 Then NCVI = 0
            //If NCVI >= 1 Then NCVI = 1


            if (NHVI > 0)
            {
                FHI0 = FHO0;
                FHO2 = FHI2;
            }
            else
            {
                FHO0 = FHI0;
                FHI2 = FHO2;
            }
            //If NHVI > 0 Then
            //    FHI0 = FHO0
            //    FHO2 = FHI2
            //Else
            //    FHO0 = FHI0
            //    FHI2 = FHO2
            //End If


            if (NCVI > 0)
            {
                FCO0 = FCI0;
                FCO2 = FCI2;
            }
            else
            {
                FCO0 = FCI0;
                FCI2 = FCO2;
            }
            //If NCVI > 0 Then
            //    FCO0 = FCI0
            //    FCO2 = FCI2
            //Else
            //    FCO0 = FCI0
            //    FCI2 = FCO2
            //End If


            if (SA <= 0) SA = 1000000;
            if (FH0 <= 0) FH0 = 100000;
            if (FC0 <= 0) FC0 = 100000;
            if (CFH <= 0) CFH = 0;
            if (CFH >= FH0) CFH = FH0;
            if (CFC <= 0) CFC = 0;
            if (CFC >= FC0) CFC = FC0;
            if (XNH <= 0) XNH = 0;
            if (XNH >= 1) XNH = 1;
            if (XNC <= 0) XNC = 0;
            if (XNC > 1) XNC = 1;
            if (K <= 0) K = 0;
            if (SHCH <= 0) SHCH = 1;

            //if (SA <= 0) SA = 1000000;
            //if (FH0 <= 0) FH0 = 100000;
            //if (FC0 <= 0) FC0 = 100000;
            //if (CFH <= 0) CFH = 0;
            //if (CFH >= FH0) CFH = FH0;
            //if (CFC <= 0) CFC = 0;
            //if (CFC >= FC0) CFC = FC0;
            //if (XNH <= 0) XNH = 0;
            //if (XNH >= 1) XNH = 1;
            //if (XNC <= 0) XNC = 0;
            //if (XNC > 1) XNC = 1;
            //if (K <= 0) K = 0;
            //if (SHCH <= 0) SHCH = 1;


            Vtx2 = Aux * 5 + FCI0 * FCI4;
            //Vtx2 = Aux * 5 + FCI0 * FCI4

            if (FCI0 > 0)
            {
                if (Vtx2 > (50 * FCI0 * FCI4))
                {
                    Vtx2 = 50 * FCI0 * FCI4;
                }
                if (Vtx2 < (10 * FCI0 * FCI4))
                {
                    Vtx2 = 10 * FCI0 * FCI4;
                }
            }
            //If FCI0 > 0 Then
            //    If Vtx2 > 50 * FCI0 * FCI4 Then Vtx2 = 50 * FCI0 * FCI4
            //    If Vtx2 < 10 * FCI0 * FCI4 Then Vtx2 = 10 * FCI0 * FCI4
            //End If

            if (Vtx1 <= 1)
            {
                Vtx1 = 1000;
            }
            if (Vtx2 <= 1)
            {
                Vtx2 = 1000;
            }
            //If Vtx1 <= 1 Then Vtx1 = 1000
            //If Vtx2 <= 1 Then Vtx2 = 1000

            THO = THO + ((FHI0 - HTTOCD) * FHI4 * SHCH * (Th1 - THO) - QD + CDTOHT * SHCW * FCI4 * (TCO - THO)) * DT / (Vtx1 + DT) * VTCH;
            TCO = TCO + ((FCI0 - CDTOHT) * SHCW * FCI4 * (Tc1 - TCO) + QD - Qs + HTTOCD * SHCH * FHI4 * (THO - TCO)) * DT / (Vtx2 + DT) * VTCW;
            //THO = THO + ((FHI0 - HTTOCD) * FHI4 * SHCH * (Th1 - THO) - QD + CDTOHT * SHCW * FCI4 * (TCO - THO)) * DT / (Vtx1 + DT) * VTCH
            //TCO = TCO + ((FCI0 - CDTOHT) * SHCW * FCI4 * (Tc1 - TCO) + QD - Qs + HTTOCD * SHCH * FHI4 * (THO - TCO)) * DT / (Vtx2 + DT) * VTCW

            if (THO >= Tf0) THO = Tf0;
            if (THO <= Tw0) THO = Tw0;
            if (TCO >= Tf0) TCO = Tf0;
            if (TCO <= Tw0) TCO = Tw0;
            if (FHI0 <= 0) THO = THO + (25 - THO) / 100 * DT;
            if (FHO0 <= 0) TCO = TCO + (25 - TCO) / 100 * DT;

            //If THO >= Tf0 Then THO = Tf0
            //If THO <= Tw0 Then THO = Tw0
            //If TCO >= Tf0 Then TCO = Tf0
            //If TCO <= Tw0 Then TCO = Tw0
            //If FHI0 < 0 Then THO = THO + (25 - THO) / 100 * DT
            //If FHO0 <= 0 Then TCO = TCO + (25 - TCO) / 100 * DT


            FHO0 = FHI0 - HTTOCD + CDTOHT;
            FCO0 = FCI0 + HTTOCD - CDTOHT;
            FHO1 = THO;
            FCO1 = TCO;

            //FHO0 = FHI0 - HTTOCD + CDTOHT
            //FCO0 = FCI0 + HTTOCD - CDTOHT
            //FHO1 = THO
            //FCO1 = TCO

            label8.Text = THO.ToString();
            label15.Text = TCO.ToString();
        }

        //public static bool InitialFlag = false;
        //public event FPSOSimulator.Forms.CloseFormSever CloseSeverNow;
        ////public event ProductDefectServer.Forms.CloseFormClient CloseClientNow;
        //public static bool IsExit = false;


        //private System.Windows.Forms.PictureBox[,] pictureBoxes = new PictureBox[5, 21];
        //public static double BackImgScale = 0.03; // ratio  width/maxWidth
        //public int ProductDefectNum = 0; //产品缺陷个数
        //public int ProductDefectSmallSize = 18; //缩略图尺寸 单位像素
        //public static bool ProductInfoReady = false;
        //public static SQLDBMode.DefectInfoParas[] ProductInfo = new SQLDBMode.DefectInfoParas[5]; //缓存产品检验信息
        //public static MyPubClass.DefectImgInfo[,] ProDefectImgInfo = new MyPubClass.DefectImgInfo[5, 21];
        //public static MyPubClass.DefectDataGridInfo ProDefectDataGridInfo = new MyPubClass.DefectDataGridInfo();
        //public static SQLDBMode.MESInterfaceParas InfoPLC = new SQLDBMode.MESInterfaceParas();
        //public static SQLDBMode.SystemFailureParas FailureParas = new SQLDBMode.SystemFailureParas();
        /// <summary>
        /// 初始化窗体，位置和字体
        /// </summary>
        public override void FrmInit()
        {
            //this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer | ControlStyles.UserPaint, true);
            //this.UpdateStyles();
            //if (UIClass.uiInitFlag)
            //{
            //    this.Location = new Point(UIClass.UILf, UIClass.UITp);
            //    this.Size = new Size(UIClass.UILen, UIClass.UIHt);
            //    InitCtrlSizeLocation(this);
            //    InitCtrlSizeLocation(cPanel1);
            //    InitCtrlSizeLocation(cPanel2);
            //    InitCtrlSizeLocation(pnlTop);
            //}
            //Program.s7Server.PLC_ADDR = "192.168.0.1";
            ////NFRMAlarm.PLCError = Program.s7Server.ConnectOPCServer();
            //int PLCErrorReturn = Program.s7Server.ConnectOPCServer();
            //if (PLCErrorReturn == -1)
            //{
            //    NFRMAlarm.PLCError = 1;
            //}

            //if (PLCErrorReturn == 1)
            //{
            //    NFRMAlarm.PLCError = 0;
            //}

            //dGViewExcelInit();
            //AddPicBox();
            ////SetTestXY();
            //for (int i = 0; i < 5; i++)
            //{
            //    HidePicBox(i);
            //}

            //创建数据库表格 测试

            string colstr = "";
            colstr = SQLDBMode.GetDefectInfoColString();
            SQLDBMode.AddNewTable("mytest", colstr);


            //colstr = SQLDBMode.GetSetParaColString();
            //SQLDBMode.AddNewTable("SetParameters", colstr);

            colstr = SQLDBMode.GetSystemFailureColString();
            SQLDBMode.AddNewTable("DefectSystemFailure", colstr);


            colstr = SQLDBMode.GetMESInterfaceColString();
            SQLDBMode.AddNewTable("MESInterface", colstr);

            //colstr = SQLDBMode.GetALMHistoryColString();
            //SQLDBMode.AddNewTable("ALMHistory", colstr);


        }

        /// <summary>
        /// refresh me
        /// </summary>
        public override void FrmRefresh()
        {
            //time in the panel
            DateTime current = DateTime.Now;
           
            //cLabel1.Text = string.Format("{0:T}", current);

            //if (frmMain.IsCamConnected[1] == 1)
            //{
            //    label12.BackColor = Color.Lime;
            //}
            //else
            //{
            //    label12.BackColor = Color.LightSlateGray;
            //}

            //if (frmMain.IsCamConnected[3] == 1)
            //{
            //    label13.BackColor = Color.Lime;
            //}
            //else
            //{
            //    label13.BackColor = Color.LightSlateGray;
            //}
            //lblDate.Text = string.Format("{0:yyyy-MM-dd dddd tt hh:mm:ss}", current);

            //if (ProductInfoErrorFlag == 1)
            //{
            //    label3.BackColor = Color.Red;
            //}
            //else
            //{
            //    label3.BackColor = Color.LightSlateGray;
            //}
            //top time
            //lblDate.Text = current.Year.ToString() + "-" + current.Date.ToString("MM") + "-" + current.Date.ToString("dd") + "      " + strWeekDays[(int)current.DayOfWeek] + "  " + string.Format("{0:T}", current);
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

        //public static bool IsExitNow()
        //{

        //    //return IsExit;
        //}

       
        
            


      
       

        

        
       
       
       
        

       

           

       



       

        
       


       


        

        private void btnStandModel_Click(object sender, EventArgs e)
        {
            Program.myFrmFresh.SetFrmType(FrmFresh.FrmTypes.NFRMParasSet);
        }

        private void btnHullClean_Click(object sender, EventArgs e)
        {
            //Program.myFrmFresh.SetFrmType(FrmFresh.FrmTypes.FrmHullClean);
        }

        private void btnPointsTrend_Click(object sender, EventArgs e)
        {
            Program.myFrmFresh.SetFrmType(FrmFresh.FrmTypes.NFRMDefectHistory);
        }

        private void btnShowModelValue_Click(object sender, EventArgs e)
        {
            Program.myFrmFresh.SetFrmType(FrmFresh.FrmTypes.FrmClient);
        }

        private void btnFuelkw_Click(object sender, EventArgs e)
        {
            //Program.myFrmFresh.SetFrmType(FrmFresh.FrmTypes.FrmFuelCurvekw);
        }

        private void btnFuelTime_Click(object sender, EventArgs e)
        {
            //Program.myFrmFresh.SetFrmType(FrmFresh.FrmTypes.FrmFuelTime);
        }

        private void cccButton1_Click(object sender, EventArgs e)
        {
            //Combine_Multiple_SampleImages_IntoOne();
        }

        private void BackPicBox_Click(object sender, EventArgs e)
        {
            //e.x
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            //ReadIDFlag = 1 - ReadIDFlag;
        }

        private void btnSysALM_Click(object sender, EventArgs e)
        {
            Program.myFrmFresh.SetFrmType(FrmFresh.FrmTypes.NFRMAlarm);
        }
        //static  int i_1 = 1;
        public static bool[] ispicsave = new bool[5] { false, false, false, false, false };
        private void timer4_Tick(object sender, EventArgs e)
        {
            HeaterTest();


        }

        

    }
}
