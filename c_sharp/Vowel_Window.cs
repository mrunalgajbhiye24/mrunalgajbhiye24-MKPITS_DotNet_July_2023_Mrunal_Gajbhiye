using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vowel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char ch;
            string result = null;
            ch = Convert.ToChar(textBox1.Text);
            if(ch=='a'||ch=='e'||ch=='i'||ch=='o'||ch=='u')
            {
                result = "It is a Vowel";
            }
            else
            {
                result = "It is a Consonant";
            }
            label2.Text = "Result: " + result;
        }
    }
}
