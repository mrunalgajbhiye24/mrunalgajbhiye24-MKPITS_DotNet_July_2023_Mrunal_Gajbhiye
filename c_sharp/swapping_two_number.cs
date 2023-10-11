using System;

namespace swapping_two_num
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5, num2 = 6 ;
            int temp;
            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine("num1=" + num2);
            Console.WriteLine("num2=" + num1);
            Console.ReadKey();


        }
    }
}
