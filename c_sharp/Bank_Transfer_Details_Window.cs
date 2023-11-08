using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace BankAccount_Transfer_Details_Windows_Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Bank[] bank = new Bank[2];
        int cnt = 0;
        int total = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            bank[0] = new Bank();
            bank[1] = new Bank();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cnt < 2)
            {
                bank[cnt].AccountNumber = Convert.ToInt32(textBox1.Text);
                bank[cnt].AccountHolderName = textBox2.Text;
                bank[cnt].Balance = Convert.ToInt32(textBox3.Text);
                cnt++;
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox1.Focus();
                if (cnt == 2)
                {
                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                    textBox3.Enabled = false;
                    button1.Enabled = false;
                    MessageBox.Show("Already entered 2 bank details");
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            for (int cnt = 0; cnt < 2; cnt++)
            {
                sb.Append("\nAccount Number: " + bank[cnt].AccountNumber);
                sb.Append("\nAccount Name: " + bank[cnt].AccountHolderName);
                sb.Append("\nAccount Balance: " + bank[cnt].Balance);
                sb.Append("\n------------------------------------------");
            }
            label4.Text = sb.ToString();
            total = bank[0].Balance + bank[1].Balance;
            bank[1].Balance = 0;

            StringBuilder sb1 = new StringBuilder();
            sb1.Append("Balance Transfer of Account 1 to Account 2: " + total);
            sb1.Append("\nNow, Balance of Account 2: " + bank[1].Balance);
            label5.Text = sb1.ToString();
        }
    }
}
