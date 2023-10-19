using System;

namespace Multiplication_Vertically
{
    internal class Program
    {
        static void Main(string[]args)
        {
            int n;
            Console.Write("Enter Limit: ");
            n = Convert.ToInt32(Console.ReadLine());

            int num;
            int cnt;
            int result = 0;
            for(num=1;num<=10;num++)
            {
                for(cnt=1;cnt<=n;cnt++)
                {
                    result = num * cnt;
                    Console.Write("{0}*{1}={2}", cnt, num, result);
                    Console.Write("\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}