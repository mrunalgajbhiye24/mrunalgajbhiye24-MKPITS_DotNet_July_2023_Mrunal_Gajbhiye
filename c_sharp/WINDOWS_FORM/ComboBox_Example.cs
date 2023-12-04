using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string empname = textBox1.Text;
            int bsal = Convert.ToInt32(textBox2.Text);
            float bonus=0.0f;
            string des = comboBox1.Text;

            switch (des)
            {
                case "manager":
                    bonus = bsal * 0.45f;
                    break;
                case "clerk":
                    bonus = bsal * 0.25f;
                    break;
                case "peon":
                    bonus = bsal * 0.15f;
                    break;

            }
            float tsal = bsal + bonus;
            if(checkBox1.Checked)
            {
                label3.Text = "Bonus of Employee:- " + bonus.ToString();
            }
            if(checkBox2.Checked)
            {
                label4.Text = "Total Salary:- " + tsal.ToString();
            }
        }
    }
}
