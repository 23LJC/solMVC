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
    public partial class Page : Form
    {
        public Page()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Hello P1 = new Hello();
            P1.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(P1);
            P1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Loan P2 = new Loan();
            P2.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(P2);
            P2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            POS機 P3 = new POS機();
            P3.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(P3);
            P3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Student_StructForm P4 = new Student_StructForm();
            P4.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(P4);
            P4.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            XOGame P5 = new XOGame();
            P5.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(P5);
            P5.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            小畫家 P6 = new 小畫家();
            P6.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(P6);
            P6.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            簡易計算機 P7 = new 簡易計算機();
            P7.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(P7);
            P7.Show();
        }
    }
}
