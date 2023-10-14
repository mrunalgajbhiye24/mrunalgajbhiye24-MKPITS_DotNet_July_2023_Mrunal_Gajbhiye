using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digit_Word
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int digit;
            string words;
            Console.Write("Enter Number: ");
            digit = Convert.ToInt32(Console.ReadLine());

            if (digit == 1)
                words = "One";
            else if (digit == 2)
                words = "Two";
            else if (digit == 3)
                words = "Three";
            else if (digit == 4)
                words = "Four";
            else if (digit == 5)
                words = "Five";
            else if (digit == 6)
                words = "Six";
            else if (digit == 7)
                words = "Seven";
            else if (digit == 8)
                words = "Eight";
            else if (digit == 9)
                words = "Nine";
            else if (digit == 10)
                words = "Ten";
            else
                words = "invalid";
            Console.WriteLine("In Word: " + words);
            Console.ReadKey();
        }
    }
}
