using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quadratic_Equation
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
            float result;

            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            c = Convert.ToInt32(textBox3.Text);

            result = b * b - 4 * (a * c);
            if(result!=0)
            {
                res = "The Roots Are Imaginary";
            }
            else
            {
                res = "The Roots Are Real";
            }
            label4.Text = "Result: " + res;
        }
    }
}
