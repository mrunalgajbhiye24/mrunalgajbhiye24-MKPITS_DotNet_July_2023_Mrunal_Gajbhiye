using System;

namespace divison_two_num
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            float result;
            Console.WriteLine("Enter number 1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 2");
            num2 = Convert.ToInt32(Console.ReadLine());
            result= num1 / num2;
            Console.WriteLine("Division :" + result);
            Console.ReadKey();
        }
    }
}
