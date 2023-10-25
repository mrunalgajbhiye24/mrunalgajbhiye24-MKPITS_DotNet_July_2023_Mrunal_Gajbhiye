using System;

namespace Factorial_Method_ReturningValue
{
    internal class Program
    {
        static int factorial(int num)
        {
            int fact = 1;
            while (num > 0)
            {
                fact = fact * num;
                num--;
            }
            return fact;
        }
        static void Main(string[] args)
        {
            int number;
            Console.Write("Enter number: ");
            number = Convert.ToInt32(Console.ReadLine());
            int result = factorial(number);
            Console.WriteLine("Fact: " + result);


            Console.ReadKey();
        }
    }
}
