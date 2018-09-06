using System;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Configuration;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;
//using Microsoft.Office.Interop.Excel;


//using Microsoft.SqlServer.ConnectionInfo;
namespace FPSOSimulator.Forms
{
    public partial class NFRMDefectHistory : FrmBase
    {


        //NFRMDefectHistory
        public static int SelectPicNum = 0;
        private System.Windows.Forms.PictureBox[,] pictureBoxes = new PictureBox[5, 21];
        public static double BackImgScale = 0.03; // ratio  width/maxWidth
        public int ProductDefectNum = 0; //产品缺陷个数
        public int ProductDefectSmallSize = 18; //缩略图尺寸 单位像素
        public static bool ProductInfoReady = false;
        public static MyClass.MyPubClass.DefectImgInfo[,] ProDefectImgInfo = new MyClass.MyPubClass.DefectImgInfo[5, 21];

        
        
       

        public void HidePicBox(int idx)
        {

            for (int j = 0; j < 21; j++)
            {
                pictureBoxes[idx, j].Visible = false;
            }

        }

        public void ShowPicBox(int idx, int PicNum)
        {
            if (PicNum < 1)
            {
                return;
            }
            string apppath = System.Windows.Forms.Application.StartupPath;
            pictureBoxes[idx, 0].Visible = false;
            for (int i = 1; i < PicNum + 1; i++)
            {
                //int MY_X = Convert.ToInt32((ProductInfo[i].FAULTPOSX[j]) * BackImgScale)
                pictureBoxes[idx, i].Visible = true;

                string aimpath = ProDefectImgInfo[idx, i].FileAimPath;

                if (File.Exists(aimpath))
                {
                    Stream s = File.Open(aimpath, FileMode.Open);
                    pictureBoxes[idx, i].Image = Image.FromStream(s);
                    s.Close();

                    //pictureBoxes[idx, i].Image = Image.FromFile(aimpath);
                }
                else
                {

                    Stream s = File.Open(apppath + "\\" + "FaultPic.jpg", FileMode.Open);
                    pictureBoxes[idx, i].Image = Image.FromStream(s);
                    s.Close();
                    //pictureBoxes[idx, i].Image = Image.FromFile(apppath + "\\" + "FaultPic.jpg");
                }

                //if (File.Exists(aimpath))
                //{
                //    pictureBoxes[idx, i].Image = Image.FromFile(aimpath);
                //}
                //else
                //{
                //    pictureBoxes[idx, i].Image = Image.FromFile(apppath + "\\" + "FaultPic.jpg");
                //}

                //= Image.FromFile(apppath + "\\DefectPicturesTest" + "\\" + frmMain.ProDefectImgInfo[idx, i].FAULTFILENAME + ".jpg"); ;
                pictureBoxes[idx, i].Location = new System.Drawing.Point(ProDefectImgInfo[idx, i].FAULTPOSX, ProDefectImgInfo[idx, i].FAULTPOSY);
            }

            for (int i = PicNum + 1; i < 21; i++)
            {
                pictureBoxes[idx, i].Visible = false;
            }
        }

        public NFRMDefectHistory()
        {
            InitializeComponent();

            this.FrmInit();
        }


        public override void FrmInit()
        {
            //this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer | ControlStyles.UserPaint, true);
            //this.UpdateStyles();

            //if (UIClass.uiInitFlag)
            //{
            //    //this.Location = new Point(UIClass.UILf, UIClass.UITp);
            //    //this.Size = new Size(UIClass.UILen, UIClass.UIHt);
            //    //InitCtrlSizeLocation(this);
            //    //InitCtrlSizeLocation(pnlTop);
            //}

            for (int i = 1; i < 5; i++)
            {
                for (int j = 1; j < 21; j++)
                {
                    ProDefectImgInfo[i, j] = new MyClass.MyPubClass.DefectImgInfo { };

                }

            }

            
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
            dGViewExcel.UserConfiguration
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

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Program.myFrmFresh.SetFrmType(FrmFresh.FrmTypes.frmMain);
        }
    }
}
