﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Three_Subject_marks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s1 = Convert.ToInt32(textBox1.Text);
            int s2 = Convert.ToInt32(textBox2.Text);
            int s3 = Convert.ToInt32(textBox3.Text);
            int total = s1 + s2 + s3;
            float percentage = total / 300.0f * 100.0f;
            string grade;
            if (percentage > 80)
            {
                grade = "Distinction";
            }
            else if (percentage < 80 && percentage > 70)
            {
                grade = "First Class";

            }
            else if (percentage < 70 && percentage > 60)
            {
                grade = "Second Class";
            }
            else if (percentage < 60 && percentage > 35)
            {
                grade = "Third Class";
            }
            else
            {
                grade = "Fail";
            }
            label4.Text = "Total Marks: " + total;
            label5.Text = "Percentage: " + percentage;
            label6.Text = "Grade: " + grade;
        }
    }
}
