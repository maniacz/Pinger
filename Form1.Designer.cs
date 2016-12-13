namespace Pinger
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
            this.mtbxStartIP = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mtbxEndIP = new System.Windows.Forms.MaskedTextBox();
            this.cbxExclude = new System.Windows.Forms.CheckBox();
            this.clbxExcludedIPs = new System.Windows.Forms.CheckedListBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.tbxPingReport = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // mtbxStartIP
            // 
            this.mtbxStartIP.Location = new System.Drawing.Point(63, 12);
            this.mtbxStartIP.Mask = "###\\.###\\.###\\.###";
            this.mtbxStartIP.Name = "mtbxStartIP";
            this.mtbxStartIP.Size = new System.Drawing.Size(100, 20);
            this.mtbxStartIP.TabIndex = 0;
            this.mtbxStartIP.Text = "14922324370";
            this.mtbxStartIP.TextChanged += new System.EventHandler(this.mtbxStartIP_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Start IP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "End IP:";
            // 
            // mtbxEndIP
            // 
            this.mtbxEndIP.Location = new System.Drawing.Point(236, 12);
            this.mtbxEndIP.Mask = "###\\.###\\.###\\.###";
            this.mtbxEndIP.Name = "mtbxEndIP";
            this.mtbxEndIP.Size = new System.Drawing.Size(100, 20);
            this.mtbxEndIP.TabIndex = 2;
            this.mtbxEndIP.Text = "14922324375";
            this.mtbxEndIP.Leave += new System.EventHandler(this.mtbxEndIP_Leave);
            // 
            // cbxExclude
            // 
            this.cbxExclude.AutoSize = true;
            this.cbxExclude.Location = new System.Drawing.Point(15, 38);
            this.cbxExclude.Name = "cbxExclude";
            this.cbxExclude.Size = new System.Drawing.Size(67, 17);
            this.cbxExclude.TabIndex = 4;
            this.cbxExclude.Text = "Exclude:";
            this.cbxExclude.UseVisualStyleBackColor = true;
            this.cbxExclude.CheckedChanged += new System.EventHandler(this.cbxExclude_CheckedChanged);
            // 
            // clbxExcludedIPs
            // 
            this.clbxExcludedIPs.FormattingEnabled = true;
            this.clbxExcludedIPs.Location = new System.Drawing.Point(12, 61);
            this.clbxExcludedIPs.Name = "clbxExcludedIPs";
            this.clbxExcludedIPs.Size = new System.Drawing.Size(151, 319);
            this.clbxExcludedIPs.TabIndex = 5;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(593, 354);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(148, 23);
            this.btnRun.TabIndex = 6;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // tbxPingReport
            // 
            this.tbxPingReport.Location = new System.Drawing.Point(170, 61);
            this.tbxPingReport.Multiline = true;
            this.tbxPingReport.Name = "tbxPingReport";
            this.tbxPingReport.Size = new System.Drawing.Size(571, 287);
            this.tbxPingReport.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 389);
            this.Controls.Add(this.tbxPingReport);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.clbxExcludedIPs);
            this.Controls.Add(this.cbxExclude);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mtbxEndIP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mtbxStartIP);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Pinger";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtbxStartIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtbxEndIP;
        private System.Windows.Forms.CheckBox cbxExclude;
        private System.Windows.Forms.CheckedListBox clbxExcludedIPs;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.TextBox tbxPingReport;
    }
}

