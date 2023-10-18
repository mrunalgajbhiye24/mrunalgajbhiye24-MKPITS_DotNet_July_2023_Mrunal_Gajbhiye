using System;

namespace Odd_Natural_Num
{
    internal class Program
    {
        static void Main(string[]args)
        {
            int n;
            Console.Write("Enter Number of terms: ");
            n = Convert.ToInt32(Console.ReadLine());
            int i=1;
            int j = 0;
            int sum = 0;
            while(j<n)
            {
                if(i%2!=0)
                {
                    Console.WriteLine("Odd No:"+ i);
                    sum += i;
                    j++;
                }
                i++;
               
            }
            Console.WriteLine("\nThe sum of the first odd natural numbers is: " + sum);
            Console.ReadKey();
        }
    }
}