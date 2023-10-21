using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a1, a2, a3;
            string res = null;
            a1 = Convert.ToInt32(textBox1.Text);
            a2 = Convert.ToInt32(textBox2.Text);
            a3 = Convert.ToInt32(textBox3.Text);

            if(a1+a2+a3==180)
            {
                res = "Triangle is Valid";
            }
            else
            {
                res = "Triangle is Not Valid";
            }
            label4.Text = "Result: " + res;
        }
    }
}
