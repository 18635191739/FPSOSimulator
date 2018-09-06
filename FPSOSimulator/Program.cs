using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using FPSOSimulator.FormInquire;
using FPSOSimulator.Forms;
using System.Threading;

namespace FPSOSimulator
{
    static class Program
    {

        private static string tbName = "datatable2016";
        public static S7OPCACCCESS.S7OPCACC s7Server;

        /// <summary>
        /// 包含的窗体刷新控制实例,一个程序只能创建一个实例
        /// </summary>
        public static FrmFresh myFrmFresh = FrmFresh.GetFrmFresh();

        /// <summary>
        /// 窗体查询刷新实例
        /// </summary>
        public static InquireRefresher myInquireRefresher = new InquireRefresher();
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            s7Server = new S7OPCACCCESS.S7OPCACC();
            bool newThread;
            using (Mutex mutex = new Mutex(true, Application.ProductName, out newThread))
            {
                if (newThread)
                {
                    Application.EnableVisualStyles();
                    myFrmFresh.InitForms();
                    myFrmFresh.myFrmBack.FrmHide();
                    myInquireRefresher.TbName = tbName;

                    Application.Run(myFrmFresh.myFrmBack);




                }
                else
                {
                    MessageBox.Show("程序已在运行中...");
                    Thread.Sleep(1000);
                    System.Environment.Exit(1);
                }
            }
        }
    }
}
