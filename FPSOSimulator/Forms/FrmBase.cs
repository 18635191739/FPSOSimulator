using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace FPSOSimulator.Forms
{
    public class FrmBase : Form
    {
        
        public const bool bolDwVisible = false;

        /// <summary>
        /// declare UI class
        /// </summary>
        protected static UIClass myUI;

        protected static UserConfiguration myUserConfiguration;

        /// <summary>
        /// 星期数组
        /// </summary>
        protected static string[] strWeekDays = new string[] { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

        /// <summary>
        /// 设置UI类
        /// </summary>
        public static void SetMyUI()
        {
            myUI = UIClass.GetUIClass();
        }

        /// <summary>
        /// 设置UI类
        /// </summary>
        public static void SetUserConfiguration()
        {
            myUserConfiguration = UserConfiguration.GetUserConfiguration();
        }

        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        CreateParams cp = base.CreateParams;
        //        cp.ExStyle |= 0x02000000;
        //        return cp;
        //    }
        //}

        /// <summary>
        /// 设置datagridview的数据
        /// </summary>
        /// <param name="dt"></param>
        public void SetDataGridView(ref DataGridView dw, DataTable dt)
        {
            dw.DataSource = dt;
        }

        #region "窗体重载的虚函数"
        public virtual void FrmInit() { }

        public virtual void FrmShow() { }

        public virtual void FrmRefresh() { }

        public virtual void FrmHide() { }

        public virtual void FrmClose() { }

        public virtual void GraphRefresh() { }
        #endregion

        /// <summary>
        /// 更新图像，设置标题，坐标轴等
        /// </summary>
        /// <param name="zgc"></param>
        /// <param name="title"></param>
        /// <param name="strX"></param>
        /// <param name="strY"></param>
        protected void InitGraphTitles(ZedGraphControl zgc, string title, string strX, string strY)
        {
            GraphPane myPane = zgc.GraphPane;

            // Set the titles and axis labels
            myPane.Title.Text = title;
            myPane.XAxis.Title.Text = strX;
            myPane.YAxis.Title.Text = strY;
        }

        /// <summary>
        /// 初始化控件大小以及字体大小
        /// </summary>
        /// <param name="ctrl"></param>
        protected void InitCtrlSizeLocation(Control ctrl)
        {
            try
            {
                foreach (Control myctrl in ctrl.Controls)
                {
                    myctrl.Size = new Size((int)(myctrl.Size.Width * (float)UIClass.UILen / UIClass.OldLen), (int)(myctrl.Size.Height * (float)UIClass.UIHt / UIClass.OldHt));
                    myctrl.Location = new Point((int)(myctrl.Location.X * (float)UIClass.UILen / UIClass.OldLen), (int)(myctrl.Location.Y * (float)UIClass.UIHt / UIClass.OldHt));

                    if (myctrl is DataGridView)
                    {
                        DataGridView mydategridview = (DataGridView)myctrl;
                        Font myfont = new Font(mydategridview.DefaultCellStyle.Font.FontFamily, 14.25f * (float)UIClass.UIHt / UIClass.OldHt);
                        mydategridview.ColumnHeadersHeight = (int)(30 * (float)UIClass.UIHt / UIClass.OldHt);
                        mydategridview.RowTemplate.Height = (int)(mydategridview.RowTemplate.Height * (float)UIClass.UIHt / UIClass.OldHt);
                        mydategridview.DefaultCellStyle.Font = myfont;
                        mydategridview.ColumnHeadersDefaultCellStyle.Font = myfont;
                        mydategridview.RowsDefaultCellStyle.Font = myfont;
                    }
                    else if (myctrl is System.Windows.Forms.Label)
                    {
                        Font myfont = new Font(myctrl.Font.FontFamily, myctrl.Height * 0.6f);
                        myctrl.Font = myfont;
                    }
                    else if (myctrl is ComboBox)
                    {
                        Font myfont = new Font(myctrl.Font.FontFamily, myctrl.Height * 0.7f);
                        myctrl.Font = myfont;
                    }
                    else if (myctrl is Controls.NumberText)
                    {
                        Font myfont = new Font(myctrl.Font.FontFamily, myctrl.Height * 0.55f);
                        myctrl.Font = myfont;
                    }
                    else if (myctrl is VBCbutton.CCCButton)
                    {
                        float myFontSize = myctrl.Height * 0.3f;
                        if (myFontSize < 10.5f)
                        {
                            myFontSize = 10.5f;
                        }
                        Font myfont = new Font(myctrl.Font.FontFamily, myFontSize);
                        myctrl.Font = myfont;
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print(ex.ToString());
            }
        }

        /// <summary>
        /// 检验时间是否颠倒
        /// </summary>
        /// <param name="datetimePickerStart"></param>
        /// <param name="datetimePickerEnd"></param>ool
        /// <param name="myPCDate"></param>
        protected bool CheckDateTime(DateTimePicker datetimePickerStart, DateTimePicker datetimePickerEnd,out string myPCDatestt, out string myPCDateend)
        {
            bool myCheckDateTime = false;
            //myPCDate = new string[2];
            myPCDatestt = datetimePickerStart.Value.ToString("yyyy-MM-dd"); //+ " 00:00:00";
            myPCDateend = datetimePickerEnd.Value.ToString("yyyy-MM-dd"); //+ " 23:59:59";
            TimeSpan ts = datetimePickerStart.Value.Subtract(datetimePickerEnd.Value);
            if (ts.Days > 0)
            {
                //string temp = myPCDate[1];
                //myPCDate[1] = myPCDate[0];
                //myPCDate[0] = temp;
                myPCDatestt = "";
                myPCDateend = "";
                MessageBox.Show("请输入正确的起止日期!", "ERROR");
            }
            else
            {
                myCheckDateTime = true;
            }


            return myCheckDateTime;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // FrmBase
            // 
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Name = "FrmBase";
            this.Load += new System.EventHandler(this.FrmBase_Load);
            this.ResumeLayout(false);
            this.Hide();

        }

        private void FrmBase_Load(object sender, EventArgs e)
        {

        }
    }
}
