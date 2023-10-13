using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Height
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int height;
            Console.Write("Enter Your Height: ");
            height = Convert.ToInt32(Console.ReadLine());
            if (height <= 140)
                Console.WriteLine("The Person is Drawf");
            else
                Console.WriteLine("The Person is Taller");
            Console.ReadKey();

        }
    }
}
