using System;

namespace Sum_Natural_Num
{
    internal class Program
    {
        static void Main(string[]args)
        {
            int num=1;
            int sum = 0;
            do
            {
                Console.WriteLine(num);
                sum += num;
                num++;
            } while (num <= 10);
            Console.WriteLine("Sum Of First Natural Number is: " + sum);
            Console.ReadKey();

        }
    }
}