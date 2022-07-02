using System;
using System.Collections;
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
    public partial class Student_Struct_Form : Form
    {
        public Student_Struct_Form()
        {
            InitializeComponent();
        }
       

            string result = " ";
            studentscore sc;

            //第一個btn,加入學生資料
            private void button1_Click(object sender, EventArgs e)
            {
                studentscore sc;

                sc.studentName = textBox1.Text;
                sc.chinesescore = int.Parse(textBox2.Text);
                sc.englishscore = int.Parse(textBox3.Text);
                sc.mathscore = int.Parse(textBox4.Text);


                //計算平均分數 
                float m;
                int total;
                total = sc.chinesescore + sc.englishscore + sc.mathscore;

                m = (float)total / 3;
                Math.Round(m, 1);

                //最低分及最高分 if-else寫法

                //紀錄最高、最低分的科目中文
                string HighScore_Name, LowScore_Name;

                //紀錄最高、最低分的科目分數
                int HighScore, LowScore;
                #region 用if-else寫法

                //先比較國文跟英文
                if (sc.chinesescore > sc.englishscore)
                {
                    HighScore_Name = "國文";
                    HighScore = sc.chinesescore;
                    LowScore_Name = "英文";
                    LowScore = sc.englishscore;
                }
                else
                {
                    HighScore_Name = "英文";
                    HighScore = sc.englishscore;
                    LowScore_Name = "國文";
                    LowScore = sc.chinesescore;
                }

                //再拿國英比較完 最高的分數跟數學比
                if (HighScore < sc.mathscore)
                {
                    HighScore_Name = "數學";
                    HighScore = sc.mathscore;
                }

                //再拿國英比較完 最低的分數跟數學比
                if (LowScore > sc.mathscore)
                {
                    LowScore_Name = "數學";
                    LowScore = sc.mathscore;
                }
                #endregion
                //listView2.Items.Add(result);
                listView2.Items.Add(sc.studentName);
                listView2.Items[0].SubItems.Add(sc.chinesescore.ToString());
                listView2.Items[0].SubItems.Add(sc.englishscore.ToString());
                listView2.Items[0].SubItems.Add(sc.mathscore.ToString());
                listView2.Items[0].SubItems.Add(total.ToString());
                listView2.Items[0].SubItems.Add(m.ToString());
                listView2.Items[0].SubItems.Add(LowScore_Name + ":" + LowScore.ToString());
                listView2.Items[0].SubItems.Add(HighScore_Name + ":" + HighScore.ToString());
            }

            //第二個btn 隨機儲存資料
            private void button2_Click(object sender, EventArgs e)
            {
                Random Score_Random = new Random();
                sc.chinesescore = Score_Random.Next(0, 100);
                sc.englishscore = Score_Random.Next(0, 100);
                sc.mathscore = Score_Random.Next(0, 100);
                int totalScore = sc.chinesescore + sc.englishscore + sc.mathscore;
                int count = listView2.Items.Count;
                #region 計算最高最低

                //紀錄最高、最低分的科目中文
                string HighScore_Name, LowScore_Name;

                //紀錄最高、最低分的科目分數
                int HighScore, LowScore;
                #region 用if-else寫法

                //先比較國文跟英文
                if (sc.chinesescore > sc.englishscore)
                {
                    HighScore_Name = "國文";
                    HighScore = sc.chinesescore;
                    LowScore_Name = "英文";
                    LowScore = sc.englishscore;
                }
                else
                {
                    HighScore_Name = "英文";
                    HighScore = sc.englishscore;
                    LowScore_Name = "國文";
                    LowScore = sc.chinesescore;
                }

                //再拿國英比較完 最高的分數跟數學比
                if (HighScore < sc.mathscore)
                {
                    HighScore_Name = "數學";
                    HighScore = sc.mathscore;
                }

                //再拿國英比較完 最低的分數跟數學比
                if (LowScore > sc.mathscore)
                {
                    LowScore_Name = "數學";
                    LowScore = sc.mathscore;
                }
                #endregion
                #endregion

                string[] arr = new string[8];
                arr[0] = (count + 1).ToString();
                arr[1] = (sc.chinesescore).ToString();
                arr[2] = (sc.englishscore).ToString();
                arr[3] = (sc.mathscore).ToString();
                arr[4] = (totalScore).ToString();
                arr[5] = (totalScore / 3).ToString();
                arr[6] = LowScore_Name + ":" + LowScore.ToString();
                arr[7] = HighScore_Name + ":" + HighScore.ToString();
                ListViewItem item = new ListViewItem(arr);
                listView2.Items.Add(item);
            }




            //第三個btn 各科統計

            private void button3_Click(object sender, EventArgs e)
            {
                //string aa = "0";
                //string bb = "0";
                //string cc = "0";

                //for 













            }

        }
        










        }


          






    
   


