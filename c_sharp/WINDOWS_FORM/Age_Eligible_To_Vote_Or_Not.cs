using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Age_Eligible_For_Vote_or_Not
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int age = Convert.ToInt32(textBox1.Text);
            if(age<18)
            {
                label2.Text = "Not Eligible for Vote";
            }
            else
            {
                label2.Text = "Eligible for Vote";
            }
        }
    }
}
