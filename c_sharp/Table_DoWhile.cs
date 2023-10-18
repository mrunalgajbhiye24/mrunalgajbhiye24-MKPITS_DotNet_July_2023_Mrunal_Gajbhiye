using System;

namespace Multiplication
{
    internal class Program
    {
        static void Main(string[]args)
        {
            int num;
            int counter = 1;
            int result = 0;

            Console.Write("Enter Number:");
            num = Convert.ToInt32(Console.ReadLine());

            do
            {
                result = num * counter;
                Console.WriteLine("{0}*{1}={2}", num, counter, result);
                counter++;
            } while (counter <= 10);
            Console.ReadKey();
        }
    }
}