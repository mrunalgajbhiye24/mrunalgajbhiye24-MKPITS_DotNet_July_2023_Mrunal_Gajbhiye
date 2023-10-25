using System;
using System.Runtime.Remoting.Messaging;

namespace Method_TwoNumber_and_Operator
{
    internal class Program
    {
        static int calculate(int num1,int num2,char op)
        {
            int res = 0;
            if (op == '+')
                res = num1 + num2;
            else if (op == '-')
                res = num1 - num2;
            else if (op == '*')
                res = num1 * num2;
            else
                Console.WriteLine("Invalid Operator");
            return res;
        }
        
        static void Main(string[] args)
        {
            int number1, number2;
            char op;
            Console.Write("Enter 1st No: ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 2nd No: ");
            number2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Operator(+,-,*): ");
            op = Convert.ToChar(Console.ReadLine());
            int res = calculate(number1, number2, op);
            Console.WriteLine("Result: " + res);
            Console.ReadKey();
        }
    }
}
