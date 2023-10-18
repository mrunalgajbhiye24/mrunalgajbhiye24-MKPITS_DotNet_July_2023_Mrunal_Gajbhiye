using System;

namespace Prime_Num
{
    internal class Program
    {
        static void Main(string[]args)
        {
            int num;
            int counter = 2;
            int flag = 0;
            Console.Write("Enter Number: ");
            num = Convert.ToInt32(Console.ReadLine());
            do
            {
                if (num % counter == 0)
                {
                    flag = 1;
                    break;
                }
                counter++;
            } while (counter < num);
            if (flag == 0)
            {
                Console.WriteLine("It is a Prime number");
            }
            else
            {
                Console.WriteLine("It is Not a Prime Number");
            }
            Console.ReadKey();
        }
    }
}
