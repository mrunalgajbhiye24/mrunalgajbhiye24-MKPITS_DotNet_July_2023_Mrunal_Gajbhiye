using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Three_Greater_Number
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
            int num3 = Convert.ToInt32(textBox3.Text);
            if(num1>num2 & num1>num3)
            {
                label4.Text = "Num1 is the Greatest Number";
            }
            else if(num2>num3)
            {
                label4.Text = "Num2 is the Greatest Number";
            }
            else
            {
                label4.Text = "Num3 is the Greatest Number";
            }
        }
    }
}
