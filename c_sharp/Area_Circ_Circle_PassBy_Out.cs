using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_Circ_Circle_PassBy_Out
{
    internal class Program
    {
        static void calculate(int radius, out float area, out float circ)
        {
            area = 3.14f * radius * radius;
            circ = 2 * 3.14f * radius;
        }
        static void Main(string[] args)
        {
            int radius = 5;
            float area = 0, circ = 0;
            calculate(radius, out area, out circ);
            Console.WriteLine("Area of Circle: " + area);
            Console.WriteLine("Area of Circumference: " + circ);
            Console.ReadKey();
        }
    }
}
