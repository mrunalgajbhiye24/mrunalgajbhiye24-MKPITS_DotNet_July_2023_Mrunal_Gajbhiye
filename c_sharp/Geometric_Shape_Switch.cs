using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometric_Shape_Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int r, l, b,b1,h,choice;
            float area;
            Console.Write("Enter Choice(1.Circle, 2.Rectangle, 3.Triangle): ");
            choice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("                                     ");
            Console.WriteLine("!-----Geometric Shape-----");
            Console.WriteLine("                                     ");
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Circle");
                    Console.Write("Enter Radius: ");
                    r = Convert.ToInt32(Console.ReadLine());
                    area = 2 * 3.14f * r;
                    Console.WriteLine("Area of Circle: " + area);
                    break;

                case 2:
                    Console.WriteLine("Rectangle");
                    Console.Write("Enter Length: ");
                    l = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter breadth: ");
                    b = Convert.ToInt32(Console.ReadLine());
                    area = l * b;
                    Console.WriteLine("Area of Rectangle: " + area);
                    break;

                case 3:
                    Console.WriteLine("Triangle");
                    Console.Write("Enter Base: ");
                    b1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Height: ");
                    h = Convert.ToInt32(Console.ReadLine());
                    area = 1 / 2f * b1 * h;
                    Console.WriteLine("Area of Triangle: " + area);
                    break;

                default:
                    Console.WriteLine("Invalid Geometric Shape");
                    break;
            }
            Console.ReadKey();

        }
    }
}
