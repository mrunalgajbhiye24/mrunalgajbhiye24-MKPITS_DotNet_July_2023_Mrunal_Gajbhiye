using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Addition_Of_Two_Numbers.Properties
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            float n1 = Convert.ToInt32(TextBox1.Text);
            float n2 = Convert.ToInt32(TextBox2.Text);
            char op = Convert.ToChar(TextBox3.Text);
            float res = 0;
            switch(op)
            {
                case '+':
                    res = n1 + n2;
                    break;
                case '-':
                    res = n1 - n2;
                    break;
                case '*':
                    res = n1 * n2;
                    break;
                case '/':
                    res = n1 / n2;
                    break;
                default:
                    Response.Write("Invalid Character");
                    break;
            }
            Label1.Text = "Result:-" + res.ToString();
        }
    }
}