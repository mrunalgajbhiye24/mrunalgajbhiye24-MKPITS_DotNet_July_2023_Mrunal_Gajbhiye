using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digit_IN_Words_Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int digit;
            Console.Write("Enter Digit: ");
            digit = Convert.ToInt32(Console.ReadLine());

            switch(digit)
            {
                case 1:
                    Console.WriteLine("ONE");
                    break;
                case 2:
                    Console.WriteLine("TWO");
                    break;
                case 3:
                    Console.WriteLine("THREE");
                    break;
                case 4:
                    Console.WriteLine("FOUR");
                    break;
                case 5:
                    Console.WriteLine("FIVE");
                    break;
                case 6:
                    Console.WriteLine("SIX");
                    break;
                case 7:
                    Console.WriteLine("SEVEN");
                    break;
                case 8:
                    Console.WriteLine("EIGHT");
                    break;
                case 9:
                    Console.WriteLine("NINE");
                    break;
                case 10:
                    Console.WriteLine("TEN");
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;
            }
            Console.ReadLine();
        }
    }
}
