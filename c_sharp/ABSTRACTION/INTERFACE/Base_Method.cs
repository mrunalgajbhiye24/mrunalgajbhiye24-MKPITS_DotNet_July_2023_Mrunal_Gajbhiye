using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Method
{
    class Company
    {
        public string name = "LOC";

        public void display()
        {
            Console.WriteLine("Company Name:- " + name);
        }
    }
    class Franchise:Company
    {
        public string name = "MKPITS";

        public void display()
        {
            base.display();
            Console.WriteLine("Franchise Name:- " + name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Franchise f = new Franchise();
            f.display();
            Console.ReadLine();
        }
    }
}
