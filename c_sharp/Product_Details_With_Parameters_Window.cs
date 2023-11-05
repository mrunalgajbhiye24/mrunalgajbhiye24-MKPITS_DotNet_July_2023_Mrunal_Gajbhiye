using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Product_Details_With_Parameters_Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product pro = new Product(textBox1.Text, Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text));
            StringBuilder sb = new StringBuilder();
            sb.Append("Product Name: " + pro.productname+"\n");
            sb.Append("Quantity: " + pro.quantity+"\n");
            sb.Append("Product Prize: " + pro.prize);

            label4.Text = sb.ToString();
        }
    }
}
