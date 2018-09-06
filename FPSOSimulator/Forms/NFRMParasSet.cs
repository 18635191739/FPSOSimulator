using System;
using System.Windows.Forms;

namespace FPSOSimulator.Forms
{
    public partial class NFRMParasSet : FrmBase
    {

        public NFRMParasSet()
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
            //    this.Location = new System.Drawing.Point(UIClass.UILf, UIClass.UITp);
            //    this.Size = new Size(UIClass.UILen, UIClass.UIHt);
            //    InitCtrlSizeLocation(this);
            //    InitCtrlSizeLocation(pnlTop);

            //}

            //    UserConfiguration.OverlapArea_width;
            //private int mOverlapArea_height;

            TxtIp.Text = UserConfiguration.DefCamera[1].RemoteIP.ToString();
            TxtPort.Text = UserConfiguration.DefCamera[1].RemotePort.ToString();

            textBox2.Text = UserConfiguration.DefCamera[2].RemoteIP.ToString();
            textBox1.Text = UserConfiguration.DefCamera[2].RemotePort.ToString();


            textBox6.Text = UserConfiguration.PicPoint.MAX_X.ToString();
            textBox5.Text = UserConfiguration.PicPoint.MAX_Y.ToString();

            textBox4.Text = UserConfiguration.CamPoint.MAX_X.ToString();
            textBox3.Text = UserConfiguration.CamPoint.MAX_Y.ToString();

            textBox8.Text = UserConfiguration.PicOverlapArea.width.ToString();
            textBox7.Text = UserConfiguration.PicOverlapArea.height.ToString();

            textBox9.Text = UserConfiguration.DefectProductNum.ToString();

            TxtIp.Enabled = false;
            textBox2.Enabled = false;
            TxtPort.Enabled = false;
            textBox1.Enabled = false;


            textBox6.Enabled = false;
            textBox5.Enabled = false;

            textBox4.Enabled = false;
            textBox3.Enabled = false;

            textBox8.Enabled = false;
            textBox7.Enabled = false;

            textBox9.Enabled = false;

            //private int mPicPointMAX_Y;

            //private int mCamPointMAX_X;
            //private int mCamPointMAX_Y;

        }

        private void update_data()
        {

            //            string strcn ="server =.数据库服务器地址; database = 数据库名; PWD = 密码; UID = 用户名; ";
            //sqlconnection cn = new sqlconnection(strcn);
            //            string sql = "update 数据表 set xxx=.... where xxx=....";
            //            sqlcommand cmd = new sqlconmmand(sql);

            //            conn.Open();
            //            //增  
            //            //string sql = "insert into 表名(字段1,字段2,字段3,字段4)values(...)";
            //            //删   
            //            //string sql = "delete from 表名 where 字段1="...;   
            //            //改   
            //            //string sql = "update student set 学号=" ...;   

            //            OleDbCommand comm = new OleDbCommand(sql, conn);
            //            comm.ExecuteNonQuery();

            //            conn.Close();
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


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Program.myFrmFresh.SetFrmType(FrmFresh.FrmTypes.frmMain);
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void cccButton2_Click(object sender, EventArgs e)
        {

            try
            {
                const string dbName = "user.mdb";
                string dbPath = Application.StartupPath + "\\";
                //const string tbName = "UserConfiguration";
                //const string tbName1 = "DefectPictureSet";
                //const string tbField = "Settings";

                UIDataBase setDB1 = new UIDataBase(dbPath, dbName, "DefectPictureSet");

                setDB1.OpenConn();
                setDB1.update_data("UserConfiguration", 1, "RemoteIP", TxtIp.Text);
                setDB1.update_data("UserConfiguration", 2, "RemoteIP", textBox2.Text);
                setDB1.update_data("UserConfiguration", 1, "RemotePort", TxtPort.Text);
                setDB1.update_data("UserConfiguration", 2, "RemotePort", textBox1.Text);

                setDB1.CloseConnOnly();

                TxtIp.Enabled = false;
                textBox2.Enabled = false;
                TxtPort.Enabled = false;
                textBox1.Enabled = false;


                MessageBox.Show("工作参数设定成功,请重启应用程序!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }

        private void cccButton4_Click(object sender, EventArgs e)
        {
            TxtIp.Enabled=true;
            textBox2.Enabled = true;
            TxtPort.Enabled = true;
            textBox1.Enabled = true;
        }

        private void cccButton5_Click(object sender, EventArgs e)
        {
            textBox6.Enabled = true;
            textBox5.Enabled = true;

            textBox4.Enabled = true;
            textBox3.Enabled = true;

            textBox8.Enabled = true;
            textBox7.Enabled = true;
        }

        private void cccButton3_Click(object sender, EventArgs e)
        {
            try
            {
                const string dbName = "user.mdb";
                string dbPath = Application.StartupPath + "\\";
                //const string tbName = "UserConfiguration";
                //const string tbName1 = "DefectPictureSet";
                //const string tbField = "Settings";

                UIDataBase setDB1 = new UIDataBase(dbPath, dbName, "DefectPictureSet");

                setDB1.OpenConn();
                setDB1.update_data("DefectPictureSet", 1, "X_MAX_OR_WIDTH", textBox6.Text);
                setDB1.update_data("DefectPictureSet", 2, "X_MAX_OR_WIDTH", textBox4.Text);
                setDB1.update_data("DefectPictureSet", 3, "X_MAX_OR_WIDTH", textBox8.Text);

                setDB1.update_data("DefectPictureSet", 1, "Y_MAX_OR_HEIGHT", textBox5.Text);
                setDB1.update_data("DefectPictureSet", 2, "Y_MAX_OR_HEIGHT", textBox3.Text);
                setDB1.update_data("DefectPictureSet", 3, "Y_MAX_OR_HEIGHT", textBox7.Text);


                setDB1.CloseConnOnly();

                textBox6.Enabled = false;
                textBox5.Enabled = false;

                textBox4.Enabled = false;
                textBox3.Enabled = false;

                textBox8.Enabled = false;
                textBox7.Enabled = false;


                MessageBox.Show("工作参数设定成功,请重启应用程序!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cccButton6_Click(object sender, EventArgs e)
        {
            textBox9.Enabled = true;
        }

        private void cccButton7_Click(object sender, EventArgs e)
        {
            try
            {
                const string dbName = "user.mdb";
                string dbPath = Application.StartupPath + "\\";
                //const string tbName = "UserConfiguration";
                //const string tbName1 = "DefectPictureSet";
                //const string tbField = "Settings";

                UIDataBase setDB1 = new UIDataBase(dbPath, dbName, "DefectProductSet");

                setDB1.OpenConn();
                setDB1.update_data("DefectProductSet", 1, "ValueSet", textBox9.Text);
               


                setDB1.CloseConnOnly();

                textBox9.Enabled = false;



                MessageBox.Show("工作参数设定成功,请重启应用程序!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
