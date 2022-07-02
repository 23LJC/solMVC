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
    public partial class Hello : Form
    {
        public Hello()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         MessageBox.Show("您好,我的姓名是:" + textBox1.Text+"\n" + "我的英文名是:" + textBox2.Text +"\n" + "我的性別是:" + textBox3.Text +"\n" + "我的星座是:" + textBox4.Text+"\n"+ "很高興認識你。" +"\n");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("嗨嗨,我的姓名是:" + textBox1.Text + "\n" + "我的英文名是:" + textBox2.Text + "\n" + "我的性別是:" + textBox3.Text + "\n" + "我的星座是:" + textBox4.Text + "\n"+ "很高興認識你" +"\n");
        }
    }
}
