using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Des_EmpName_Window
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string empname, des;
            float bonus = 0, totalsal;
            int basicsalary;

            empname = textBox1.Text;
            des = textBox2.Text;
            basicsalary = Convert.ToInt32(textBox3.Text);

            if(des=="manager")
            {
                bonus = 10000;
            }
            else if(des=="clerk")
            {
                bonus = 5000;
            }
            else if(des=="peon")
            {
                bonus = 2000;
            }
            else
            {
                throw new Exception("Invalid");
            }
            totalsal = basicsalary + bonus;
            label4.Text = "EmpName: " + empname;
            label5.Text = "Designation: " + des;
            label6.Text = "Basic salary: " + basicsalary;
            label7.Text = "Bonus: " + bonus;
            label8.Text = "Total Salary: " + totalsal;
        }
    }
}
