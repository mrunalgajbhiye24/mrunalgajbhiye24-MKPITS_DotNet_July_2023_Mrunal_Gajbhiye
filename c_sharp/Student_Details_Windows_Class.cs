using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Details_Windows_Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Student[] stu = new Student[10];
        int cnt=0;
        private void Form1_Load(object sender, EventArgs e)
        {
            stu[0] = new Student();
            stu[1] = new Student();
            stu[2] = new Student();
            stu[3] = new Student();
            stu[4] = new Student();
            stu[5] = new Student();
            stu[6] = new Student();
            stu[7] = new Student();
            stu[8] = new Student();
            stu[9] = new Student();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(cnt<10)
            {
                stu[cnt].name = textBox1.Text;
                stu[cnt].rollno = Convert.ToInt32(textBox2.Text);
                stu[cnt].fees = Convert.ToInt32(textBox3.Text);
                stu[cnt].date =textBox4.Text;
                cnt++;
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox1.Focus();

                if(cnt==10)
                {
                    button1.Enabled = false;
                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                    textBox3.Enabled = false;
                    textBox4.Enabled = false;
                    button2.Enabled = true;
                    MessageBox.Show("You Have Entered all the Details of 10 Student");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Details of All Students: " + "\n");

            for(int i=0;i<10;i++)
            {
                sb.Append("Student Name: " + stu[i].name + "\n");
                sb.Append("Student Roll No: " + stu[i].rollno + "\n");
                sb.Append("Student Fees: " + stu[i].fees + "\n");
                sb.Append("Date: " + stu[i].date + "\n");
                sb.Append("-----------------------------------------\n");
            }
            label5.Text = sb.ToString();

            double high = stu[0].fees;
            int foundat=0;
            for(int i=0;i<10;i++)
            {
                if (high < stu[i].fees)
                {
                    high = stu[i].fees;
                    foundat = i;
                }
            }

            StringBuilder sb1 = new StringBuilder();
            sb1.Append("Employee With Highest Salary"+"\n");
            sb1.Append("Student Name: " + stu[foundat].name+"\n");
            sb1.Append("Student Roll No: " + stu[foundat].rollno+"\n");
            sb1.Append("Student Fees: " + stu[foundat].fees+"\n");
            sb1.Append("Date: " + stu[foundat].date);
            label6.Text = sb1.ToString();
        }
    }
}
