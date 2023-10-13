using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace three_greater_num
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.WriteLine("Enter 1st No:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd No:");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 3rd No:");
            num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2 && num1 > num3)
                Console.WriteLine("num1 is greater ");
            else if (num2 > num3)
                Console.WriteLine("num2 is greater ");
            else
                Console.WriteLine("num3 is greater ");
            Console.ReadKey();
        }
    }
}
