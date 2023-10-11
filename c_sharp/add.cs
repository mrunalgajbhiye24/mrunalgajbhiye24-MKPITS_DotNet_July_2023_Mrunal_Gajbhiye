using System;

namespace add
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2 ,add;
            Console.WriteLine("enter number 1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number 2");
            num2 = Convert.ToInt32(Console.ReadLine());
            add = num1 + num2;
            Console.WriteLine("addition :" + add);
            Console.ReadKey();
        }
    }
}
