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
    public partial class POS機 : Form
    {
        public POS機()
        {

            InitializeComponent();

        }
        double Total;

        int 啤酒 = 120, 龍舌蘭 = 180, 威士忌 = 350, 紅酒 = 320;
        int 啤點擊數, 龍點擊數, 威點擊數, 紅點擊數;
        String 啤酒字串, 龍舌蘭字串, 威士忌字串, 紅酒字串;

       

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = ""+ "NT$0";
            label6.Text = null;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label6.Text = Total.ToString();
            double aa = Convert.ToInt32(Total * 0.9);
            MessageBox.Show("總金額是NT$:" + label6.Text+"\n折扣後是NT$:"+aa);
        }

        
        private void button5_Click(object sender, EventArgs e)
        {
            label6.Text = Total.ToString();
            MessageBox.Show("總金額是NT$:" + label6.Text);
        }

        
        private void button4_Click(object sender, EventArgs e)
        {
            紅點擊數++;
            Total += 紅酒;
            textBox1.Text = "NT$" + Total.ToString();
            紅酒字串 = "紅酒 Wine x" + 紅點擊數 + ",共$" + 紅酒 * 紅點擊數 + "元\n";
            label6.Text = 啤酒字串 + 龍舌蘭字串 + 威士忌字串 + 紅酒字串;
        }

        
        private void button3_Click(object sender, EventArgs e)
        {
            威點擊數++;
            Total += 威士忌;
            textBox1.Text = "NT$" + Total.ToString();
            威士忌字串 = "威士忌 Whisky x" + 威點擊數 + ",共$" + 威士忌 * 威點擊數 + "元\n";
            label6.Text = 啤酒字串 + 龍舌蘭字串 + 威士忌字串 + 紅酒字串;
        }

        


        private void button1_Click(object sender, EventArgs e) 
        {
            啤點擊數++;
            Total += 啤酒;
            textBox1.Text = "NT$" + Total.ToString();
            啤酒字串 = "啤酒 Beer x" + 啤點擊數 + ",共$" + 啤酒 * 啤點擊數 + "元\n";
            label6.Text = 啤酒字串 + 龍舌蘭字串 + 威士忌字串 + 紅酒字串;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            龍點擊數++;
            Total += 龍舌蘭;
            textBox1.Text = "NT$" + Total.ToString();
            龍舌蘭字串 = "龍舌蘭 Tequila x" + 龍點擊數 + ",共$" + 龍舌蘭 * 龍點擊數 + "元\n";
            label6.Text = 啤酒字串 + 龍舌蘭字串 + 威士忌字串 + 紅酒字串;
        }
    }
}













