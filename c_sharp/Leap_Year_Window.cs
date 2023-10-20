using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Leap_Year
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int year;
            string result;
            year = Convert.ToInt32(textBox1.Text);
            if(year%4==0)
            {
                result = "It is a Leap Year";
            }
            else
            {
                result = "It is Not a Leap Year";
            }
            label2.Text = "Year: " + result;
        }
    }
}
