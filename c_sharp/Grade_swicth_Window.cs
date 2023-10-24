using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grade_Switch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char grade;
            string res = null;
            grade = Convert.ToChar(textBox1.Text);

            switch (grade)
            {
                case 'E':
                    res="Excellent";
                    break;
                case 'V':
                    res="Very Good";
                    break;
                case 'G':
                    res = "Good";
                    break;
                case 'A':
                    res = "Average";
                    break;
                case 'F':
                    res = "Fail";
                    break;
                default:
                    res = "Invalid";
                    break;

            }
            label2.Text = "Result: " + res;
        }
    }
}
