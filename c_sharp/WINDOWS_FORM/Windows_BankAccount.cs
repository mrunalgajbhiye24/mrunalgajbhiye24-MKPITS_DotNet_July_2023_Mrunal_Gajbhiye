using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Form_BankAccount
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BankAccount act = null;
            int actno = Convert.ToInt32(textBox1.Text);
            int amount = Convert.ToInt32(textBox2.Text);
            string tt = textBox3.Text;
            if(tt=="Saving")
            {
                act = new Saving();
            }
            else if(tt=="Current")
            {
                act = new Current();
            }
            label4.Text = act.deposit(actno, amount);
            label5.Text = act.showbalance();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BankAccount act = null;
            int actno = Convert.ToInt32(textBox1.Text);
            int amount = Convert.ToInt32(textBox2.Text);
            string tt = textBox3.Text;
            if (tt == "Saving")
            {
                act = new Saving();
            }
            else if (tt == "Current")
            {
                act = new Current();
            }
            label4.Text = act.withdrawl(actno, amount);
            label5.Text = act.showbalance();
        }
    }
}
