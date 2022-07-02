
namespace 期中貸款
{
    partial class LoanReport
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labLoan = new System.Windows.Forms.TextBox();
            this.labDeadline = new System.Windows.Forms.TextBox();
            this.labInterestRate = new System.Windows.Forms.TextBox();
            this.labMonth = new System.Windows.Forms.TextBox();
            this.labTotal = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "貸款金額:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "期限(年)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "利率(%)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "月付款";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "總付款";
            // 
            // labLoan
            // 
            this.labLoan.Location = new System.Drawing.Point(226, 61);
            this.labLoan.Name = "labLoan";
            this.labLoan.Size = new System.Drawing.Size(100, 36);
            this.labLoan.TabIndex = 5;
            this.labLoan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labDeadline
            // 
            this.labDeadline.Location = new System.Drawing.Point(226, 125);
            this.labDeadline.Name = "labDeadline";
            this.labDeadline.Size = new System.Drawing.Size(100, 36);
            this.labDeadline.TabIndex = 6;
            // 
            // labInterestRate
            // 
            this.labInterestRate.Location = new System.Drawing.Point(226, 187);
            this.labInterestRate.Name = "labInterestRate";
            this.labInterestRate.Size = new System.Drawing.Size(100, 36);
            this.labInterestRate.TabIndex = 7;
            // 
            // labMonth
            // 
            this.labMonth.Location = new System.Drawing.Point(226, 262);
            this.labMonth.Name = "labMonth";
            this.labMonth.Size = new System.Drawing.Size(100, 36);
            this.labMonth.TabIndex = 8;
            // 
            // labTotal
            // 
            this.labTotal.Location = new System.Drawing.Point(226, 341);
            this.labTotal.Name = "labTotal";
            this.labTotal.Size = new System.Drawing.Size(100, 36);
            this.labTotal.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(452, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 70);
            this.button1.TabIndex = 10;
            this.button1.Text = "Email";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // LoanReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 559);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labTotal);
            this.Controls.Add(this.labMonth);
            this.Controls.Add(this.labInterestRate);
            this.Controls.Add(this.labDeadline);
            this.Controls.Add(this.labLoan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoanReport";
            this.Text = "LoanReport";
            this.Load += new System.EventHandler(this.LoanReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox labLoan;
        public System.Windows.Forms.TextBox labDeadline;
        public System.Windows.Forms.TextBox labInterestRate;
        public System.Windows.Forms.TextBox labMonth;
        public System.Windows.Forms.TextBox labTotal;
    }
}