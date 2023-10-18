using System;

namespace ONE_to_FIVE
{
    internal class Program
    {
        static void Main(string[]args)
        {
            int num = 1;
            do
            {
                Console.WriteLine("Num: {0}" , num);
                num++;
            } while (num <= 5);
            Console.ReadKey();
        }
    }
}
