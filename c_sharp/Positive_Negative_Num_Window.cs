using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Positive_Negative_Num
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num;
            string result = null;
            num = Convert.ToInt32(textBox1.Text);
            if (num > 0)
            {
                result = "Number is Positive";
            }
            else
            {
                result = "Number is Negative";
            }
            label2.Text = "Result: " + result;
        }
    }
}
