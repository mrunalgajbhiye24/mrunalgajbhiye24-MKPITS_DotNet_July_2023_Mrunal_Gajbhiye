using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_Text_Editor
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Name:- " + textBox1.Text+"\n");
            sb.Append("Mobile Number:- " + maskedTextBox1.Text + "\n");
            sb.Append("Address:- " + textBox2.Text + "\n");
            sb.Append("Branch:- " + textBox3.Text + "\n");
            label5.Text = sb.ToString();
        }
    }
}
