using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
namespace Student_ArrayList_Windows_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Student s;
        ArrayList ar = new ArrayList();
        private void button1_Click(object sender, EventArgs e)
        {
            s = new Student(Convert.ToInt32(textBox1.Text), textBox2.Text);
            ar.Add(s);
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Capacity " + ar.Capacity);
            MessageBox.Show("Count " + ar.Count);
            StringBuilder sb = new StringBuilder();
            foreach(Student s in ar)
            {
                sb.Append("Student Roll No:- " + s.rno+"\n");
                sb.Append("Student Name:- " + s.name+"\n");
            }
            label3.Text = sb.ToString();
        }
    }
}
