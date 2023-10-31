using System;

namespace Customer_Code_Name
{
    class Customer
    {

        public int customer_code;
        public string customer_name;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer cust = new Customer();
            cust.customer_code = 123;
            cust.customer_name = "Mrunal";
            Console.Write("Customer Code: "+ cust.customer_code+"\n");
            Console.Write("Customer_Name: " + cust.customer_name);
            Console.ReadKey();
        }
    }
}
