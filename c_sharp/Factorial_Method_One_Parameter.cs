using System;

namespace Factorial_Method_One_Parameter
{
    internal class Program
    {
        static void factorial(int num)
        {
            int fact = 1;
            while(num>0)
            {
                fact = fact * num;
                num--;
            }
            Console.WriteLine("Fact: " + fact);
        }
        static void Main(string[] args)
        {
            factorial(5);
            Console.ReadKey();
        }
    }
}
