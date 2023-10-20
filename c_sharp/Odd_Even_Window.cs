using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odd_Even
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
            if(num%2==0)
            {
                result = "It is a Even Number";
            }
            else
            {
                result = "It is a Odd Number";
            }
            label2.Text = "Result: " + result;
        }
    }
}
