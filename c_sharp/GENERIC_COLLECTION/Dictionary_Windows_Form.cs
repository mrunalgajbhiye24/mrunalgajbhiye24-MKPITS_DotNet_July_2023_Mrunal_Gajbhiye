using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary_Windows_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Dictionary<string, string> di = new Dictionary<string, string>();
        private void button1_Click(object sender, EventArgs e)
        {
            di.Add(textBox1.Text, textBox2.Text);
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            List<string> li = new List<string>(di.Keys);
            foreach(string s in li)
            {
                sb.Append("Keys:-"+ s+"\n");
            }
            label3.Text = sb.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            List<string> li = new List<string>(di.Values);
            foreach (string s in li)
            {
                sb.Append("Values:-" + s + "\n");
            }
            label3.Text = sb.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Keys and Values of the dictionary"+"\n");
            foreach (KeyValuePair<string, string> kvp in di) 
            {
                sb.Append("keys:- " + kvp.Key +" "+ "Values:-" + kvp.Value+"\n");
            }
            label4.Text = sb.ToString();
        }
    }
}
