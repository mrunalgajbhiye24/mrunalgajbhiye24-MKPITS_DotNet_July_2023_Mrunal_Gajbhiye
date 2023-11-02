using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Salary_Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Employee[] emp = new Employee[3];
        int cnt = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            emp[0] = new Employee();
            emp[1] = new Employee();
            emp[2] = new Employee();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (cnt < 3)
            {
                emp[cnt].EmployeeId = Convert.ToInt32(textBox1.Text);
                emp[cnt].EmployeeName = textBox2.Text;
                emp[cnt].salary = Convert.ToInt32(textBox3.Text);
                cnt++;
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox1.Focus();

            }
            if(cnt==3)
            {
                button1.Enabled = false;
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                button2.Enabled = true;
                MessageBox.Show("You Have Enter All the Details Of 3 Employees");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Employee Details Are: " + "\n");
            for(int i=0;i<3;i++)
            {
                sb.Append("Employee Id: " + emp[i].EmployeeId+"\n");
                sb.Append("Employee Name: " + emp[i].EmployeeName+"\n");
                sb.Append("Employee Salary: " + emp[i].salary+"\n");
                sb.Append("----------------------------------------\n");

            }
            label4.Text = sb.ToString();

            double high = emp[0].salary;
            int foundat = 0;
            for(int i=0;i<3;i++)
            {
                
                 if (emp[i].salary >high)
                 {
                    high = emp[i].salary;
                    foundat = i;
                 }
                    
                
            }

            StringBuilder sb1 = new StringBuilder();
            sb1.Append("Employee Id: " + emp[foundat].EmployeeId+"\n");
            sb1.Append("Employee Name: " + emp[foundat].EmployeeName+"\n");
            sb1.Append("Employee Salary: " + emp[foundat].salary+"\n");
            label5.Text = sb1.ToString();
        }
    }
}
