﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Swapping
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            

            num1 = Convert.ToInt32(textBox1.Text);
            num2= Convert.ToInt32(textBox2.Text);

            num1 = num1 - num2;
            num2 = num1 + num2;
            num1 = num2 - num1;

            label3.Text = "Number 1: " + num1;
            label4.Text = "Number 2: " + num2;

        }
    }
}
