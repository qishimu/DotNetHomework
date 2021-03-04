using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsfirst_two
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
        }
        float num1, num2, result;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnjia_Click(object sender, EventArgs e)
        {
            float num1 = Convert.ToSingle(textBox1.Text);
            float num2 = Convert.ToSingle(textBox2.Text);
            float result = num1 + num2;
            textBox3.Text = Convert.ToString(result);

        }

        private void btnjian_Click(object sender, EventArgs e)
        {
            float num1 = Convert.ToSingle(textBox1.Text);
            float num2 = Convert.ToSingle(textBox2.Text);
            float result = num1 - num2;
            textBox3.Text = Convert.ToString(result);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            num1 = Convert.ToSingle(textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            num2 = Convert.ToSingle(textBox2.Text);
        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnchen_Click(object sender, EventArgs e)
        {
            float num1 = Convert.ToSingle(textBox1.Text);
            float num2 = Convert.ToSingle(textBox2.Text);
            float result = num1 * num2;
            textBox3.Text = Convert.ToString(result);
        }

        private void btnchu_Click(object sender, EventArgs e)
        {
            float num1 = Convert.ToSingle(textBox1.Text);
            float num2 = Convert.ToSingle(textBox2.Text);
            float result = num1 / num2;
            textBox3.Text = Convert.ToString(result);
        }
    }
}
