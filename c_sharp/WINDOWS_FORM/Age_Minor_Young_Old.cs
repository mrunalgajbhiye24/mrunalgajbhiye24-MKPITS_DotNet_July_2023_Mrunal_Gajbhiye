using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Age_Minor_Young_or_Old
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
                label2.Text = "You are Minor in age";
            }
            else if(age<=50)
            {
                label2.Text = "You are Young in age";
            }
            else
            {
                label2.Text = "You are Older in age";
            }
        }
    }
}
