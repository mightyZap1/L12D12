namespace MightyZapDemo_CS2010
{
    partial class Form1
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
            this.textPosition = new System.Windows.Forms.TextBox();
            this.textShortLimit = new System.Windows.Forms.TextBox();
            this.textLongLimit = new System.Windows.Forms.TextBox();
            this.textPresentPosition = new System.Windows.Forms.TextBox();
            this.GoalPosition = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Connect = new System.Windows.Forms.Button();
            this.mServoID = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.AddrRead = new System.Windows.Forms.Button();
            this.textReadData = new System.Windows.Forms.TextBox();
            this.textReadBytes = new System.Windows.Forms.TextBox();
            this.textReadAddr = new System.Windows.Forms.TextBox();
            this.textWriteData = new System.Windows.Forms.TextBox();
            this.textWriteBytes = new System.Windows.Forms.TextBox();
            this.AddrWrite = new System.Windows.Forms.Button();
            this.textWriteAddr = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.VoltageError = new System.Windows.Forms.CheckBox();
            this.StrokeError = new System.Windows.Forms.CheckBox();
            this.RangeError = new System.Windows.Forms.CheckBox();
            this.ChecksumError = new System.Windows.Forms.CheckBox();
            this.OverloadError = new System.Windows.Forms.CheckBox();
            this.InsError = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.VoltageErrorSD = new System.Windows.Forms.CheckBox();
            this.StrokeErrorSD = new System.Windows.Forms.CheckBox();
            this.RangeErrorSD = new System.Windows.Forms.CheckBox();
            this.CheckSumErrorSD = new System.Windows.Forms.CheckBox();
            this.OverloadErrorSD = new System.Windows.Forms.CheckBox();
            this.InsErrorSD = new System.Windows.Forms.CheckBox();
            this.button11 = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.textSpeed = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // textPosition
            // 
            this.textPosition.Location = new System.Drawing.Point(23, 26);
            this.textPosition.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textPosition.Name = "textPosition";
            this.textPosition.Size = new System.Drawing.Size(56, 21);
            this.textPosition.TabIndex = 0;
            this.textPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textShortLimit
            // 
            this.textShortLimit.Location = new System.Drawing.Point(23, 50);
            this.textShortLimit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textShortLimit.Name = "textShortLimit";
            this.textShortLimit.Size = new System.Drawing.Size(56, 21);
            this.textShortLimit.TabIndex = 1;
            this.textShortLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textLongLimit
            // 
            this.textLongLimit.Location = new System.Drawing.Point(23, 76);
            this.textLongLimit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textLongLimit.Name = "textLongLimit";
            this.textLongLimit.Size = new System.Drawing.Size(56, 21);
            this.textLongLimit.TabIndex = 2;
            this.textLongLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textPresentPosition
            // 
            this.textPresentPosition.Location = new System.Drawing.Point(23, 131);
            this.textPresentPosition.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textPresentPosition.Name = "textPresentPosition";
            this.textPresentPosition.ReadOnly = true;
            this.textPresentPosition.Size = new System.Drawing.Size(56, 21);
            this.textPresentPosition.TabIndex = 3;
            this.textPresentPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // GoalPosition
            // 
            this.GoalPosition.Location = new System.Drawing.Point(86, 26);
            this.GoalPosition.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GoalPosition.Name = "GoalPosition";
            this.GoalPosition.Size = new System.Drawing.Size(136, 20);
            this.GoalPosition.TabIndex = 4;
            this.GoalPosition.Text = "Goal Position";
            this.GoalPosition.UseVisualStyleBackColor = true;
            this.GoalPosition.Click += new System.EventHandler(this.GoalPosition_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(86, 50);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 20);
            this.button2.TabIndex = 5;
            this.button2.Text = "Short Stroke Limit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(86, 76);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 20);
            this.button3.TabIndex = 6;
            this.button3.Text = "Long Stroke Limit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(86, 131);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(136, 20);
            this.button4.TabIndex = 7;
            this.button4.Text = "Present Position";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textSpeed);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(334, 154);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Servo Test";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(232, 19);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(75, 16);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Force Off";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Connect);
            this.groupBox2.Controls.Add(this.mServoID);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(350, 10);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(220, 154);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Port Setting";
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(96, 86);
            this.Connect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(106, 18);
            this.Connect.TabIndex = 6;
            this.Connect.Text = "Connect";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // mServoID
            // 
            this.mServoID.Location = new System.Drawing.Point(96, 61);
            this.mServoID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mServoID.Name = "mServoID";
            this.mServoID.Size = new System.Drawing.Size(106, 21);
            this.mServoID.TabIndex = 5;
            this.mServoID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "9600",
            "19200",
            "57600",
            "115200"});
            this.comboBox2.Location = new System.Drawing.Point(96, 38);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(106, 20);
            this.comboBox2.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(96, 16);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(106, 20);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "Servo ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Baudrate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.AddrRead);
            this.groupBox3.Controls.Add(this.textReadData);
            this.groupBox3.Controls.Add(this.textReadBytes);
            this.groupBox3.Controls.Add(this.textReadAddr);
            this.groupBox3.Controls.Add(this.textWriteData);
            this.groupBox3.Controls.Add(this.textWriteBytes);
            this.groupBox3.Controls.Add(this.AddrWrite);
            this.groupBox3.Controls.Add(this.textWriteAddr);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(10, 168);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(560, 94);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DATA Test";
            // 
            // AddrRead
            // 
            this.AddrRead.Location = new System.Drawing.Point(220, 62);
            this.AddrRead.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddrRead.Name = "AddrRead";
            this.AddrRead.Size = new System.Drawing.Size(67, 18);
            this.AddrRead.TabIndex = 12;
            this.AddrRead.Text = "Read";
            this.AddrRead.UseVisualStyleBackColor = true;
            this.AddrRead.Click += new System.EventHandler(this.AddrRead_Click);
            // 
            // textReadData
            // 
            this.textReadData.Enabled = false;
            this.textReadData.Location = new System.Drawing.Point(150, 62);
            this.textReadData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textReadData.Name = "textReadData";
            this.textReadData.ReadOnly = true;
            this.textReadData.Size = new System.Drawing.Size(64, 21);
            this.textReadData.TabIndex = 11;
            this.textReadData.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textReadBytes
            // 
            this.textReadBytes.Location = new System.Drawing.Point(81, 62);
            this.textReadBytes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textReadBytes.Name = "textReadBytes";
            this.textReadBytes.Size = new System.Drawing.Size(64, 21);
            this.textReadBytes.TabIndex = 10;
            this.textReadBytes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textReadAddr
            // 
            this.textReadAddr.Location = new System.Drawing.Point(12, 62);
            this.textReadAddr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textReadAddr.Name = "textReadAddr";
            this.textReadAddr.Size = new System.Drawing.Size(64, 21);
            this.textReadAddr.TabIndex = 9;
            this.textReadAddr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textWriteData
            // 
            this.textWriteData.Location = new System.Drawing.Point(150, 37);
            this.textWriteData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textWriteData.Name = "textWriteData";
            this.textWriteData.Size = new System.Drawing.Size(64, 21);
            this.textWriteData.TabIndex = 8;
            this.textWriteData.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textWriteBytes
            // 
            this.textWriteBytes.Location = new System.Drawing.Point(81, 37);
            this.textWriteBytes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textWriteBytes.Name = "textWriteBytes";
            this.textWriteBytes.Size = new System.Drawing.Size(64, 21);
            this.textWriteBytes.TabIndex = 7;
            this.textWriteBytes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // AddrWrite
            // 
            this.AddrWrite.Location = new System.Drawing.Point(220, 38);
            this.AddrWrite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddrWrite.Name = "AddrWrite";
            this.AddrWrite.Size = new System.Drawing.Size(67, 18);
            this.AddrWrite.TabIndex = 6;
            this.AddrWrite.Text = "Write";
            this.AddrWrite.UseVisualStyleBackColor = true;
            this.AddrWrite.Click += new System.EventHandler(this.AddrWrite_Click);
            // 
            // textWriteAddr
            // 
            this.textWriteAddr.Location = new System.Drawing.Point(12, 37);
            this.textWriteAddr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textWriteAddr.Name = "textWriteAddr";
            this.textWriteAddr.Size = new System.Drawing.Size(64, 21);
            this.textWriteAddr.TabIndex = 5;
            this.textWriteAddr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(155, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "Data";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "Addr bytes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "Addr";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button8);
            this.groupBox4.Controls.Add(this.VoltageError);
            this.groupBox4.Controls.Add(this.StrokeError);
            this.groupBox4.Controls.Add(this.RangeError);
            this.groupBox4.Controls.Add(this.ChecksumError);
            this.groupBox4.Controls.Add(this.OverloadError);
            this.groupBox4.Controls.Add(this.InsError);
            this.groupBox4.Location = new System.Drawing.Point(10, 268);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(234, 152);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Error Display";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(158, 20);
            this.button8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(66, 18);
            this.button8.TabIndex = 6;
            this.button8.Text = "Read";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // VoltageError
            // 
            this.VoltageError.AutoSize = true;
            this.VoltageError.Location = new System.Drawing.Point(5, 132);
            this.VoltageError.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.VoltageError.Name = "VoltageError";
            this.VoltageError.Size = new System.Drawing.Size(128, 16);
            this.VoltageError.TabIndex = 5;
            this.VoltageError.Text = "Input Voltage Error";
            this.VoltageError.UseVisualStyleBackColor = true;
            // 
            // StrokeError
            // 
            this.StrokeError.AutoSize = true;
            this.StrokeError.Location = new System.Drawing.Point(5, 110);
            this.StrokeError.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StrokeError.Name = "StrokeError";
            this.StrokeError.Size = new System.Drawing.Size(90, 16);
            this.StrokeError.TabIndex = 4;
            this.StrokeError.Text = "Stroke Error";
            this.StrokeError.UseVisualStyleBackColor = true;
            // 
            // RangeError
            // 
            this.RangeError.AutoSize = true;
            this.RangeError.Location = new System.Drawing.Point(5, 87);
            this.RangeError.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RangeError.Name = "RangeError";
            this.RangeError.Size = new System.Drawing.Size(91, 16);
            this.RangeError.TabIndex = 3;
            this.RangeError.Text = "Range Error";
            this.RangeError.UseVisualStyleBackColor = true;
            // 
            // ChecksumError
            // 
            this.ChecksumError.AutoSize = true;
            this.ChecksumError.Location = new System.Drawing.Point(5, 65);
            this.ChecksumError.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChecksumError.Name = "ChecksumError";
            this.ChecksumError.Size = new System.Drawing.Size(117, 16);
            this.ChecksumError.TabIndex = 2;
            this.ChecksumError.Text = "CheckSum Error";
            this.ChecksumError.UseVisualStyleBackColor = true;
            // 
            // OverloadError
            // 
            this.OverloadError.AutoSize = true;
            this.OverloadError.Location = new System.Drawing.Point(5, 42);
            this.OverloadError.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OverloadError.Name = "OverloadError";
            this.OverloadError.Size = new System.Drawing.Size(105, 16);
            this.OverloadError.TabIndex = 1;
            this.OverloadError.Text = "Overload Error";
            this.OverloadError.UseVisualStyleBackColor = true;
            // 
            // InsError
            // 
            this.InsError.AutoSize = true;
            this.InsError.Location = new System.Drawing.Point(5, 20);
            this.InsError.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InsError.Name = "InsError";
            this.InsError.Size = new System.Drawing.Size(113, 16);
            this.InsError.TabIndex = 0;
            this.InsError.Text = "Instruction Error";
            this.InsError.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button10);
            this.groupBox5.Controls.Add(this.button9);
            this.groupBox5.Controls.Add(this.VoltageErrorSD);
            this.groupBox5.Controls.Add(this.StrokeErrorSD);
            this.groupBox5.Controls.Add(this.RangeErrorSD);
            this.groupBox5.Controls.Add(this.CheckSumErrorSD);
            this.groupBox5.Controls.Add(this.OverloadErrorSD);
            this.groupBox5.Controls.Add(this.InsErrorSD);
            this.groupBox5.Location = new System.Drawing.Point(249, 268);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Size = new System.Drawing.Size(234, 152);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Error ShutDown";
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(158, 38);
            this.button10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(66, 18);
            this.button10.TabIndex = 7;
            this.button10.Text = "Write";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(158, 20);
            this.button9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(66, 18);
            this.button9.TabIndex = 6;
            this.button9.Text = "Read";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // VoltageErrorSD
            // 
            this.VoltageErrorSD.AutoSize = true;
            this.VoltageErrorSD.Location = new System.Drawing.Point(5, 132);
            this.VoltageErrorSD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.VoltageErrorSD.Name = "VoltageErrorSD";
            this.VoltageErrorSD.Size = new System.Drawing.Size(128, 16);
            this.VoltageErrorSD.TabIndex = 5;
            this.VoltageErrorSD.Text = "Input Voltage Error";
            this.VoltageErrorSD.UseVisualStyleBackColor = true;
            // 
            // StrokeErrorSD
            // 
            this.StrokeErrorSD.AutoSize = true;
            this.StrokeErrorSD.Location = new System.Drawing.Point(5, 110);
            this.StrokeErrorSD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StrokeErrorSD.Name = "StrokeErrorSD";
            this.StrokeErrorSD.Size = new System.Drawing.Size(90, 16);
            this.StrokeErrorSD.TabIndex = 4;
            this.StrokeErrorSD.Text = "Stroke Error";
            this.StrokeErrorSD.UseVisualStyleBackColor = true;
            // 
            // RangeErrorSD
            // 
            this.RangeErrorSD.AutoSize = true;
            this.RangeErrorSD.Location = new System.Drawing.Point(5, 87);
            this.RangeErrorSD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RangeErrorSD.Name = "RangeErrorSD";
            this.RangeErrorSD.Size = new System.Drawing.Size(91, 16);
            this.RangeErrorSD.TabIndex = 3;
            this.RangeErrorSD.Text = "Range Error";
            this.RangeErrorSD.UseVisualStyleBackColor = true;
            // 
            // CheckSumErrorSD
            // 
            this.CheckSumErrorSD.AutoSize = true;
            this.CheckSumErrorSD.Location = new System.Drawing.Point(5, 65);
            this.CheckSumErrorSD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CheckSumErrorSD.Name = "CheckSumErrorSD";
            this.CheckSumErrorSD.Size = new System.Drawing.Size(117, 16);
            this.CheckSumErrorSD.TabIndex = 2;
            this.CheckSumErrorSD.Text = "CheckSum Error";
            this.CheckSumErrorSD.UseVisualStyleBackColor = true;
            // 
            // OverloadErrorSD
            // 
            this.OverloadErrorSD.AutoSize = true;
            this.OverloadErrorSD.Location = new System.Drawing.Point(5, 42);
            this.OverloadErrorSD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OverloadErrorSD.Name = "OverloadErrorSD";
            this.OverloadErrorSD.Size = new System.Drawing.Size(105, 16);
            this.OverloadErrorSD.TabIndex = 1;
            this.OverloadErrorSD.Text = "Overload Error";
            this.OverloadErrorSD.UseVisualStyleBackColor = true;
            // 
            // InsErrorSD
            // 
            this.InsErrorSD.AutoSize = true;
            this.InsErrorSD.Location = new System.Drawing.Point(5, 20);
            this.InsErrorSD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InsErrorSD.Name = "InsErrorSD";
            this.InsErrorSD.Size = new System.Drawing.Size(113, 16);
            this.InsErrorSD.TabIndex = 0;
            this.InsErrorSD.Text = "Instruction Error";
            this.InsErrorSD.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(489, 276);
            this.button11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(81, 144);
            this.button11.TabIndex = 13;
            this.button11.Text = "Close";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(76, 94);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 20);
            this.button1.TabIndex = 15;
            this.button1.Text = "Speed";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textSpeed
            // 
            this.textSpeed.Location = new System.Drawing.Point(13, 94);
            this.textSpeed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textSpeed.Name = "textSpeed";
            this.textSpeed.Size = new System.Drawing.Size(56, 21);
            this.textSpeed.TabIndex = 14;
            this.textSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 468);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.GoalPosition);
            this.Controls.Add(this.textPresentPosition);
            this.Controls.Add(this.textLongLimit);
            this.Controls.Add(this.textShortLimit);
            this.Controls.Add(this.textPosition);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textPosition;
        private System.Windows.Forms.TextBox textShortLimit;
        private System.Windows.Forms.TextBox textLongLimit;
        private System.Windows.Forms.TextBox textPresentPosition;
        private System.Windows.Forms.Button GoalPosition;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.TextBox mServoID;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button AddrRead;
        private System.Windows.Forms.TextBox textReadData;
        private System.Windows.Forms.TextBox textReadBytes;
        private System.Windows.Forms.TextBox textReadAddr;
        private System.Windows.Forms.TextBox textWriteData;
        private System.Windows.Forms.TextBox textWriteBytes;
        private System.Windows.Forms.Button AddrWrite;
        private System.Windows.Forms.TextBox textWriteAddr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.CheckBox VoltageError;
        private System.Windows.Forms.CheckBox StrokeError;
        private System.Windows.Forms.CheckBox RangeError;
        private System.Windows.Forms.CheckBox ChecksumError;
        private System.Windows.Forms.CheckBox OverloadError;
        private System.Windows.Forms.CheckBox InsError;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.CheckBox VoltageErrorSD;
        private System.Windows.Forms.CheckBox StrokeErrorSD;
        private System.Windows.Forms.CheckBox RangeErrorSD;
        private System.Windows.Forms.CheckBox CheckSumErrorSD;
        private System.Windows.Forms.CheckBox OverloadErrorSD;
        private System.Windows.Forms.CheckBox InsErrorSD;
        private System.Windows.Forms.Button button11;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textSpeed;
    }
}

