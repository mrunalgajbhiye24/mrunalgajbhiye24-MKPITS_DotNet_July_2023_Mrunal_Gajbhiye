using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_TwoNumbers_Method
{
    internal class Program
    {
        static int calculate(int num1,int num2)
        {
            int res = 0;
            res = num1 + num2;
            return res;
        }
       
        static void Main(string[] args)
        {
            int number1, number2;
            Console.Write("Enter 1st No: ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 2nd No: ");
            number2 = Convert.ToInt32(Console.ReadLine());
            int result = calculate(number1, number2);
            Console.WriteLine("Addition of " + number1 + " + " + number2 + " " + "is: " + result);
            Console.ReadKey();
        }
    }
}
