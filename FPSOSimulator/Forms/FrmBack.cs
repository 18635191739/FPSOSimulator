using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FPSOSimulator.Forms
{
    public partial class FrmBack : FrmBase
    {
        public FrmBack()
        {
            InitializeComponent();
            this.Size = new Size(0, 0); 
        }

        public override void FrmHide()
        {
            this.Hide();
        }

        public override void FrmShow()
        {
            base.FrmShow();
        }

        public override void FrmRefresh()
        {
            base.FrmRefresh();
        }

        public override void FrmInit()
        {
            base.FrmInit();
        }

        public override void FrmClose()
        {
            this.Close();
        }
    }
}
