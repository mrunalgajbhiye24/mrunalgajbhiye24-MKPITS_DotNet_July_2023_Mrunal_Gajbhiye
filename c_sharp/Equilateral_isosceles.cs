using System;

namespace Equilateral_iso_scalen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Enter the length of three sides of triangle ");
            Console.Write("Enter side1: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter side2: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter side3: ");
            c = Convert.ToInt32(Console.ReadLine());

            if (a == b && b == c)
                Console.WriteLine("Equilateral Triangle");
            else if (a == b || b == c || a == c)
                Console.WriteLine("Isosceles Triangle");
            else
                Console.WriteLine("Scalene");
            Console.ReadKey();

        }
    }
}
