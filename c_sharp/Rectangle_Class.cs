using System;

namespace Rectangle_Class
{
    class Rectangle
    {
        int area;
        int width;
        int height;

        public void getdata(int width,int height)
        {
            this.width = width;
            this.height = height;
        }
        public void Calculate()
        {
            area = width * height;
            Console.Write("Area of Rectangle: " + area);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rec = new Rectangle();
            rec.getdata(5, 10);
            rec.Calculate();
            Console.ReadKey();

        }
    }
}
