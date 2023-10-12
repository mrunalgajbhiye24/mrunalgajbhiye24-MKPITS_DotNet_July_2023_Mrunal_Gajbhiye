using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace long_ulong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long b = -25890;
            Console.WriteLine("value " + b);
            Console.WriteLine("enter");
            b = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("value =" + b);

            ulong b1 = 25890000;
            Console.WriteLine("value " + b1);
            Console.WriteLine("enter");
            b1 = Convert.ToUInt64(Console.ReadLine());
            Console.WriteLine("value =" + b1);
            Console.ReadKey();

        }
    }
}
