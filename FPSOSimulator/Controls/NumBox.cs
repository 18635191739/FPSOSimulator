using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace FPSOSimulator.Controls
{
    /// <summary>
    /// text box only for numbers
    /// </summary>
    public partial class NumBox : Ctextbox
    {
        private const int WM_PAINT = 0x000F;
        private const int WM_NCPAINT = 0x0085;
        private const int WM_CHAR = 0x0102;
        private const int WM_PASTE = 0x0302;
        /// <summary>
        /// number box
        /// </summary>
        public NumBox()
            : base()
        {                 
            this.ContextMenu = new ContextMenu();            
        }

        /// <summary>
        /// override win proc
        /// </summary>
        /// <param name="m"></param>
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == WM_PAINT || m.Msg == WM_NCPAINT)
            {
                RectPaint();
            }
        }

        private void ClearSelection() // 清除当前TextBox的选择
        {
            if (this.SelectionLength == 0)
            {
                return;
            }

            int selLength = this.SelectedText.Length;
            this.SelectionStart += this.SelectedText.Length;  // 光标在选择之后
            this.SelectionLength = 0;

            for (int k = 1; k <= selLength; k++)
            {
                this.DeleteText(Keys.Back);
            }
        }

        private void DeleteText(Keys key) // 删除字符并计算SelectionStart值
        {
            int selStart = this.SelectionStart;

            if (selStart == 0 || selStart > base.Text.Length)  // 不需要删除
            {
                return;
            }

            if (selStart == 1 && base.Text.Length == 1)
            {
                base.Text = "";
                base.SelectionStart = 0;
            }
            else   
            {
                base.Text = base.Text.Substring(0, selStart - 1) +
                    base.Text.Substring(selStart, base.Text.Length - selStart);
                base.SelectionStart = selStart - 1;
            }
        }

        /// <summary>
        /// over ride key press
        /// </summary>
        /// <param name="e"></param>
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Decimal && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Enter && e.KeyChar != (char)Keys.Delete 
                && e.KeyChar != (char)Keys.Tab && e.KeyChar != (char)Keys.End && e.KeyChar != (char)Keys.Escape && e.KeyChar != (char)Keys.Home)  // 非数字键, 放弃该输入
            {
                e.Handled = true;
                return;
            }
        }

        /// <summary>
        /// ctrl v process
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="keyData"></param>
        /// <returns></returns>
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys)Shortcut.CtrlV)  // 快捷键 Ctrl+V 粘贴操作
            {
                this.ClearSelection();

                string text = Clipboard.GetText();
                for (int k = 0; k < text.Length; k++) // can not use SendKeys.Send
                {
                    // 通过消息模拟键盘输入, SendKeys.Send()静态方法不行
                    SendCharKey(text[k]);
                }
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);

        }

        private void SendCharKey(char c)  // 通过消息模拟键盘录入
        {
            Message msg = new Message();

            msg.HWnd = this.Handle;
            msg.Msg = WM_CHAR;  // 输入键盘字符消息WM_CHAR 0x0102
            msg.WParam = (IntPtr)c;
            msg.LParam = IntPtr.Zero;

            base.WndProc(ref msg);
        }

        /// <summary>
        /// paint the rectangle
        /// </summary>
        private void RectPaint()
        {
            if (this.BorderWeight % 2 == 0)
            {
                this.BorderWeight -= 1;
                if (this.BorderWeight <= 0)
                {
                    this.BorderWeight = 1;
                }
            }
            using (Graphics g = Graphics.FromHwnd(this.Handle))
            {
                if (!this.Focused)
                {
                    using (Pen pen = new Pen(this.BorderColor, this.BorderWeight))
                    {
                        g.DrawRectangle(pen, 0, 0, Size.Width - 1, Size.Height - 1);
                    }
                }
                else
                {
                    using (Pen pen = new Pen(this.HotColor, this.BorderWeight))
                    {
                        g.DrawRectangle(pen, 0, 0, Size.Width - 1, Size.Height - 1);
                    }
                }
            }
        }
    }
}
