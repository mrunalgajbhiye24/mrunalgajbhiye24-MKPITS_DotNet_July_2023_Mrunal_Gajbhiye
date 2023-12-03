using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
namespace DayNo_And_Dayname
{
    internal class DayNo
    {
        public int dayno;
        public string res;
        public void getdata(int dayno)
        {
            switch (dayno)
            {
                case 1:
                    res = "Monday";
                    break;
                case 2:
                    res = "Tuesday";
                    break;
                case 3:
                    res = "Wednesday";
                    break;
                case 4:
                    res = "Thursday";
                    break;
                case 5:
                    res = "Friday";
                    break;
                case 6:
                    res = "Saturday";
                    break;
                case 7:
                    res = "Sunday";
                    break;
            }
        }
    }
}
*/
namespace DayNo_And_Dayname
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DayNo d = new DayNo();
        private void button1_Click(object sender, EventArgs e)
        {
            d.getdata(Convert.ToInt32(textBox1.Text));
            label2.Text = "Day Name:- " + d.res;
        }
    }
}
