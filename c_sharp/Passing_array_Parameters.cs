using System;

namespace Passing_Array_Parameters
{
    internal class Program
    {
        static void acceptarray(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
                sum = sum + arr[i];
            }
            Console.WriteLine("Sum of Array elements are: " + sum);
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] num = { 5, 8, 3 };
            acceptarray(num);

            int[] num1 = { 55, 88, 33 };
            acceptarray(num1);

            Console.ReadKey();
        }
    }
}
