using System;

namespace ForEach_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 4, 5 };
            int sum = 0;
            foreach(int val in arr)
            {
                Console.WriteLine(val);
                sum = sum + val;
            }
            Console.WriteLine("Sum of array Elements: " + sum);
            Console.ReadKey();
        }
    }
}
