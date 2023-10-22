using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vowel_Window_Switch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char op;
            string res;
            op = Convert.ToChar(textBox1.Text);

            switch (op)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    res="It is a Vowel";
                    break;
                default:
                    res="It is a Consonant";
                    break;
            }
            label2.Text = "Result: " + res;
        }
    }
}
