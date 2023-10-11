using System;

namespace area_circle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int radius;
            float area, circ;
            Console.WriteLine("enter radius");
            radius = Convert.ToInt32(Console.ReadLine());
            area = 3.14f * radius * radius;
            circ = 2 * 3.14f * radius;
            Console.WriteLine("area of circle:" + area);
            Console.WriteLine("circumference of circle :" + circ);
            Console.ReadKey();
        }
    }
}
