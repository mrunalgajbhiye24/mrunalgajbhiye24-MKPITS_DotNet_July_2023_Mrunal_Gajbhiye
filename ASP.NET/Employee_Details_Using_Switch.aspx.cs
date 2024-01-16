using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Employee_Details_Switch.Properties
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string name = TextBox1.Text;
            string des = TextBox2.Text;
            int sal = Convert.ToInt32(TextBox3.Text);
            float hra = 0;
            float da = 0;
            float total = 0;
            switch(des)
            {
                case "Manager":
                    hra = sal * 0.45f;
                    da = sal * 0.35f;
                    total = hra + da + sal;
                    break;
                case "Peon":
                    hra = sal * 0.25f;
                    da = sal * 0.15f;
                    total = hra + da + sal;
                    break;
                default:
                    Response.Write ( "Invalid Character");
                    break;
            }
            Label1.Text = "HRA:-" + hra;
            Label2.Text = "DA:-" + da;
            Label3.Text = "Total Salary:- " + total;
        }
    }
}