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
    public partial class 簡易計算機 : Form
    {
        public 簡易計算機()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Num1 = Double.Parse(textBox1.Text);
            double Num2 = Double.Parse(textBox2.Text);
            textBox3.Text = $"{Num1 + Num2}";   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double Num1 = Double.Parse(textBox1.Text);
            double Num2 = Double.Parse(textBox2.Text);
            textBox3.Text = $"{Num1 - Num2}";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double Num1 = Double.Parse(textBox1.Text);
            double Num2 = Double.Parse(textBox2.Text);
            textBox3.Text = $"{Num1 * Num2}";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double Num1 = Double.Parse(textBox1.Text);
            double Num2 = Double.Parse(textBox2.Text);
            textBox3.Text = $"{Num1 / Num2}";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

        }
    }
}
