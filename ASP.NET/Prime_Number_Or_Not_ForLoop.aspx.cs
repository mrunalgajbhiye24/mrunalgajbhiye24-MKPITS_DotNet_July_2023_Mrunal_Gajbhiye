﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prime_Number_or_Not.Properties
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int num;
            int cnt ;
            int flag = 0;
            string res;
            num = Convert.ToInt32(TextBox1.Text);
            for (cnt=2; cnt < num;cnt++)
            {
                if (num % cnt == 0)
                {
                    flag = 1;
                    break;

                }
               
            }
            if (flag == 0)
            {
                res = "It is a Prime Number";
            }
            else
            {
                res = "It is not a Prime Number";
            }
            Label1.Text = res.ToString();
        }
    }
}