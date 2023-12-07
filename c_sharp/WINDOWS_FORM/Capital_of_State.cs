using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capital_of_States
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Score=0;
            if(radioButton3.Checked)
            {
                radioButton3.Text="Mumbai";
                Score++;
            }
            if (radioButton4.Checked)
            {
                radioButton4.Text= "Bhopal";
                Score++;
            }
            if (radioButton7.Checked)
            {
                radioButton7.Text= "Surat";
                Score++;
            }
            label5.Text = "Score:- " + Score;
        }
    }
}
