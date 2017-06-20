namespace IllumiWifiControl
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGetMac = new System.Windows.Forms.Button();
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
            this.groupBox2.Location = new System.Drawing.Point(12, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(636, 181);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kolory";
            // 
            // scrTime
            // 
            this.scrTime.Location = new System.Drawing.Point(112, 151);
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
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Czas przejścia barw:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(426, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Kolor domyślny (po włączeniu illumiWiFi)";
            // 
            // btnGetColors
            // 
            this.btnGetColors.Location = new System.Drawing.Point(9, 19);
            this.btnGetColors.Name = "btnGetColors";
            this.btnGetColors.Size = new System.Drawing.Size(210, 23);
            this.btnGetColors.TabIndex = 7;
            this.btnGetColors.Text = "Pobierz kolory z illumiWiFi";
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
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Kolor bieżący";
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
            this.btnSendCurrent.Text = "Wyślij bieżący kolor";
            this.btnSendCurrent.UseVisualStyleBackColor = true;
            this.btnSendCurrent.Click += new System.EventHandler(this.btnSendCurrent_Click);
            // 
            // btnSendDefault
            // 
            this.btnSendDefault.Location = new System.Drawing.Point(9, 106);
            this.btnSendDefault.Name = "btnSendDefault";
            this.btnSendDefault.Size = new System.Drawing.Size(210, 23);
            this.btnSendDefault.TabIndex = 5;
            this.btnSendDefault.Text = "Wyślij domyślny kolor";
            this.btnSendDefault.UseVisualStyleBackColor = true;
            this.btnSendDefault.Click += new System.EventHandler(this.btnSendDefault_Click);
            // 
            // btnSendWithFade
            // 
            this.btnSendWithFade.Location = new System.Drawing.Point(9, 77);
            this.btnSendWithFade.Name = "btnSendWithFade";
            this.btnSendWithFade.Size = new System.Drawing.Size(210, 23);
            this.btnSendWithFade.TabIndex = 8;
            this.btnSendWithFade.Text = "Wyślij bieżący kolor z przejściem barw";
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
            this.groupBox1.Size = new System.Drawing.Size(262, 81);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Połączenie";
            // 
            // btnConnection
            // 
            this.btnConnection.Location = new System.Drawing.Point(9, 47);
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.Size = new System.Drawing.Size(247, 23);
            this.btnConnection.TabIndex = 2;
            this.btnConnection.Text = "Połącz";
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
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numer IP lub nazwa hosta:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 286);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(636, 121);
            this.textBox1.TabIndex = 11;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnGetMac);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(281, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(367, 80);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Twoje illumi WiFi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Adres MAC:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(75, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "text";
            // 
            // btnGetMac
            // 
            this.btnGetMac.Location = new System.Drawing.Point(7, 45);
            this.btnGetMac.Name = "btnGetMac";
            this.btnGetMac.Size = new System.Drawing.Size(129, 23);
            this.btnGetMac.TabIndex = 3;
            this.btnGetMac.Text = "Pobierz adres MAC";
            this.btnGetMac.UseVisualStyleBackColor = true;
            this.btnGetMac.Click += new System.EventHandler(this.btnGetMac_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 426);
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
    }
}

