using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculate_Switch_Window
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float num1, num2, result;
            char op;
            string res;
            num1 = Convert.ToInt32(textBox1.Text);
            num2 = Convert.ToInt32(textBox2.Text);
            op = Convert.ToChar(textBox3.Text);

            switch (op)
            {
                case '+':
                    result = num1 + num2;
                    res="The Addition of" + " " + num1 + " " + "and" + " " + num2 + " " + "is: " + result;
                    break;

                case '-':
                    result = num1 - num2;
                    res="The Subtraction of" + " " + num1 + " " + "and" + " " + num2 + " " + "is: " + result;
                    break;

                case '*':
                    result = num1 * num2;
                    res="The Multiplication of" + " " + num1 + " " + "and" + " " + num2 + " " + "is: " + result;
                    break;

                case '/':
                    result = num1 / num2;
                    res="The Division of" + " " + num1 + " " + "and" + " " + num2 + " " + "is: " + result;
                    break;

                default:
                    res="Invalid";
                    break;
            }
            label4.Text = "Result: " + res;
        }
    }
}
