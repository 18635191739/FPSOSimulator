
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace FPSOSimulator
{
    public class WriteLog
    {

        public  void  WriteLogs(string logText)
        {
            string strLogFilePath = "C:\\NCLog.log";
            using (System.IO.StreamWriter logWriter = System.IO.File.AppendText(strLogFilePath))
            {
                logWriter.Write(DateTime.Now.ToString() + ": ");
                logWriter.WriteLine(logText);
            }
        }
    }
}