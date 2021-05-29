using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Random;

namespace recite
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int index=0;
        public string word;
        public string meaning;
        string[] strl = new string[1409];
        public int i = 0;
        private void next_vocabulary(object sender, EventArgs e)
        {
            vocabulary.Text = "";
            
            Random rd = new Random();
            int every = rd.Next(0, i);
            string[] temp = strl[every].Split(new Char[] { '\t', '\t', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            word = temp[0];
            meaning = temp[1];
            Chinese.Text = meaning;
            index++;
            next.Text = "显示答案";
            
        }
        private void start_Click(object sender, EventArgs e)
        {
            next.Enabled = true;
            timer1.Start();
            Chinese.Text = "";
            this.next_vocabulary(sender, e);//调用函数
            
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            next.Enabled = false;
            StreamReader sr = new StreamReader("College_Grade4.txt", Encoding.Default);
            string str;
            while ((str = sr.ReadLine()) != null)
            {      
                strl[i] = str;
                i++;
            }
            Chinese.Text = "目前本系统共有" + i.ToString() + "个单词";
        }

        private void next_Click(object sender, EventArgs e)
        {
            if(next.Text == "显示答案")
            {
                vocabulary.Text = word;
                vocabulary.Enabled = false;              
                next.Text = "下一个";
            }
            else
            {
                vocabulary.Enabled = true;
                this.next_vocabulary(sender, e);
            }
        }


        
        private void vocabulary_TextChanged(object sender, EventArgs e)
        {
        }

        private void vocabulary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if(vocabulary.Text == word)
                {
                    this.next_vocabulary(sender, e);
                }
                else
                {
                    MessageBox.Show("错误！");
                }
            }
        }



        //timer
        int second = 0;
        int minute = 0;
        int hour = 0;

        string string_s;
        string string_m;
        string string_h;
        private void timer1_Tick(object sender, EventArgs e)
        {
            second++;
            if (second == 60)
            {
                second = 0;
                minute++;
            }
            if(minute == 60)
            {
                minute = 0;
                hour++;
            }

            if (second < 10)
            {
                string_s = "0" + second.ToString();
            }
            else
            {
                string_s = second.ToString();
            }
            if (minute < 10)
            {
                string_m = "0" + minute.ToString();
            }
            else
            {
                string_m = minute.ToString();
            }
            if (hour < 10)
            {
                string_h = "0" + hour.ToString();
            }
            else
            {
                string_h = hour.ToString();
            }
            Hour.Text = string_h;
            Minute.Text = string_m;
            Second.Text = string_s;
        }

    }
}