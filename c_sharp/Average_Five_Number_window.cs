using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Average_Window
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n1, n2, n3, n4, n5, sum;
            float avg = 0;

            n1 = Convert.ToInt32(textBox1.Text);
            n2 = Convert.ToInt32(textBox2.Text);
            n3 = Convert.ToInt32(textBox3.Text);
            n4 = Convert.ToInt32(textBox4.Text);
            n5 = Convert.ToInt32(textBox5.Text);

            sum = n1 + n2 + n3 + n4 + n5;

            avg = sum / 5.0f;
            label6.Text = "Average: " + avg;
        }
    }
}
