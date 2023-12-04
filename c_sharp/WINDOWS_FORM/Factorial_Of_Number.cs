using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
namespace Factorial_of_Number
{
    internal class Factorial
    {
        public int fact = 1;

        int n { get; set; }

        public void facto(int n)
        {
            while (n > 0)
            {
                fact = fact * n;
                n--;
            }
        }
    }
}
*/
namespace Factorial_of_Number
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Factorial f = new Factorial();
        private void button1_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(textBox1.Text);
            f.facto(num);

            label2.Text = "Factorial of a Number:- " + f.fact;
        }
    }
}
