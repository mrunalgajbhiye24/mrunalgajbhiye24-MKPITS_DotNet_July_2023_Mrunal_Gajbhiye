using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Equilateral_Isosceles_Scalene
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, c;
            string res = null;
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            c = Convert.ToInt32(textBox3.Text);

            if(a==b && b==c)
            {
                res = "Equilateral Triangle";
            }
            else if(a==b||b==c||a==c)
            {
                res = "Isosceles Triangle";
            }
            else
            {
                res = "Scalene";
            }
            label4.Text = "Result: " + res;
        }
    }
}
