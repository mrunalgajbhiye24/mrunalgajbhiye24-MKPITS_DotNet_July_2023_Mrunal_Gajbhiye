using System;

namespace Local_Shared_Varible
{
    internal class Program
    {
        static int num = 20;

        static void display()
        {
            int num = 10; //local variable
            Console.WriteLine("Num inside method " + num);
        }
        static void Main(string[] args)
        {
            display();
            Console.WriteLine("Num (shared) " + num);
            Console.ReadKey();
        }
    }
}
