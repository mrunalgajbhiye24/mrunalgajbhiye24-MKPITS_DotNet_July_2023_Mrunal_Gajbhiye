using System;

namespace Prime_Num
{
    internal class Program
    {
        static void Main(string[]args)
        {
            int num;
            int counter = 2;
            int flag=0;
            Console.Write("Enter Number: ");
            num = Convert.ToInt32(Console.ReadLine());
            while(counter<num)
            {
                if(num%counter==0)
                {
                    flag = 1;
                    break;
                }
                counter++;
            }
            if(flag==0)
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