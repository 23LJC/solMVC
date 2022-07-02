using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 期中貸款
{
    public partial class Loan : Form
    {
        public  Loan()
        {
            InitializeComponent();
        }


        public string loan, dl, ir, dp;
        public double loanD, dlD, irD, dpD, d1, d2, d3, d4, d;

        private void loanReport_Click_1(object sender, EventArgs e)
        {
            LoanReport loanReport = new LoanReport();
            loanReport.labLoan.Text = txtLoan.Text;
            loanReport.labDeadline.Text = txtDeadLine.Text;
            loanReport.labInterestRate.Text = txtInterestRate.Text;
            loanReport.labMonth.Text = Calculate("month").ToString();
            loanReport.labTotal.Text = Calculate("total").ToString();
            if (!"".Equals(Check()))
            {
                MessageBox.Show(Check());
            }
            else
            {

                loanReport.Show();

            }
        }

        
        

        public void button1_Click(object sender, EventArgs e)
        {

            if (!"".Equals(Check()))
            {
                MessageBox.Show(Check());
            }
            else
            {
                d = Calculate("month");
                MessageBox.Show("月付" + d + "元");
            }
        }

       public void button2_Click(object sender, EventArgs e)
        {
            if (!"".Equals(Check()))
            {
                MessageBox.Show(Check());
            }
            else
            {
                d = Calculate("total");
                MessageBox.Show("總金額" + d + "元");
            }
        }

        public double Calculate(String s)
        {
            loan = txtLoan.Text;
            dl = txtDeadLine.Text;
            ir = txtInterestRate.Text;
            dp = txtDownPayment.Text;
            loanD = double.Parse(loan);
            dlD = double.Parse(dl) * 12;
            irD = double.Parse(ir) / 100;
            dpD = double.Parse(dp);
            d1 = irD / 12;
            d2 = (Math.Pow((1 + d1), dlD) * d1) / (Math.Pow((1 + d1), dlD) - 1);
            d3 = loanD - dpD;
            d4 = Math.Floor(d3 * d2);
            d = 0;
            if (s == "month")
            {
                d = d4;
            }
            if (s == "total")
            {
                d = d4 * dlD;
            }
            return d;
        }

        public String Check()
        {
            loan = txtLoan.Text;
            dl = txtDeadLine.Text;
            ir = txtInterestRate.Text;
            dp = txtDownPayment.Text;
            
            StringBuilder chkMsg = new StringBuilder("");
            if ("".Equals(loan) || loan == null)
            {
                chkMsg.Append("".Equals(chkMsg.ToString()) ? "請填寫貸款金額" : "、貸款金額");
            }
            if ("".Equals(dl) || dl == null)
            {
                chkMsg.Append("".Equals(chkMsg.ToString()) ? "請填寫期限(年)" : "、期限(年)");
            }
            if ("".Equals(ir) || ir == null)
            {
                chkMsg.Append("".Equals(chkMsg.ToString()) ? "請填寫利率(%)" : "、利率(%)");
            }
            if ("".Equals(dp) || dp == null)
            {
                chkMsg.Append("".Equals(chkMsg.ToString()) ? "請填寫頭期款" : "、頭期款");
            }
            return chkMsg.ToString();
            
        }
    }
}

