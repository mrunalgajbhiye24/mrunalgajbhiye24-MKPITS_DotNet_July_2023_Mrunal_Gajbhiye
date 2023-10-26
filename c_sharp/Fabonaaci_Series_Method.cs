using System;

namespace Fabonacci_series_Method
{
    internal class Program
    {
        static int fabonacci(int n)
        {
            int num1 = 0;
            int num2 = 1;
            int cnt = 0;
            int temp;
            while(cnt<n)
            {
                if (cnt < 2)
                {
                    temp = cnt;
                }
                else
                {
                    temp = num1 + num2;
                    num1 = num2;
                    num2 = temp;
                }
                Console.WriteLine(temp);
                cnt++;
            }
            return n;
        }
        static void Main(string[] args)
        {
            int n;
            Console.Write("Enter Number: ");
            n = Convert.ToInt32(Console.ReadLine());
            fabonacci(n);
            Console.ReadKey();
        }
    }
}
