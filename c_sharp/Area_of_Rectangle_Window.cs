using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rectangle_Window
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int length, breadth, result;
            length = Convert.ToInt32(textBox1.Text);
            breadth = Convert.ToInt32(textBox2.Text);
            result = length * breadth;
            label3.Text = "Area of Rectangle: " + result;
        }
    }
}
