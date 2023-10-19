using System;

namespace Print_Sum_FiveNum
{
    internal class Program
    {
        static void Main(string[]args)
        {
            int num;
            int counter;
            int sum = 0;

            for (counter=1;counter<=5;counter++)
            {
                Console.Write("Enter Number: ");
                num = Convert.ToInt32(Console.ReadLine());
                sum = sum+num;
            }
            Console.WriteLine("\nSum of five numbers: " + sum);
            Console.ReadKey();
        }
    }
}