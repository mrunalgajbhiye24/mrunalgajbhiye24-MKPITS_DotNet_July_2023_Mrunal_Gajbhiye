using System;

namespace Pass_By_Reference
{
    internal class Program
    {
            static void display(ref int num)
            {
                num = 20;
                Console.WriteLine("Num inside Method " + num);
            }
            static void Main(string[] args)
            {
                int num = 10;
                display(ref num);
                Console.WriteLine("Num after passing inside main " + num);
                Console.ReadKey();
            }
    }
}
