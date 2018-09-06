
using FPSOSimulator.Forms;
using System;
using System.Diagnostics;
using System.IO;
namespace FPSOSimulator.MyClass
{
    public class FolderService
    {
        public static void GetDefectPics(int DefectCamIdx)
        {
            //int DefectCamIdx = 1;
            bool status = false;
            string MRemoteIP = null;
            //连接共享文件夹
            if (DefectCamIdx == 1 || DefectCamIdx == 2)
            {
                MRemoteIP = UserConfiguration.DefCamera[1].RemoteIP;
            }

            if (DefectCamIdx == 3 || DefectCamIdx == 4)
            {
                MRemoteIP = UserConfiguration.DefCamera[3].RemoteIP;
            }
            //连接共享文件夹
            string sharepath = @"\\" + MRemoteIP + @"\" + UserConfiguration.DefCamera[DefectCamIdx].ShareFoldName;
            //string sharepath1 = @"\\" + MRemoteIP + @"\" + UserConfiguration.DefCamera[DefectCamIdx + 1].ShareFoldName;
            //status = connectState(@sharepath, UserConfiguration.DefCamera[DefectCamIdx].UserName, UserConfiguration.DefCamera[DefectCamIdx].PassWord);
            //status = connectState(@sharepath, UserConfiguration.DefCamera[DefectCamIdx].UserName, UserConfiguration.DefCamera[DefectCamIdx].PassWord);
            //if (!IsProcessStart)
            //{
            //    StartProcess(@sharepath, UserConfiguration.DefCamera[DefectCamIdx].UserName, UserConfiguration.DefCamera[DefectCamIdx].PassWord);
            //    IsProcessStart = true;
            //}

            //if (IsProcessStart)
            //{
            //    if (!proc.HasExited)
            //    {
            //        //proc.Close();
            //        //proc.Dispose();
            //        //return Flag;
            //        //proc.WaitForExit(1000);
            //        status = connectState(@sharepath, UserConfiguration.DefCamera[DefectCamIdx].UserName, UserConfiguration.DefCamera[DefectCamIdx].PassWord);
            //        IsProcessStart = false;
            //    }

            //}
            //while (!proc.HasExited)
            //{
            //    proc.Close();
            //    proc.Dispose();
            //    return Flag;
            //    //proc.WaitForExit(1000);
            //}

            status = true;
            if (status)
            {
                //frmMain.ProductInfo[DefectCamIdx].FileAimPath = UserConfiguration.DefCamera[DefectCamIdx].AimPath + DateTime.Now.ToString("yyyyMM");
                //共享文件夹的目录
                DirectoryInfo theFolder = new DirectoryInfo(@sharepath);
                //DirectoryInfo theFolder1 = new DirectoryInfo(@sharepath1);
                //相对共享文件夹的路径
                //string fielpath = @"";//\CAMERA1_1.jpg

                //获取保存文件的路径
                //string filename = theFolder.ToString() + fielpath;
                //执行方法
                //Transport(@"\\192.168.1.20\defect", filename, "CAMERA1_1_copy.jpg");

                //const int filenum = 50;
                //string[] filename = new string[filenum];
                //int picnum = frmMain.ProductInfo[DefectCamIdx].LNKTOTAL;
                //for (int j = 1; j < picnum + 1; j++) //0表示无缺陷，其他有缺陷
                //{
                //    //存入缺陷图片信息
                //    filename[j] = frmMain.ProductInfo[DefectCamIdx].FAULTFILENAME[j - 1] + ".BMP";
                //}

                
                //CopyDir(theFolder.ToString(), frmMain.ProductInfo[DefectCamIdx].FileAimPath, filename, picnum, DefectCamIdx); //单个文件复制

                //int picnum_1 = frmMain.ProductInfo[DefectCamIdx + 1].LNKTOTAL;
                //for (int j = 1; j < picnum_1 + 1; j++) //0表示无缺陷，其他有缺陷
                //{
                //    //存入缺陷图片信息
                //    filename[j] = frmMain.ProductInfo[DefectCamIdx + 1].FAULTFILENAME[j - 1] + ".BMP";
                //}

                //frmMain.ProductInfo[DefectCamIdx+1].FileAimPath = UserConfiguration.DefCamera[DefectCamIdx+1].AimPath + DateTime.Now.ToString("yyyyMM");
                //CopyDir(theFolder1.ToString(), frmMain.ProductInfo[DefectCamIdx + 1].FileAimPath, filename, picnum_1, DefectCamIdx + 1); //单个文件复制

                frmMain.ispicsave[DefectCamIdx] = true;
            }
            else
            {
                //ListBox1.Items.Add("访问共享文件夹失败！");
            }
        }


