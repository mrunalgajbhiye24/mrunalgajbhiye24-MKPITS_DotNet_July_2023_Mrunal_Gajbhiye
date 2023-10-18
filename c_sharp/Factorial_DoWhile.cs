using System;

namespace Factorial
{
    internal class Program
    {
        static void Main(string[]args)
        {
            int num;
            int fact = 1;
            Console.Write("Enter Number: ");
            num = Convert.ToInt32(Console.ReadLine());

            do
            {
                fact = fact * num;
                num--;
            } while (num > 0);
            Console.WriteLine("Factorial: " + fact);
            Console.ReadKey();
        }
    }
}