using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Abstraction
{
    abstract class Shape
    {
        public abstract void draw();
    }
    class Circle:Shape
    {
        public override void draw()
        {
            Console.WriteLine("Circle is Drawn....");
        }
    }
    class Square : Shape
    {
        public override void draw()
        {
            Console.WriteLine("Square is Drawn....");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape s;
            s = new Circle();
            s.draw();
            s = new Square();
            s.draw();
            Console.ReadKey();
        }
    }
}