        public static void GetDefectPics1()
        {

            int DefectCamIdx = 3;
            bool status = false;
            string MRemoteIP = null;
            //连接共享文件夹
            if (DefectCamIdx == 1 || DefectCamIdx == 2)
            {
                MRemoteIP = UserConfiguration.DefCamera[1].RemoteIP;
            }

            if (DefectCamIdx == 3 || DefectCamIdx == 4)
            {
                MRemoteIP = UserConfiguration.DefCamera[2].RemoteIP;
            }
            //连接共享文件夹
            string sharepath = @"\\" + MRemoteIP + @"\" + UserConfiguration.DefCamera[DefectCamIdx].ShareFoldName;
            string sharepath1 = @"\\" + MRemoteIP + @"\" + UserConfiguration.DefCamera[DefectCamIdx + 1].ShareFoldName;
            //status = connectState(@sharepath, UserConfiguration.DefCamera[DefectCamIdx].UserName, UserConfiguration.DefCamera[DefectCamIdx].PassWord);
            //status = connectState(@sharepath, UserConfiguration.DefCamera[DefectCamIdx].UserName, UserConfiguration.DefCamera[DefectCamIdx].PassWord);
            //if (!IsProcessStart1)
            //{
            //    StartProcess1(@sharepath, UserConfiguration.DefCamera[DefectCamIdx].UserName, UserConfiguration.DefCamera[DefectCamIdx].PassWord);
            //    IsProcessStart1 = true;
            //}

            //if (IsProcessStart1)
            //{
            //    if (!proc1.HasExited)
            //    {
            //        //proc.Close();
            //        //proc.Dispose();
            //        //return Flag;
            //        //proc.WaitForExit(1000);
            //        status = connectState1(@sharepath, UserConfiguration.DefCamera[DefectCamIdx].UserName, UserConfiguration.DefCamera[DefectCamIdx].PassWord);
            //        IsProcessStart1 = false;
            //    }

            //}
            //while (!proc.HasExited)
            //{
            //    proc.Close();
            //    proc.Dispose();
            //    return Flag;
            //    //proc.WaitForExit(1000);
            //}

            status = true;
            if (status)
            {
                //共享文件夹的目录
                DirectoryInfo theFolder = new DirectoryInfo(@sharepath);
                DirectoryInfo theFolder1 = new DirectoryInfo(@sharepath1);
                //相对共享文件夹的路径
                //string fielpath = @"";//\CAMERA1_1.jpg

                //获取保存文件的路径
                //string filename = theFolder.ToString() + fielpath;
                //执行方法
                //Transport(@"\\192.168.1.20\defect", filename, "CAMERA1_1_copy.jpg");

                //const int filenum = 20;
                //string[] filename = new string[filenum];
                //int picnum = frmMain.ProductInfo[DefectCamIdx].LNKTOTAL;
                //for (int j = 1; j < picnum + 1; j++) //0表示无缺陷，其他有缺陷
                //{
                //    //存入缺陷图片信息
                //    filename[j] = frmMain.ProductInfo[DefectCamIdx].FAULTFILENAME[j - 1] + ".BMP";
                //}

                //frmMain.ProductInfo[DefectCamIdx].FileAimPath = UserConfiguration.DefCamera[DefectCamIdx].AimPath + DateTime.Now.ToString("yyyyMM");
                //CopyDir(theFolder.ToString(), frmMain.ProductInfo[DefectCamIdx].FileAimPath, filename, picnum, DefectCamIdx); //单个文件复制

                //int picnum_1 = frmMain.ProductInfo[DefectCamIdx + 1].LNKTOTAL;
                //for (int j = 1; j < picnum_1 + 1; j++) //0表示无缺陷，其他有缺陷
                //{
                //    //存入缺陷图片信息
                //    filename[j] = frmMain.ProductInfo[DefectCamIdx + 1].FAULTFILENAME[j - 1] + ".BMP";
                //}

                //frmMain.ProductInfo[DefectCamIdx].FileAimPath = UserConfiguration.DefCamera[DefectCamIdx].AimPath + DateTime.Now.ToString("yyyyMM");
                //CopyDir(theFolder1.ToString(), frmMain.ProductInfo[DefectCamIdx + 1].FileAimPath, filename, picnum_1, DefectCamIdx + 1); //单个文件复制
                //frmMain.ispicsave[3] = true;
            }
            else
            {
                //ListBox1.Items.Add("访问共享文件夹失败！");
            }
        }



