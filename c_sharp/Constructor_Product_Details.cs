using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Product_Details
{
    class Product
    {
        int productid;
        string productname;
        int prize;
        int quantity;

        public Product()
        {
            productid = 123;
            productname = "Induleka Oil";
            prize = 350;
            quantity = 1;
        }

        public void display()
        {
            Console.WriteLine("Product Id: " + productid);
            Console.WriteLine("Product Name: " + productname);
            Console.WriteLine("Product Prize: " + prize);
            Console.WriteLine("Quantity: " + quantity);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Product pro = new Product();
            pro.display();
            Console.ReadKey();
        }
    }
}
