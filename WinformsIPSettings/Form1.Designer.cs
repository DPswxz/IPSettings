﻿namespace WinformsIPSettings
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label3 = new System.Windows.Forms.Label();
            this.IpAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SubnetMask = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Gateway = new System.Windows.Forms.TextBox();
            this.PrimaryDNS = new System.Windows.Forms.TextBox();
            this.BackupDNS = new System.Windows.Forms.TextBox();
            this.MAC = new System.Windows.Forms.TextBox();
            this.btnDefault = new System.Windows.Forms.Button();
            this.listboxAdapters = new System.Windows.Forms.ListBox();
            this.rbtnAuto = new System.Windows.Forms.RadioButton();
            this.rbtnManual = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lbIP = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbGateway = new System.Windows.Forms.Label();
            this.lbDNS1 = new System.Windows.Forms.Label();
            this.lbDNS2 = new System.Windows.Forms.Label();
            this.lbSubmask = new System.Windows.Forms.Label();
            this.btnOpenConfig = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSetDefaultIP = new System.Windows.Forms.Button();
            this.btnFill = new System.Windows.Forms.Button();
            this.btnOpenLog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 324);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "IP地址";
            // 
            // IpAddress
            // 
            this.IpAddress.Location = new System.Drawing.Point(220, 320);
            this.IpAddress.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.IpAddress.Name = "IpAddress";
            this.IpAddress.Size = new System.Drawing.Size(262, 29);
            this.IpAddress.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 378);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "子网掩码";
            // 
            // SubnetMask
            // 
            this.SubnetMask.Location = new System.Drawing.Point(220, 374);
            this.SubnetMask.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.SubnetMask.Name = "SubnetMask";
            this.SubnetMask.Size = new System.Drawing.Size(262, 29);
            this.SubnetMask.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(125, 432);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "网关";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(120, 485);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 21);
            this.label6.TabIndex = 9;
            this.label6.Text = "主DNS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(110, 539);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 21);
            this.label7.TabIndex = 10;
            this.label7.Text = "备用DNS";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(115, 593);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 21);
            this.label9.TabIndex = 12;
            this.label9.Text = "MAC地址";
            // 
            // Gateway
            // 
            this.Gateway.Location = new System.Drawing.Point(220, 429);
            this.Gateway.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Gateway.Name = "Gateway";
            this.Gateway.Size = new System.Drawing.Size(262, 29);
            this.Gateway.TabIndex = 13;
            // 
            // PrimaryDNS
            // 
            this.PrimaryDNS.Location = new System.Drawing.Point(220, 481);
            this.PrimaryDNS.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.PrimaryDNS.Name = "PrimaryDNS";
            this.PrimaryDNS.Size = new System.Drawing.Size(262, 29);
            this.PrimaryDNS.TabIndex = 14;
            // 
            // BackupDNS
            // 
            this.BackupDNS.Location = new System.Drawing.Point(220, 536);
            this.BackupDNS.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.BackupDNS.Name = "BackupDNS";
            this.BackupDNS.Size = new System.Drawing.Size(262, 29);
            this.BackupDNS.TabIndex = 15;
            // 
            // MAC
            // 
            this.MAC.Location = new System.Drawing.Point(220, 590);
            this.MAC.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MAC.Name = "MAC";
            this.MAC.ReadOnly = true;
            this.MAC.Size = new System.Drawing.Size(262, 29);
            this.MAC.TabIndex = 17;
            // 
            // btnDefault
            // 
            this.btnDefault.Location = new System.Drawing.Point(327, 649);
            this.btnDefault.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(158, 49);
            this.btnDefault.TabIndex = 18;
            this.btnDefault.Text = "设置IP";
            this.btnDefault.UseVisualStyleBackColor = true;
            this.btnDefault.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // listboxAdapters
            // 
            this.listboxAdapters.FormattingEnabled = true;
            this.listboxAdapters.HorizontalScrollbar = true;
            this.listboxAdapters.ItemHeight = 21;
            this.listboxAdapters.Location = new System.Drawing.Point(47, 22);
            this.listboxAdapters.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listboxAdapters.Name = "listboxAdapters";
            this.listboxAdapters.Size = new System.Drawing.Size(531, 172);
            this.listboxAdapters.TabIndex = 21;
            this.listboxAdapters.SelectedIndexChanged += new System.EventHandler(this.listboxAdapters_SelectedIndexChanged);
            // 
            // rbtnAuto
            // 
            this.rbtnAuto.AutoSize = true;
            this.rbtnAuto.Location = new System.Drawing.Point(245, 262);
            this.rbtnAuto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtnAuto.Name = "rbtnAuto";
            this.rbtnAuto.Size = new System.Drawing.Size(65, 25);
            this.rbtnAuto.TabIndex = 22;
            this.rbtnAuto.TabStop = true;
            this.rbtnAuto.Text = "Auto";
            this.rbtnAuto.UseVisualStyleBackColor = true;
            this.rbtnAuto.CheckedChanged += new System.EventHandler(this.rbtnAuto_CheckedChanged);
            // 
            // rbtnManual
            // 
            this.rbtnManual.AutoSize = true;
            this.rbtnManual.Location = new System.Drawing.Point(342, 262);
            this.rbtnManual.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtnManual.Name = "rbtnManual";
            this.rbtnManual.Size = new System.Drawing.Size(86, 25);
            this.rbtnManual.TabIndex = 23;
            this.rbtnManual.TabStop = true;
            this.rbtnManual.Text = "Manual";
            this.rbtnManual.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 21);
            this.label1.TabIndex = 24;
            this.label1.Text = "获取IP地址方式";
            // 
            // lbIP
            // 
            this.lbIP.AutoSize = true;
            this.lbIP.Location = new System.Drawing.Point(532, 324);
            this.lbIP.Name = "lbIP";
            this.lbIP.Size = new System.Drawing.Size(0, 21);
            this.lbIP.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(532, 378);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 21);
            this.label8.TabIndex = 26;
            // 
            // lbGateway
            // 
            this.lbGateway.AutoSize = true;
            this.lbGateway.Location = new System.Drawing.Point(532, 432);
            this.lbGateway.Name = "lbGateway";
            this.lbGateway.Size = new System.Drawing.Size(0, 21);
            this.lbGateway.TabIndex = 27;
            // 
            // lbDNS1
            // 
            this.lbDNS1.AutoSize = true;
            this.lbDNS1.Location = new System.Drawing.Point(532, 485);
            this.lbDNS1.Name = "lbDNS1";
            this.lbDNS1.Size = new System.Drawing.Size(0, 21);
            this.lbDNS1.TabIndex = 28;
            // 
            // lbDNS2
            // 
            this.lbDNS2.AutoSize = true;
            this.lbDNS2.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbDNS2.Location = new System.Drawing.Point(532, 539);
            this.lbDNS2.Name = "lbDNS2";
            this.lbDNS2.Size = new System.Drawing.Size(0, 21);
            this.lbDNS2.TabIndex = 29;
            // 
            // lbSubmask
            // 
            this.lbSubmask.AutoSize = true;
            this.lbSubmask.Location = new System.Drawing.Point(532, 378);
            this.lbSubmask.Name = "lbSubmask";
            this.lbSubmask.Size = new System.Drawing.Size(0, 21);
            this.lbSubmask.TabIndex = 30;
            // 
            // btnOpenConfig
            // 
            this.btnOpenConfig.Location = new System.Drawing.Point(428, 203);
            this.btnOpenConfig.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOpenConfig.Name = "btnOpenConfig";
            this.btnOpenConfig.Size = new System.Drawing.Size(150, 39);
            this.btnOpenConfig.TabIndex = 31;
            this.btnOpenConfig.Text = "系统网络配置";
            this.btnOpenConfig.UseVisualStyleBackColor = true;
            this.btnOpenConfig.Click += new System.EventHandler(this.btnOpenConfig_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(38, 203);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(103, 39);
            this.btnRefresh.TabIndex = 32;
            this.btnRefresh.Text = "刷新";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSetDefaultIP
            // 
            this.btnSetDefaultIP.Location = new System.Drawing.Point(149, 203);
            this.btnSetDefaultIP.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnSetDefaultIP.Name = "btnSetDefaultIP";
            this.btnSetDefaultIP.Size = new System.Drawing.Size(125, 39);
            this.btnSetDefaultIP.TabIndex = 33;
            this.btnSetDefaultIP.Text = "预设IP";
            this.btnSetDefaultIP.UseVisualStyleBackColor = true;
            this.btnSetDefaultIP.Click += new System.EventHandler(this.btnSetDefaultIP_Click);
            // 
            // btnFill
            // 
            this.btnFill.Location = new System.Drawing.Point(128, 649);
            this.btnFill.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(130, 49);
            this.btnFill.TabIndex = 34;
            this.btnFill.Text = "填入预设IP";
            this.btnFill.UseVisualStyleBackColor = true;
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // btnOpenLog
            // 
            this.btnOpenLog.Location = new System.Drawing.Point(327, 203);
            this.btnOpenLog.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnOpenLog.Name = "btnOpenLog";
            this.btnOpenLog.Size = new System.Drawing.Size(93, 39);
            this.btnOpenLog.TabIndex = 35;
            this.btnOpenLog.Text = "日志";
            this.btnOpenLog.UseVisualStyleBackColor = true;
            this.btnOpenLog.Click += new System.EventHandler(this.btnOpenLog_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 737);
            this.Controls.Add(this.btnOpenLog);
            this.Controls.Add(this.btnFill);
            this.Controls.Add(this.btnSetDefaultIP);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnOpenConfig);
            this.Controls.Add(this.lbSubmask);
            this.Controls.Add(this.lbDNS2);
            this.Controls.Add(this.lbDNS1);
            this.Controls.Add(this.lbGateway);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbIP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbtnManual);
            this.Controls.Add(this.rbtnAuto);
            this.Controls.Add(this.listboxAdapters);
            this.Controls.Add(this.btnDefault);
            this.Controls.Add(this.MAC);
            this.Controls.Add(this.BackupDNS);
            this.Controls.Add(this.PrimaryDNS);
            this.Controls.Add(this.Gateway);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SubnetMask);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.IpAddress);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Network Settings";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IpAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SubnetMask;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Gateway;
        private System.Windows.Forms.TextBox PrimaryDNS;
        private System.Windows.Forms.TextBox BackupDNS;
        private System.Windows.Forms.TextBox MAC;
        private System.Windows.Forms.Button btnDefault;
        private System.Windows.Forms.ListBox listboxAdapters;
        private System.Windows.Forms.RadioButton rbtnAuto;
        private System.Windows.Forms.RadioButton rbtnManual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbIP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbGateway;
        private System.Windows.Forms.Label lbDNS1;
        private System.Windows.Forms.Label lbDNS2;
        private System.Windows.Forms.Label lbSubmask;
        private System.Windows.Forms.Button btnOpenConfig;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSetDefaultIP;
        private System.Windows.Forms.Button btnFill;
        private System.Windows.Forms.Button btnOpenLog;
    }
}

