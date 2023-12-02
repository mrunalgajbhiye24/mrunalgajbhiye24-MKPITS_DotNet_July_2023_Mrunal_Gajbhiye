using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Details
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            int basicsalary = Convert.ToInt32(textBox2.Text);
            string des = comboBox1.Text;
            float hra;
            float bonus;
            if(comboBox1.Text=="manager")
            {
                hra = basicsalary * 0.35f;
                bonus = basicsalary * 0.5f;
            }
            else if(comboBox1.Text=="clerk")
            {
                hra = basicsalary * 0.25f;
                bonus = basicsalary * 0.3f;
            }
            else if(comboBox1.Text=="peon")
            {
                hra = basicsalary * 0.15f;
                bonus = basicsalary * 0.2f;
            }
            else
            {
                hra = 0;
                bonus = 0;
            }
            float total = basicsalary + bonus + hra;
            label7.Text = "Employee Name: " + name;
            label4.Text = "HRA: " + hra;
            label5.Text = "Bonus: " + bonus;
            label6.Text = "Total Salary: " + total;
        }
    }
}
