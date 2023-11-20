using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Method_Example_One
{
    abstract class Shape
    {
        abstract public void draw();
    }
    class Rectangle:Shape
    {
        public override void draw()
        {
            Console.WriteLine("Rectangle shape is Drawn....");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape s = new Rectangle();
            s.draw();
            Console.ReadKey();
        }
    }
}
