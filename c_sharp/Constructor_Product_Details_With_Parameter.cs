using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Details_With_Parameters
{
    class Product
    {
        int productid;
        string productname;
        int quantity;
        int prize;

        public Product()
        {
            productid = 1;
            productname = "Santoor Soap";
            quantity = 4;
            prize = 600;
        }
        public Product(int productid, string productname,int quantity,int prize)
        {
            this.productid = productid;
            this.productname = productname;
            this.quantity = quantity;
            this.prize = prize;
        }
        public void display()
        {
            Console.WriteLine("Product Id: " + productid);
            Console.WriteLine("Product Name: " + productname);
            Console.WriteLine("Quantity: " + quantity);
            Console.WriteLine("Product Prize: " + prize);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Product pro1 = new Product();
            pro1.display();

            Console.WriteLine();
            Product pro2 = new Product(2, "Induleka Oil", 2, 200);
            pro2.display();
            Console.ReadKey();
        }
    }
}
