using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Employee_Details.Properties
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string name = TextBox1.Text;
            string designation = TextBox2.Text;
            int sal=Convert.ToInt32(TextBox3.Text);
            float hra=0;
            float da=0;
            float total = 0;
            if(designation=="Manager")
            {
                hra = sal * 0.45f;
                da = sal * 0.35f;
                total = hra + da + sal;
            }
            else if(designation=="Peon")
            {
                hra = sal * 0.25f;
                da = sal * 0.15f;
                total = hra + da + sal;
            }
            Label1.Text = "HRA:-" + hra.ToString();
            Label2.Text = "DA:- " + da.ToString();
            Label3.Text = "Total Salary:- " + total.ToString();
        }
    }
}