using System;

namespace Table
{
    internal class Program
    {
        static void Main(string[]args)
        {
            int num;
            int result = 0;
            int counter = 1;

            Console.Write("Enter Number: ");
            num = Convert.ToInt32(Console.ReadLine());

            while(counter<=10)
            {
                result = num * counter;
                Console.WriteLine("{0} * {1} = {2} ", num, counter, result);
                counter++;
            }
            Console.ReadKey();
        }
    }
}