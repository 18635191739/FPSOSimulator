using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FPSOSimulator.Controls
{
    /// <summary>
    /// prevent sprinkle
    /// </summary>
    public partial class CLabel : Label
    {
        /// <summary>
        /// constructure
        /// </summary>
        public CLabel()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer | ControlStyles.UserPaint, true);
            this.UpdateStyles();
        }
    }
}
