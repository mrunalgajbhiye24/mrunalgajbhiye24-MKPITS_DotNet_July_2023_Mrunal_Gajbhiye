using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
namespace Product_Details_WindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Product pro;
        ArrayList ar = new ArrayList();
        private void button1_Click(object sender, EventArgs e)
        {
            pro = new Product(Convert.ToInt32(textBox1.Text), textBox2.Text, Convert.ToInt32(textBox3.Text));
            ar.Add(pro);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Capacity" + ar.Capacity);
            MessageBox.Show("Count" + ar.Count);
            StringBuilder sb = new StringBuilder();
            foreach(Product pro in ar)
            {
                sb.Append("Product Id:- " + pro.pid+"\n");
                sb.Append("Product Name:- " + pro.name + "\n");
                sb.Append("Product Rate:- " + pro.rate + "\n");
                sb.Append("--------------------------" + "\n");
            }
            label4.Text = sb.ToString();
        }
    }
}
