using System;

namespace Table
{
    internal class Program
    {
        static void Main(string[]args)
        {
            int num;
            int counter;
            int result = 0;
            Console.Write("Enter Number: ");
            num = Convert.ToInt32(Console.ReadLine());

            for(counter=1;counter<=10;counter++)
            {
                result = num * counter;
                Console.WriteLine("{0}*{1}={2}",num,counter, result);
            }
            Console.ReadKey();
        }
    }
}