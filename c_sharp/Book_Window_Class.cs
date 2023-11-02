using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_Windows_Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Book[] bookied = new Book[3];
        int cnt = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            bookied[0] = new Book();
            bookied[1] = new Book();
            bookied[2] = new Book();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cnt < 3)
            {
                bookied[cnt].title = textBox1.Text;
                bookied[cnt].author = textBox2.Text;
                bookied[cnt].publication_year = Convert.ToInt32(textBox3.Text);
                cnt++;

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox1.Focus();

                if (cnt == 3)
                {
                    button1.Enabled = false;
                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                    textBox3.Enabled = false;
                    button2.Enabled = true;
                    MessageBox.Show("You Have enter all Details of Book");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Details of All The Books");

            for(int i=0;i<3;i++)
            {
                sb.Append("Title of Book: " + bookied[i].title+"\n");
                sb.Append("Author of Book: " + bookied[i].author+"\n");
                sb.Append("Publication Year of Book: " + bookied[i].publication_year+"\n");
                sb.Append("-----------------------------------------------\n");
            }
            label4.Text = sb.ToString();
        }
    }
}
