using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Details_With_Parameters_Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee(Convert.ToInt32(textBox1.Text), textBox2.Text, textBox3.Text, Convert.ToInt32(textBox4.Text));
            StringBuilder sb = new StringBuilder();
            sb.Append("Employee No: " + emp.empno+"\n");
            sb.Append("Employee Name: " + emp.empname+"\n");
            sb.Append("Employee Designation: " +emp.designation+"\n");
            sb.Append("Employee Salary: " + emp.salary);
            label5.Text = sb.ToString();
        }
    }
}
