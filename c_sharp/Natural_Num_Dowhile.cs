using System;

namespace Natural_Num
{
    internal class Program
    {
        static void Main(string[]args)
        {
            int num=1;
            Console.WriteLine("First 10 Natural Numbers are: ");
            do
            {
                Console.WriteLine(num);
                num++;
            } while (num <= 10);
            Console.ReadKey();
        }
    }
}