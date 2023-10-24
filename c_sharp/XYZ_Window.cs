using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xyz_Window
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x, y, z;
            int res1, res2;

            x = Convert.ToInt32(textBox1.Text);
            y = Convert.ToInt32(textBox2.Text);
            z = Convert.ToInt32(textBox3.Text);

            res1 = (x + y) * z;
            res2 = (x * y) + y * z;

            label4.Text = "(x + y).z : " + res1;
            label5.Text = "x.y + y.z : " + res2;
        }
    }
}
