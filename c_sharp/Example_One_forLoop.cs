using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0, j = 0; i <= 10; i++, j++)
            {
                Console.WriteLine("i= " + i);
                Console.WriteLine("j= " + j);
            }
            Console.ReadKey();
        }
    }
}
