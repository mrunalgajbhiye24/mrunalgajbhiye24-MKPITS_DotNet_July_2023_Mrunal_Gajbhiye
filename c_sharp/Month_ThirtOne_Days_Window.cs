using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Month_31_Days
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int monthno;
            string res;
            monthno = Convert.ToInt32(textBox1.Text);

            if(monthno==1||monthno==3||monthno==5||monthno==7||monthno==8||monthno==10||monthno==12)
            {
                res = "It Have 31 Days";
            }
            else
            {
                res = "It Have 30 Days";
            }
            label2.Text = "Result: " + res;
        }
    }
}
