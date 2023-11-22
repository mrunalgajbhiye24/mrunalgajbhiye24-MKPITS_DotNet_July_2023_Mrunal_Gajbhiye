using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmnet_Interface_Shape
{
    interface IDrawable
    {
        void draw();
    }
    class Circle:IDrawable
    {
        public void draw()
        {
            Console.WriteLine("Circle is Drawn...");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            IDrawable d;
            d = new Circle();
            d.draw();
            Console.ReadKey();
        }
    }
}
