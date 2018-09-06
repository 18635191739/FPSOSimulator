using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace FPSOSimulator.Forms
{
    public partial class frm3DPic : Form
    {
        public frm3DPic()
        {
            InitializeComponent();
        }


        public void SetFormPara(int senderForm, int idx)
        {
            if (senderForm == 1)
            {

                //frmMain.ProDefectImgInfo.
                //for test
                //frmMain.ProDefectImgInfo[frmMain.SelectPicNum].FAULTWIDTH = 600;
                //frmMain.ProDefectImgInfo[frmMain.SelectPicNum].FAULTHEIGHT = 600;

                //int mywidth = frmMain.ProDefectImgInfo[idx, frmMain.SelectPicNum].FAULTWIDTH;
                //int myheight = frmMain.ProDefectImgInfo[idx, frmMain.SelectPicNum].FAULTHEIGHT;
                //BackPicBox.Size = new Size(mywidth, myheight);
                string apppath = System.Windows.Forms.Application.StartupPath;
                //BackPicBox.Image = Image.FromFile(apppath + "\\DefectPicturesTest" + "\\" + frmMain.ProDefectImgInfo[idx, frmMain.SelectPicNum].FAULTFILENAME + ".jpg");
                //string aimpath = frmMain.ProDefectImgInfo[idx, frmMain.SelectPicNum].FileAimPath;


            }
            else
            {


                int mywidth = NFRMDefectHistory.ProDefectImgInfo[idx, NFRMDefectHistory.SelectPicNum].FAULTWIDTH;
                int myheight = NFRMDefectHistory.ProDefectImgInfo[idx, NFRMDefectHistory.SelectPicNum].FAULTHEIGHT;
                //BackPicBox.Size = new Size(mywidth, myheight);
                string apppath = System.Windows.Forms.Application.StartupPath;
                //BackPicBox.Image = Image.FromFile(apppath + "\\DefectPicturesTest" + "\\" + NFRMDefectHistory.ProDefectImgInfo[idx, NFRMDefectHistory.SelectPicNum].FAULTFILENAME + ".jpg");
                string aimpath = NFRMDefectHistory.ProDefectImgInfo[idx, NFRMDefectHistory.SelectPicNum].FileAimPath;

                //if (File.Exists(aimpath))
                //{
                //    BackPicBox.Image = Image.FromFile(aimpath);
                //}
                //else
                //{
                //    BackPicBox.Image = Image.FromFile(apppath + "\\" + "FaultPic.jpg");
                //}


            }
        }

        public   void show3dpic(int senderForm, int idx)
        {
            string aimpath = "";
            string apppath = System.Windows.Forms.Application.StartupPath;
            if (senderForm == 1)
            {

                //frmMain.ProDefectImgInfo.
                //for test
                //frmMain.ProDefectImgInfo[frmMain.SelectPicNum].FAULTWIDTH = 600;
                //frmMain.ProDefectImgInfo[frmMain.SelectPicNum].FAULTHEIGHT = 600;

                //int mywidth = frmMain.ProDefectImgInfo[idx, frmMain.SelectPicNum].FAULTWIDTH;
                //int myheight = frmMain.ProDefectImgInfo[idx, frmMain.SelectPicNum].FAULTHEIGHT;
                //BackPicBox.Size = new Size(mywidth, myheight);
                //string apppath = System.Windows.Forms.Application.StartupPath;
                //BackPicBox.Image = Image.FromFile(apppath + "\\DefectPicturesTest" + "\\" + frmMain.ProDefectImgInfo[idx, frmMain.SelectPicNum].FAULTFILENAME + ".jpg");
                 //aimpath = frmMain.ProDefectImgInfo[idx, frmMain.SelectPicNum].FileAimPath;


            }
            else
            {


                //int mywidth = NFRMDefectHistory.ProDefectImgInfo[idx, NFRMDefectHistory.SelectPicNum].FAULTWIDTH;
                //int myheight = NFRMDefectHistory.ProDefectImgInfo[idx, NFRMDefectHistory.SelectPicNum].FAULTHEIGHT;
                //BackPicBox.Size = new Size(mywidth, myheight);
                //string apppath = System.Windows.Forms.Application.StartupPath;
                //BackPicBox.Image = Image.FromFile(apppath + "\\DefectPicturesTest" + "\\" + NFRMDefectHistory.ProDefectImgInfo[idx, NFRMDefectHistory.SelectPicNum].FAULTFILENAME + ".jpg");
                 aimpath = NFRMDefectHistory.ProDefectImgInfo[idx, NFRMDefectHistory.SelectPicNum].FileAimPath;


            }

            if (!File.Exists(aimpath))
            {
                aimpath = apppath + "\\" + "FaultPic.jpg";
            }
            string tempname = "tpic" + DateTime.Now.ToString("yyyyMMddHHmmss");
            //图片格式转化：因为gnuplot不支持.bmp，如果甲方只能提供.bmp,则需要转化一下。
            System.Drawing.Bitmap bm = new System.Drawing.Bitmap(aimpath);
            bm.Save("c:\\temp\\quexian1.gif", System.Drawing.Imaging.ImageFormat.Gif);//把bmp转成gif 
            bm.Dispose();

            string cmdStr1 = "C:\\Progra~1\\gnuplot\\bin\\gnuplot.exe \"c:/temp/quexian.gnu\"";
            txtResult.Text = Wuya.GetDosCommandOutput.DosCommandOutput.Execute(cmdStr1);//不显示命令窗口地执行DOS命令。


            //显示获得的3D图片
            FileStream pFileStream2 = new FileStream("c:\\temp\\3dquexian.GIF", FileMode.Open, FileAccess.Read);
            pictureBox1.Image = Image.FromStream(pFileStream2);
            pFileStream2.Close();
            pFileStream2.Dispose();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            ////图片格式转化：因为gnuplot不支持.bmp，如果甲方只能提供.bmp,则需要转化一下。
            //System.Drawing.Bitmap bm = new System.Drawing.Bitmap("c:\\temp\\quexian1.bmp");
            //bm.Save("c:\\temp\\quexian1.gif", System.Drawing.Imaging.ImageFormat.Gif);//把bmp转成gif 
            //bm.Dispose();

            //string cmdStr1 = "C:\\Progra~1\\gnuplot\\bin\\gnuplot.exe \"c:/temp/quexian.gnu\"";
            //txtResult.Text = Wuya.GetDosCommandOutput.DosCommandOutput.Execute(cmdStr1);//不显示命令窗口地执行DOS命令。


            ////显示获得的3D图片
            //FileStream pFileStream2 = new FileStream("c:\\temp\\3dquexian.GIF", FileMode.Open, FileAccess.Read);
            //pictureBox1.Image = Image.FromStream(pFileStream2);
            //pFileStream2.Close();
            //pFileStream2.Dispose();
        }


    }
}




