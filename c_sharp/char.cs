using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @char
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch; 
            Console.WriteLine("enter character");
            ch = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("char :" + ch);
            Console.ReadKey();

        }
    }
}
