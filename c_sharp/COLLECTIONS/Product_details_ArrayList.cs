using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Details_ArrayList
{
    class Product
    {
        public int proid;
        public string proname;
        public int rate;

        public Product(int proid,string proname,int rate)
        {
            this.proid = proid;
            this.proname = proname;
            this.rate = rate;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList ar = new ArrayList();
            Product p1 = new Product(1, "Rice", 400);
            Product p2 = new Product(2, "Wheat", 500);
            Product p3 = new Product(1, "Jawar", 200);
            ar.Add(p1);
            ar.Add(p2);
            ar.Add(p3);
            foreach (Product pro in ar)
            {
                Console.WriteLine("Product Id:- " + pro.proid);
                Console.WriteLine("Product Name:- " + pro.proname);
                Console.WriteLine("Product Rate:- " + pro.rate);
                Console.WriteLine("---------------------------");
            }
            Console.ReadKey();
        }
    }
}
