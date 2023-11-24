﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
namespace HashTable_Windows_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Hashtable ht = new Hashtable();
        private void button1_Click(object sender, EventArgs e)
        {
            ht.Add(textBox1.Text, textBox2.Text);
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            ICollection key = ht.Keys;
            foreach(string s in ht.Keys)
            {
                sb.Append("Album Name: " + s + "\n");
            }
            label3.Text = sb.ToString();

            StringBuilder sb1 = new StringBuilder();
            ICollection value = ht.Keys;
            foreach (string s in ht.Keys)
            {
                sb1.Append( "Singer Name: " + ht[s] + "\n");
            }
            label4.Text = sb1.ToString();
        }
    }
}
