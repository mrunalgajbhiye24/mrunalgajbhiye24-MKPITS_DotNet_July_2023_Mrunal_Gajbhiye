using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        private void button1_Click(object sender, EventArgs e)
        {
            string constr = "server=.\\sqlexpress;integrated security=true;database=Samples1";

            SqlConnection con = new SqlConnection(constr);
            try
            {
                con.Open();
                string strcmd = "insert into Login values('" + textBox1.Text + "','" + textBox2.Text + "')";
                SqlCommand cmd = new SqlCommand(strcmd, con);
                cmd.ExecuteNonQuery();
                con.Close();
                label3.Text = "Record inserted Successfully";
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string constr = "server=.\\sqlexpress;integrated security=true;database=Samples1";

            SqlConnection con = new SqlConnection(constr);
            try
            {
                con.Open();
                string strcmd = "update Login set Password='" + textBox2.Text + "' where Username='" + textBox1.Text + "'";
                SqlCommand cmd = new SqlCommand(strcmd,con);
                cmd.ExecuteNonQuery();
                con.Close();
                label3.Text = "Record Updated Successfully";
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string constr = "server=.\\sqlexpress;integrated security=true;database=Samples1";

            SqlConnection con = new SqlConnection(constr);
            try
            {
                con.Open();
                string strcmd = "delete from Login where Username='" + textBox1.Text + "'or Password='" + textBox2.Text + "'";
                SqlCommand cmd = new SqlCommand(strcmd, con);
                cmd.ExecuteNonQuery();
                con.Close();
                label3.Text = "Record Delete Successfully";
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string constr = "server=.\\sqlexpress;integrated security=true;database=Samples1";

            SqlConnection con = new SqlConnection(constr);
            try
            {
                con.Open();
                string strcmd = "Select * from Login where Username='" + textBox1.Text + "'";

                SqlCommand cmd = new SqlCommand(strcmd, con);
                SqlDataReader dr;
                int flag = 0;
                dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    flag = 1;
                    textBox2.Text = dr["Password"].ToString();
                }
                dr.Close();
                con.Close();
                if(flag==0)
                {
                    label3.Text="Record Not Found";
                }
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }
    }
}
