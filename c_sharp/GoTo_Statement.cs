using System;

namespace Goto_Statement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Enter Number: ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0) goto Even;
            Console.WriteLine("Odd No");
            goto End;

        Even:
            Console.WriteLine("Even No");
        End:
            Console.WriteLine("Bye");
            Console.ReadKey();
        }
    }
}
