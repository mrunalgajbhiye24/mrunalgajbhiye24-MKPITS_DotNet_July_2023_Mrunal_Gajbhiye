using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Add_Sub_Mul.Properties
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int num1=Convert.ToInt32(TextBox1.Text);
            int num2=Convert.ToInt32(TextBox2.Text);
            System.Text.StringBuilder sb=new System.Text.StringBuilder();
            int add = 0;
            int sub = 0;
            int mul = 0;
            if(CheckBox1.Checked)
            {
               add = num1 + num2;
               sb.Append("Addition of Two Numbers:- " + add+"<br>");
            }
            if (CheckBox2.Checked)
            {
                sub = num1 - num2;
                sb.Append("Substraction of Two Numbers:- " + sub+"<br>");
            }
            if(CheckBox3.Checked)
            {
                mul = num1 * num2;
                sb.Append("Multiplication of Two Numbers:- " + mul);
            }           
            Label1.Text=sb.ToString();  
        }
    }
}