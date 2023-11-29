using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bank;
/*namespace Bank
{
    public abstract class Account
    {
        public int accountno;
        public int balance = 1000;
        public abstract string deposit(int amount);
        public string withdrawl(int amount)
        {
            string result = null;
            if (balance < amount)
            {
                result = "Insufficient fund Cannot withdrawl Money!";
            }
            else
            {
                balance = balance - amount;
                result = "Amount withdrawl Successfully, Balance is: " + balance.ToString();
            }
            return result;
        }
        public string showbalance()
        {
            return "Balance Amount is: " + balance.ToString();
        }

    }
    public class Saving : Account
    {
        public override string deposit(int amount)
        {
            int interest = 500;
            balance = balance + amount + interest;
            return "Amount Deposited Successfully, Balance is: " + balance.ToString();
        }
    }
    public class Current : Account
    {
        public override string deposit(int amount)
        {
            balance = balance + amount;
            return "Amount Deposited Successfully,Balance is: " + balance.ToString();
        }
    }
}*/

namespace BankWindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Account act = null;
        private void button1_Click(object sender, EventArgs e)
        {
            act.accountno = Convert.ToInt32(textBox1.Text);
            string res = act.deposit(Convert.ToInt32(textBox2.Text));
            label4.Text = res;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "saving")
            {
                act = new Saving();
            }
            else if(comboBox1.Text == "current")
            {
                act = new Current();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            act.accountno = Convert.ToInt32(textBox1.Text);
            string res = act.withdrawl(Convert.ToInt32(textBox2.Text));
            label4.Text = res;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            act.accountno = Convert.ToInt32(textBox1.Text);
            string res = act.showbalance();
            label4.Text = res;
        }
    }
}
