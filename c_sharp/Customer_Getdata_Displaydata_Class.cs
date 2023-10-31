using System;

namespace Customer_GetData_DisplayData
{
    class Customer
    {
        int customer_code;
        string customer_name;
        public void getdata(int c_code, string c_name)
        {
            customer_code = c_code;
            customer_name = c_name;
        }
        public void displaydata()
        {
            Console.Write("Customer Code: " + customer_code+"\n");
            Console.Write("Customer Name: " + customer_name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer cust = new Customer();
            cust.getdata(123, "Mrunal");
            cust.displaydata();
            Console.ReadKey();
        }
    }
}
