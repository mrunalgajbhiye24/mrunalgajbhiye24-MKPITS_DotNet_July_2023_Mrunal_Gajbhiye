using System;

namespace Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i=1;
            int j = 1;
            int result ;
            int num;
            
            Console.Write("Enter Limit: ");
            num = Convert.ToInt32(Console.ReadLine());

            while (i <= 10)
            {
                j = 1;
            
                while (j <= num)
                {
                    result = i * j;
                    Console.Write("{0}*{1}={2}", j, i, result);
                    Console.Write("\t");
                    j++;
                }
                Console.WriteLine();
                i++;
            }
            Console.ReadKey();
        }
    }
}