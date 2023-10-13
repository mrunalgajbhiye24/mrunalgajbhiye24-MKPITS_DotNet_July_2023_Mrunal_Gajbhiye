using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EQUAL_NUM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.Write("Enter 1st No:");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter 2nd No:");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 == num2)
                Console.WriteLine("Both the Numbers are Equal");
            else
                Console.WriteLine("Both the Numbers are Not Equal");
            Console.ReadKey();
        }
    }
}
