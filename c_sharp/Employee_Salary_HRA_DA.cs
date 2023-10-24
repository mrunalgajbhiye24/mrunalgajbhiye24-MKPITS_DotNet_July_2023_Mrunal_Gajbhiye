using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Salary_Hra_Da
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float sal, hra, da, total = 0;

            sal = Convert.ToSingle(textBox1.Text);

            if (sal <= 10000)
            {
                hra = sal * 0.20f;
                da = sal * 0.80f;
            }

            else if (sal <= 20000)
            {
                hra = sal * 0.25f;
                da = sal * 0.90f;
            }

            else
            {
                hra = sal * 0.30f;
                da = sal * 0.95f;
            }

            total = sal + hra + da;

            label2.Text = "Basic Salary: " + sal;
            label3.Text = "HRA: " + hra;
            label4.Text = "DA: " + da;
            label5.Text = "Total Salary: " + total;
        }
    }
}
