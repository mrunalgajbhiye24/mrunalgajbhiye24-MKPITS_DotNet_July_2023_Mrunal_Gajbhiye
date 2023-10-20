using System;

using System.Windows.Forms;

namespace Divide_Window
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float num1, num2,result;
            num1 = Convert.ToInt32(textBox1.Text);
            num2 = Convert.ToInt32(textBox2.Text);
            result = num1 / num2;
            label3.Text = "Result: " + result;
        }
    }
}
