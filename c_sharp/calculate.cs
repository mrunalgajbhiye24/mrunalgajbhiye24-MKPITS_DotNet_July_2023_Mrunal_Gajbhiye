using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float num1, num2, add , sub , mul,div, mod;
            Console.WriteLine("Enter First number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second number:");
            num2 = Convert.ToInt32(Console.ReadLine());
            add = num1 + num2;
            sub = num1 - num2;
            mul = num1 * num2;
            div = num1 / num2;
            mod = num1 % num2;
            Console.WriteLine("Addition :" + add);
            Console.WriteLine("Subtraction :" + sub);
            Console.WriteLine("Multiply :" + mul);
            Console.WriteLine("Division :" + div);
            Console.WriteLine("Modulus :" + mod);
            Console.ReadKey();



        }
    }
}
