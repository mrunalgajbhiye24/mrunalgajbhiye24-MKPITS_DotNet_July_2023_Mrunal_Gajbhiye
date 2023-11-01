using System;
using System.Runtime.InteropServices;
using System.Security.Policy;

namespace Circle_Console_Class
{
    class Circle
    {
        int radius;
        float area;
        float circumference;
        public void getdata(int radius)
        {
            this.radius = radius;
        }
        public void displaydata()
        {
            area = 3.14f * radius * radius;
            circumference= 2 * 3.14f * radius;
            Console.Write("Area of Circle: " + area+"\n");
            Console.Write("Circumference of Circle: " + circumference);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle cir = new Circle();
            cir.getdata(7);
            cir.displaydata();
            Console.ReadKey();
        }
    }
}
