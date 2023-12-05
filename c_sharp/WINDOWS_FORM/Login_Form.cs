using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox2.Text = "";
            switch(comboBox1.Text)
            {
                case "India":
                    comboBox2.Items.Add ( "Maharashtra");
                    comboBox2.Items.Add ("Gujarat");
                    comboBox2.Items.Add ( "Delhi");
                    comboBox2.Items.Add ("Chennai");
                    break;
                case "USA":
                    comboBox2.Items.Add ("California");
                    comboBox2.Items.Add ("New York");
                    comboBox2.Items.Add ("La");
                    comboBox2.Items.Add ("Canada");
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Username:- " + textBox1.Text+"\n");
            sb.Append("Password:- " + textBox2.Text+"\n");

            //-------------Gender--------------
            string gender = null;
            if(radioButton1.Checked)
            {
                gender = radioButton1.Text;
            }
            else if(radioButton2.Checked)
            {
                gender = radioButton2.Text;
            }
            else if(radioButton3.Checked)
            {
                gender = radioButton3.Text;
            }
            sb.Append("Gender:- " + gender + "\n");

            //------------Course---------------
            string course = null;
            if (checkBox1.Checked)
            {
                course = checkBox1.Text;
            }
            if(checkBox2.Checked)
            {
                course = course+ " " +checkBox2.Text;
            }
            if(checkBox3.Checked)
            {
                course = course + " " + checkBox3.Text;
            }
            sb.Append("Courses:- " + course + "\n");

            sb.Append("Country:- " + comboBox1.Text + "\n");
            sb.Append("City:- " + comboBox1.Text + "\n");

            string age = dateTimePicker1.Text;
            MessageBox.Show("DOB:- " + age);
            int yr = dateTimePicker1.Value.Year;
            MessageBox.Show("DOB Year:- " + yr);
            int cyr = DateTime.Now.Year;
            MessageBox.Show("Current Year:- " + cyr);
            int diff = cyr - Convert.ToInt32(yr);
            MessageBox.Show("Your age is:- " + diff);
            sb.Append("Age is:- " + diff);
            label8.Text = sb.ToString();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
