﻿namespace 串口工具
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssl_tx = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssl_rx = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssl_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.text_com = new System.Windows.Forms.NumericUpDown();
            this.bt_open = new System.Windows.Forms.Button();
            this.text_stop = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.text_parity = new System.Windows.Forms.ComboBox();
            this.text_data = new System.Windows.Forms.ComboBox();
            this.text_baud = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_clear = new System.Windows.Forms.Button();
            this.tb_read = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.bt_send = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.hSerialPort = new System.IO.Ports.SerialPort(this.components);
            this.timer_send = new System.Windows.Forms.Timer(this.components);
            this.timer_ref = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.text_com)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel3,
            this.tssl_tx,
            this.tssl_rx,
            this.toolStripStatusLabel1,
            this.tssl_status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 531);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(932, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(32, 17);
            this.toolStripStatusLabel3.Text = "      ";
            // 
            // tssl_tx
            // 
            this.tssl_tx.Name = "tssl_tx";
            this.tssl_tx.Size = new System.Drawing.Size(58, 17);
            this.tssl_tx.Text = "Tx:0,Rx:0";
            // 
            // tssl_rx
            // 
            this.tssl_rx.Name = "tssl_rx";
            this.tssl_rx.Size = new System.Drawing.Size(32, 17);
            this.tssl_rx.Text = "Rx:0";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(32, 17);
            this.toolStripStatusLabel1.Text = "      ";
            // 
            // tssl_status
            // 
            this.tssl_status.Name = "tssl_status";
            this.tssl_status.Size = new System.Drawing.Size(57, 17);
            this.tssl_status.Text = "Closed...";
            // 
            // text_com
            // 
            this.text_com.Location = new System.Drawing.Point(101, 22);
            this.text_com.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.text_com.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.text_com.Name = "text_com";
            this.text_com.Size = new System.Drawing.Size(79, 21);
            this.text_com.TabIndex = 4;
            this.text_com.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.text_com.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // bt_open
            // 
            this.bt_open.Location = new System.Drawing.Point(63, 173);
            this.bt_open.Name = "bt_open";
            this.bt_open.Size = new System.Drawing.Size(98, 36);
            this.bt_open.TabIndex = 2;
            this.bt_open.Text = "打开";
            this.bt_open.UseVisualStyleBackColor = true;
            this.bt_open.Click += new System.EventHandler(this.bt_open_Click);
            // 
            // text_stop
            // 
            this.text_stop.FormattingEnabled = true;
            this.text_stop.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2",
            "0"});
            this.text_stop.Location = new System.Drawing.Point(101, 131);
            this.text_stop.Name = "text_stop";
            this.text_stop.Size = new System.Drawing.Size(79, 20);
            this.text_stop.TabIndex = 1;
            this.text_stop.Text = "1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.text_com);
            this.groupBox3.Controls.Add(this.bt_open);
            this.groupBox3.Controls.Add(this.text_stop);
            this.groupBox3.Controls.Add(this.text_parity);
            this.groupBox3.Controls.Add(this.text_data);
            this.groupBox3.Controls.Add(this.text_baud);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(224, 224);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "串口设置";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(204, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 14);
            this.label6.TabIndex = 5;
            this.label6.Text = "？";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // text_parity
            // 
            this.text_parity.FormattingEnabled = true;
            this.text_parity.Items.AddRange(new object[] {
            "无",
            "奇校验",
            "偶校验"});
            this.text_parity.Location = new System.Drawing.Point(101, 104);
            this.text_parity.Name = "text_parity";
            this.text_parity.Size = new System.Drawing.Size(79, 20);
            this.text_parity.TabIndex = 1;
            this.text_parity.Text = "无";
            // 
            // text_data
            // 
            this.text_data.FormattingEnabled = true;
            this.text_data.Items.AddRange(new object[] {
            "8",
            "7",
            "6"});
            this.text_data.Location = new System.Drawing.Point(101, 77);
            this.text_data.Name = "text_data";
            this.text_data.Size = new System.Drawing.Size(79, 20);
            this.text_data.TabIndex = 1;
            this.text_data.Text = "8";
            // 
            // text_baud
            // 
            this.text_baud.FormattingEnabled = true;
            this.text_baud.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "7200",
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200",
            "128000"});
            this.text_baud.Location = new System.Drawing.Point(101, 50);
            this.text_baud.Name = "text_baud";
            this.text_baud.Size = new System.Drawing.Size(79, 20);
            this.text_baud.TabIndex = 1;
            this.text_baud.Text = "115200";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "停止位";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "校验";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "数据位";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "波特率";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "COM";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer2.Panel1.Controls.Add(this.panel3);
            this.splitContainer2.Panel1.Controls.Add(this.panel5);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.bt_send);
            this.splitContainer2.Panel2.Controls.Add(this.panel6);
            this.splitContainer2.Panel2.Controls.Add(this.panel4);
            this.splitContainer2.Size = new System.Drawing.Size(704, 531);
            this.splitContainer2.SplitterDistance = 401;
            this.splitContainer2.TabIndex = 1;
            this.splitContainer2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_clear);
            this.groupBox1.Controls.Add(this.tb_read);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(694, 391);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "打印张数";
            // 
            // bt_clear
            // 
            this.bt_clear.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_clear.Location = new System.Drawing.Point(560, 0);
            this.bt_clear.Name = "bt_clear";
            this.bt_clear.Size = new System.Drawing.Size(128, 19);
            this.bt_clear.TabIndex = 5;
            this.bt_clear.Text = "清空";
            this.bt_clear.UseVisualStyleBackColor = true;
            this.bt_clear.Click += new System.EventHandler(this.bt_clear_Click);
            // 
            // tb_read
            // 
            this.tb_read.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_read.Font = new System.Drawing.Font("宋体", 249.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_read.Location = new System.Drawing.Point(3, 17);
            this.tb_read.Multiline = true;
            this.tb_read.Name = "tb_read";
            this.tb_read.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_read.Size = new System.Drawing.Size(688, 371);
            this.tb_read.TabIndex = 3;
            this.tb_read.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 391);
            this.panel3.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(704, 10);
            this.panel5.TabIndex = 2;
            // 
            // bt_send
            // 
            this.bt_send.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_send.Location = new System.Drawing.Point(16, 16);
            this.bt_send.Name = "bt_send";
            this.bt_send.Size = new System.Drawing.Size(667, 100);
            this.bt_send.TabIndex = 1;
            this.bt_send.Text = "新的打印计数";
            this.bt_send.UseVisualStyleBackColor = true;
            this.bt_send.Click += new System.EventHandler(this.bt_send_Click);
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(10, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(694, 10);
            this.panel6.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 126);
            this.panel4.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(704, 531);
            this.panel1.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer1.Size = new System.Drawing.Size(932, 531);
            this.splitContainer1.SplitterDistance = 704;
            this.splitContainer1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(5, 440);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(212, 81);
            this.panel2.TabIndex = 5;
            // 
            // hSerialPort
            // 
            this.hSerialPort.BaudRate = 115200;
            // 
            // timer_send
            // 
            this.timer_send.Tick += new System.EventHandler(this.timer_send_Tick);
            // 
            // timer_ref
            // 
            this.timer_ref.Enabled = true;
            this.timer_ref.Tick += new System.EventHandler(this.timer_ref_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 553);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Print Paper";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.text_com)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssl_status;
        private System.Windows.Forms.NumericUpDown text_com;
        private System.Windows.Forms.Button bt_open;
        private System.Windows.Forms.ComboBox text_stop;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox text_parity;
        private System.Windows.Forms.ComboBox text_data;
        private System.Windows.Forms.ComboBox text_baud;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bt_send;
        private System.IO.Ports.SerialPort hSerialPort;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.Timer timer_send;
        private System.Windows.Forms.Timer timer_ref;
        private System.Windows.Forms.ToolStripStatusLabel tssl_tx;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tssl_rx;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_clear;
        private System.Windows.Forms.TextBox tb_read;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
    }
}

