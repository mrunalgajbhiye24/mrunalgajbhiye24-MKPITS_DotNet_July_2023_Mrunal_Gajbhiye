using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digit_Words
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int digit;
            string word;
            digit = Convert.ToInt32(textBox1.Text);

            if (digit == 1)
            {
                word = "One";
            }
            else if (digit == 2)
            {
                word = "Two";
            }
            else if (digit == 3)
            {
                word = "Three";
            }
            else if (digit == 4)
            {
                word = "Four";
            }
            else if (digit == 5)
            {
                word = "Five";
            }
            else if (digit == 6)
            {
                word = "Six";
            }
            else if (digit == 7)
            {
                word = "Seven";
            }
            else if (digit == 8)
            {
                word = "Eight";
            }
            else if (digit == 9)
            {
                word = "Nine";
            }
            else if (digit == 10)
            {
                word = "Ten";
            }
            else
            {
                word = "Invalid";
            }
            label2.Text = "In Words: " + word;

        }
    }
}
