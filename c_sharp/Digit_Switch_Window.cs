using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digit_Switch
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
            string res = null;
            digit = Convert.ToInt32(textBox1.Text);

            switch (digit)
            {
                case 1:
                    res="ONE";
                    break;
                case 2:
                    res="TWO";
                    break;
                case 3:
                    res = "THREE";
                    break;
                case 4:
                    res = "FOUR";
                    break;
                case 5:
                    res = "FIVE";
                    break;
                case 6:
                    res = "SIX";
                    break;
                case 7:
                    res = "SEVEN";
                    break;
                case 8:
                    res = "EIGHT";
                    break;
                case 9:
                    res = "NINE";
                    break;
                case 10:
                    res = "TEN";
                    break;
                default:
                    res = "Invalid";
                    break;
            }
            label2.Text = "In Words: " + res;
        }
    }
}
