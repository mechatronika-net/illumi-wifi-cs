namespace mechatronika_net.illumiwifi.examples
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.scrTime = new System.Windows.Forms.HScrollBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGetColors = new System.Windows.Forms.Button();
            this.pnlDefault = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlCurrent = new System.Windows.Forms.Panel();
            this.btnSendCurrent = new System.Windows.Forms.Button();
            this.btnSendDefault = new System.Windows.Forms.Button();
            this.btnSendWithFade = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnConnection = new System.Windows.Forms.Button();
            this.tbHost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGetMac = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.scrTime);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnGetColors);
            this.groupBox2.Controls.Add(this.pnlDefault);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.pnlCurrent);
            this.groupBox2.Controls.Add(this.btnSendCurrent);
            this.groupBox2.Controls.Add(this.btnSendDefault);
            this.groupBox2.Controls.Add(this.btnSendWithFade);
            this.groupBox2.Location = new System.Drawing.Point(12, 142);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(636, 181);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Colors";
            // 
            // scrTime
            // 
            this.scrTime.Location = new System.Drawing.Point(112, 154);
            this.scrTime.Name = "scrTime";
            this.scrTime.Size = new System.Drawing.Size(510, 16);
            this.scrTime.TabIndex = 14;
            this.scrTime.Value = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Color fade time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(426, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Default color (after turning on illumi WiFi)";
            // 
            // btnGetColors
            // 
            this.btnGetColors.Location = new System.Drawing.Point(9, 19);
            this.btnGetColors.Name = "btnGetColors";
            this.btnGetColors.Size = new System.Drawing.Size(210, 23);
            this.btnGetColors.TabIndex = 7;
            this.btnGetColors.Text = "Get colors from illumi WiFi";
            this.btnGetColors.UseVisualStyleBackColor = true;
            this.btnGetColors.Click += new System.EventHandler(this.btnGetColors_Click);
            // 
            // pnlDefault
            // 
            this.pnlDefault.Location = new System.Drawing.Point(429, 48);
            this.pnlDefault.Name = "pnlDefault";
            this.pnlDefault.Size = new System.Drawing.Size(154, 81);
            this.pnlDefault.TabIndex = 11;
            this.pnlDefault.Click += new System.EventHandler(this.pnlDefault_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Current collor";
            // 
            // pnlCurrent
            // 
            this.pnlCurrent.Location = new System.Drawing.Point(251, 48);
            this.pnlCurrent.Name = "pnlCurrent";
            this.pnlCurrent.Size = new System.Drawing.Size(154, 81);
            this.pnlCurrent.TabIndex = 9;
            this.pnlCurrent.Click += new System.EventHandler(this.pnlCurrent_Click);
            // 
            // btnSendCurrent
            // 
            this.btnSendCurrent.Location = new System.Drawing.Point(9, 48);
            this.btnSendCurrent.Name = "btnSendCurrent";
            this.btnSendCurrent.Size = new System.Drawing.Size(210, 23);
            this.btnSendCurrent.TabIndex = 0;
            this.btnSendCurrent.Text = "Send current color";
            this.btnSendCurrent.UseVisualStyleBackColor = true;
            this.btnSendCurrent.Click += new System.EventHandler(this.btnSendCurrent_Click);
            // 
            // btnSendDefault
            // 
            this.btnSendDefault.Location = new System.Drawing.Point(9, 106);
            this.btnSendDefault.Name = "btnSendDefault";
            this.btnSendDefault.Size = new System.Drawing.Size(210, 23);
            this.btnSendDefault.TabIndex = 5;
            this.btnSendDefault.Text = "Send default color";
            this.btnSendDefault.UseVisualStyleBackColor = true;
            this.btnSendDefault.Click += new System.EventHandler(this.btnSendDefault_Click);
            // 
            // btnSendWithFade
            // 
            this.btnSendWithFade.Location = new System.Drawing.Point(9, 77);
            this.btnSendWithFade.Name = "btnSendWithFade";
            this.btnSendWithFade.Size = new System.Drawing.Size(210, 23);
            this.btnSendWithFade.TabIndex = 8;
            this.btnSendWithFade.Text = "Send current color with fade";
            this.btnSendWithFade.UseVisualStyleBackColor = true;
            this.btnSendWithFade.Click += new System.EventHandler(this.btnSendWithFade_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnConnection);
            this.groupBox1.Controls.Add(this.tbHost);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 110);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection";
            // 
            // btnConnection
            // 
            this.btnConnection.Location = new System.Drawing.Point(9, 81);
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.Size = new System.Drawing.Size(247, 23);
            this.btnConnection.TabIndex = 2;
            this.btnConnection.Text = "Connect";
            this.btnConnection.UseVisualStyleBackColor = true;
            this.btnConnection.Click += new System.EventHandler(this.btnConnection_Click);
            // 
            // tbHost
            // 
            this.tbHost.Location = new System.Drawing.Point(146, 19);
            this.tbHost.Name = "tbHost";
            this.tbHost.Size = new System.Drawing.Size(110, 20);
            this.tbHost.TabIndex = 1;
            this.tbHost.Text = "192.168.0.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP address or hostname:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 359);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(636, 121);
            this.textBox1.TabIndex = 11;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.btnGetMac);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(281, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(367, 109);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Your illumi WiFi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(78, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Version:";
            // 
            // btnGetMac
            // 
            this.btnGetMac.Location = new System.Drawing.Point(6, 80);
            this.btnGetMac.Name = "btnGetMac";
            this.btnGetMac.Size = new System.Drawing.Size(129, 23);
            this.btnGetMac.TabIndex = 3;
            this.btnGetMac.Text = "Get info";
            this.btnGetMac.UseVisualStyleBackColor = true;
            this.btnGetMac.Click += new System.EventHandler(this.btnGetMac_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(75, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "MAC address:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 492);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Illumi WiFi Control";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.HScrollBar scrTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGetColors;
        private System.Windows.Forms.Panel pnlDefault;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlCurrent;
        private System.Windows.Forms.Button btnSendCurrent;
        private System.Windows.Forms.Button btnSendDefault;
        private System.Windows.Forms.Button btnSendWithFade;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnConnection;
        private System.Windows.Forms.TextBox tbHost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGetMac;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}

