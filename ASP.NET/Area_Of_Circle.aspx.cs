using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Area_of_Circle.Properties
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            float r=Convert.ToInt32(TextBox1.Text);
            float area = 3.14f * r * r;
            float circ = 2 * 3.14f * r;
            Label1.Text = "Area of Circle:- " + area.ToString();
            Label2.Text="Circumference of Circle:- "+circ.ToString();
        }
    }
}