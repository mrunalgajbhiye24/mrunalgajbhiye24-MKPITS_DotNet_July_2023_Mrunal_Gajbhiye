using System;

namespace Float_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float[] radius = new float[3];
            float[] area = new float[3];
            double[] circ = new double[3];


            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter Radius {0}: ",i);
                radius[i] = Convert.ToSingle(Console.ReadLine());
                area[i] = 3.14f * radius[i] * radius[i];
                circ[i] = 2 * 3.14f * radius[i];
            }

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Area of Circle " + i + " = " + area[i]);
                Console.WriteLine("Circumference of Circle " + i + " = " + circ[i]+ "\n" );
            }
            Console.ReadKey();
        }
    }
}
