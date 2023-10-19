using System;

namespace Average_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int cnt;
            int sum = 0;
            float avg = 0;
            for (cnt = 1; cnt <= 10; cnt++)
            {
                Console.Write("Enter Number: ");
                num = Convert.ToInt32(Console.ReadLine());
                sum += num;
                avg = sum / 10.0f;
            }
            Console.WriteLine("Sum of 10 Number is: " + sum);
            Console.WriteLine("Average of First natural Number is: " + avg);
            Console.ReadKey();
        }
    }
}