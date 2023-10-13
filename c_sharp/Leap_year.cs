using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leap_year
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int year;
            Console.WriteLine("Enter year");
            year = Convert.ToInt32(Console.ReadLine());

            if (year % 4 == 0)
                Console.WriteLine("It is a leap year");
            else
                Console.WriteLine("It is not a leap year");
            Console.ReadKey();

        }
    }
}
