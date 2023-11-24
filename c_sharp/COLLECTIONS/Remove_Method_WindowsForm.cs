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
namespace Remove_Method_Windows_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList ar = new ArrayList();
        private void button1_Click(object sender, EventArgs e)
        {
            ar.Add(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("ArrayList Collection Without Removing"+"\n");
            foreach(object obj in ar)
            {
                sb.Append("Name:- " + obj+"\n");
            }
            label2.Text = sb.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            ar.Remove(textBox2.Text);
            textBox2.Clear();
            textBox2.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int position = Convert.ToInt32(textBox2.Text);
            ar.RemoveAt(position);
            textBox2.Clear();
            textBox2.Focus();
        }
    }
}
