using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Products_Details_Windows_Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Product pro = new Product();
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pro.ProductName = textBox1.Text;
            pro.ProductQuantity=Convert.ToInt32( textBox2.Text);
            pro.ProductPrize= Convert.ToInt32(textBox3.Text);

            int stock = 100;
            if (pro.ProductQuantity > 0 && pro.ProductQuantity < stock)
            {
                int remainingrpize = stock - pro.ProductQuantity;
                int total = pro.ProductQuantity * pro.ProductPrize;

                label4.Text = "Remaining Prize: " + remainingrpize;
                label5.Text = "Total: " + total;
            }
            
        }
    }
}
