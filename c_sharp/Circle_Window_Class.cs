using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Circle_Class_Wndow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Circle cir = new Circle();
           cir.radius = Convert.ToInt32(textBox1.Text);
           cir.area = 3.14f * cir.radius * cir.radius;
           cir.circ = 2 * 3.14f * cir.radius;

            StringBuilder sb = new StringBuilder();
            sb.Append("Area of circle: " + cir.area + "\n");
            sb.Append("Circumference of circle: " + cir.circ);
           
            label2.Text = sb.ToString();
        }
    }
}
