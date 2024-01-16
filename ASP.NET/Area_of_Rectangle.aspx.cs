using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Area_of_Rectangle.Properties
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int l = Convert.ToInt32(TextBox1.Text);
            int b=Convert.ToInt32(TextBox2.Text);
            int res;
            res = l * b;
            Label1.Text = "Area of Rectangle:- " + res.ToString();
        }
    }
}