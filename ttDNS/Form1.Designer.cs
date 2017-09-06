namespace ttDNS
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
            this.domeneTxt = new System.Windows.Forms.TextBox();
            this.startBTN = new System.Windows.Forms.Button();
            this.IPaddLbl = new System.Windows.Forms.Label();
            this.dnsServerTxt = new System.Windows.Forms.TextBox();
            this.nsLbl = new System.Windows.Forms.Label();
            this.resolTimer = new System.Windows.Forms.Timer(this.components);
            this.timerBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timStopBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // domeneTxt
            // 
            this.domeneTxt.Location = new System.Drawing.Point(102, 117);
            this.domeneTxt.Name = "domeneTxt";
            this.domeneTxt.Size = new System.Drawing.Size(100, 20);
            this.domeneTxt.TabIndex = 0;
            this.domeneTxt.Text = "griegstar.com";
            // 
            // startBTN
            // 
            this.startBTN.Location = new System.Drawing.Point(357, 117);
            this.startBTN.Name = "startBTN";
            this.startBTN.Size = new System.Drawing.Size(75, 23);
            this.startBTN.TabIndex = 1;
            this.startBTN.Text = "etFrosøk";
            this.startBTN.UseVisualStyleBackColor = true;
            this.startBTN.Click += new System.EventHandler(this.startBTN_Click);
            // 
            // IPaddLbl
            // 
            this.IPaddLbl.AutoSize = true;
            this.IPaddLbl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.IPaddLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.IPaddLbl.Location = new System.Drawing.Point(587, 117);
            this.IPaddLbl.Name = "IPaddLbl";
            this.IPaddLbl.Size = new System.Drawing.Size(0, 13);
            this.IPaddLbl.TabIndex = 2;
            // 
            // dnsServerTxt
            // 
            this.dnsServerTxt.Location = new System.Drawing.Point(102, 169);
            this.dnsServerTxt.Name = "dnsServerTxt";
            this.dnsServerTxt.Size = new System.Drawing.Size(100, 20);
            this.dnsServerTxt.TabIndex = 3;
            this.dnsServerTxt.Text = "8.8.8.8";
            // 
            // nsLbl
            // 
            this.nsLbl.AutoSize = true;
            this.nsLbl.Location = new System.Drawing.Point(272, 319);
            this.nsLbl.Name = "nsLbl";
            this.nsLbl.Size = new System.Drawing.Size(0, 13);
            this.nsLbl.TabIndex = 4;
            // 
            // resolTimer
            // 
            this.resolTimer.Interval = 1000;
            this.resolTimer.Tick += new System.EventHandler(this.resolTimer_Tick);
            // 
            // timerBtn
            // 
            this.timerBtn.Location = new System.Drawing.Point(357, 147);
            this.timerBtn.Name = "timerBtn";
            this.timerBtn.Size = new System.Drawing.Size(75, 23);
            this.timerBtn.TabIndex = 5;
            this.timerBtn.Text = "timer";
            this.timerBtn.UseVisualStyleBackColor = true;
            this.timerBtn.Click += new System.EventHandler(this.timerBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "DNS server";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Host to resolve";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(275, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "NS lookup";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(587, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Reslove (lokal DNS)";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // timStopBtn
            // 
            this.timStopBtn.Location = new System.Drawing.Point(357, 176);
            this.timStopBtn.Name = "timStopBtn";
            this.timStopBtn.Size = new System.Drawing.Size(75, 23);
            this.timStopBtn.TabIndex = 10;
            this.timStopBtn.Text = "Stop Timer\'";
            this.timStopBtn.UseVisualStyleBackColor = true;
            this.timStopBtn.Click += new System.EventHandler(this.timStopBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 647);
            this.Controls.Add(this.timStopBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timerBtn);
            this.Controls.Add(this.nsLbl);
            this.Controls.Add(this.dnsServerTxt);
            this.Controls.Add(this.IPaddLbl);
            this.Controls.Add(this.startBTN);
            this.Controls.Add(this.domeneTxt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox domeneTxt;
        private System.Windows.Forms.Button startBTN;
        private System.Windows.Forms.Label IPaddLbl;
        private System.Windows.Forms.TextBox dnsServerTxt;
        private System.Windows.Forms.Label nsLbl;
        private System.Windows.Forms.Timer resolTimer;
        private System.Windows.Forms.Button timerBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button timStopBtn;
    }
}

