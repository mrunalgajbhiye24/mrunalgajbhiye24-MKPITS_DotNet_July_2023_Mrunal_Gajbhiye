using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace area_rectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length , breadth , area;
            Console.WriteLine("Enter length");
            length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter breadth");
            breadth = Convert.ToInt32(Console.ReadLine());
            area = length * breadth;
            Console.WriteLine("area of rect :" + area);
            Console.ReadKey();
        }
    }
}
