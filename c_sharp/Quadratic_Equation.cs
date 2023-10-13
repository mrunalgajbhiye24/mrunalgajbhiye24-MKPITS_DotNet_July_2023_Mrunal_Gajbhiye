using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadratic_Equation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            float  result ;
            Console.Write("Enter value of a:");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter value of b:");
            b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter value of c:");
            c = Convert.ToInt32(Console.ReadLine());

            result = b * b - 4 * a * c;

            if (result != 0)
                Console.WriteLine("The Roots are imaginary");
            else
                Console.WriteLine("The Roots are real");
            Console.ReadKey();


        }
    }
}
