using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Product_Details.Properties
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("Order No:- " + TextBox1.Text+"<br>");
            sb.Append("Customer Name:- " + TextBox2.Text + "<br>");
            sb.Append("Order Date:- " + TextBox3.Text + "<br>");
            sb.Append("Product:- " + DropDownList1.Text + "<br>");

            double price = Convert.ToDouble(TextBox4.Text);
            sb.Append("Price:- " + price+"<br>");

            double quantity = Convert.ToDouble(TextBox5.Text);
            sb.Append("Quantity:- " + quantity+"<br>");

            double totamt = 0;
            totamt = price * quantity;
            sb.Append("Total Amount:- " + totamt);
            
            Label1.Text=sb.ToString();
        }
       
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string p = DropDownList1.Text;
            
            switch (p)
            {
                case "TV":
                    TextBox4.Text = "35000";
                    break;
                case "Refrigerator":
                    TextBox4.Text = "20000";
                    break;
                case "Washing Machine":
                    TextBox4.Text = "25000";
                    break;
                case "Oven":
                    TextBox4.Text = "65000";
                    break;
            }
           
        }
    }
}