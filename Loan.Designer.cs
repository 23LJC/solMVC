
namespace 期中貸款
{
    partial class Loan
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
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
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.labMonth = new System.Windows.Forms.Button();
            this.labTotal = new System.Windows.Forms.Button();
            this.loanReport = new System.Windows.Forms.Button();
            this.labLoan = new System.Windows.Forms.Label();
            this.labDeadline = new System.Windows.Forms.Label();
            this.labInterestRate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLoan = new System.Windows.Forms.TextBox();
            this.txtDeadLine = new System.Windows.Forms.TextBox();
            this.txtInterestRate = new System.Windows.Forms.TextBox();
            this.txtDownPayment = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labMonth
            // 
            this.labMonth.Location = new System.Drawing.Point(106, 526);
            this.labMonth.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.labMonth.Name = "labMonth";
            this.labMonth.Size = new System.Drawing.Size(163, 46);
            this.labMonth.TabIndex = 0;
            this.labMonth.Text = "PMT(月付";
            this.labMonth.UseVisualStyleBackColor = true;
            this.labMonth.Click += new System.EventHandler(this.button1_Click);
            // 
            // labTotal
            // 
            this.labTotal.Location = new System.Drawing.Point(327, 526);
            this.labTotal.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.labTotal.Name = "labTotal";
            this.labTotal.Size = new System.Drawing.Size(163, 46);
            this.labTotal.TabIndex = 1;
            this.labTotal.Text = "總付款";
            this.labTotal.UseVisualStyleBackColor = true;
            this.labTotal.Click += new System.EventHandler(this.button2_Click);
            // 
            // loanReport
            // 
            this.loanReport.AllowDrop = true;
            this.loanReport.Location = new System.Drawing.Point(542, 526);
            this.loanReport.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.loanReport.Name = "loanReport";
            this.loanReport.Size = new System.Drawing.Size(163, 46);
            this.loanReport.TabIndex = 2;
            this.loanReport.Text = "Report";
            this.loanReport.UseVisualStyleBackColor = true;
            this.loanReport.Click += new System.EventHandler(this.loanReport_Click_1);
            // 
            // labLoan
            // 
            this.labLoan.AutoSize = true;
            this.labLoan.Location = new System.Drawing.Point(163, 128);
            this.labLoan.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.labLoan.Name = "labLoan";
            this.labLoan.Size = new System.Drawing.Size(106, 24);
            this.labLoan.TabIndex = 3;
            this.labLoan.Text = "貸款金額";
            // 
            // labDeadline
            // 
            this.labDeadline.AutoSize = true;
            this.labDeadline.Location = new System.Drawing.Point(163, 222);
            this.labDeadline.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.labDeadline.Name = "labDeadline";
            this.labDeadline.Size = new System.Drawing.Size(98, 24);
            this.labDeadline.TabIndex = 4;
            this.labDeadline.Text = "期限(年)";
            // 
            // labInterestRate
            // 
            this.labInterestRate.AutoSize = true;
            this.labInterestRate.Location = new System.Drawing.Point(163, 318);
            this.labInterestRate.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.labInterestRate.Name = "labInterestRate";
            this.labInterestRate.Size = new System.Drawing.Size(93, 24);
            this.labInterestRate.TabIndex = 5;
            this.labInterestRate.Text = "利率(%)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(163, 422);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "頭期款";
            // 
            // txtLoan
            // 
            this.txtLoan.Location = new System.Drawing.Point(327, 128);
            this.txtLoan.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtLoan.Name = "txtLoan";
            this.txtLoan.Size = new System.Drawing.Size(212, 36);
            this.txtLoan.TabIndex = 7;
            // 
            // txtDeadLine
            // 
            this.txtDeadLine.Location = new System.Drawing.Point(327, 222);
            this.txtDeadLine.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtDeadLine.Name = "txtDeadLine";
            this.txtDeadLine.Size = new System.Drawing.Size(212, 36);
            this.txtDeadLine.TabIndex = 8;
            // 
            // txtInterestRate
            // 
            this.txtInterestRate.Location = new System.Drawing.Point(327, 312);
            this.txtInterestRate.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.Size = new System.Drawing.Size(212, 36);
            this.txtInterestRate.TabIndex = 9;
            // 
            // txtDownPayment
            // 
            this.txtDownPayment.Location = new System.Drawing.Point(327, 402);
            this.txtDownPayment.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtDownPayment.Name = "txtDownPayment";
            this.txtDownPayment.Size = new System.Drawing.Size(212, 36);
            this.txtDownPayment.TabIndex = 10;
            // 
            // Loan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 685);
            this.Controls.Add(this.txtDownPayment);
            this.Controls.Add(this.txtInterestRate);
            this.Controls.Add(this.txtDeadLine);
            this.Controls.Add(this.txtLoan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labInterestRate);
            this.Controls.Add(this.labDeadline);
            this.Controls.Add(this.labLoan);
            this.Controls.Add(this.loanReport);
            this.Controls.Add(this.labTotal);
            this.Controls.Add(this.labMonth);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Loan";
            this.Text = "貸款金額計算";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button labMonth;
        private System.Windows.Forms.Button labTotal;
        private System.Windows.Forms.Button loanReport;
        private System.Windows.Forms.Label labLoan;
        private System.Windows.Forms.Label labDeadline;
        private System.Windows.Forms.Label labInterestRate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLoan;
        private System.Windows.Forms.TextBox txtDeadLine;
        private System.Windows.Forms.TextBox txtInterestRate;
        private System.Windows.Forms.TextBox txtDownPayment;
    }
}

