using System;

namespace Triangle_Equal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a1, a2, a3;
            Console.WriteLine("Enter the length of three sides of triangle ");
            Console.Write("Enter angle1: ");
            a1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter angle2: ");
            a2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter angle3: ");
            a3 = Convert.ToInt32(Console.ReadLine());

            if (a1 + a2 + a3 == 180)
                Console.WriteLine("Triangle is valid");
            else
                Console.WriteLine("Triangle is not valid");
            Console.ReadKey();
        }
    }
}
