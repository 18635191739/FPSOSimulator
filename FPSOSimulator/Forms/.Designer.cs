namespace FPSOSimulator.Forms
{
    partial class frmMain
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
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.cccButton2 = new VBCbutton.CCCButton();
            this.btnSysALM = new VBCbutton.CCCButton();
            this.cccButton1 = new VBCbutton.CCCButton();
            this.cPanel3 = new FPSOSimulator.Controls.CPanel(this.components);
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.TxtPort = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.TxtIp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnParasSet = new VBCbutton.CCCButton();
            this.btnCommStatus = new VBCbutton.CCCButton();
            this.pnlTop = new FPSOSimulator.Controls.CPanel(this.components);
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblSysName = new System.Windows.Forms.Label();
            this.btnDefectHistory = new VBCbutton.CCCButton();
            this.btnDefectInfoSet = new VBCbutton.CCCButton();
            this.btnFrmTech = new VBCbutton.CCCButton();
            this.btnExit = new VBCbutton.CCCButton();
            this.cPanel2 = new FPSOSimulator.Controls.CPanel(this.components);
            this.cccButton3 = new VBCbutton.CCCButton();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cPanel1 = new FPSOSimulator.Controls.CPanel(this.components);
            this.cPanel3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.cPanel2.SuspendLayout();
            this.cPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 500;
            // 
            // cccButton2
            // 
            this.cccButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(3)))), ((int)(((byte)(33)))));
            this.cccButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(18)))), ((int)(((byte)(81)))));
            this.cccButton2.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cccButton2.ForeColor = System.Drawing.Color.White;
            this.cccButton2.ImageWidth = 18;
            this.cccButton2.Location = new System.Drawing.Point(49, 401);
            this.cccButton2.Name = "cccButton2";
            this.cccButton2.Radius = 8;
            this.cccButton2.Selected = false;
            this.cccButton2.SetControlState = VBCbutton.CCCButton.ControlState.Normal;
            this.cccButton2.SetRoundStyle = VBCbutton.CCCButton.RoundStyle.All;
            this.cccButton2.Size = new System.Drawing.Size(236, 51);
            this.cccButton2.TabIndex = 13;
            this.cccButton2.Text = "远程copy";
            this.cccButton2.UseVisualStyleBackColor = false;
            this.cccButton2.Visible = false;
            // 
            // btnSysALM
            // 
            this.btnSysALM.BackColor = System.Drawing.Color.Navy;
            this.btnSysALM.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(44)))), ((int)(((byte)(95)))));
            this.btnSysALM.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSysALM.ForeColor = System.Drawing.Color.Snow;
            this.btnSysALM.ImageWidth = 18;
            this.btnSysALM.Location = new System.Drawing.Point(49, 263);
            this.btnSysALM.Name = "btnSysALM";
            this.btnSysALM.Radius = 4;
            this.btnSysALM.Selected = false;
            this.btnSysALM.SetControlState = VBCbutton.CCCButton.ControlState.Normal;
            this.btnSysALM.SetRoundStyle = VBCbutton.CCCButton.RoundStyle.All;
            this.btnSysALM.Size = new System.Drawing.Size(236, 51);
            this.btnSysALM.TabIndex = 12;
            this.btnSysALM.Text = "系统警报";
            this.btnSysALM.UseVisualStyleBackColor = false;
            this.btnSysALM.Click += new System.EventHandler(this.btnSysALM_Click);
            // 
            // cccButton1
            // 
            this.cccButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(3)))), ((int)(((byte)(33)))));
            this.cccButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(18)))), ((int)(((byte)(81)))));
            this.cccButton1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cccButton1.ForeColor = System.Drawing.Color.White;
            this.cccButton1.ImageWidth = 18;
            this.cccButton1.Location = new System.Drawing.Point(493, 401);
            this.cccButton1.Name = "cccButton1";
            this.cccButton1.Radius = 8;
            this.cccButton1.Selected = false;
            this.cccButton1.SetControlState = VBCbutton.CCCButton.ControlState.Normal;
            this.cccButton1.SetRoundStyle = VBCbutton.CCCButton.RoundStyle.All;
            this.cccButton1.Size = new System.Drawing.Size(236, 51);
            this.cccButton1.TabIndex = 11;
            this.cccButton1.Text = "图片拼接";
            this.cccButton1.UseVisualStyleBackColor = false;
            this.cccButton1.Visible = false;
            this.cccButton1.Click += new System.EventHandler(this.cccButton1_Click);
            // 
            // cPanel3
            // 
            this.cPanel3.ClrOffSet = ((byte)(25));
            this.cPanel3.Controls.Add(this.groupBox5);
            this.cPanel3.Controls.Add(this.groupBox4);
            this.cPanel3.Controls.Add(this.groupBox3);
            this.cPanel3.Controls.Add(this.groupBox1);
            this.cPanel3.Controls.Add(this.groupBox2);
            this.cPanel3.Controls.Add(this.label2);
            this.cPanel3.Location = new System.Drawing.Point(12, 88);
            this.cPanel3.MiddleClrOffSetPercent = 2;
            this.cPanel3.Name = "cPanel3";
            this.cPanel3.showstyle = FPSOSimulator.Controls.CPanel.ShowStyle.MainFrmPanel;
            this.cPanel3.Size = new System.Drawing.Size(403, 680);
            this.cPanel3.TabIndex = 1;
            this.cPanel3.UphtPercent = 10;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.label20);
            this.groupBox5.Controls.Add(this.label21);
            this.groupBox5.Controls.Add(this.textBox7);
            this.groupBox5.Controls.Add(this.label22);
            this.groupBox5.Controls.Add(this.textBox8);
            this.groupBox5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(11, 643);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(383, 105);
            this.groupBox5.TabIndex = 64;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Operator Training Station E";
            this.groupBox5.Visible = false;
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.LightSlateGray;
            this.label20.Location = new System.Drawing.Point(15, 49);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(28, 20);
            this.label20.TabIndex = 61;
            this.label20.Text = "    ";
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(49, 49);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(25, 23);
            this.label21.TabIndex = 40;
            this.label21.Text = "IP";
            // 
            // textBox7
            // 
            this.textBox7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox7.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBox7.Location = new System.Drawing.Point(299, 44);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(78, 31);
            this.textBox7.TabIndex = 38;
            this.textBox7.Text = "5005";
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(240, 49);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(53, 23);
            this.label22.TabIndex = 41;
            this.label22.Text = "PORT";
            // 
            // textBox8
            // 
            this.textBox8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox8.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBox8.Location = new System.Drawing.Point(80, 44);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(136, 31);
            this.textBox8.TabIndex = 39;
            this.textBox8.Text = "192.168.1.24";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.textBox5);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.textBox6);
            this.groupBox4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(11, 500);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(383, 105);
            this.groupBox4.TabIndex = 63;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Operator Training Station D";
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.LightSlateGray;
            this.label13.Location = new System.Drawing.Point(15, 49);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 20);
            this.label13.TabIndex = 61;
            this.label13.Text = "    ";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(49, 49);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(25, 23);
            this.label14.TabIndex = 40;
            this.label14.Text = "IP";
            // 
            // textBox5
            // 
            this.textBox5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBox5.Location = new System.Drawing.Point(299, 44);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(78, 31);
            this.textBox5.TabIndex = 38;
            this.textBox5.Text = "5004";
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(240, 49);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 23);
            this.label17.TabIndex = 41;
            this.label17.Text = "PORT";
            // 
            // textBox6
            // 
            this.textBox6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBox6.Location = new System.Drawing.Point(80, 44);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(136, 31);
            this.textBox6.TabIndex = 39;
            this.textBox6.Text = "192.168.1.23";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.textBox4);
            this.groupBox3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(11, 357);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(383, 105);
            this.groupBox3.TabIndex = 62;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Operator Training Station C";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.LightSlateGray;
            this.label9.Location = new System.Drawing.Point(15, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 20);
            this.label9.TabIndex = 61;
            this.label9.Text = "    ";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(49, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 23);
            this.label10.TabIndex = 40;
            this.label10.Text = "IP";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBox3.Location = new System.Drawing.Point(299, 44);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(78, 31);
            this.textBox3.TabIndex = 38;
            this.textBox3.Text = "5003";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(240, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 23);
            this.label11.TabIndex = 41;
            this.label11.Text = "PORT";
            // 
            // textBox4
            // 
            this.textBox4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBox4.Location = new System.Drawing.Point(80, 44);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(136, 31);
            this.textBox4.TabIndex = 39;
            this.textBox4.Text = "192.168.1.22";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(11, 214);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 105);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operator Training Station B";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.LightSlateGray;
            this.label3.Location = new System.Drawing.Point(15, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 20);
            this.label3.TabIndex = 61;
            this.label3.Text = "    ";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(49, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 23);
            this.label4.TabIndex = 40;
            this.label4.Text = "IP";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(299, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(78, 31);
            this.textBox1.TabIndex = 38;
            this.textBox1.Text = "5002";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(240, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 23);
            this.label6.TabIndex = 41;
            this.label6.Text = "PORT";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBox2.Location = new System.Drawing.Point(80, 44);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(136, 31);
            this.textBox2.TabIndex = 39;
            this.textBox2.Text = "192.168.1.21";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.TxtPort);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.TxtIp);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(11, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(383, 105);
            this.groupBox2.TabIndex = 53;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operator Training Station A";
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.LightSlateGray;
            this.label12.Location = new System.Drawing.Point(15, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 20);
            this.label12.TabIndex = 61;
            this.label12.Text = "    ";
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(49, 49);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(25, 23);
            this.label18.TabIndex = 40;
            this.label18.Text = "IP";
            // 
            // TxtPort
            // 
            this.TxtPort.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtPort.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.TxtPort.Location = new System.Drawing.Point(299, 44);
            this.TxtPort.Name = "TxtPort";
            this.TxtPort.Size = new System.Drawing.Size(78, 31);
            this.TxtPort.TabIndex = 38;
            this.TxtPort.Text = "5001";
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(240, 49);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 23);
            this.label19.TabIndex = 41;
            this.label19.Text = "PORT";
            // 
            // TxtIp
            // 
            this.TxtIp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtIp.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.TxtIp.Location = new System.Drawing.Point(80, 44);
            this.TxtIp.Name = "TxtIp";
            this.TxtIp.Size = new System.Drawing.Size(136, 31);
            this.TxtIp.TabIndex = 39;
            this.TxtIp.Text = "192.168.1.20";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(-17, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 26);
            this.label2.TabIndex = 11;
            this.label2.Text = "Operator Training Station:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnParasSet
            // 
            this.btnParasSet.BackColor = System.Drawing.Color.Navy;
            this.btnParasSet.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(44)))), ((int)(((byte)(95)))));
            this.btnParasSet.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParasSet.ForeColor = System.Drawing.Color.Snow;
            this.btnParasSet.ImageWidth = 18;
            this.btnParasSet.Location = new System.Drawing.Point(49, 169);
            this.btnParasSet.Name = "btnParasSet";
            this.btnParasSet.Radius = 4;
            this.btnParasSet.Selected = false;
            this.btnParasSet.SetControlState = VBCbutton.CCCButton.ControlState.Normal;
            this.btnParasSet.SetRoundStyle = VBCbutton.CCCButton.RoundStyle.All;
            this.btnParasSet.Size = new System.Drawing.Size(236, 51);
            this.btnParasSet.TabIndex = 5;
            this.btnParasSet.Text = "工作参数设定";
            this.btnParasSet.UseVisualStyleBackColor = false;
            this.btnParasSet.Click += new System.EventHandler(this.btnStandModel_Click);
            // 
            // btnCommStatus
            // 
            this.btnCommStatus.BackColor = System.Drawing.Color.Navy;
            this.btnCommStatus.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(44)))), ((int)(((byte)(95)))));
            this.btnCommStatus.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCommStatus.ForeColor = System.Drawing.Color.Snow;
            this.btnCommStatus.ImageWidth = 18;
            this.btnCommStatus.Location = new System.Drawing.Point(493, 169);
            this.btnCommStatus.Name = "btnCommStatus";
            this.btnCommStatus.Radius = 4;
            this.btnCommStatus.Selected = false;
            this.btnCommStatus.SetControlState = VBCbutton.CCCButton.ControlState.Normal;
            this.btnCommStatus.SetRoundStyle = VBCbutton.CCCButton.RoundStyle.All;
            this.btnCommStatus.Size = new System.Drawing.Size(236, 51);
            this.btnCommStatus.TabIndex = 3;
            this.btnCommStatus.Text = "通讯连接状态";
            this.btnCommStatus.UseVisualStyleBackColor = false;
            this.btnCommStatus.Click += new System.EventHandler(this.btnShowModelValue_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlTop.ClrOffSet = ((byte)(80));
            this.pnlTop.Controls.Add(this.label16);
            this.pnlTop.Controls.Add(this.label15);
            this.pnlTop.Controls.Add(this.lblDate);
            this.pnlTop.Controls.Add(this.label7);
            this.pnlTop.Controls.Add(this.label8);
            this.pnlTop.Controls.Add(this.lblSysName);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.MiddleClrOffSetPercent = 2;
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.showstyle = FPSOSimulator.Controls.CPanel.ShowStyle.ToMiddle;
            this.pnlTop.Size = new System.Drawing.Size(1600, 68);
            this.pnlTop.TabIndex = 3;
            this.pnlTop.UphtPercent = 10;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(550, 35);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(106, 26);
            this.label16.TabIndex = 49;
            this.label16.Text = "TCO:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(662, 39);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 19);
            this.label15.TabIndex = 48;
            this.label15.Text = "NULL";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Snow;
            this.lblDate.Location = new System.Drawing.Point(983, 17);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(271, 29);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "2018/05/07     Wednesday";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(551, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 26);
            this.label7.TabIndex = 46;
            this.label7.Text = "THO:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(662, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 19);
            this.label8.TabIndex = 47;
            this.label8.Text = "NULL";
            // 
            // lblSysName
            // 
            this.lblSysName.AutoSize = true;
            this.lblSysName.BackColor = System.Drawing.Color.Transparent;
            this.lblSysName.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSysName.ForeColor = System.Drawing.Color.Snow;
            this.lblSysName.Location = new System.Drawing.Point(79, 18);
            this.lblSysName.Name = "lblSysName";
            this.lblSysName.Size = new System.Drawing.Size(357, 29);
            this.lblSysName.TabIndex = 2;
            this.lblSysName.Text = "FPSO Simulator\\ Instructor Station";
            this.lblSysName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDefectHistory
            // 
            this.btnDefectHistory.BackColor = System.Drawing.Color.Navy;
            this.btnDefectHistory.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(44)))), ((int)(((byte)(95)))));
            this.btnDefectHistory.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDefectHistory.ForeColor = System.Drawing.Color.Snow;
            this.btnDefectHistory.ImageWidth = 18;
            this.btnDefectHistory.Location = new System.Drawing.Point(49, 71);
            this.btnDefectHistory.Name = "btnDefectHistory";
            this.btnDefectHistory.Radius = 4;
            this.btnDefectHistory.Selected = false;
            this.btnDefectHistory.SetControlState = VBCbutton.CCCButton.ControlState.Normal;
            this.btnDefectHistory.SetRoundStyle = VBCbutton.CCCButton.RoundStyle.All;
            this.btnDefectHistory.Size = new System.Drawing.Size(236, 51);
            this.btnDefectHistory.TabIndex = 1;
            this.btnDefectHistory.Text = "产品历史缺陷查询";
            this.btnDefectHistory.UseVisualStyleBackColor = false;
            this.btnDefectHistory.Click += new System.EventHandler(this.btnPointsTrend_Click);
            // 
            // btnDefectInfoSet
            // 
            this.btnDefectInfoSet.BackColor = System.Drawing.Color.Navy;
            this.btnDefectInfoSet.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(44)))), ((int)(((byte)(95)))));
            this.btnDefectInfoSet.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDefectInfoSet.ForeColor = System.Drawing.Color.Snow;
            this.btnDefectInfoSet.ImageWidth = 30;
            this.btnDefectInfoSet.Location = new System.Drawing.Point(493, 71);
            this.btnDefectInfoSet.Name = "btnDefectInfoSet";
            this.btnDefectInfoSet.Radius = 4;
            this.btnDefectInfoSet.Selected = false;
            this.btnDefectInfoSet.SetControlState = VBCbutton.CCCButton.ControlState.Normal;
            this.btnDefectInfoSet.SetRoundStyle = VBCbutton.CCCButton.RoundStyle.All;
            this.btnDefectInfoSet.Size = new System.Drawing.Size(236, 51);
            this.btnDefectInfoSet.TabIndex = 0;
            this.btnDefectInfoSet.Text = "产品缺陷信息维护";
            this.btnDefectInfoSet.UseVisualStyleBackColor = false;
            // 
            // btnFrmTech
            // 
            this.btnFrmTech.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(3)))), ((int)(((byte)(33)))));
            this.btnFrmTech.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(18)))), ((int)(((byte)(81)))));
            this.btnFrmTech.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFrmTech.ForeColor = System.Drawing.Color.White;
            this.btnFrmTech.ImageWidth = 18;
            this.btnFrmTech.Location = new System.Drawing.Point(907, 540);
            this.btnFrmTech.Name = "btnFrmTech";
            this.btnFrmTech.Radius = 8;
            this.btnFrmTech.Selected = false;
            this.btnFrmTech.SetControlState = VBCbutton.CCCButton.ControlState.Normal;
            this.btnFrmTech.SetRoundStyle = VBCbutton.CCCButton.RoundStyle.All;
            this.btnFrmTech.Size = new System.Drawing.Size(236, 51);
            this.btnFrmTech.TabIndex = 9;
            this.btnFrmTech.Text = "Tech Support";
            this.btnFrmTech.UseVisualStyleBackColor = false;
            this.btnFrmTech.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(3)))), ((int)(((byte)(33)))));
            this.btnExit.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(18)))), ((int)(((byte)(81)))));
            this.btnExit.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.ImageWidth = 18;
            this.btnExit.Location = new System.Drawing.Point(907, 611);
            this.btnExit.Name = "btnExit";
            this.btnExit.Radius = 8;
            this.btnExit.Selected = false;
            this.btnExit.SetControlState = VBCbutton.CCCButton.ControlState.Normal;
            this.btnExit.SetRoundStyle = VBCbutton.CCCButton.RoundStyle.All;
            this.btnExit.Size = new System.Drawing.Size(236, 51);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // cPanel2
            // 
            this.cPanel2.ClrOffSet = ((byte)(25));
            this.cPanel2.Controls.Add(this.cccButton1);
            this.cPanel2.Controls.Add(this.cccButton2);
            this.cPanel2.Controls.Add(this.cccButton3);
            this.cPanel2.Controls.Add(this.btnExit);
            this.cPanel2.Controls.Add(this.btnFrmTech);
            this.cPanel2.Controls.Add(this.btnDefectHistory);
            this.cPanel2.Controls.Add(this.btnDefectInfoSet);
            this.cPanel2.Controls.Add(this.btnSysALM);
            this.cPanel2.Controls.Add(this.btnParasSet);
            this.cPanel2.Controls.Add(this.btnCommStatus);
            this.cPanel2.Location = new System.Drawing.Point(421, 88);
            this.cPanel2.MiddleClrOffSetPercent = 2;
            this.cPanel2.Name = "cPanel2";
            this.cPanel2.showstyle = FPSOSimulator.Controls.CPanel.ShowStyle.MainFrmPanel;
            this.cPanel2.Size = new System.Drawing.Size(1167, 680);
            this.cPanel2.TabIndex = 0;
            this.cPanel2.UphtPercent = 10;
            // 
            // cccButton3
            // 
            this.cccButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(3)))), ((int)(((byte)(33)))));
            this.cccButton3.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(18)))), ((int)(((byte)(81)))));
            this.cccButton3.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cccButton3.ForeColor = System.Drawing.Color.White;
            this.cccButton3.ImageWidth = 18;
            this.cccButton3.Location = new System.Drawing.Point(493, 258);
            this.cccButton3.Name = "cccButton3";
            this.cccButton3.Radius = 8;
            this.cccButton3.Selected = false;
            this.cccButton3.SetControlState = VBCbutton.CCCButton.ControlState.Normal;
            this.cccButton3.SetRoundStyle = VBCbutton.CCCButton.RoundStyle.All;
            this.cccButton3.Size = new System.Drawing.Size(236, 51);
            this.cccButton3.TabIndex = 14;
            this.cccButton3.Text = "ReadIDFlag = 0";
            this.cccButton3.UseVisualStyleBackColor = false;
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 10000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Enabled = true;
            this.timer4.Interval = 1000;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(1120, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(548, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "FPSO Simulator\\ Instructor Station";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Calibri", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Snow;
            this.label5.Location = new System.Drawing.Point(1325, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(222, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Copyright ©All rights reserved";
            // 
            // cPanel1
            // 
            this.cPanel1.ClrOffSet = ((byte)(50));
            this.cPanel1.Controls.Add(this.label5);
            this.cPanel1.Controls.Add(this.label1);
            this.cPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cPanel1.Location = new System.Drawing.Point(0, 780);
            this.cPanel1.MiddleClrOffSetPercent = 2;
            this.cPanel1.Name = "cPanel1";
            this.cPanel1.showstyle = FPSOSimulator.Controls.CPanel.ShowStyle.UpDn;
            this.cPanel1.Size = new System.Drawing.Size(1600, 120);
            this.cPanel1.TabIndex = 2;
            this.cPanel1.UphtPercent = 10;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.cPanel3);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.cPanel1);
            this.Controls.Add(this.cPanel2);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.Color.Coral;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = " ";
            this.cPanel3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.cPanel2.ResumeLayout(false);
            this.cPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private VBCbutton.CCCButton btnDefectInfoSet;
        private VBCbutton.CCCButton btnExit;
        private FPSOSimulator.Controls.CPanel cPanel2;
        private VBCbutton.CCCButton btnCommStatus;
        private VBCbutton.CCCButton btnParasSet;
        private VBCbutton.CCCButton btnDefectHistory;
        private FPSOSimulator.Controls.CPanel pnlTop;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblSysName;
        private VBCbutton.CCCButton btnFrmTech;
        private System.Windows.Forms.Timer timer1;
        private Controls.CPanel cPanel3;
        private System.Windows.Forms.Label label2;
        private VBCbutton.CCCButton cccButton1;
        private System.Windows.Forms.Timer timer2;
        private VBCbutton.CCCButton btnSysALM;
        private VBCbutton.CCCButton cccButton2;
        private VBCbutton.CCCButton cccButton3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private Controls.CPanel cPanel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox TxtPort;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox TxtIp;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label12;
    }
}