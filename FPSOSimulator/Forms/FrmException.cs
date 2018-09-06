using System;
using System.Windows.Forms;
using System.Runtime.CompilerServices;

namespace FPSOSimulator.Forms
{
    class FrmException
    {
        /// <summary>
        /// 出错处理显示程序
        /// </summary>
        /// <param name="ex"></param>
        /// <param name="ClassName"></param>
        /// <param name="MethodName"></param>
        public static void ShowException(Exception ex, string ClassName = null, [CallerMemberName] string MethodName = null)
        {
            // --- build caption for COM exception message box ----------------------
            string strMessageBoxCaption = "Exception";
            if (!String.IsNullOrEmpty(ClassName) && !String.IsNullOrEmpty(MethodName))
                strMessageBoxCaption = ClassName + " --> " + MethodName;

            // --- build text for COM exception message box -------------------------
            string strExceptionMessage = ".NET Exception:" + Environment.NewLine +
                                         ex.Message + Environment.NewLine;

            // --- show message box -------------------------------------------------
            MessageBox.Show(strExceptionMessage, strMessageBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// 出错处理显示程序
        /// </summary>
        /// <param name="ex"></param>
        /// <param name="ClassName"></param>
        /// <param name="MethodName"></param>
        public static void ShowNormalButNoRecord(string content = null, string ClassName = null, string MethodName = null)
        {
            // --- build caption for COM exception message box ----------------------
            string strMessageBoxCaption = "No Record";
            if (!String.IsNullOrEmpty(ClassName) && !String.IsNullOrEmpty(MethodName))
                strMessageBoxCaption = ClassName + " --> " + MethodName;

            // --- build text for COM exception message box -------------------------
            string strExceptionMessage;
            if (!String.IsNullOrEmpty(content))
            {
                strExceptionMessage = content;
            }
            else
            {
                strExceptionMessage = "No Record:" + Environment.NewLine + "!!!";
            }
            // --- show message box -------------------------------------------------
            MessageBox.Show(strExceptionMessage, strMessageBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
