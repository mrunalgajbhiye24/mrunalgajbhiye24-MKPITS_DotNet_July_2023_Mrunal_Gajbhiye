using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Add_Sub_Mul_ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBox1.Text);
            int num2 = Convert.ToInt32(textBox2.Text);
            int res;
            if (comboBox1.Text == "+")
            {
                res = num1 + num2;
            }
            else if(comboBox1.Text=="-")
            {
                res = num1 - num2;
            }
            else if(comboBox1.Text=="*")
            {
                res = num1 * num2;
            }
            else
            {
                res = 0;
            }
            label4.Text = res.ToString();
        }
    }
}
