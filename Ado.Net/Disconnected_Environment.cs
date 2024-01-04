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

namespace Disconnected_Environment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("server=.\\sqlexpress;integrated security=true;database=Student");
        DataSet DS = new DataSet();
        SqlDataAdapter da;
        SqlCommandBuilder cb = null;

        private void button1_Click(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("select * from Student2", con);

            cb = new SqlCommandBuilder(da);

            da.Fill(DS, "Stud");
            dataGridView1.DataSource = DS.Tables["Stud"];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                da.Update(DS.Tables["Stud"]);
                MessageBox.Show("Record Updated Successfully");
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }
    }
}
