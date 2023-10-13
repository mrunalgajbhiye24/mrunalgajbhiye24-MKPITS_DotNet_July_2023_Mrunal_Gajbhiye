using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even_Odd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter Number");
            num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
                Console.WriteLine("It is a Prime Number");
            else
                Console.WriteLine("It is a Odd Number");
            Console.ReadKey();
        }
    }
}
