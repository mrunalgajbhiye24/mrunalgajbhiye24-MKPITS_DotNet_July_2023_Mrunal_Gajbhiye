﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Table_Number_Window
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            int num, cnt;
            int res = 1;
            num = Convert.ToInt32(textBox1.Text);
            for (cnt = 1; cnt <= 10; cnt++)
            {
                res = num * cnt;
                sb.Append(num + "*" + cnt + "=" + res + "\n");
            }
            label2.Text = sb.ToString();
        }
    }
}
