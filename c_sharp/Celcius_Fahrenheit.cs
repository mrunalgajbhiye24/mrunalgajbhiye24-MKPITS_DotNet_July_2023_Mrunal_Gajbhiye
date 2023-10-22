using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fahrenit_Celcius
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float temp,F,C;
            temp = Convert.ToInt32(textBox1.Text);

            F = (temp - 32) * 5 / 9; //Convert Celcius to Fahrenheit;
            label2.Text = "Celcius to Fahrenheit: " + F + "°F";
;

            C = (temp * 9 / 5) + 32; //Convert Fahrenheit to Celcius;
            label3.Text = "Fahrenheit to Celcius: "+C+ "°C" ;
;
        }
    }
}
