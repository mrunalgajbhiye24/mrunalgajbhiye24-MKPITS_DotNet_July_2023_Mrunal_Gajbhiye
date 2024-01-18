using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Account_Withdrawl_Deposit.Properties
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int bal = 1000;
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("Account No:- " + TextBox1.Text + "<br>");
            int amt=Convert.ToInt32(TextBox2.Text);
            if(RadioButton1.Checked)
            {
                bal = bal + amt;
            }
            else if(RadioButton2.Checked)
            {
                bal = bal - amt;
            }
            sb.Append("Total Amount:- " + bal + "<br>");
            Label1.Text=sb.ToString();
        }
    }
}