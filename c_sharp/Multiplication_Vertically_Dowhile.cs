using System;

namespace Multiplication
{
    internal class Program
    {
        static void Main(string[]args)
        {
            int n;
            Console.Write("Enter Limit: ");
            n = Convert.ToInt32(Console.ReadLine());

            int num = 1;
            int count = 1;
            int result;

            do
            {
                count = 1;
                while (count <= n)
                {
                    result = num * count;
                    Console.Write("{0}*{1}={2}", count, num, result);
                    Console.Write("\t");
                    count++;
                }
                Console.WriteLine();
                num++;
                    
            } while (num <= 10);
            Console.ReadKey();
            
        }
    }
}