using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Average
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float n1, n2, n3, n4, result;
            n1 = Convert.ToInt32(textBox1.Text);
            n2 = Convert.ToInt32(textBox2.Text);
            n3 = Convert.ToInt32(textBox3.Text);
            n4 = Convert.ToInt32(textBox4.Text);

            result = (n1 + n2 + n3 + n4) / 4.0f;
            label5.Text = "Average: " + result;
        }
    }
}
