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
    /// textbox override
    /// </summary>
    [ToolboxItem(true)]
    public partial class Ctextbox : TextBox
    {
        private const int WM_PAINT = 0x000F;
        private const int WM_NCPAINT = 0x0085;
        private const int WM_CHAR = 0x0102;
        private const int WM_PASTE = 0x0302;

        /// <summary>
        /// constructure
        /// </summary>
        public Ctextbox()
        {
            InitializeComponent();
            //this.ContextMenu = new ContextMenu();
            this.BorderStyle = BorderStyle.FixedSingle;
            this.Multiline = true;
        }

        private Color mBorderColor = Color.Black;
        /// <summary>
        /// set bordercolor
        /// </summary>
        public Color BorderColor
        {
            get
            {
                return mBorderColor;
            }
            set
            {
                mBorderColor = value;
            }
        }

        private int mBorderWeight = 2;
        /// <summary>
        /// border width
        /// </summary>
        public int BorderWeight
        {
            get
            {
                return mBorderWeight;
            }
            set
            {
                mBorderWeight = value;
                this.Invalidate();
            }
        }

        private Color _HotColor = Color.Blue;
        /// <summary>
        /// hot color
        /// </summary>
        [Category("Appearance"),
         Description("Hot color, Only for BorderStyle equal FixedSingle"),
         DefaultValue(typeof(Color), "#996699")]
        public Color HotColor
        {
            get
            {
                return this._HotColor;
            }
            set
            {
                this._HotColor = value;
                this.Invalidate();
            }
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

        //private void ClearSelection() // 清除当前TextBox的选择
        //{
        //    if (this.SelectionLength == 0)
        //    {
        //        return;
        //    }

        //    int selLength = this.SelectedText.Length;
        //    this.SelectionStart += this.SelectedText.Length;  // 光标在选择之后
        //    this.SelectionLength = 0;

        //    for (int k = 1; k <= selLength; k++)
        //    {
        //        this.DeleteText(Keys.Back);
        //    }
        //}
        
        //private void DeleteText(Keys key) // 删除字符并计算SelectionStart值
        //{
        //    int selStart = this.SelectionStart;

        //    if (selStart == 0 || selStart > base.Text.Length)  // 不需要删除
        //    {
        //        return;
        //    }

        //    if (selStart == 1 && base.Text.Length == 1)
        //    {
        //        base.Text = "";
        //        base.SelectionStart = 0;
        //    }
        //    else  // selStart > 0
        //    {
        //        base.Text = base.Text.Substring(0, selStart - 1) +
        //            base.Text.Substring(selStart, base.Text.Length - selStart);
        //        base.SelectionStart = selStart - 1;
        //    }
        //}

        /// <summary>
        /// over ride key press 输入enter后不加到text中
        /// </summary>
        /// <param name="e"></param>
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
            }
        }

        //protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        //{
        //    if (keyData == (Keys)Shortcut.CtrlV)  // 快捷键 Ctrl+V 粘贴操作
        //    {
        //        this.ClearSelection();

        //        string text = Clipboard.GetText();
        //        for (int k = 0; k < text.Length; k++) // can not use SendKeys.Send
        //        {
        //            // 通过消息模拟键盘输入, SendKeys.Send()静态方法不行
        //            SendCharKey(text[k]);
        //        }
        //        return true;
        //    }
        //    return base.ProcessCmdKey(ref msg, keyData);

        //}

        //private void SendCharKey(char c)  // 通过消息模拟键盘录入
        //{
        //    Message msg = new Message();

        //    msg.HWnd = this.Handle;
        //    msg.Msg = WM_CHAR;  // 输入键盘字符消息WM_CHAR 0x0102
        //    msg.WParam = (IntPtr)c;
        //    msg.LParam = IntPtr.Zero;

        //    base.WndProc(ref msg);
        //}

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
