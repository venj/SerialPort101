namespace SerialReader
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
            this.portsBox = new System.Windows.Forms.ComboBox();
            this.openCloseButton = new System.Windows.Forms.Button();
            this.logBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rateBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.parityBox = new System.Windows.Forms.ComboBox();
            this.dataBitsBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.stopBitsBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.clearLogButton = new System.Windows.Forms.Button();
            this.dataOutputBox = new System.Windows.Forms.TextBox();
            this.clearDataButton = new System.Windows.Forms.Button();
            this.sendMessageButton = new System.Windows.Forms.Button();
            this.base64CheckBox = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // portsBox
            // 
            this.portsBox.FormattingEnabled = true;
            this.portsBox.Location = new System.Drawing.Point(60, 12);
            this.portsBox.Name = "portsBox";
            this.portsBox.Size = new System.Drawing.Size(86, 20);
            this.portsBox.TabIndex = 3;
            // 
            // openCloseButton
            // 
            this.openCloseButton.Location = new System.Drawing.Point(362, 36);
            this.openCloseButton.Name = "openCloseButton";
            this.openCloseButton.Size = new System.Drawing.Size(66, 23);
            this.openCloseButton.TabIndex = 2;
            this.openCloseButton.Text = "打开";
            this.openCloseButton.UseVisualStyleBackColor = true;
            this.openCloseButton.Click += new System.EventHandler(this.openCloseButton_Click);
            // 
            // logBox
            // 
            this.logBox.Location = new System.Drawing.Point(434, 12);
            this.logBox.Multiline = true;
            this.logBox.Name = "logBox";
            this.logBox.ReadOnly = true;
            this.logBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logBox.Size = new System.Drawing.Size(217, 372);
            this.logBox.TabIndex = 4;
            this.logBox.Tag = "是";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "串口";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "波特率";
            // 
            // rateBox
            // 
            this.rateBox.FormattingEnabled = true;
            this.rateBox.Items.AddRange(new object[] {
            "150",
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.rateBox.Location = new System.Drawing.Point(199, 12);
            this.rateBox.Name = "rateBox";
            this.rateBox.Size = new System.Drawing.Size(86, 20);
            this.rateBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(295, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "校验位";
            // 
            // parityBox
            // 
            this.parityBox.FormattingEnabled = true;
            this.parityBox.Items.AddRange(new object[] {
            "Even",
            "Mark",
            "None",
            "Odd",
            "Space"});
            this.parityBox.Location = new System.Drawing.Point(342, 12);
            this.parityBox.Name = "parityBox";
            this.parityBox.Size = new System.Drawing.Size(86, 20);
            this.parityBox.TabIndex = 8;
            // 
            // dataBitsBox
            // 
            this.dataBitsBox.FormattingEnabled = true;
            this.dataBitsBox.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.dataBitsBox.Location = new System.Drawing.Point(60, 38);
            this.dataBitsBox.Name = "dataBitsBox";
            this.dataBitsBox.Size = new System.Drawing.Size(86, 20);
            this.dataBitsBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "数据位";
            // 
            // stopBitsBox
            // 
            this.stopBitsBox.FormattingEnabled = true;
            this.stopBitsBox.Items.AddRange(new object[] {
            "1",
            "2"});
            this.stopBitsBox.Location = new System.Drawing.Point(199, 38);
            this.stopBitsBox.Name = "stopBitsBox";
            this.stopBitsBox.Size = new System.Drawing.Size(86, 20);
            this.stopBitsBox.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(152, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "停止位";
            // 
            // clearLogButton
            // 
            this.clearLogButton.Location = new System.Drawing.Point(576, 390);
            this.clearLogButton.Name = "clearLogButton";
            this.clearLogButton.Size = new System.Drawing.Size(75, 23);
            this.clearLogButton.TabIndex = 11;
            this.clearLogButton.Text = "清空日志";
            this.clearLogButton.UseVisualStyleBackColor = true;
            this.clearLogButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataOutputBox
            // 
            this.dataOutputBox.Location = new System.Drawing.Point(12, 65);
            this.dataOutputBox.Multiline = true;
            this.dataOutputBox.Name = "dataOutputBox";
            this.dataOutputBox.ReadOnly = true;
            this.dataOutputBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataOutputBox.Size = new System.Drawing.Size(416, 319);
            this.dataOutputBox.TabIndex = 12;
            this.dataOutputBox.Tag = "是";
            // 
            // clearDataButton
            // 
            this.clearDataButton.Location = new System.Drawing.Point(12, 390);
            this.clearDataButton.Name = "clearDataButton";
            this.clearDataButton.Size = new System.Drawing.Size(75, 23);
            this.clearDataButton.TabIndex = 11;
            this.clearDataButton.Text = "清空数据";
            this.clearDataButton.UseVisualStyleBackColor = true;
            this.clearDataButton.Click += new System.EventHandler(this.clearDataButton_Click);
            // 
            // sendMessageButton
            // 
            this.sendMessageButton.Location = new System.Drawing.Point(352, 390);
            this.sendMessageButton.Name = "sendMessageButton";
            this.sendMessageButton.Size = new System.Drawing.Size(75, 23);
            this.sendMessageButton.TabIndex = 13;
            this.sendMessageButton.Text = "发送消息";
            this.sendMessageButton.UseVisualStyleBackColor = true;
            this.sendMessageButton.Click += new System.EventHandler(this.sendMessageButton_Click);
            // 
            // base64CheckBox
            // 
            this.base64CheckBox.AutoSize = true;
            this.base64CheckBox.Location = new System.Drawing.Point(297, 40);
            this.base64CheckBox.Name = "base64CheckBox";
            this.base64CheckBox.Size = new System.Drawing.Size(60, 16);
            this.base64CheckBox.TabIndex = 14;
            this.base64CheckBox.Text = "Base64";
            this.base64CheckBox.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(143, 395);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(203, 12);
            this.label6.TabIndex = 15;
            this.label6.Text = "发送消息按钮仅用于单串口调试。-->";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 422);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.base64CheckBox);
            this.Controls.Add(this.sendMessageButton);
            this.Controls.Add(this.dataOutputBox);
            this.Controls.Add(this.clearDataButton);
            this.Controls.Add(this.clearLogButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataBitsBox);
            this.Controls.Add(this.parityBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.stopBitsBox);
            this.Controls.Add(this.rateBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.portsBox);
            this.Controls.Add(this.openCloseButton);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "串口读取";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox portsBox;
        private System.Windows.Forms.Button openCloseButton;
        private System.Windows.Forms.TextBox logBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox rateBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox parityBox;
        private System.Windows.Forms.ComboBox dataBitsBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox stopBitsBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button clearLogButton;
        private System.Windows.Forms.TextBox dataOutputBox;
        private System.Windows.Forms.Button clearDataButton;
        private System.Windows.Forms.Button sendMessageButton;
        private System.Windows.Forms.CheckBox base64CheckBox;
        private System.Windows.Forms.Label label6;
    }
}

