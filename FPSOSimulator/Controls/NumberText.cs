using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FPSOSimulator.Controls
{
    public partial class NumberText : TextBox
    {
        public NumberText()
        {
            InitializeComponent();
        }

        public NumberText(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
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
    }
}
