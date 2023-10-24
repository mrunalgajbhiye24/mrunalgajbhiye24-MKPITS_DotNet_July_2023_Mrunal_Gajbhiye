using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Deposite_Withdrawl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int acntno, bal = 1000, amt, deposite, withdrwal;
            string name;


            acntno = Convert.ToInt32(textBox1.Text);
            name = (textBox2.Text);
            amt = Convert.ToInt32(textBox3.Text);


            if (amt==0)
            {

                deposite = amt + bal;
                label4.Text = "Account no. : " + acntno;
                label5.Text = "Account Holder's Name: " + name;
                label6.Text = "Iniatial Balance: " + bal;
                label7.Text = "Total Balance: " + deposite;
            }

            else
            {
                withdrwal = bal - amt;
                label4.Text = "Account no. : " + acntno;
                label5.Text = "Account Holder's Name: " + name;
                label6.Text = "Iniatial Balance: " + bal;
                label7.Text = "Total Balance: " + withdrwal;
            }
        }
    }
}
