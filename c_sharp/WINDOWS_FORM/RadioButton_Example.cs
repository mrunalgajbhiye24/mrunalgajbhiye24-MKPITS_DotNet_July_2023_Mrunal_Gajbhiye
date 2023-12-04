using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int actno = Convert.ToInt32(textBox1.Text);
            int amount = Convert.ToInt32(textBox2.Text);
            int balance = 1000;

            if(radioButton1.Checked)
            {
                balance = balance+amount;
            }
            else if(radioButton2.Checked)
            {
                balance = balance-amount;
            }
            label3.Text = "Total Balance:- " + balance;
        }
    }
}
