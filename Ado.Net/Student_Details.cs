using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*namespace Student_Details
{
    internal class StudentClass
    {
        string strcon = "server=.\\sqlexpress;integrated security=true;database=Samples1";

        public string InsertStudent(int Roll_No, string Name, string Gender, string Hobby, string City, string DOB)
        {
            using(SqlConnection con=new SqlConnection(strcon))
            {
                con.Open();
                string str="insert into Student7 values(@Roll_No,@Name,@Gender,@Hobby,@City,@DOB)";

                using(SqlCommand cmd=new SqlCommand(str,con))
                {
                    cmd.Parameters.AddWithValue("@Roll_No", Roll_No);
                    cmd.Parameters.AddWithValue("@Name", Name);
                    cmd.Parameters.AddWithValue("@Gender", Gender);
                    cmd.Parameters.AddWithValue("@Hobby", Hobby);
                    cmd.Parameters.AddWithValue("@City", City);
                    cmd.Parameters.AddWithValue("@DOB", DOB);

                    cmd.ExecuteNonQuery();
                    con.Close();
                    return "Record Saved Successfully";
                }
            }
        }
        public string UpdateStudent(int Roll_No, string Name, string Gender, string Hobby, string City, string DOB)
        {
            using (SqlConnection con = new SqlConnection(strcon))
            {
                con.Open();
                string str = "update Student7 set Name=@Name,Gender=@Gender,Hobby=@Hobby,City=@City,DOB=@DOB where Roll_No=@Roll_No";

                using(SqlCommand cmd=new SqlCommand(str,con))
                {
                    cmd.Parameters.AddWithValue("@Name", Name);
                    cmd.Parameters.AddWithValue("@Gender", Gender);
                    cmd.Parameters.AddWithValue("@Hobby", Hobby);
                    cmd.Parameters.AddWithValue("@City", City);
                    cmd.Parameters.AddWithValue("@DOB", DOB);
                    cmd.Parameters.AddWithValue("@Roll_No", Roll_No);

                    cmd.ExecuteNonQuery();
                    con.Close();
                    return "Record Updated Successfully";
                }
            }
        }
        public string DeleteStudent(int Roll_No, string Name)
        {
            using (SqlConnection con = new SqlConnection(strcon))
            {
                con.Open();
                string str = "delete from Student7 where Name=@Name or Roll_No=@Roll_No";

                using (SqlCommand cmd = new SqlCommand(str, con))
                {
                    cmd.Parameters.AddWithValue("@Name", Name);
                    cmd.Parameters.AddWithValue("@Roll_No", Roll_No);

                    cmd.ExecuteNonQuery();
                    con.Close();
                    return "Record Deleted Successfully";
                }
            }
        }
    }
}

 */
namespace Student_Details
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentClass s = new StudentClass();
            string g = null;
            if(radioButton1.Checked)
            {
                g = "Male";
            }
            if(radioButton2.Checked)
            {
                g = "Female";
            }
            string h = null;
            if(checkBox1.Checked)
            {
                h = "Music";
            }
            if(checkBox2.Checked)
            {
                if(h!=null)
                {
                    h = h + " " + "Dancing";
                }
                else
                {
                    h = "Dancing";
                }
            }
            string result = s.InsertStudent(Convert.ToInt32(textBox1.Text), textBox2.Text, g, h, comboBox1.Text, dateTimePicker1.Value.ToShortDateString());
            label7.Text = result;
            Cleartext();
        }
        public void Cleartext()
        {
            textBox1.Clear();
            textBox2.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            comboBox1.Text = " ";
            dateTimePicker1.Value = DateTime.Now;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StudentClass s = new StudentClass();
            string g = null;
            if(radioButton1.Checked)
            {
                g = "Male";
            }
            if(radioButton2.Checked)
            {
                g = "Female";
            }
            string h = null;
            if(checkBox1.Checked)
            {
                h = "Music";
            }
            if(checkBox2.Checked)
            {
                if(h!=null)
                {
                    h = h + " " + "Dancing";
                }
                else
                {
                    h = "Dancing";
                }
            }
            string result = s.UpdateStudent(Convert.ToInt32(textBox1.Text), textBox2.Text, g, h, comboBox1.Text, dateTimePicker1.Value.ToShortDateString());
            label7.Text = result;
            Cleartext();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StudentClass s = new StudentClass();

            string result = s.DeleteStudent(Convert.ToInt32(textBox1.Text), textBox2.Text);

            label7.Text = result;
            Cleartext();

        }
    }
}
