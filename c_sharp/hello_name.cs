using System;

namespace hello_name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("Hello");
            Console.Write("enter name");
            name = Console.ReadLine();
            Console.WriteLine("Hello:" + name);
            Console.ReadKey();
        }
    }
}
