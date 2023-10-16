using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sphere
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int radius;
            float surface, volume;
            Console.Write("Enter radius of sphere: ");
            radius = Convert.ToInt32(Console.ReadLine());

            surface = 4 * 3.14f * radius * radius;
            volume = (4 / 3) * 3.14f * radius * radius * radius;

            Console.WriteLine("\n -- Surafece area And Volume of sphere -- \n");
            Console.WriteLine("Surafece area of sphere: " + surface);
            Console.WriteLine("Volume of sphere: " + volume);
            Console.ReadKey();

        }
    }
}
