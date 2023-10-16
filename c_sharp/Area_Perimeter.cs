using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_Perimeter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int r;
            float area, peri;
            Console.Write("Enter Radius: ");
            r = Convert.ToInt32(Console.ReadLine());
            area = 3.14f * r * r;
            Console.WriteLine("Area of Circle: " + area);
            peri = 2 * 3.14f * r;
            Console.WriteLine("Perimetere of circle: " + peri);
            Console.ReadKey();
        }
    }
}
