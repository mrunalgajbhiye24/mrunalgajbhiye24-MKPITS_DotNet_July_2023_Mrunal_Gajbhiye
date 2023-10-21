using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Profit_Loss
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s, c, total;
            string res;
            s = Convert.ToInt32(textBox1.Text);
            c = Convert.ToInt32(textBox2.Text);

            total = s - c;
            if(s>c)
            {
                res = "Profit: " + total;
            }
            else if(s<c)
            {
                res = "Loss: " + total;
            }
            else
            {
                res = "No Profit or Loss";
            }
            label3.Text = "Result: " + res;
        }
    }
}
