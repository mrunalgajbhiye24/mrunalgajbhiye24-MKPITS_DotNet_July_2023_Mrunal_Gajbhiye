using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coordinate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x, y;
            string res = null;
            x = Convert.ToInt32(textBox1.Text);
            y = Convert.ToInt32(textBox2.Text);

            if (x > 0 && y > 0)
            {
                res = "The coordinate point" + " " + (x, y) + " " + "lies in the First quadrant";
            }
            else if (x > 0 && y < 0)
            {
                res = "The coordinate point" + " " + (x, y) + " " + "lies in the Second quadrant";
            }
            else if (x < 0 && y < 0)
            {
                res = "The coordinate point" + " " + (x, y) + " " + "lies in the Third quadrant";
            }
            else if (x < 0 && y > 0)
            {
                res = "The coordinate point" + " " + (x, y) + " " + "lies in the Fourth quadrant";
            }
            else
            {
                res = "invalid";
            }
            label3.Text = "Result: " + res;

        }
    }
}
