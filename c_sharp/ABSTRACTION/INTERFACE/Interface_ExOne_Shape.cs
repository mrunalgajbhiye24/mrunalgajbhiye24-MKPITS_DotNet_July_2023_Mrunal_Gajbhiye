using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFace_ExOne_Shape
{
    interface  Shape
    {
        void draw();
    }
    class Rectangle:Shape
    {
        public void draw()
        {
            Console.WriteLine("Drawing Rectangle....");
        }
    }
    class Circle:Shape
    {
        public void draw()
        {
            Console.WriteLine("Drawing Circle....");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape s;
            s = new Rectangle();
            s.draw();
            s = new Circle();
            s.draw();
            Console.ReadKey();

        }
    }
}
