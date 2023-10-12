using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @double
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double b = 123456.1234567890123;
            Console.WriteLine(" value " + b);
            Console.WriteLine("enter value ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("value = " + b);
            Console.ReadKey();

        }
    }
}
