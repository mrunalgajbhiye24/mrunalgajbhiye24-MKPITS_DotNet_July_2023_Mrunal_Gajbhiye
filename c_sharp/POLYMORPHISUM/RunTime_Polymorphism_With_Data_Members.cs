using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runtime_Polymorphisum_with_Data_Members
{
    class Animal
    {
        public string color = "White";
    }
    class Dog:Animal
    {
        public string color = "Balck";
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal d = new Animal();
            Console.WriteLine(d.color);
            Console.ReadKey();
        }
    }
}
