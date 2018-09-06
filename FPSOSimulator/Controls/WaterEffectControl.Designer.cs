namespace FPSOSimulator.Controls
{
    partial class WaterEffectControl
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Timer effectTimer;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            _bmp.UnlockBits(_bmpBitmapData);
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }


        #region 组件设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.effectTimer = new System.Windows.Forms.Timer(this.components);
            // 
            // effectTimer
            // 
            this.effectTimer.Tick += new System.EventHandler(this.effectTimer_Tick);
            // 
            // WaterEffectControl
            // 
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.WaterEffectControl_Paint);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.WaterEffectControl_MouseMove);

        }

        #endregion
    }
}
