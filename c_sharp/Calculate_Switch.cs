using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float num1, num2, result;
            char op;
            Console.Write("Enter 1st No: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 2nd No: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Operator: ");
            op = Convert.ToChar(Console.ReadLine());

            switch(op)
            {
                case '+':
                    result = num1 + num2;
                    Console.WriteLine("The Addition of" +" "+ num1 + " " + "and" + " " + num2 + " " + "is: " + result);
                    break;

                case '-':
                    result = num1 - num2;
                    Console.WriteLine("The Subtraction of" + " " + num1 + " " + "and" + " " + num2 + " " + "is: " + result);
                    break;

                case '*':
                    result = num1 * num2;
                    Console.WriteLine("The Multiplication of" + " " + num1 + " " + "and" + " " + num2 + " " + "is: " + result);
                    break;

                case '/':
                    result = num1 / num2;
                    Console.WriteLine("The Division of" + " " + num1 + " " + "and" + " " + num2 + " " + "is: " + result);
                    break;

                default:
                    Console.WriteLine("Invalid");
                    break;
            }
            Console.ReadKey();

        }
    }
}
