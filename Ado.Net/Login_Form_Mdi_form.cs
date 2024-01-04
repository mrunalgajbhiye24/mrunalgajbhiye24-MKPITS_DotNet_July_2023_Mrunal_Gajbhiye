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

namespace Login_Form_One
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string strcon = "server=.\\sqlexpress;integrated security=true;database=Samples1";
        
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(strcon);
            string str = "select count(*) from Login where Username=@Username and Password=@Password";
            try
            { 
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.Parameters.AddWithValue("@Username", textBox1.Text);
                cmd.Parameters.AddWithValue("@Password", textBox2.Text);
                con.Open();
                int cnt = Convert.ToInt32(cmd.ExecuteScalar());
                if (cnt>0)
                {
                    MessageBox.Show("Login Successfull");
                    panel1.Visible = false;
                    menuStrip1.Visible = true;
                }
                else
                {
                    MessageBox.Show("Invalid Credentials! Try Again");
                }
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }
    }
}
