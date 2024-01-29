using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prime_Number_Between_1_to_20.Properties
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int num =1;
            int counter = 2;
            int flag = 0;
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            do
            {
                flag = 0;
                counter = 2;
                while (counter < num)
                {
                    if (num % counter == 0)
                    {
                        flag = 1;
                        break;
                    }
                    counter++;

                }
                if (flag == 0)
                {
                    sb.Append("Prime Numbers are:- "+num+"<br>");
                }
                num++;
            } while (num <= 20);
            Label1.Text = sb.ToString();
        }
    }
}