namespace Wuya.GetDosCommandOutput
{
    /// <summary>
    /// DOS命令输出类
    /// </summary>
    class DosCommandOutput
    {
        /// <summary>
        /// 执行DOS命令，返回DOS命令的输出
        /// </summary>
        /// <param name="dosCommand">dos命令</param>
        /// <returns>返回输出，如果发生异常，返回空字符串</returns>
        public static string Execute(string dosCommand)
        {
            return Execute(dosCommand, 60 * 1000);
        }
        /// <summary>
        /// 执行DOS命令，返回DOS命令的输出
        /// </summary>
        /// <param name="dosCommand">dos命令</param>
        /// <param name="milliseconds">等待命令执行的时间（单位：毫秒），如果设定为0，则无限等待</param>
        /// <returns>返回输出，如果发生异常，返回空字符串</returns>
        public static string Execute(string dosCommand, int milliseconds)
        {
            string output = "";     //输出字符串
            if (dosCommand != null && dosCommand != "")
            {
                Process process = new Process();     //创建进程对象
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = "cmd.exe";      //设定需要执行的命令
                startInfo.Arguments = "/C " + dosCommand;   //设定参数，其中的“/C”表示执行完命令后马上退出
                startInfo.UseShellExecute = false;     //不使用系统外壳程序启动
                startInfo.RedirectStandardInput = false;   //不重定向输入
                startInfo.RedirectStandardOutput = true;   //重定向输出
                startInfo.CreateNoWindow = true;     //不创建窗口
                process.StartInfo = startInfo;
                try
                {
                    if (process.Start())       //开始进程
                    {
                        if (milliseconds == 0)
                            process.WaitForExit();     //这里无限等待进程结束
                        else
                            process.WaitForExit(milliseconds);  //这里等待进程结束，等待时间为指定的毫秒
                        output = process.StandardOutput.ReadToEnd();//读取进程的输出
                    }
                }
                catch
                {
                }
                finally
                {
                    if (process != null)
                        process.Close();
                }
            }
            return output;
        }
    }
}