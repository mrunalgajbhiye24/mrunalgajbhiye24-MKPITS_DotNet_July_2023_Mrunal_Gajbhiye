using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Subject_Marks.Properties
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            float s1=Convert.ToInt32(TextBox1.Text);
            float s2=Convert.ToInt32(TextBox2.Text);
            float s3=Convert.ToInt32(TextBox3.Text);
            float total = s1 + s2 + s3;
            Label1.Text = "Total Marks:- " + total.ToString();
            float per = total / 300 * 100f;
            Label2.Text="Percentage:- "+per.ToString();
            string g;
            if(per>=80)
            {
                g = "A";
            }
            else if(per<80 && per>=70)
            {
                g = "B";
            }
            else if (per < 70 && per >= 60)
            {
                g = "C";
            }
            else if (per < 60 && per >= 50)
            {
                g = "D";
            }
            else if (per < 50 && per >= 35)
            {
                g = "E";
            }
            else
            {
                g= "Fail";
            }
            Label3.Text = "Grade:- " + g.ToString();
        }
    }
}