using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
namespace Vowel_Or_Not
{
    internal class Vowel
    {
        public char ch;
        public string res;
        public void getdata(char ch)
        {
            switch (ch)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    res = "It is a Vowel";
                    break;

                default:
                    res = "It is a Consonant";
                    break;
            }
        }
    }
}
*/
namespace Vowel_Or_Not
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Vowel v = new Vowel();
        private void button1_Click(object sender, EventArgs e)
        {
           char op=(Convert.ToChar(textBox1.Text));
            v.getdata(op);
            label2.Text = v.res;
        }
    }
}
