using System;
using System.Xml.Serialization;

namespace Square
{
    internal class Program
    {
        static void Main(string[]args)
        {
            int num,square;
            char choice = 'y';
            do
            {
                Console.Write("Enter Number: ");
                num = Convert.ToInt32(Console.ReadLine());
                square = num * num;
                Console.WriteLine("Square of Number is: " + square);
                Console.WriteLine("Do you want to Continue, Press y or n");
                choice = Convert.ToChar(Console.ReadLine());
            } while (choice == 'y' || choice == 'Y');
            Console.ReadKey();
        }
    }
}