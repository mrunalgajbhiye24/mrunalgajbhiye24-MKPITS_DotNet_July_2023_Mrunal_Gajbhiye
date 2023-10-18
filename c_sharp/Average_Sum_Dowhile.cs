using System;

namespace Average_Sum
{
    internal class Program
    {
        static void Main(string[]args)
        {
            int num=1;
            int sum = 0;
            float avg = 0;
            do
            {
                Console.WriteLine(num);
                sum += num;
                avg = sum / 10f;
                num++;

            } while (num <= 10);
            Console.WriteLine("Sum of First natural Number is: " + sum);
            Console.WriteLine("Average of First natural Number is: " + avg);


        }
    }
}