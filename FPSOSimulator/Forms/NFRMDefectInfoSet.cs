using System;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Configuration;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;
//using ProductDefectServer.Forms.NFRMDefectHistory;


namespace FPSOSimulator.Forms
{
    public partial class NFRMDefectInfoSet : FrmBase
    {
        //NFRMDefectInfoSet
        public NFRMDefectInfoSet()
        {
            InitializeComponent();
            this.FrmInit();

        }


        /// <summary>
        /// 初始化窗体，位置和字;
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
            //    InitCtrlSizeLocation(pnlTop);

            //}

            checkBox1.Parent = cPanel1;
            checkBox2.Parent = cPanel1;
            checkBox3.Parent = cPanel1;
            checkBox4.Parent = cPanel1;
            checkBox5.Parent = cPanel1;

            checkedListBox1.Items.Add("CAMERA1");
            checkedListBox1.Items.Add("CAMERA2");
            checkedListBox1.Items.Add("CAMERA3");
            checkedListBox1.Items.Add("CAMERA4");

            for (int i = 0; i < 4; i++)
            {
                checkedListBox1.SetItemChecked(i, true);
            }
            checkedListBox2.Items.Add("有缺陷");
            checkedListBox2.Items.Add("无缺陷");
            checkedListBox2.SetItemChecked(0, true);

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

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {



            }
            catch (Exception ex)    // 这是一个常规的 catch 处理程序，能捕捉一切异常  
            {
                //可以提升异常如下:
                Console.WriteLine(ex);
            }

        }

        private void NFRMDefectInfoSet_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            Program.myFrmFresh.SetFrmType(FrmFresh.FrmTypes.frmMain);
        }

        private void cccButton1_Click(object sender, EventArgs e)
        {

        }
        public DataSet checkds;
        private void cccButton1_Click_1(object sender, EventArgs e)
        {
            try
            {
                string[] checkstr = new string[6] { "", "", "", "", "", "" };
                int[] checkEnb = new int[5];
                if (checkBox1.Checked == true)
                {
                    string myPCDatestt = "";
                    string myPCDateend = "";
                    bool checkreturn = base.CheckDateTime(datetimePickerStart, datetimePickerEnd, out myPCDatestt, out myPCDateend);

                    if (!checkreturn)
                    {
                        return;
                    }

                    checkstr[0] = "LNKDATETIME between '" + myPCDatestt + "' and '" + myPCDateend + "'";
                    checkEnb[0] = 1;
                }
                else
                {
                    checkstr[0] = "";
                    //checkEnb[0] = 0;
                }

                if (checkBox2.Checked == true)
                {
                    //int[] cam_enb = new int[5] { 0, 0, 0, 0, 0 };
                    for (int j = 0; j < checkedListBox1.Items.Count; j++)
                    {
                        if (checkedListBox1.GetItemChecked(j))
                        {
                            if (checkstr[1] != "")
                            {
                                checkstr[1] = checkstr[1] + " or " + "LNKNUM =" + "'" + (j + 1).ToString() + "'";
                            }
                            else
                            {
                                checkstr[1] = checkstr[1] + "LNKNUM =" + "'" + (j + 1).ToString() + "'";
                            }

                        }


                    }
                    checkEnb[1] = 1;
                }
                else
                {
                    checkstr[1] = "";
                    //checkEnb[1] = 0;
                }

                if (checkBox3.Checked == true)
                {

                    if (checkedListBox2.SelectedItem.ToString() == "有缺陷")
                    {
                        checkstr[2] = "LNKRESULT =" + "'1'";
                    }
                    if (checkedListBox2.SelectedItem.ToString() == "无缺陷")
                    {
                        checkstr[2] = "LNKRESULT =" + "'0'";
                    }
                }
                else
                {
                    checkstr[2] = "";
                }

                if (checkBox4.Checked == true)
                {

                    checkstr[3] = "LNKOPER =" + "'" + textBox1.Text + "'";
                }
                else
                {
                    checkstr[3] = "";
                }

                if (checkBox5.Checked == true)
                {

                    checkstr[4] = "LNKSHIFT =" + "'" + textBox2.Text + "'";
                }
                else
                {
                    checkstr[4] = "";
                }



                for (int i = 0; i < 5; i++)
                {
                    if (checkstr[i] == "" || checkstr[5] == "")
                    {
                        checkstr[5] = checkstr[5] + checkstr[i];
                    }
                    else
                    {
                        checkstr[5] = checkstr[5] + " and " + checkstr[i];
                    }

                }

                if (checkstr[5] != "")
                {
                    checkstr[5] = "select* from mytest where " + checkstr[5];
                }

                //连接数据库"select* from mytest where LNKDATETIME between '" + myPCDatestt + "' and '" + myPCDateend + "'"

                //using (SqlConnection con = SqlHelper.GetConnection())
                //{
                SqlConnection con = SqlHelper.GetConnection();
                checkds = SqlHelper.ExecuteDataset(con, CommandType.Text, checkstr[5]);
                adapter = new SqlDataAdapter(checkstr[5], con);
                dSet = new DataSet();
                adapter.Fill(dSet);
                //}




                //DGVMain.DataSource = dSet.Tables[0];

                dGViewExcel.DataSource = dSet.Tables[0];//把dt的内容绑定到dGViewExcel里显示。

            }
            catch (Exception ex)
            {
                FrmException.ShowException(ex, "查询", "btnInquire_Click");
            }
        }


        private void cccButton2_Click(object sender, EventArgs e)
        {
            //if 
            dGViewExcel.Enabled = true;
            dGViewExcel.ReadOnly = false;
        }


        public static bool UpdataSql(DataTable dt)
        {
            try
            {
                using (SqlConnection con = SqlHelper.GetConnection())
                {
                    string strSql = "select * from mytest";
                    using (SqlCommand cmd = new SqlCommand(strSql, con))
                    {
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            using (SqlCommandBuilder builder = new SqlCommandBuilder(da))
                            {
                                da.Update(dt);
                                return true;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        /// <summary>  
        /// 数据适配器  
        /// </summary>  
        SqlDataAdapter adapter = null;
        /// <summary>  
        /// 数据集对象  
        /// </summary>  
        DataSet dSet = null;

        private void cccButton3_Click(object sender, EventArgs e)
        {
            //DataTable dt = dataGridView1.DataSource as DataTable;
            //UpdataSql(dt);

            //创建命令重建对象  
            SqlCommandBuilder scb = new SqlCommandBuilder(adapter);

            //更新数据  
            try
            {
                //这里是关键  
                adapter.Update(dSet);
                MessageBox.Show("缺陷信息修改成功!");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            dGViewExcel.ReadOnly = true;

            
        }
    }
}
