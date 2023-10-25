using System;

namespace Factorial_Method_Accepting_From_User
{
    internal class Program
    {
        static void factorial(int num) //method with one integer parameter
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
            int number;
            Console.Write("Enter Number: ");
            number = Convert.ToInt32(Console.ReadLine());
            factorial(number);
            Console.ReadKey();
        }
    }
}