        /// <summary>
        /// 网络硬盘映射到本地
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void CopyMain(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("请输入源文件夹地址和目的文件夹地址！");
                return;
            }
            // 判断源文件夹是否存在              
            if (!Directory.Exists(args[0]))
            {
                Console.WriteLine("源文件夹不存在！");
                return;
            }
            // 拷贝文件夹              
            FolderService copy = new FolderService();
            string flag = copy.CopyFolder(args[0], args[1]);
            Console.WriteLine(flag);
        }
        /// <summary>          
        /// Copy文件夹          
        /// </summary>          
        /// <param name="sPath">源文件夹路径</param>          
        /// <param name="dPath">目的文件夹路径</param>          
        /// <returns>完成状态：success-完成；其他-报错</returns>          
        public string CopyFolder(string sPath, string dPath)
        {
            string flag = "success";
            try
            {
                // 创建目的文件夹                  
                if (!Directory.Exists(dPath))
                {
                    Directory.CreateDirectory
                   (dPath);
                }
                // 拷贝文件                  
                DirectoryInfo sDir = new DirectoryInfo(sPath);
                FileInfo[] fileArray = sDir.GetFiles();
                foreach (FileInfo file in fileArray)
                {
                    file.CopyTo(dPath + "\\" + file.Name, true);
                }
                // 循环子文件夹                  
                DirectoryInfo dDir = new DirectoryInfo(dPath);
                DirectoryInfo[] subDirArray = sDir.GetDirectories();
                foreach (DirectoryInfo subDir in subDirArray)
                {
                    CopyFolder(subDir.FullName, dPath + "//" + subDir.Name);
                }
            }
            catch (Exception ex)
            {
                flag = ex.ToString();
            }
            return flag;
        }

        public static bool connectState(string path)
        {
            return connectState(path, "", "");
        }
        /// <summary>
        /// 连接远程共享文件夹
        /// </summary>
        /// <param name="path">远程共享文件夹的路径</param>
        /// <param name="userName">用户名</param>
        /// <param name="passWord">密码</param>
        /// <returns></returns>
        public static Process proc = new Process();
        public static bool IsProcessStart = false;
        public static void StartProcess(string path, string userName, string passWord)
        {
            //try
            //{ 
            proc.StartInfo.FileName = "cmd.exe";
                proc.StartInfo.UseShellExecute = false;
                proc.StartInfo.RedirectStandardInput = true;
                proc.StartInfo.RedirectStandardOutput = true;
                proc.StartInfo.RedirectStandardError = true;
                proc.StartInfo.CreateNoWindow = true;
                proc.Start();
                string dosLine = "net use " + path + " " + passWord + " /user:" + userName;
                proc.StandardInput.WriteLine(dosLine);
                proc.StandardInput.WriteLine("exit");
            //}
            //catch (Exception)
            //{
            //    proc.Close();
            //    proc.Dispose();
            //    //throw;
            //}
           

        }


        public static bool connectState(string path, string userName, string passWord)
        {
            //passWord = "123456";
            bool Flag = false;
            //Process proc = new Process();
            try
            {
                //proc.StartInfo.FileName = "cmd.exe";
                //proc.StartInfo.UseShellExecute = false;
                //proc.StartInfo.RedirectStandardInput = true;
                //proc.StartInfo.RedirectStandardOutput = true;
                //proc.StartInfo.RedirectStandardError = true;
                //proc.StartInfo.CreateNoWindow = true;
                //proc.Start();
                //string dosLine = "net use " + path + " " + passWord + " /user:" + userName;
                //proc.StandardInput.WriteLine(dosLine);
                //proc.StandardInput.WriteLine("exit");
                //while (!proc.HasExited)
                //{
                //    proc.Close();
                //    proc.Dispose();
                //    return Flag;
                //    //proc.WaitForExit(1000);
                //}
                string errormsg = proc.StandardError.ReadToEnd();
                proc.StandardError.Close();
                if (string.IsNullOrEmpty(errormsg))
                {
                    Flag = true;
                }
                else
                {
                    //throw new Exception(errormsg);
                }
            }
            catch (Exception ex)
            {
                //throw ex;
            }
            finally
            {
                proc.Close();
                proc.Dispose();
            }
            return Flag;
        }


