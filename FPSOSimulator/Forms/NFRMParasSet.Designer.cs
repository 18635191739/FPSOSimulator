namespace FPSOSimulator.Forms
{
    partial class NFRMParasSet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlTop = new FPSOSimulator.Controls.CPanel(this.components);
            this.lblDate = new System.Windows.Forms.Label();
            this.btnBack = new VBCbutton.CCCButton();
            this.lblSysName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cccButton1 = new VBCbutton.CCCButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtPort = new System.Windows.Forms.TextBox();
            this.TxtIp = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cccButton2 = new VBCbutton.CCCButton();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.cccButton3 = new VBCbutton.CCCButton();
            this.cccButton4 = new VBCbutton.CCCButton();
            this.cccButton5 = new VBCbutton.CCCButton();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.cccButton6 = new VBCbutton.CCCButton();
            this.cccButton7 = new VBCbutton.CCCButton();
            this.pnlTop.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
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
            this.pnlTop.Size = new System.Drawing.Size(1620, 64);
            this.pnlTop.TabIndex = 23;
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
            this.btnBack.Location = new System.Drawing.Point(1500, 12);
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
            // lblSysName
            // 
            this.lblSysName.BackColor = System.Drawing.Color.Transparent;
            this.lblSysName.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSysName.ForeColor = System.Drawing.Color.Snow;
            this.lblSysName.Location = new System.Drawing.Point(109, 21);
            this.lblSysName.Name = "lblSysName";
            this.lblSysName.Size = new System.Drawing.Size(554, 26);
            this.lblSysName.TabIndex = 2;
            this.lblSysName.Text = "工作参数设定";
            this.lblSysName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(213, 1030);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 26);
            this.label1.TabIndex = 25;
            this.label1.Text = "数据库历史数据删除间隔设置：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Visible = false;
            // 
            // cccButton1
            // 
            this.cccButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(3)))), ((int)(((byte)(33)))));
            this.cccButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(18)))), ((int)(((byte)(81)))));
            this.cccButton1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cccButton1.ForeColor = System.Drawing.Color.White;
            this.cccButton1.ImageWidth = 18;
            this.cccButton1.Location = new System.Drawing.Point(1190, 1030);
            this.cccButton1.Name = "cccButton1";
            this.cccButton1.Radius = 8;
            this.cccButton1.Selected = false;
            this.cccButton1.SetControlState = VBCbutton.CCCButton.ControlState.Normal;
            this.cccButton1.SetRoundStyle = VBCbutton.CCCButton.RoundStyle.All;
            this.cccButton1.Size = new System.Drawing.Size(93, 36);
            this.cccButton1.TabIndex = 26;
            this.cccButton1.Text = "保存";
            this.cccButton1.UseVisualStyleBackColor = false;
            this.cccButton1.Visible = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.radioButton1.ForeColor = System.Drawing.Color.White;
            this.radioButton1.Location = new System.Drawing.Point(34, 39);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(91, 27);
            this.radioButton1.TabIndex = 33;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "三个月";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.radioButton2.ForeColor = System.Drawing.Color.White;
            this.radioButton2.Location = new System.Drawing.Point(173, 38);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(70, 27);
            this.radioButton2.TabIndex = 34;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "半年";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.radioButton3.ForeColor = System.Drawing.Color.White;
            this.radioButton3.Location = new System.Drawing.Point(291, 39);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(70, 27);
            this.radioButton3.TabIndex = 35;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "一年";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(569, 991);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 100);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "请选择";
            this.groupBox1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(224, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 26);
            this.label2.TabIndex = 37;
            this.label2.Text = "工控机客户端通信设置：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(361, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 23);
            this.label3.TabIndex = 41;
            this.label3.Text = "端口";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(122, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 23);
            this.label4.TabIndex = 40;
            this.label4.Text = "服务IP";
            // 
            // TxtPort
            // 
            this.TxtPort.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtPort.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.TxtPort.Location = new System.Drawing.Point(419, 41);
            this.TxtPort.Name = "TxtPort";
            this.TxtPort.Size = new System.Drawing.Size(78, 31);
            this.TxtPort.TabIndex = 38;
            // 
            // TxtIp
            // 
            this.TxtIp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtIp.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.TxtIp.Location = new System.Drawing.Point(206, 41);
            this.TxtIp.Name = "TxtIp";
            this.TxtIp.Size = new System.Drawing.Size(136, 31);
            this.TxtIp.TabIndex = 39;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.TxtPort);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.TxtIp);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(521, 227);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(610, 190);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(20, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 23);
            this.label6.TabIndex = 47;
            this.label6.Text = "工控机2：";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(122, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 23);
            this.label7.TabIndex = 45;
            this.label7.Text = "服务IP";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(419, 107);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(78, 31);
            this.textBox1.TabIndex = 43;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(361, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 23);
            this.label8.TabIndex = 46;
            this.label8.Text = "端口";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBox2.Location = new System.Drawing.Point(206, 107);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(136, 31);
            this.textBox2.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(20, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 23);
            this.label5.TabIndex = 42;
            this.label5.Text = "工控机1：";
            // 
            // cccButton2
            // 
            this.cccButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(3)))), ((int)(((byte)(33)))));
            this.cccButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(18)))), ((int)(((byte)(81)))));
            this.cccButton2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cccButton2.ForeColor = System.Drawing.Color.White;
            this.cccButton2.ImageWidth = 18;
            this.cccButton2.Location = new System.Drawing.Point(1313, 293);
            this.cccButton2.Name = "cccButton2";
            this.cccButton2.Radius = 8;
            this.cccButton2.Selected = false;
            this.cccButton2.SetControlState = VBCbutton.CCCButton.ControlState.Normal;
            this.cccButton2.SetRoundStyle = VBCbutton.CCCButton.RoundStyle.All;
            this.cccButton2.Size = new System.Drawing.Size(93, 36);
            this.cccButton2.TabIndex = 43;
            this.cccButton2.Text = "保存";
            this.cccButton2.UseVisualStyleBackColor = false;
            this.cccButton2.Click += new System.EventHandler(this.cccButton2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Snow;
            this.label9.Location = new System.Drawing.Point(270, 616);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(219, 26);
            this.label9.TabIndex = 44;
            this.label9.Text = "缺陷图片显示设置：";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.textBox7);
            this.groupBox3.Controls.Add(this.textBox8);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.textBox4);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.textBox5);
            this.groupBox3.Controls.Add(this.textBox6);
            this.groupBox3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(521, 508);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(610, 238);
            this.groupBox3.TabIndex = 48;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "单位：像素";
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(441, 173);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(52, 23);
            this.label17.TabIndex = 57;
            this.label17.Text = "高度";
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(220, 173);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(52, 23);
            this.label18.TabIndex = 56;
            this.label18.Text = "宽度";
            // 
            // textBox7
            // 
            this.textBox7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox7.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBox7.Location = new System.Drawing.Point(502, 165);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(78, 31);
            this.textBox7.TabIndex = 54;
            // 
            // textBox8
            // 
            this.textBox8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox8.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBox8.Location = new System.Drawing.Point(283, 165);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(86, 31);
            this.textBox8.TabIndex = 55;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(44, 173);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(157, 23);
            this.label16.TabIndex = 53;
            this.label16.Text = "缺陷重叠区域：";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(428, 112);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 23);
            this.label11.TabIndex = 52;
            this.label11.Text = "Y_MAX";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(207, 112);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 23);
            this.label12.TabIndex = 51;
            this.label12.Text = "X_MAX";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBox3.Location = new System.Drawing.Point(502, 108);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(78, 31);
            this.textBox3.TabIndex = 49;
            // 
            // textBox4
            // 
            this.textBox4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBox4.Location = new System.Drawing.Point(283, 108);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(86, 31);
            this.textBox4.TabIndex = 50;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(428, 51);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 23);
            this.label15.TabIndex = 48;
            this.label15.Text = "Y_MAX";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(44, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 23);
            this.label10.TabIndex = 47;
            this.label10.Text = "相机坐标系：";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(44, 51);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(136, 23);
            this.label13.TabIndex = 42;
            this.label13.Text = "底图坐标系：";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(207, 51);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 23);
            this.label14.TabIndex = 40;
            this.label14.Text = "X_MAX";
            // 
            // textBox5
            // 
            this.textBox5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBox5.Location = new System.Drawing.Point(502, 47);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(78, 31);
            this.textBox5.TabIndex = 38;
            // 
            // textBox6
            // 
            this.textBox6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBox6.Location = new System.Drawing.Point(283, 47);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(86, 31);
            this.textBox6.TabIndex = 39;
            // 
            // cccButton3
            // 
            this.cccButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(3)))), ((int)(((byte)(33)))));
            this.cccButton3.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(18)))), ((int)(((byte)(81)))));
            this.cccButton3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cccButton3.ForeColor = System.Drawing.Color.White;
            this.cccButton3.ImageWidth = 18;
            this.cccButton3.Location = new System.Drawing.Point(1313, 559);
            this.cccButton3.Name = "cccButton3";
            this.cccButton3.Radius = 8;
            this.cccButton3.Selected = false;
            this.cccButton3.SetControlState = VBCbutton.CCCButton.ControlState.Normal;
            this.cccButton3.SetRoundStyle = VBCbutton.CCCButton.RoundStyle.All;
            this.cccButton3.Size = new System.Drawing.Size(93, 36);
            this.cccButton3.TabIndex = 49;
            this.cccButton3.Text = "保存";
            this.cccButton3.UseVisualStyleBackColor = false;
            this.cccButton3.Click += new System.EventHandler(this.cccButton3_Click);
            // 
            // cccButton4
            // 
            this.cccButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(3)))), ((int)(((byte)(33)))));
            this.cccButton4.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(18)))), ((int)(((byte)(81)))));
            this.cccButton4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cccButton4.ForeColor = System.Drawing.Color.White;
            this.cccButton4.ImageWidth = 18;
            this.cccButton4.Location = new System.Drawing.Point(1173, 293);
            this.cccButton4.Name = "cccButton4";
            this.cccButton4.Radius = 8;
            this.cccButton4.Selected = false;
            this.cccButton4.SetControlState = VBCbutton.CCCButton.ControlState.Normal;
            this.cccButton4.SetRoundStyle = VBCbutton.CCCButton.RoundStyle.All;
            this.cccButton4.Size = new System.Drawing.Size(93, 36);
            this.cccButton4.TabIndex = 50;
            this.cccButton4.Text = "修改";
            this.cccButton4.UseVisualStyleBackColor = false;
            this.cccButton4.Click += new System.EventHandler(this.cccButton4_Click);
            // 
            // cccButton5
            // 
            this.cccButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(3)))), ((int)(((byte)(33)))));
            this.cccButton5.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(18)))), ((int)(((byte)(81)))));
            this.cccButton5.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cccButton5.ForeColor = System.Drawing.Color.White;
            this.cccButton5.ImageWidth = 18;
            this.cccButton5.Location = new System.Drawing.Point(1173, 559);
            this.cccButton5.Name = "cccButton5";
            this.cccButton5.Radius = 8;
            this.cccButton5.Selected = false;
            this.cccButton5.SetControlState = VBCbutton.CCCButton.ControlState.Normal;
            this.cccButton5.SetRoundStyle = VBCbutton.CCCButton.RoundStyle.All;
            this.cccButton5.Size = new System.Drawing.Size(93, 36);
            this.cccButton5.TabIndex = 51;
            this.cccButton5.Text = "修改";
            this.cccButton5.UseVisualStyleBackColor = false;
            this.cccButton5.Click += new System.EventHandler(this.cccButton5_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Snow;
            this.label19.Location = new System.Drawing.Point(155, 859);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(311, 26);
            this.label19.TabIndex = 52;
            this.label19.Text = "连续不良工件个数阈值设置：";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox9
            // 
            this.textBox9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox9.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBox9.Location = new System.Drawing.Point(491, 858);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(86, 31);
            this.textBox9.TabIndex = 58;
            // 
            // cccButton6
            // 
            this.cccButton6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(3)))), ((int)(((byte)(33)))));
            this.cccButton6.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(18)))), ((int)(((byte)(81)))));
            this.cccButton6.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cccButton6.ForeColor = System.Drawing.Color.White;
            this.cccButton6.ImageWidth = 18;
            this.cccButton6.Location = new System.Drawing.Point(720, 853);
            this.cccButton6.Name = "cccButton6";
            this.cccButton6.Radius = 8;
            this.cccButton6.Selected = false;
            this.cccButton6.SetControlState = VBCbutton.CCCButton.ControlState.Normal;
            this.cccButton6.SetRoundStyle = VBCbutton.CCCButton.RoundStyle.All;
            this.cccButton6.Size = new System.Drawing.Size(93, 36);
            this.cccButton6.TabIndex = 60;
            this.cccButton6.Text = "修改";
            this.cccButton6.UseVisualStyleBackColor = false;
            this.cccButton6.Click += new System.EventHandler(this.cccButton6_Click);
            // 
            // cccButton7
            // 
            this.cccButton7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(3)))), ((int)(((byte)(33)))));
            this.cccButton7.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(18)))), ((int)(((byte)(81)))));
            this.cccButton7.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cccButton7.ForeColor = System.Drawing.Color.White;
            this.cccButton7.ImageWidth = 18;
            this.cccButton7.Location = new System.Drawing.Point(860, 853);
            this.cccButton7.Name = "cccButton7";
            this.cccButton7.Radius = 8;
            this.cccButton7.Selected = false;
            this.cccButton7.SetControlState = VBCbutton.CCCButton.ControlState.Normal;
            this.cccButton7.SetRoundStyle = VBCbutton.CCCButton.RoundStyle.All;
            this.cccButton7.Size = new System.Drawing.Size(93, 36);
            this.cccButton7.TabIndex = 59;
            this.cccButton7.Text = "保存";
            this.cccButton7.UseVisualStyleBackColor = false;
            this.cccButton7.Click += new System.EventHandler(this.cccButton7_Click);
            // 
            // NFRMParasSet
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1620, 920);
            this.Controls.Add(this.cccButton6);
            this.Controls.Add(this.cccButton7);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.cccButton5);
            this.Controls.Add(this.cccButton4);
            this.Controls.Add(this.cccButton3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cccButton2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cccButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "NFRMParasSet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "NFRMParasSet";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private Controls.CPanel pnlTop;
        private System.Windows.Forms.Label lblDate;
        private VBCbutton.CCCButton btnBack;
        private System.Windows.Forms.Label lblSysName;
        private System.Windows.Forms.Label label1;
        private VBCbutton.CCCButton cccButton1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtPort;
        private System.Windows.Forms.TextBox TxtIp;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private VBCbutton.CCCButton cccButton2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private VBCbutton.CCCButton cccButton3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label16;
        private VBCbutton.CCCButton cccButton4;
        private VBCbutton.CCCButton cccButton5;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBox9;
        private VBCbutton.CCCButton cccButton6;
        private VBCbutton.CCCButton cccButton7;
    }
}