namespace FPSOSimulator.Forms
{
    partial class NFRMDefectHistory
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblSysName = new System.Windows.Forms.Label();
            this.pnlTop = new FPSOSimulator.Controls.CPanel(this.components);
            this.lblDate = new System.Windows.Forms.Label();
            this.btnBack = new VBCbutton.CCCButton();
            this.label2 = new System.Windows.Forms.Label();
            this.dGViewExcel = new System.Windows.Forms.DataGridView();
            this.cPanel2 = new FPSOSimulator.Controls.CPanel(this.components);
            this.cPanel1 = new FPSOSimulator.Controls.CPanel(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGViewExcel)).BeginInit();
            this.cPanel2.SuspendLayout();
            this.cPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSysName
            // 
            this.lblSysName.BackColor = System.Drawing.Color.Transparent;
            this.lblSysName.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSysName.ForeColor = System.Drawing.Color.Snow;
            this.lblSysName.Location = new System.Drawing.Point(103, 19);
            this.lblSysName.Name = "lblSysName";
            this.lblSysName.Size = new System.Drawing.Size(554, 26);
            this.lblSysName.TabIndex = 2;
            this.lblSysName.Text = " 设备参数设置 Equipment Parameter Setting";
            this.lblSysName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlTop.ClrOffSet = ((byte)(80));
            this.pnlTop.Controls.Add(this.lblDate);
            this.pnlTop.Controls.Add(this.btnBack);
            this.pnlTop.Controls.Add(this.lblSysName);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.MiddleClrOffSetPercent = 2;
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.showstyle = FPSOSimulator.Controls.CPanel.ShowStyle.ToMiddle;
            this.pnlTop.Size = new System.Drawing.Size(1600, 64);
            this.pnlTop.TabIndex = 18;
            this.pnlTop.UphtPercent = 10;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Snow;
            this.lblDate.Location = new System.Drawing.Point(1038, 19);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(244, 26);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "2016/12/07     Wednesday";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(3)))), ((int)(((byte)(33)))));
            this.btnBack.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(18)))), ((int)(((byte)(81)))));
            this.btnBack.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.ImageWidth = 18;
            this.btnBack.Location = new System.Drawing.Point(1343, 10);
            this.btnBack.Name = "btnBack";
            this.btnBack.Radius = 8;
            this.btnBack.Selected = false;
            this.btnBack.SetControlState = VBCbutton.CCCButton.ControlState.Normal;
            this.btnBack.SetRoundStyle = VBCbutton.CCCButton.RoundStyle.All;
            this.btnBack.Size = new System.Drawing.Size(156, 45);
            this.btnBack.TabIndex = 17;
            this.btnBack.Text = "返回主界面";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(20, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 26);
            this.label2.TabIndex = 24;
            this.label2.Text = "系统列表 System List";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dGViewExcel
            // 
            this.dGViewExcel.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dGViewExcel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dGViewExcel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGViewExcel.Location = new System.Drawing.Point(16, 48);
            this.dGViewExcel.Name = "dGViewExcel";
            this.dGViewExcel.ReadOnly = true;
            this.dGViewExcel.RowTemplate.Height = 23;
            this.dGViewExcel.Size = new System.Drawing.Size(383, 731);
            this.dGViewExcel.TabIndex = 25;
            // 
            // cPanel2
            // 
            this.cPanel2.ClrOffSet = ((byte)(25));
            this.cPanel2.Controls.Add(this.dGViewExcel);
            this.cPanel2.Controls.Add(this.label2);
            this.cPanel2.Location = new System.Drawing.Point(12, 81);
            this.cPanel2.MiddleClrOffSetPercent = 2;
            this.cPanel2.Name = "cPanel2";
            this.cPanel2.showstyle = FPSOSimulator.Controls.CPanel.ShowStyle.MainFrmPanel;
            this.cPanel2.Size = new System.Drawing.Size(413, 797);
            this.cPanel2.TabIndex = 26;
            this.cPanel2.UphtPercent = 10;
            // 
            // cPanel1
            // 
            this.cPanel1.ClrOffSet = ((byte)(25));
            this.cPanel1.Controls.Add(this.dataGridView1);
            this.cPanel1.Controls.Add(this.label3);
            this.cPanel1.Controls.Add(this.label1);
            this.cPanel1.Location = new System.Drawing.Point(443, 81);
            this.cPanel1.MiddleClrOffSetPercent = 2;
            this.cPanel1.Name = "cPanel1";
            this.cPanel1.showstyle = FPSOSimulator.Controls.CPanel.ShowStyle.MainFrmPanel;
            this.cPanel1.Size = new System.Drawing.Size(1145, 797);
            this.cPanel1.TabIndex = 27;
            this.cPanel1.UphtPercent = 10;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(485, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 26);
            this.label1.TabIndex = 26;
            this.label1.Text = "参数设置  Parameter Setting";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Visible = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(67, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(275, 26);
            this.label3.TabIndex = 26;
            this.label3.Text = "设备列表 Equipment List";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1107, 731);
            this.dataGridView1.TabIndex = 26;
            // 
            // NFRMDefectHistory
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.cPanel1);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.cPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NFRMDefectHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGViewExcel)).EndInit();
            this.cPanel2.ResumeLayout(false);
            this.cPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label lblSysName;
        private Controls.CPanel pnlTop;
        private System.Windows.Forms.Label lblDate;
        private VBCbutton.CCCButton btnBack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dGViewExcel;
        private Controls.CPanel cPanel2;
        private Controls.CPanel cPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;

        #endregion
        //private System.Windows.Forms.Timer TimerPlc;
        //private Controls.CPanel pnlTop;
        //private System.Windows.Forms.Label lblDate;
        //private System.Windows.Forms.Label lblSysName;
        //private VBCbutton.CCCButton btnBack;
        //private System.Windows.Forms.Label label4;
        //private System.Windows.Forms.PictureBox BackPicBox;
        //private System.Windows.Forms.DataGridView dGViewExcel;
        //private Controls.CPanel cPanel3;
        //private System.Windows.Forms.Label label2;
        //private Controls.CPanel cPanel2;
        //private System.Windows.Forms.PictureBox pictureBox5;
        //private System.Windows.Forms.Label label1;
        //private Controls.CPanel cPanel1;
        //private System.Windows.Forms.Label label3;
        //private System.Windows.Forms.Label label7;
        //private System.Windows.Forms.Label label6;
        //private System.Windows.Forms.DateTimePicker datetimePickerEnd;
        //private VBCbutton.CCCButton cccButton1;
        //private System.Windows.Forms.DateTimePicker datetimePickerStart;
        //private System.Windows.Forms.CheckedListBox checkedListBox1;
        //private System.Windows.Forms.CheckBox checkBox1;
        //private System.Windows.Forms.Label label5;
        //private System.Windows.Forms.CheckBox checkBox2;
        //private System.Windows.Forms.CheckBox checkBox3;
        //private System.Windows.Forms.CheckedListBox checkedListBox2;
        //private System.Windows.Forms.TextBox textBox2;
        //private System.Windows.Forms.TextBox textBox1;
        //private System.Windows.Forms.CheckBox checkBox5;
        //private System.Windows.Forms.CheckBox checkBox4;
        //private VBCbutton.CCCButton cccButton2;
        //private System.Windows.Forms.PictureBox pictureBox1;
    }
}

