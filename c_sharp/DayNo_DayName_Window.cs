using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DayNo_DAyNAme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dayno;
            string dayname;
            dayno = Convert.ToInt32(textBox1.Text);
            if (dayno == 1)
            {
                dayname = "Monday";
            }
            else if (dayno == 2)
            {
                dayname = "Tuesday";
            }
            else if (dayno == 3)
            {
                dayname = "Wednesday";
            }
            else if (dayno == 4)
            {
                dayname = "Thursday";
            }
            else if (dayno == 5)
            {
                dayname = "Friday";
            }
            else if (dayno == 6)
            {
                dayname = "Saturday";
            }
            else if (dayno == 7)
            {
                dayname = "Sunday";
            }
            else
            {
                dayname = "Invalid";
            }
            label2.Text = "DayName: " + dayname;
        }
    }
}
