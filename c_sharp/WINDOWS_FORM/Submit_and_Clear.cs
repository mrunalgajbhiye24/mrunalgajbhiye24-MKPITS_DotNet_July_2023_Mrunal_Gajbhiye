using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Submit_and_Clear
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            string name = textBox1.Text;
            int age = Convert.ToInt32(numericUpDown1.Value);

            if(textBox1.Text=="" && numericUpDown1.Value==0)
            {
                MessageBox.Show("Enter Name and Age");
            }
            else if(textBox1.Text=="")
            {
                MessageBox.Show("Enter Your Name");
            }
            if(numericUpDown1.Value==0)
            {
                MessageBox.Show("Enter age" );
            }
            else if (numericUpDown1.Value <=18)
            {
                MessageBox.Show("Your Age should be greater than 18");
            }
            sb.Append("Name:- " + name+"\n");
            sb.Append("Age:- " + age);
            label3.Text = sb.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            numericUpDown1.Value = 0;
        }
    }
}
