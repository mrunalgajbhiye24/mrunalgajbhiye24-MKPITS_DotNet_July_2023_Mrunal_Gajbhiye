using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temperature
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int temp;
            string res = null;
            temp = Convert.ToInt32(textBox1.Text);

            if (temp <0)
            {
                res = "Freezing Wheather";
            }
            else if (temp >= 0 && temp <= 10) 
            {
                res = "Very Cold Wheather";
            }
            else if (temp >= 20 && temp <= 30) 
            {
                res = "Temperature is Normal";
            }
            else if (temp >= 30 && temp <= 40) 
            {
                res = "Temperature is Hot";
            }
            else if (temp >= 40) 
            {
                res = "Temperature is Very Hot ";
            }
            else
            {
                res = "Invalid";
            }
            label2.Text = "Result: " + res;
        }
    }
}
