using System;

namespace Odd_Num
{
    internal class Program
    {
        static void Main(string[]args)
        {
            int num;
            Console.Write("Enter Number of terms: ");
            num = Convert.ToInt32(Console.ReadLine());

            int cnt ;
            int sum = 0;
            for(cnt=1;cnt<=num;cnt++)
            {
                
                    Console.WriteLine("Odd No:{0} " ,2 * cnt - 1);
                    sum += 2 * cnt -1;
                 
            }
            Console.WriteLine("\nThe sum of the first odd natural numbers is: " + sum);
            Console.ReadKey();
        }
    }
}
