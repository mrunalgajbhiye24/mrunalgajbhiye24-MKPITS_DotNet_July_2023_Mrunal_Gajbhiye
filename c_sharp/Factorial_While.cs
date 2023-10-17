using System;
using System.Diagnostics;

namespace Factorial_While
{
    internal class Factorial
    {
        static void Main(string[] args)
        {
            int num, fact = 1;
            Console.Write("Enter Number: ");
            num = Convert.ToInt32(Console.ReadLine());

            while(num>0)
            {
                fact = fact * num;
                num--;
            }
            Console.WriteLine("Factorial of a num  is: " + fact);
            Console.ReadKey();
        }
    }
}
