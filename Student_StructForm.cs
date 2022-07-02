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
    public partial class Student_StructForm : Form
    {
        public Student_StructForm()
        {
            InitializeComponent();
        }
        
        string result = "成績";
        
        //int count = 0;
        //int totalScore = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            Student sc;
            sc.StudentName = txtName.Text;
            sc.ChineseScore = int.Parse(txtCinese.Text);
            sc.EngilshScore = int.Parse(txtEnglish.Text);
            sc.MathScore = int.Parse(txtMath.Text);
            result = "\n姓名:" + sc.StudentName + ",國文分數:" + sc.ChineseScore + ",英文分數:" + sc.EngilshScore + ",數學分數:" + sc.MathScore;



        }

        private void button2_Click(object sender, EventArgs e)
        {
            Student sc;
            sc.StudentName = txtName.Text;
            sc.ChineseScore = int.Parse(txtCinese.Text);
            sc.EngilshScore = int.Parse(txtEnglish.Text);
            sc.MathScore = int.Parse(txtMath.Text);
            result = "\n姓名:" + sc.StudentName + "\n國文分數:" + sc.ChineseScore + "\n英文分數:" + sc.EngilshScore + "\n數學分數:" + sc.MathScore;
            label6.Text = result;

        }

        private void button3_Click(object sender, EventArgs e)
        {

            Student sc;
            sc.StudentName = txtName.Text;
            sc.ChineseScore = int.Parse(txtCinese.Text);
            sc.EngilshScore = int.Parse(txtEnglish.Text);
            sc.MathScore = int.Parse(txtMath.Text);


            int[] 分數 = { sc.ChineseScore, sc.EngilshScore, sc.MathScore };

            String[] 科目 = { "國文","英文","數學" };
            //比較的陣列,跟著前面走
            Array.Sort(分數, 科目);
            //Array.Reverse(分數);Array.Reserve(科目);反轉
            label7.Text = "最高分科目成績為:" + 科目[2] + 分數[2] + "\n最低分科目成績為:" + 科目[0] + 分數[0];
        }

       
    }
        
 }
