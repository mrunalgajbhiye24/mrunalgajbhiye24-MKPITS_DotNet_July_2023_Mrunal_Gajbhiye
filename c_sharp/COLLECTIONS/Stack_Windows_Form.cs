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
namespace Stack_Windows_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Stack st = new Stack();
        private void button1_Click(object sender, EventArgs e)
        {
            st.Push(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach(string s in st)
            {
                sb.Append( s+" "+"\n");
            }
            label2.Text = sb.ToString();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StringBuilder sb1 = new StringBuilder();
            st.Push(textBox1.Text);
            foreach(string c in st )
            {
                sb1.Append(c + " " + "\n");
            }
            label4.Text = sb1.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StringBuilder sb2 = new StringBuilder();
            st.Pop().ToString();
            foreach (string s1 in st)
            {
                sb2.Append(s1 + " " + "\n");
            }
            label5.Text = sb2.ToString();
        }
    }
}
