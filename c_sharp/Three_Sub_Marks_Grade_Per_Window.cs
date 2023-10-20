using System;

using System.Windows.Forms;

namespace Three_Subject_Marks_per_Grade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int m, p, c;
            int total;
            float per;
            string grade = null;

            m = Convert.ToInt32(textBox1.Text);
            p = Convert.ToInt32(textBox2.Text);
            c = Convert.ToInt32(textBox3.Text);

            total = m + p + c;
            per = (total / 300.0f) * 100.0f;

            label4.Text = "Total: " + total;
            label5.Text = "Percentage: " + per;

            if (per >= 75)
                grade = "Distinction";
            else if (per >= 60 && per < 75)
                grade = "First Class";
            else if (per >= 50 && per < 60)
                grade = "Second";
            else
                grade = "Fail";
            label6.Text = "Grade: " + grade;
        }
    }
}
