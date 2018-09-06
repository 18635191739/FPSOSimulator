namespace FPSOSimulator.Forms
{
    partial class NFRMAlarm
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
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cccButton4 = new VBCbutton.CCCButton();
            this.cccButton1 = new VBCbutton.CCCButton();
            this.pnlTop.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.pnlTop.Size = new System.Drawing.Size(1680, 64);
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
            this.lblSysName.Text = "系统警报";
            this.lblSysName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(279, 383);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 26);
            this.label4.TabIndex = 51;
            this.label4.Text = "工控机4异常标志";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(279, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 26);
            this.label2.TabIndex = 52;
            this.label2.Text = "工控机2异常标志";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(279, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 26);
            this.label3.TabIndex = 53;
            this.label3.Text = "工控机3异常标志";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(279, 433);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 26);
            this.label5.TabIndex = 54;
            this.label5.Text = "相机1异常标志";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(279, 483);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 26);
            this.label6.TabIndex = 55;
            this.label6.Text = "相机2异常标志";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(279, 533);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 26);
            this.label7.TabIndex = 56;
            this.label7.Text = "相机3异常标志";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(1040, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(196, 26);
            this.label8.TabIndex = 57;
            this.label8.Text = "连续不良工件标志";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(279, 583);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 26);
            this.label9.TabIndex = 58;
            this.label9.Text = "相机4异常标志";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(279, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 26);
            this.label1.TabIndex = 59;
            this.label1.Text = "工控机1异常标志";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.LightSlateGray;
            this.label10.Location = new System.Drawing.Point(214, 233);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 20);
            this.label10.TabIndex = 60;
            this.label10.Text = "    ";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.LightSlateGray;
            this.label11.Location = new System.Drawing.Point(214, 283);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 20);
            this.label11.TabIndex = 61;
            this.label11.Text = "    ";
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.LightSlateGray;
            this.label12.Location = new System.Drawing.Point(214, 333);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 20);
            this.label12.TabIndex = 62;
            this.label12.Text = "    ";
            this.label12.Visible = false;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.LightSlateGray;
            this.label13.Location = new System.Drawing.Point(214, 383);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 20);
            this.label13.TabIndex = 63;
            this.label13.Text = "    ";
            this.label13.Visible = false;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.LightSlateGray;
            this.label14.Location = new System.Drawing.Point(214, 433);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(28, 20);
            this.label14.TabIndex = 64;
            this.label14.Text = "    ";
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.LightSlateGray;
            this.label15.Location = new System.Drawing.Point(214, 483);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(28, 20);
            this.label15.TabIndex = 65;
            this.label15.Text = "    ";
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.LightSlateGray;
            this.label16.Location = new System.Drawing.Point(214, 533);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(28, 20);
            this.label16.TabIndex = 66;
            this.label16.Text = "    ";
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.LightSlateGray;
            this.label17.Location = new System.Drawing.Point(214, 583);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(28, 20);
            this.label17.TabIndex = 67;
            this.label17.Text = "    ";
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.LightSlateGray;
            this.label18.Location = new System.Drawing.Point(964, 233);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(28, 20);
            this.label18.TabIndex = 68;
            this.label18.Text = "    ";
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.LightSlateGray;
            this.label19.Location = new System.Drawing.Point(964, 283);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(28, 20);
            this.label19.TabIndex = 69;
            this.label19.Text = "    ";
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.LightSlateGray;
            this.label20.Location = new System.Drawing.Point(964, 333);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(28, 20);
            this.label20.TabIndex = 70;
            this.label20.Text = "    ";
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.Color.LightSlateGray;
            this.label21.Location = new System.Drawing.Point(964, 383);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(28, 20);
            this.label21.TabIndex = 71;
            this.label21.Text = "    ";
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.Color.LightSlateGray;
            this.label22.Location = new System.Drawing.Point(964, 433);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(28, 20);
            this.label22.TabIndex = 72;
            this.label22.Text = "    ";
            this.label22.Visible = false;
            // 
            // label23
            // 
            this.label23.BackColor = System.Drawing.Color.LightSlateGray;
            this.label23.Location = new System.Drawing.Point(964, 483);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(28, 20);
            this.label23.TabIndex = 73;
            this.label23.Text = "    ";
            this.label23.Visible = false;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.White;
            this.label24.Location = new System.Drawing.Point(1040, 283);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(273, 26);
            this.label24.TabIndex = 74;
            this.label24.Text = "图像服务器和PLC通讯异常";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.White;
            this.label25.Location = new System.Drawing.Point(1040, 333);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(322, 26);
            this.label25.TabIndex = 75;
            this.label25.Text = "图像服务器和工控机1通讯异常";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.White;
            this.label26.Location = new System.Drawing.Point(1040, 383);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(322, 26);
            this.label26.TabIndex = 76;
            this.label26.Text = "图像服务器和工控机2通讯异常";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.White;
            this.label27.Location = new System.Drawing.Point(1040, 433);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(322, 26);
            this.label27.TabIndex = 77;
            this.label27.Text = "图像服务器和工控机3通讯异常";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label27.Visible = false;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.Color.Transparent;
            this.label28.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.White;
            this.label28.Location = new System.Drawing.Point(1040, 483);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(322, 26);
            this.label28.TabIndex = 78;
            this.label28.Text = "图像服务器和工控机4通讯异常";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label28.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(67, 174);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(654, 535);
            this.groupBox3.TabIndex = 79;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = " PLC判定并置位，0正常，1异常";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cccButton1);
            this.groupBox1.Controls.Add(this.cccButton4);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(818, 174);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(791, 535);
            this.groupBox1.TabIndex = 80;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "图像服务器判定并置位，0正常，1异常";
            // 
            // cccButton4
            // 
            this.cccButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(3)))), ((int)(((byte)(33)))));
            this.cccButton4.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(18)))), ((int)(((byte)(81)))));
            this.cccButton4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cccButton4.ForeColor = System.Drawing.Color.White;
            this.cccButton4.ImageWidth = 18;
            this.cccButton4.Location = new System.Drawing.Point(529, 99);
            this.cccButton4.Name = "cccButton4";
            this.cccButton4.Radius = 8;
            this.cccButton4.Selected = false;
            this.cccButton4.SetControlState = VBCbutton.CCCButton.ControlState.Normal;
            this.cccButton4.SetRoundStyle = VBCbutton.CCCButton.RoundStyle.All;
            this.cccButton4.Size = new System.Drawing.Size(93, 36);
            this.cccButton4.TabIndex = 81;
            this.cccButton4.Text = "连接PLC";
            this.cccButton4.UseVisualStyleBackColor = false;
            this.cccButton4.Click += new System.EventHandler(this.cccButton4_Click);
            // 
            // cccButton1
            // 
            this.cccButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(3)))), ((int)(((byte)(33)))));
            this.cccButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(18)))), ((int)(((byte)(81)))));
            this.cccButton1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cccButton1.ForeColor = System.Drawing.Color.White;
            this.cccButton1.ImageWidth = 18;
            this.cccButton1.Location = new System.Drawing.Point(643, 99);
            this.cccButton1.Name = "cccButton1";
            this.cccButton1.Radius = 8;
            this.cccButton1.Selected = false;
            this.cccButton1.SetControlState = VBCbutton.CCCButton.ControlState.Normal;
            this.cccButton1.SetRoundStyle = VBCbutton.CCCButton.RoundStyle.All;
            this.cccButton1.Size = new System.Drawing.Size(93, 36);
            this.cccButton1.TabIndex = 82;
            this.cccButton1.Text = "断开PLC";
            this.cccButton1.UseVisualStyleBackColor = false;
            this.cccButton1.Click += new System.EventHandler(this.cccButton1_Click);
            // 
            // NFRMAlarm
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1680, 1050);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "NFRMAlarm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "NFRMParasSet";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private Controls.CPanel pnlTop;
        private System.Windows.Forms.Label lblDate;
        private VBCbutton.CCCButton btnBack;
        private System.Windows.Forms.Label lblSysName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private VBCbutton.CCCButton cccButton1;
        private VBCbutton.CCCButton cccButton4;
    }
}