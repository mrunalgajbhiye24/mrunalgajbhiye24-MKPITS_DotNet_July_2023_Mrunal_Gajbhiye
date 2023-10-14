using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace add_sub_mul_div
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float num1,num2,result;
            string op;
            Console.Write("Enter 1st No: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter 2nd No: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Operator: ");
            op = Console.ReadLine();

            if (op == "+")
                result = num1 + num2;
            else if (op == "-")
                result = num1 - num2;
            else if (op == "*")
                result = num1 * num2;
            else if (op == "/")
                result = num1 / num2;
            else
                result = 0;
            Console.WriteLine("Result: " + result);
            Console.ReadKey();


        }
    }
}
