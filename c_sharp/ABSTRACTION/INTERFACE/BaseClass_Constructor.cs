using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Class_Constructor
{
    class Company
    {
        public string name = "LOC";

        public Company()
        {
            Console.WriteLine("Base Class Constructor");
            Console.WriteLine("Company Name:- " + name);
        }
    }
    class Franchise:Company
    {
        public string name = "MKPITS";

        public Franchise()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("Derived Class Constructor");
            Console.WriteLine("Franchise Name:- " + name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Franchise f = new Franchise();
            Console.ReadKey();
        }
    }
}
