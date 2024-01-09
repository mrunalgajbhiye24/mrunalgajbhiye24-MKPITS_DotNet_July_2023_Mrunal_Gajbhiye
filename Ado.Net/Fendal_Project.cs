using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fendal_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        string strcon = "server=.\\sqlexpress;integrated security=true;database=Course Registration";
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(strcon);
                da = new SqlDataAdapter("select * from TableNationss order by Nation_Id", con);
                ds = new DataSet();
                da.Fill(ds, "Nations");

                comboBox1.DataSource = ds.Tables["Nations"];
                comboBox1.DisplayMember = "Nation_Name";
                comboBox1.ValueMember = "Nation_Id";
            }
            catch(SqlException ee)
            {
                MessageBox.Show(ee.ToString());
            }
            dateTimePicker1.Text = DateTime.Now.ToShortDateString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                try
                {
                    con = new SqlConnection(strcon);
                    da = new SqlDataAdapter("select * from TablesStatess where Nation_Id=@Nation_Id", con);
                    da.SelectCommand.Parameters.AddWithValue("@Nation_Id", comboBox1.SelectedValue);
                    ds = new DataSet();
                    ds.Clear();
                    da.Fill(ds,"States");
                    comboBox2.DataSource = ds.Tables["States"];
                    comboBox2.DisplayMember = "State_Name";
                    comboBox2.ValueMember = "State_Id";
                }
                catch(SqlException ee)
                {
                    MessageBox.Show(ee.ToString());
                }
                
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                try
                {
                    con = new SqlConnection(strcon);
                    da = new SqlDataAdapter("select * from TablesCitys where State_Id=@State_Id", con);
                    da.SelectCommand.Parameters.AddWithValue("@State_Id", comboBox2.SelectedValue);
                    ds = new DataSet();
                    ds.Clear();
                    da.Fill(ds, "City");
                    comboBox3.DataSource = ds.Tables["City"];
                    comboBox3.DisplayMember = "City_Name";
                    comboBox3.ValueMember = "City_Id";
                }
                catch (SqlException ee)
                {
                    MessageBox.Show(ee.ToString());
                }

            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
       public enum category { student,It_Professional}
       public enum gender { male,female,other}

        category cat;
        gender gen;

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime selecteddate = dateTimePicker1.Value;

            if(selecteddate.Date<DateTime.Today)
            {
                MessageBox.Show("Please Select a Payment date that is on or After todays's date", "Invalid Date Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(textBox1.Text=="")
            {
                MessageBox.Show("Full Name Can't be Blank");
            }
            else
            {
                if(radioButton1.Checked)
                {
                    cat = category.student;
                }
                else if(radioButton2.Checked)
                {
                    cat = category.It_Professional;
                }
                MessageBox.Show("Category " + cat);
                if(radioButton3.Checked)
                {
                    gen = gender.male;
                }
                else if(radioButton4.Checked)
                {
                    gen = gender.female;
                }
                else if(radioButton5.Checked)
                {
                    gen = gender.other;
                }
                MessageBox.Show("Gender Selected" + gen);
                savecourseregdetail(cat, gen);
            }
         
        }
        public void savecourseregdetail(category c,gender g)
        {
            try
            {
                
                string str = "insert into TableCourseRegDetailss values(@Category_Id,@Full_Name,@Gender_Id)";
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.Parameters.AddWithValue("@Category_Id", Convert.ToInt32(c));
                cmd.Parameters.AddWithValue("@Full_Name", textBox1.Text);
                cmd.Parameters.AddWithValue("@Gender_Id", Convert.ToInt32(g));
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Saved Successfully");
                con.Close();

            }
            catch(SqlException ee)
            {
                MessageBox.Show(ee.ToString());
            }
            insertRegAddress();
        }
        public void insertRegAddress()
        {
            con.Open();
            string strs = "select max(CourseReg_Id) from TableCourseRegDetailss";
            SqlCommand cmd1 = new SqlCommand(strs, con);
            int mcid = Convert.ToInt32(cmd1.ExecuteScalar());
            MessageBox.Show(mcid.ToString());
            string s2 = "insert into TablesRegAddress1 values(@CourseReg_Id,@Nation_Id,@State_Id,@City_Id)";
            cmd1.Parameters.Add("@CourseReg_Id", SqlDbType.Int).Value = mcid;
            cmd1.Parameters.Add("@Nation_Id", SqlDbType.Int).Value = comboBox1.SelectedValue;
            cmd1.Parameters.Add("@State_Id", SqlDbType.Int).Value = comboBox2.SelectedValue;
            cmd1.Parameters.Add("@City_Id", SqlDbType.Int).Value = comboBox3.SelectedValue;
            cmd1.ExecuteNonQuery();
            MessageBox.Show("Stored TablesRegAddress1");
            con.Close();
            insertFeeDetails();
        }
        public  void insertFeeDetails()
        {
            con.Open();

            string str = "select max(courseregid) from TableCourseRegDetailss";
            SqlCommand cmd11 = new SqlCommand(str, con);
            int mcid = Convert.ToInt32(cmd11.ExecuteScalar());

            string s2 = "insert into TablesFeeDetails values(@CourseReg_Id,@TotalAmount,@MinPer,@PaidAmount,@BalAmount,@PaidDate)";
            SqlCommand cmd1 = new SqlCommand(s2, con);
            cmd1.Parameters.Add("@CourseReg_Id", SqlDbType.Int).Value = mcid;
            cmd1.Parameters.Add("@TotalAmount", SqlDbType.Decimal).Value = textBox2.Text;
            cmd1.Parameters.Add("@MinPer", SqlDbType.Int).Value = fp;
            cmd1.Parameters.Add("@PaidAmount", SqlDbType.Int).Value = textBox3.Text;
            cmd1.Parameters.Add("@BalAmount", SqlDbType.Int).Value = textBox4.Text;
            cmd1.Parameters.Add("@PaidDate", SqlDbType.DateTime).Value = dateTimePicker1.Value;
            cmd1.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Stored TableFeeDetail");

        }
        private void textBox3_Leave(object sender, EventArgs e)
        {
            calculatefees();
        }


        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton2.Checked)
            {
                cat = category.It_Professional;
                textBox2.Text = "3000";
                textBox3.Text = "0";
                textBox4.Text = "0";
            }
        }

        float fp;
        float bamt;
        public void calculatefees()
        {
            if(cat.ToString()=="student")
            {
                textBox2.Text = "1000";

                float ta = Convert.ToSingle(textBox2.Text);
                 fp = ta * 0.5f;
                float amt = Convert.ToSingle(textBox3.Text);

                if(amt<fp)
                {
                    MessageBox.Show("Minimum Amount to be paid is 50 Percent");
                }
                else
                {
                    float bamt = ta - amt;
                    textBox4.Text = bamt.ToString();
                }
            }
            else if(cat.ToString()=="It_Professional")
            {
                textBox2.Text = "3000";
                float ta = Convert.ToSingle(textBox2.Text);
                float fp = ta * 0.8f;
                float amt = Convert.ToSingle(textBox3.Text);

                if (amt < fp)
                {
                    MessageBox.Show("Minimum amount to be paid is 80 per");
                }
                else
                {
                    float bamt = ta - amt;
                    textBox4.Text = bamt.ToString();
                }
            }

        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                cat = category.student;
                textBox2.Text = "1000";
                textBox3.Text = "0";
                textBox4.Text = "0";
            }

        }

    }
}