        public static Process proc1 = new Process();
        public static bool IsProcessStart1 = false;
        public static void StartProcess1(string path, string userName, string passWord)
        {
            proc1.StartInfo.FileName = "cmd.exe";
            proc1.StartInfo.UseShellExecute = false;
            proc1.StartInfo.RedirectStandardInput = true;
            proc1.StartInfo.RedirectStandardOutput = true;
            proc1.StartInfo.RedirectStandardError = true;
            proc1.StartInfo.CreateNoWindow = true;
            proc1.Start();
            string dosLine = "net use " + path + " " + passWord + " /user:" + userName;
            proc1.StandardInput.WriteLine(dosLine);
            proc1.StandardInput.WriteLine("exit");
        }


        public static bool connectState1(string path, string userName, string passWord)
        {
            //passWord = "123456";
            bool Flag = false;
            //Process proc = new Process();
            try
            {
                //proc.StartInfo.FileName = "cmd.exe";
                //proc.StartInfo.UseShellExecute = false;
                //proc.StartInfo.RedirectStandardInput = true;
                //proc.StartInfo.RedirectStandardOutput = true;
                //proc.StartInfo.RedirectStandardError = true;
                //proc.StartInfo.CreateNoWindow = true;
                //proc.Start();
                //string dosLine = "net use " + path + " " + passWord + " /user:" + userName;
                //proc.StandardInput.WriteLine(dosLine);
                //proc.StandardInput.WriteLine("exit");
                //while (!proc.HasExited)
                //{
                //    proc.Close();
                //    proc.Dispose();
                //    return Flag;
                //    //proc.WaitForExit(1000);
                //}
                string errormsg = proc1.StandardError.ReadToEnd();
                proc1.StandardError.Close();
                if (string.IsNullOrEmpty(errormsg))
                {
                    Flag = true;
                }
                else
                {
                    //throw new Exception(errormsg);
                }
            }
            catch (Exception ex)
            {
                //throw ex;
            }
            finally
            {
                proc1.Close();
                proc1.Dispose();
            }
            return Flag;
        }


        public static void CopyDir(string srcPath, string aimPath, string[] srcFileName, int filenum, int idx)//,string srcFileName
        {
            try
            {
                // 检查目标目录是否以目录分割字符结束如果不是则添加之
                if (aimPath[aimPath.Length - 1] != Path.DirectorySeparatorChar)
                    aimPath += Path.DirectorySeparatorChar;
                // 判断目标目录是否存在如果不存在则新建之
                if (!Directory.Exists(aimPath))
                    Directory.CreateDirectory(aimPath);
                // 得到源目录的文件列表，该里面是包含文件以及目录路径的一个数组
                //如果你指向copy目标文件下面的文件而不包含目录请使用下面的方法
                //string[] fileList = Directory.GetFiles(srcPath);
                string[] filepath = new string[5] { null, null, null, null, null };
                filepath[1] = @"\\PC1\BlobImgC1";
                filepath[2] = @"\\PC1\BlobImgC2";
                filepath[3] = @"\\PC2\BlobImgC3";
                filepath[4] = @"\\PC2\BlobImgC4";


                string[] fileList = Directory.GetFileSystemEntries(filepath[idx]);
                //string[] fileList = Directory.GetFileSystemEntries(srcPath);
                //int filenum = srcFileName.Length;
                //遍历所有的文件和目录
                foreach (string file in fileList)
                {
                    for (int i = 1; i < filenum + 1; i++)
                    {
                        string myfilename = filepath[idx] + "\\" + srcFileName[i];
                        if (file == myfilename)
                        {
                            //先当作目录处理如果存在这个目录就递归Copy该目录下面的文件
                            //if (idx ==4 )
                            //{
                            //    idx = idx;
                            //}
                            //frmMain.ProDefectImgInfo[idx, i].FileAimPath = aimPath + "\\" + srcFileName[i];
                            if (Directory.Exists(file))
                            {
                                CopyDir(file, aimPath + Path.GetFileName(file), srcFileName, filenum, idx);
                            }
                            else
                            {
                                //否则直接Copy文件
                                File.Copy(file, aimPath + Path.GetFileName(file), true);
                                
                                //frmMain.ProDefectImgInfo[idx, i].FileIsSaved = 1;
                            }

                        }
                    }

                }
            }
            catch (Exception ee)
            {
                string eestr = ee.ToString();
                //throw new Exception(ee.ToString());
            }
        }
    }
}