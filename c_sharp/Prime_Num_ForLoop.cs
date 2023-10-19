using System;

namespace Prime_Num
{
    internal class Program
    {
        static void Main(string[]args)
        {
            int num;
            int counter ;
            int flag = 0;
            Console.Write("Enter Number: ");
            num = Convert.ToInt32(Console.ReadLine());

            for (counter = 2; counter < num; counter++)
            {
                if (num%counter== 0)
                {
                    flag = 1;
                    break;
                }
                
            }
            if (flag == 0)
            {
                Console.WriteLine("It is a Prime Number");
            }
            else
            {
                Console.WriteLine("It is Not A Prime number");
            }
            Console.ReadKey();

        }
    }
}