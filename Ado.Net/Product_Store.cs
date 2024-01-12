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

namespace Product_Store
{
    public partial class Form1 : Form
    { 
        public enum Nationality { Indian, NRI }
        Nationality nat;

        string strcon = "server=.\\sqlexpress;integrated security=true;database=Product Store";
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar!='.'))
            {
                e.Handled = true;
                MessageBox.Show("Enter Only Numbers");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getcategory();
            getproduct();
            getprice();
            nat = Nationality.Indian;
        }
        public void getcategory()
        {
            con = new SqlConnection(strcon);
            da = new SqlDataAdapter("select * from TableProductCategory2", con);
            ds = new DataSet();
            da.Fill(ds, "tpc");
            comboBox1.DataSource = ds.Tables["tpc"];
            comboBox1.DisplayMember = "Product_Type_Name";
            comboBox1.ValueMember = "Product_Category_Id";
        }
        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox11.Text = "0";
            getproduct();   
            
            if (comboBox1.Text != "System.Data.DataRowView")
            {
                string catname = comboBox1.Text;                
                con = new SqlConnection(strcon);
                da = new SqlDataAdapter("select * from TableProductGSTDetails2 where Gst_Detail_Name=@gdn", con);
                da.SelectCommand.Parameters.AddWithValue("@gdn",catname);
                ds=new DataSet();
                da.Fill(ds,"tgst");

                foreach(DataRow dr in ds.Tables["tgst"].Rows)
                {
                    textBox3.Text = dr["CGST"].ToString();
                    textBox4.Text = dr["SGST"].ToString();
                    textBox5.Text = dr["IGST"].ToString();
                }
            }
        }


    
    public void getproduct()
        {
            if (comboBox1.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                con = new SqlConnection(strcon);
                da = new SqlDataAdapter("select * from TableProduct2 where ProductTypeID = @PCI", con);
                da.SelectCommand.Parameters.AddWithValue("@PCI", comboBox1.SelectedValue);
                ds = new DataSet();
                da.Fill(ds, "tp");
                comboBox2.DataSource = ds.Tables["tp"];
                comboBox2.DisplayMember = "ProductName";
                comboBox2.ValueMember = "ProductID";
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            getprice();
            textBox10.Text = "0";
            textBox11.Text = "0";            
        }
        public void getprice()
        {
            if(comboBox2.SelectedValue.ToString()!="System.Data.DataRowView")
            {
                con = new SqlConnection(strcon);
                da = new SqlDataAdapter("select * from TableProduct2 where ProductID=@pid", con);
                da.SelectCommand.Parameters.AddWithValue("@pid", comboBox2.SelectedValue);
                ds = new DataSet();
                da.Fill(ds, "tp1");
                foreach(DataRow dr in ds.Tables["tp1"].Rows)
                {
                    textBox9.Text = dr["ProductPrice"].ToString();
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                nat = Nationality.Indian;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                nat = Nationality.NRI;
            }
        }
        double tcgst = 0;
        double tsgst = 0;
        double tigst = 0;
        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            if (textBox10.Text != "")
            {
                double price = Convert.ToDouble(textBox9.Text);
                double quantity = Convert.ToDouble(textBox10.Text);
                double totalamount = price * quantity;
                textBox11.Text = totalamount.ToString();

                double pcgst = Convert.ToDouble(textBox3.Text);
                tcgst = totalamount * (pcgst / 100);
                textBox6.Text = tcgst.ToString();

                double psgst = Convert.ToDouble(textBox4.Text);
                tsgst = totalamount * (psgst / 100);
                textBox7.Text=tsgst.ToString();

                double pigst = Convert.ToDouble(textBox5.Text);
                tigst = totalamount * (pigst / 100);
                textBox8.Text = tigst.ToString();

                if(nat.ToString()=="Indian")
                {
                    double netamount = Convert.ToDouble(textBox11.Text) +
                                     Convert.ToDouble(textBox6.Text) +
                                     Convert.ToDouble(textBox7.Text);
                    textBox12.Text = netamount.ToString();
                }
                else if(nat.ToString()=="NRI")
                {
                    double netamount = Convert.ToDouble(textBox11.Text) +
                                     Convert.ToDouble(textBox8.Text);
                    textBox12.Text = netamount.ToString();
                }
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="" && textBox2.Text=="")
            {
                MessageBox.Show("You Cannot Left Blank any Field");
            }
            else
            {
                SqlConnection con = new SqlConnection(strcon);
                con.Open();
                string s2 = "insert into TableInvoiceDetails values(@Customer_Name,@Customer_Contact,@Product_Category_ID,@Product_ID, @Residential_Type_ID,@Invoice_Date,@Quantity,@Price,@CGST,@SGST,@IGST,@CGST_Value,@SGST_Value,@IGST_Value,@Total_Amount)";
                SqlCommand cmd = new SqlCommand(s2, con);
                cmd.Parameters.Add("@Customer_Name", SqlDbType.VarChar).Value = textBox1.Text;
                cmd.Parameters.Add("@Customer_Contact", SqlDbType.VarChar).Value = textBox2.Text;
                cmd.Parameters.Add("@Product_Category_ID", SqlDbType.Int).Value = comboBox1.SelectedValue;
                cmd.Parameters.Add("@Product_ID", SqlDbType.Int).Value = comboBox2.SelectedValue;
                cmd.Parameters.Add("@Residential_Type_ID", SqlDbType.Int).Value = 1001;
                cmd.Parameters.Add("@Invoice_Date", SqlDbType.DateTime).Value = dateTimePicker1.Text;
                cmd.Parameters.Add("@Quantity", SqlDbType.Decimal).Value = textBox10.Text;
                cmd.Parameters.Add("@Price", SqlDbType.Decimal).Value = textBox9.Text;
                cmd.Parameters.Add("@CGST", SqlDbType.Decimal).Value = textBox3.Text;
                cmd.Parameters.Add("@SGST", SqlDbType.Decimal).Value = textBox4.Text;
                cmd.Parameters.Add("@IGST", SqlDbType.Decimal).Value = textBox5.Text;
                cmd.Parameters.Add("@CGST_Value", SqlDbType.Decimal).Value = textBox6.Text;
                cmd.Parameters.Add("@SGST_Value", SqlDbType.Decimal).Value = textBox7.Text;
                cmd.Parameters.Add("@IGST_Value", SqlDbType.Decimal).Value = textBox8.Text;
                cmd.Parameters.Add("@Total_Amount", SqlDbType.Decimal).Value = textBox12.Text;
                cmd.ExecuteNonQuery();
                con.Close();
                Clear();
                MessageBox.Show("Record inserted in TableInvoiceDetails");
            }
        }
        public void Clear()
        {
            dateTimePicker1.Value = DateTime.Today;
            comboBox1.Text = "Select";
            comboBox2.Text = "Select";
            textBox3.Text = "0";
            textBox4.Text = "0";
            textBox5.Text = "0";
            textBox6.Text = "0";
            textBox7.Text = "0";
            textBox8.Text = "0";
            textBox9.Text = "0";
            textBox10.Text = "0";
            textBox11.Text = "0";
            textBox12.Text = "0";
            textBox1.Clear();
            textBox2.Clear();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}


