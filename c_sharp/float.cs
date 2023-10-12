using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @float
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float b = 123.4567890F;
            Console.WriteLine(" value " + b);
            Console.WriteLine("enter value");
            b = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("value =" + b);
            Console.ReadKey();6


        }
    }
}
