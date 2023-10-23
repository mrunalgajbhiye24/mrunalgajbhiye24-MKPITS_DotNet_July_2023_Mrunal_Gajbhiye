using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Month_Name_Switch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int month_no;
            string res = null;
            month_no = Convert.ToInt32(textBox1.Text);

            switch (month_no)
            {
                case 1:
                    res = "JANUARY";
                    break;
                case 2:
                    res = "FEBRUARY";
                    break;
                case 3:
                    res = "MARCH";
                    break;
                case 4:
                    res = "APRIL";
                    break;
                case 5:
                    res = "MAY";
                    break;
                case 6:
                    res = "JUNE";
                    break;
                case 7:
                    res = "JULY";
                    break;
                case 8:
                    res = "AUGUST";
                    break;
                case 9:
                    res = "SEPTEMBER";
                    break;
                case 10:
                    res = "OCTOBER";
                    break;
                case 11:
                    res = "NOVEMBER";
                    break;
                case 12:
                    res = "DECEMBER";
                    break;
                default:
                    res="Invalid";
                    break;
            }
            label2.Text = "Month Name: " + res;
        }
    }
}
