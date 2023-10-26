using System;

namespace Area_Circ_Circle_PassBy_Reference
{
    internal class Program
    {
        static void calculate(int radius,ref float area,ref float circ)
        {
            area = 3.14f * radius * radius;
            circ = 2 * 3.14f * radius;
        }
        static void Main(string[] args)
        {
            int radius = 5;
            float area = 0, circ = 0;
            calculate(radius, ref area, ref circ);
            Console.WriteLine("Area of Circle: " + area);
            Console.WriteLine("Area of Circumference: " + circ);
            Console.ReadKey();
        }
    }
}
