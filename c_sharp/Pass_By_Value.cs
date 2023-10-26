using System;

namespace Pass_By_Value
{
    internal class Program
    {
        static void display(int num)
        {
            num = 20;
            Console.WriteLine("Num inside Method " + num);
        }
        static void Main(string[] args)
        {
            int num = 10;
            display(num);
            Console.WriteLine("Num after passing inside main " + num);
            Console.ReadKey();
        }
    }
}
