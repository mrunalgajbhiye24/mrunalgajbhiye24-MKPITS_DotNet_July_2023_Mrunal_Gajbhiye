using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vowel_Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char op;
            Console.Write("Enter Character:  ");
            op = Convert.ToChar(Console.ReadLine());

            switch(op)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("It is a Vowel");
                    break;
                default:
                    Console.WriteLine("It is a Consonant");
                    break;
            }
            Console.ReadKey();

        }
    }
}
