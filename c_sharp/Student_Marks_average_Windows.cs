using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Marks_Average
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Student stu = new Student();
            stu.Name = textBox1.Text;
            stu.Roll_No = Convert.ToInt32(textBox2.Text);
            stu.marks[0] = Convert.ToInt32(textBox3.Text);
            stu.marks[1] = Convert.ToInt32(textBox4.Text);
            stu.marks[2] = Convert.ToInt32(textBox5.Text);

            StringBuilder sb = new StringBuilder();
            stu.getdata(stu.Name, stu.Roll_No, stu.marks);
            sb.Append("Student Name: " + stu.Name+"\n");
            sb.Append("Student Roll No: " + stu.Roll_No +"\n");
            sb.Append("Maths Marks: " + stu.marks[0]+"\n");
            sb.Append("Physics Marks: " + stu.marks[0]+"\n");
            sb.Append("Chemistry Marks: " + stu.marks[0]+"\n");
            sb.Append("Total Marks: " + stu.total+"\n");
            sb.Append("Average of all Marks: " +stu.average);
            label6.Text = sb.ToString();
        }
    }
}
