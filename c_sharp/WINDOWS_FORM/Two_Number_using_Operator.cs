using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
namespace Two_Numbers_Using_Operator
{
    internal class Operator
    {
        public int num1;
        public int num2;
        public string op;
        public int res;

        public void getdata(int num1, int num2, string op)
        {
            if (op == "+")
            {
                res = num1 + num2;
            }
            else if (op == "-")
            {
                res = num1 - num2;
            }
            else if (op == "*")
            {
                res = num1 * num2;
            }
            else
            {
                res = 0;
            }
        }
    }
}
*/
namespace Two_Numbers_Using_Operator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Operator o = new Operator();
        private void button1_Click(object sender, EventArgs e)
        {
            o.getdata(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), textBox3.Text);
            label4.Text = "Result:- " + o.res;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }
    }
}
