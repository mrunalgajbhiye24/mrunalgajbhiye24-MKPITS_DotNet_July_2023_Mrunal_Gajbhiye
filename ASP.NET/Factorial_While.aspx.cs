using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Factorial_of_Number.Properties
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int fact = 1;
            int num=Convert.ToInt32(TextBox1.Text);
            
            while(num>0)
            {
                fact = num * fact;
                num--;
            }
            Label1.Text = fact.ToString();
        }
    }
}