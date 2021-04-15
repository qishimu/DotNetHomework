using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CayleyTree
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Pen pen = new Pen(Color.Pink);
        private void button1_Click(object sender, EventArgs e)
        {
            if (graphics == null) graphics = this.CreateGraphics();
            graphics.Clear(Color.White);//覆盖旧图

            //获取Cayleys树参数
            int depth = int.Parse(comboBox_depth.Text);
            double leng = double.Parse(comboBox_leng.Text);
            double leftAngle = double.Parse(comboBox_leftAngle.Text);
            double rightAngle = double.Parse(comboBox_rightAngle.Text);
            th1=leftAngle * Math.PI / 180;
            th2=rightAngle * Math.PI / 180;
            per1 = double.Parse(comboBox_leftLeng.Text);
            per2 = double.Parse(comboBox_rightLeng.Text);
            drawCayleyTree(depth, 200, 310, leng, -Math.PI / 2);
        }
       

        private void button2_Click(object sender, EventArgs e)//获取画笔颜色
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();
            pen.Color = cd.Color;
            panel1.BackColor = cd.Color;

        }

        private Graphics graphics;
        double th1 = 30 * Math.PI / 180;
        double th2 = 60 * Math.PI / 180;
        double per1 = 0.6;
        double per2 = 0.7;

        void drawCayleyTree(int n,
                double x0, double y0, double leng, double th)
        {
            if (n == 0) return;

            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);

            drawLine(x0, y0, x1, y1);

            drawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
            drawCayleyTree(n - 1, x1, y1, per2 * leng, th - th2);
        }
        void drawLine(double x0, double y0, double x1, double y1)
        {
            graphics.DrawLine(
                pen,
                (int)x0, (int)y0, (int)x1, (int)y1);
        }


        //获取画笔粗细
        private void radioButton_small_CheckedChanged(object sender, EventArgs e)
        {
            pen.Width = 1.0f;
        }
        private void radioButton_middle_CheckedChanged(object sender, EventArgs e)
        {
            pen.Width = 2.0f;
        }
        private void radioButton_large_CheckedChanged(object sender, EventArgs e)
        {
            pen.Width = 4.0f;
        }
    }
}
