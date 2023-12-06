using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Product_Details
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox2.Text = "";
            switch(comboBox1.Text)
            {
                case "Tools":
                    comboBox2.Items.Add("Makeup Brush");
                    comboBox2.Items.Add("Air brush");
                    comboBox2.Items.Add("Mannicure kit");
                    comboBox2.Items.Add("Eyelash Curler");
                    comboBox2.Items.Add("Straighting machine ");
                    comboBox2.Items.Add("Crimmping  machine ");
                    break;
                case "Brands Available":
                    comboBox2.Items.Add("Lakme");
                    comboBox2.Items.Add("Sugar");
                    comboBox2.Items.Add("Nyka");
                    comboBox2.Items.Add("Color Bar");
                    break;
      
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            int quantity = Convert.ToInt32(textBox2.Text+"\n");
            sb.Append("Customer Name:- " + textBox1.Text + "\n");
            sb.Append("Customer Mobile Number:- " + maskedTextBox1.Text + "\n");
            sb.Append("Products :- " + comboBox1.Text + "\n");
            sb.Append("Product Name:- " + comboBox2.Text + "\n");
            sb.Append("Quantity:- " + quantity + "\n");
            int rate = Convert.ToInt32(textBox3.Text);
            sb.Append("Rate:- " + rate + "\n");
            int total = quantity * rate;
            sb.Append("Total:- " + total + "\n");
            label7.Text = "Display:- " + sb.ToString();
        }
    }
}
