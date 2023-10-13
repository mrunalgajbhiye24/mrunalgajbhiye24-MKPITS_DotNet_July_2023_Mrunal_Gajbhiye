using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X_Y_Coordinates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("Enter value of X: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter value of Y: ");
            y = Convert.ToInt32(Console.ReadLine());

            if (x > 0 && y > 0)
                Console.WriteLine("The coordinate point" +" " + (x,y) + " " + "lies in the First quadrant");
            else if (x > 0 && y < 0)
                Console.WriteLine("The coordinate point" + " " + (x,y) + " " + "lies in the Second quadrant");
            else if (x < 0 && y < 0)
                Console.WriteLine("The coordinate point" + " " + (x,y) + " " + "lies in the Third quadrant");
            else if (x < 0 && y > 0)
                Console.WriteLine("The coordinate point" + " " + (x,y) + " " + "lies in the Fourth quadrant");
            else
                Console.WriteLine("invalid");
            Console.ReadKey();

        }
    }
}
