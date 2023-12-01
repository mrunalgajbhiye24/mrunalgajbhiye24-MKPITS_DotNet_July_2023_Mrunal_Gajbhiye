using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Class
{
    public class Calculator
    {
        public double result { get; set; }

        public void Add(double num)
        {
            result += num;
        }
        public void sub(double num)
        {
            result -= num;
        }
        public void mul(double num)
        {
            result *= num;
        }
        public void div(double num)
        {
            if(num!=0)
            {
                result /= num;
            }
            else
            {
                Console.WriteLine("Error: Cannot divide by zero");
            }
        }
        public void clear()
        {
            result = 0;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            c.Add(5);
            Console.WriteLine("Result: " + c.result);

            c.sub(2);
            Console.WriteLine("Result: " + c.result);

            c.mul(3);
            Console.WriteLine("Result: " + c.result);

            c.div(2);
            Console.WriteLine("Result: " + c.result);

            c.clear();
            Console.WriteLine("Result after clearing: " + c.result);
            Console.ReadKey();
        }
    }
}
