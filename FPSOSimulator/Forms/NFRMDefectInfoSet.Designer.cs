namespace FPSOSimulator.Forms
{
    partial class NFRMDefectInfoSet
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
            this.lblSysName = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlTop = new FPSOSimulator.Controls.CPanel(this.components);
            this.lblDate = new System.Windows.Forms.Label();
            this.btnBack = new VBCbutton.CCCButton();
            this.cPanel1 = new FPSOSimulator.Controls.CPanel(this.components);
            this.cccButton1 = new VBCbutton.CCCButton();
            this.datetimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.datetimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cPanel3 = new FPSOSimulator.Controls.CPanel(this.components);
            this.cccButton3 = new VBCbutton.CCCButton();
            this.cccButton2 = new VBCbutton.CCCButton();
            this.label2 = new System.Windows.Forms.Label();
            this.dGViewExcel = new System.Windows.Forms.DataGridView();
            this.cPanel2 = new FPSOSimulator.Controls.CPanel(this.components);
            this.cccButton4 = new VBCbutton.CCCButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pnlTop.SuspendLayout();
            this.cPanel1.SuspendLayout();
            this.cPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGViewExcel)).BeginInit();
            this.cPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.lblSysName.Text = "产品缺陷信息维护";
            this.lblSysName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            this.pnlTop.TabIndex = 22;
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
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // cPanel1
            // 
            this.cPanel1.ClrOffSet = ((byte)(25));
            this.cPanel1.Controls.Add(this.cccButton1);
            this.cPanel1.Controls.Add(this.datetimePickerEnd);
            this.cPanel1.Controls.Add(this.datetimePickerStart);
            this.cPanel1.Controls.Add(this.textBox2);
            this.cPanel1.Controls.Add(this.textBox1);
            this.cPanel1.Controls.Add(this.checkedListBox2);
            this.cPanel1.Controls.Add(this.checkBox5);
            this.cPanel1.Controls.Add(this.checkBox4);
            this.cPanel1.Controls.Add(this.checkBox3);
            this.cPanel1.Controls.Add(this.checkBox2);
            this.cPanel1.Controls.Add(this.checkedListBox1);
            this.cPanel1.Controls.Add(this.label3);
            this.cPanel1.Controls.Add(this.label4);
            this.cPanel1.Controls.Add(this.checkBox1);
            this.cPanel1.Location = new System.Drawing.Point(2, 73);
            this.cPanel1.MiddleClrOffSetPercent = 2;
            this.cPanel1.Name = "cPanel1";
            this.cPanel1.showstyle = FPSOSimulator.Controls.CPanel.ShowStyle.MainFrmPanel;
            this.cPanel1.Size = new System.Drawing.Size(1667, 160);
            this.cPanel1.TabIndex = 41;
            this.cPanel1.UphtPercent = 10;
            // 
            // cccButton1
            // 
            this.cccButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(3)))), ((int)(((byte)(33)))));
            this.cccButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(18)))), ((int)(((byte)(81)))));
            this.cccButton1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cccButton1.ForeColor = System.Drawing.Color.White;
            this.cccButton1.ImageWidth = 18;
            this.cccButton1.Location = new System.Drawing.Point(1487, 74);
            this.cccButton1.Name = "cccButton1";
            this.cccButton1.Radius = 8;
            this.cccButton1.Selected = false;
            this.cccButton1.SetControlState = VBCbutton.CCCButton.ControlState.Normal;
            this.cccButton1.SetRoundStyle = VBCbutton.CCCButton.RoundStyle.All;
            this.cccButton1.Size = new System.Drawing.Size(93, 36);
            this.cccButton1.TabIndex = 18;
            this.cccButton1.Text = "查询";
            this.cccButton1.UseVisualStyleBackColor = false;
            this.cccButton1.Click += new System.EventHandler(this.cccButton1_Click_1);
            // 
            // datetimePickerEnd
            // 
            this.datetimePickerEnd.Font = new System.Drawing.Font("Calibri", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetimePickerEnd.Location = new System.Drawing.Point(468, 24);
            this.datetimePickerEnd.Name = "datetimePickerEnd";
            this.datetimePickerEnd.Size = new System.Drawing.Size(186, 25);
            this.datetimePickerEnd.TabIndex = 42;
            // 
            // datetimePickerStart
            // 
            this.datetimePickerStart.Font = new System.Drawing.Font("Calibri", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetimePickerStart.Location = new System.Drawing.Point(239, 25);
            this.datetimePickerStart.Name = "datetimePickerStart";
            this.datetimePickerStart.Size = new System.Drawing.Size(186, 25);
            this.datetimePickerStart.TabIndex = 41;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Calibri", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(1307, 80);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(149, 25);
            this.textBox2.TabIndex = 34;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Calibri", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(1307, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 25);
            this.textBox1.TabIndex = 33;
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.checkedListBox2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox2.ForeColor = System.Drawing.Color.White;
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Location = new System.Drawing.Point(233, 80);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(120, 56);
            this.checkedListBox2.TabIndex = 32;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.BackColor = System.Drawing.Color.Transparent;
            this.checkBox5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox5.ForeColor = System.Drawing.Color.White;
            this.checkBox5.Location = new System.Drawing.Point(1094, 80);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(176, 27);
            this.checkBox5.TabIndex = 31;
            this.checkBox5.Text = "操作员班组信息";
            this.checkBox5.UseVisualStyleBackColor = false;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.BackColor = System.Drawing.Color.Transparent;
            this.checkBox4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.ForeColor = System.Drawing.Color.White;
            this.checkBox4.Location = new System.Drawing.Point(1094, 25);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(134, 27);
            this.checkBox4.TabIndex = 30;
            this.checkBox4.Text = "操作员工号";
            this.checkBox4.UseVisualStyleBackColor = false;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.BackColor = System.Drawing.Color.Transparent;
            this.checkBox3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.ForeColor = System.Drawing.Color.White;
            this.checkBox3.Location = new System.Drawing.Point(64, 80);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(155, 27);
            this.checkBox3.TabIndex = 29;
            this.checkBox3.Text = "总体判定结果";
            this.checkBox3.UseVisualStyleBackColor = false;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.BackColor = System.Drawing.Color.Transparent;
            this.checkBox2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.ForeColor = System.Drawing.Color.White;
            this.checkBox2.Location = new System.Drawing.Point(729, 24);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(92, 27);
            this.checkBox2.TabIndex = 28;
            this.checkBox2.Text = "相机号";
            this.checkBox2.UseVisualStyleBackColor = false;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.checkedListBox1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.ForeColor = System.Drawing.Color.White;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(842, 24);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 108);
            this.checkedListBox1.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(431, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 23);
            this.label3.TabIndex = 26;
            this.label3.Text = "到";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(202, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 23);
            this.label4.TabIndex = 25;
            this.label4.Text = "从";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(64, 24);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(113, 27);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "起始日期";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // cPanel3
            // 
            this.cPanel3.BackColor = System.Drawing.Color.Transparent;
            this.cPanel3.ClrOffSet = ((byte)(25));
            this.cPanel3.Controls.Add(this.cccButton3);
            this.cPanel3.Controls.Add(this.cccButton2);
            this.cPanel3.Controls.Add(this.label2);
            this.cPanel3.Controls.Add(this.dGViewExcel);
            this.cPanel3.Location = new System.Drawing.Point(0, 245);
            this.cPanel3.MiddleClrOffSetPercent = 2;
            this.cPanel3.Name = "cPanel3";
            this.cPanel3.showstyle = FPSOSimulator.Controls.CPanel.ShowStyle.MainFrmPanel;
            this.cPanel3.Size = new System.Drawing.Size(1668, 793);
            this.cPanel3.TabIndex = 42;
            this.cPanel3.UphtPercent = 10;
            // 
            // cccButton3
            // 
            this.cccButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(3)))), ((int)(((byte)(33)))));
            this.cccButton3.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(18)))), ((int)(((byte)(81)))));
            this.cccButton3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cccButton3.ForeColor = System.Drawing.Color.White;
            this.cccButton3.ImageWidth = 18;
            this.cccButton3.Location = new System.Drawing.Point(1488, 15);
            this.cccButton3.Name = "cccButton3";
            this.cccButton3.Radius = 8;
            this.cccButton3.Selected = false;
            this.cccButton3.SetControlState = VBCbutton.CCCButton.ControlState.Normal;
            this.cccButton3.SetRoundStyle = VBCbutton.CCCButton.RoundStyle.All;
            this.cccButton3.Size = new System.Drawing.Size(93, 36);
            this.cccButton3.TabIndex = 25;
            this.cccButton3.Text = "保存";
            this.cccButton3.UseVisualStyleBackColor = false;
            this.cccButton3.Click += new System.EventHandler(this.cccButton3_Click);
            // 
            // cccButton2
            // 
            this.cccButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(3)))), ((int)(((byte)(33)))));
            this.cccButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(18)))), ((int)(((byte)(81)))));
            this.cccButton2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cccButton2.ForeColor = System.Drawing.Color.White;
            this.cccButton2.ImageWidth = 18;
            this.cccButton2.Location = new System.Drawing.Point(1308, 15);
            this.cccButton2.Name = "cccButton2";
            this.cccButton2.Radius = 8;
            this.cccButton2.Selected = false;
            this.cccButton2.SetControlState = VBCbutton.CCCButton.ControlState.Normal;
            this.cccButton2.SetRoundStyle = VBCbutton.CCCButton.RoundStyle.All;
            this.cccButton2.Size = new System.Drawing.Size(93, 36);
            this.cccButton2.TabIndex = 24;
            this.cccButton2.Text = "修改";
            this.cccButton2.UseVisualStyleBackColor = false;
            this.cccButton2.Click += new System.EventHandler(this.cccButton2_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(-4, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 26);
            this.label2.TabIndex = 11;
            this.label2.Text = "产品历史缺陷信息";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dGViewExcel
            // 
            this.dGViewExcel.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dGViewExcel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dGViewExcel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGViewExcel.Location = new System.Drawing.Point(17, 57);
            this.dGViewExcel.Name = "dGViewExcel";
            this.dGViewExcel.ReadOnly = true;
            this.dGViewExcel.RowTemplate.Height = 23;
            this.dGViewExcel.Size = new System.Drawing.Size(1639, 725);
            this.dGViewExcel.TabIndex = 23;
            // 
            // cPanel2
            // 
            this.cPanel2.ClrOffSet = ((byte)(25));
            this.cPanel2.Controls.Add(this.cccButton4);
            this.cPanel2.Controls.Add(this.label1);
            this.cPanel2.Controls.Add(this.dataGridView1);
            this.cPanel2.Location = new System.Drawing.Point(1, 879);
            this.cPanel2.MiddleClrOffSetPercent = 2;
            this.cPanel2.Name = "cPanel2";
            this.cPanel2.showstyle = FPSOSimulator.Controls.CPanel.ShowStyle.MainFrmPanel;
            this.cPanel2.Size = new System.Drawing.Size(1668, 159);
            this.cPanel2.TabIndex = 43;
            this.cPanel2.UphtPercent = 10;
            this.cPanel2.Visible = false;
            // 
            // cccButton4
            // 
            this.cccButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(3)))), ((int)(((byte)(33)))));
            this.cccButton4.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(18)))), ((int)(((byte)(81)))));
            this.cccButton4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cccButton4.ForeColor = System.Drawing.Color.White;
            this.cccButton4.ImageWidth = 18;
            this.cccButton4.Location = new System.Drawing.Point(1488, 15);
            this.cccButton4.Name = "cccButton4";
            this.cccButton4.Radius = 8;
            this.cccButton4.Selected = false;
            this.cccButton4.SetControlState = VBCbutton.CCCButton.ControlState.Normal;
            this.cccButton4.SetRoundStyle = VBCbutton.CCCButton.RoundStyle.All;
            this.cccButton4.Size = new System.Drawing.Size(93, 36);
            this.cccButton4.TabIndex = 25;
            this.cccButton4.Text = "保存";
            this.cccButton4.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(11, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 26);
            this.label1.TabIndex = 11;
            this.label1.Text = "请输入新增产品缺陷信息";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1639, 91);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.Visible = false;
            // 
            // NFRMDefectInfoSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1620, 920);
            this.Controls.Add(this.cPanel3);
            this.Controls.Add(this.cPanel1);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.cPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NFRMDefectInfoSet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.NFRMDefectInfoSet_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.cPanel1.ResumeLayout(false);
            this.cPanel1.PerformLayout();
            this.cPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGViewExcel)).EndInit();
            this.cPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblSysName;
        private System.Windows.Forms.Timer timer1;
        private Controls.CPanel pnlTop;
        private System.Windows.Forms.Label lblDate;
        private VBCbutton.CCCButton btnBack;
        private Controls.CPanel cPanel1;
        private VBCbutton.CCCButton cccButton1;
        private System.Windows.Forms.DateTimePicker datetimePickerEnd;
        private System.Windows.Forms.DateTimePicker datetimePickerStart;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox1;
        private Controls.CPanel cPanel3;
        private VBCbutton.CCCButton cccButton3;
        private VBCbutton.CCCButton cccButton2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dGViewExcel;
        private Controls.CPanel cPanel2;
        private VBCbutton.CCCButton cccButton4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}