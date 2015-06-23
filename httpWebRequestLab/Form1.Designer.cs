namespace httpWebRequestLab
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlToolbar = new System.Windows.Forms.Panel();
            this.cboUrl = new System.Windows.Forms.ComboBox();
            this.cbxAuthLevel = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPattern = new System.Windows.Forms.TextBox();
            this.numTimeOut = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGo = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.pnlToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeOut)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlToolbar
            // 
            this.pnlToolbar.Controls.Add(this.cboUrl);
            this.pnlToolbar.Controls.Add(this.cbxAuthLevel);
            this.pnlToolbar.Controls.Add(this.label4);
            this.pnlToolbar.Controls.Add(this.label3);
            this.pnlToolbar.Controls.Add(this.txtPattern);
            this.pnlToolbar.Controls.Add(this.numTimeOut);
            this.pnlToolbar.Controls.Add(this.label2);
            this.pnlToolbar.Controls.Add(this.label1);
            this.pnlToolbar.Controls.Add(this.btnGo);
            this.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolbar.Location = new System.Drawing.Point(0, 0);
            this.pnlToolbar.Name = "pnlToolbar";
            this.pnlToolbar.Size = new System.Drawing.Size(660, 100);
            this.pnlToolbar.TabIndex = 0;
            // 
            // cboUrl
            // 
            this.cboUrl.FormattingEnabled = true;
            this.cboUrl.Items.AddRange(new object[] {
            "https://tw.yahoo.com/",
            "http://www.google.com"});
            this.cboUrl.Location = new System.Drawing.Point(52, 12);
            this.cboUrl.Name = "cboUrl";
            this.cboUrl.Size = new System.Drawing.Size(361, 20);
            this.cboUrl.TabIndex = 0;
            // 
            // cbxAuthLevel
            // 
            this.cbxAuthLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAuthLevel.FormattingEnabled = true;
            this.cbxAuthLevel.Location = new System.Drawing.Point(122, 38);
            this.cbxAuthLevel.Name = "cbxAuthLevel";
            this.cbxAuthLevel.Size = new System.Drawing.Size(291, 20);
            this.cbxAuthLevel.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "Authentication Level";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "RegEx pattern";
            // 
            // txtPattern
            // 
            this.txtPattern.Location = new System.Drawing.Point(122, 64);
            this.txtPattern.Name = "txtPattern";
            this.txtPattern.Size = new System.Drawing.Size(291, 22);
            this.txtPattern.TabIndex = 3;
            this.txtPattern.Text = "[\\s\\S]*(<html)[\\s\\S]*(<\\/html>)[\\s\\S]*";
            // 
            // numTimeOut
            // 
            this.numTimeOut.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numTimeOut.Location = new System.Drawing.Point(493, 13);
            this.numTimeOut.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numTimeOut.Name = "numTimeOut";
            this.numTimeOut.Size = new System.Drawing.Size(99, 22);
            this.numTimeOut.TabIndex = 1;
            this.numTimeOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numTimeOut.ThousandsSeparator = true;
            this.numTimeOut.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(419, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Timeout (ms)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "URL";
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(543, 62);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 4;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMessage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtMessage.Font = new System.Drawing.Font("細明體-ExtB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMessage.Location = new System.Drawing.Point(0, 371);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMessage.Size = new System.Drawing.Size(660, 137);
            this.txtMessage.TabIndex = 1;
            // 
            // txtOutput
            // 
            this.txtOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOutput.Font = new System.Drawing.Font("細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtOutput.Location = new System.Drawing.Point(0, 100);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOutput.Size = new System.Drawing.Size(660, 271);
            this.txtOutput.TabIndex = 2;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnGo;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 508);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.pnlToolbar);
            this.Controls.Add(this.txtMessage);
            this.Name = "Form1";
            this.Text = "HttpWebRequest Lab";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlToolbar.ResumeLayout(false);
            this.pnlToolbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeOut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlToolbar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.NumericUpDown numTimeOut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPattern;
        private System.Windows.Forms.ComboBox cbxAuthLevel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboUrl;
    }
}

