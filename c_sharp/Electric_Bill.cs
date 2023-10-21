using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electric_Bill
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cid, unit;
            string name;
            float total, surcharge = 0, finalamt = 0, chrgpunit = 0;

            cid = Convert.ToInt32(textBox1.Text);
            name = textBox2.Text;
            unit = Convert.ToInt32(textBox3.Text);
            {
                if (unit < 200)
                {
                    chrgpunit = 1.20f;
                }
                else if (unit >= 200 && unit < 400)
                {
                    chrgpunit = 1.50f;
                }
                else if (unit >= 400 && unit < 600)
                {
                    chrgpunit = 1.80f;
                }
                else
                {
                    chrgpunit = 2.00f;
                }
                total = unit * chrgpunit;
                label4.Text = "Customer Id: " + cid;
                label5.Text = "Customer Name: " + name;
                label6.Text = "Unit: " + unit;
                label7.Text = "Amount Charges @Rs." + chrgpunit + " per unit: Rs." + total;
            }
            if(total>=400)
            {
                surcharge = total * 0.15f;
            }
            finalamt = total + surcharge;
            label8.Text = "Surchage Amount: Rs." + surcharge;
            label9.Text = "Net Amount Paid By the Customer: Rs." + finalamt;
        }
    }
}
