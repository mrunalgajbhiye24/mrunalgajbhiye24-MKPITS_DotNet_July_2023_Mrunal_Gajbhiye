using System;

namespace Index_Of_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 9, 12 };
            int l = Array.IndexOf(arr, 9);
            Console.WriteLine("Index of 9 is: "+ l);
            Console.ReadKey();
        }
    }
}
