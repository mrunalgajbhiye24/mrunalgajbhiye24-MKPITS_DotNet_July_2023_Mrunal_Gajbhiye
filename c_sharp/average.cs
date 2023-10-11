using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace average
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float num1, num2, num3, num4 ,result;
            Console.WriteLine("Enter number 1:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 2:");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 3:");
            num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 4:");
            num4 = Convert.ToInt32(Console.ReadLine());
            result = (num1 + num2 + num3 + num4) / 4;
            Console.WriteLine("Average :" + result);
            Console.ReadKey();


        }
    }
}
