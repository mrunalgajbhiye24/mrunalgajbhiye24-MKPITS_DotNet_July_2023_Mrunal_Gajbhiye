using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _31_Days_Switch_Window
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string month_name,res;
            month_name =textBox1.Text;

            switch (month_name)
            {
                case "January":
                case "March":
                case "May":
                case "July":
                case "August":
                case "October":
                case "December":
                    res="Month have 31 days";
                    break;
                case "February":
                case "April":
                case "June":
                case "September":
                case "November":
                    res="Month have 30 Days";
                    break;
                default:
                    res="Invalid";
                    break;
            }
            label2.Text = "Result: " + res;
        }
    }
}
