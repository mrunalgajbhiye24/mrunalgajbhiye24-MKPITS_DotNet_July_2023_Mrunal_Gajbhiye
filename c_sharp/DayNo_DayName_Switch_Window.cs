using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DayNo_DayName_Switch
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
            string res=null;
            dayno = Convert.ToInt32(textBox1.Text);

            switch (dayno)
            {
                case 1:
                    res="MONDAY";
                    break;
                case 2:
                    res="TUESDAY";
                    break;
                case 3:
                    res="WEDNESDAY";
                    break;
                case 4:
                    res="THURSDAY";
                    break;
                case 5:
                    res = "FRIDAY";
                    break;
                case 6:
                    res = "SATURDAY";
                    break;
                case 7:
                    Console.WriteLine("SUNDAY");
                    break;
                default:
                    res = "Invalid";
                    break;

            }
            label2.Text = "Result: " + res;
        }
    }
}
