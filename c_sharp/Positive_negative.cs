using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Positive_Negative
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Enter Number: ");
            num=Convert.ToInt32(Console.ReadLine());

            if (num > 0)
                Console.WriteLine("It is a Positive number");
            else
                Console.WriteLine("It is a Negative Number");
            Console.ReadKey();
        }
    }
}
