using System;

namespace Clear_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 6, 8 ,4,3};
            Array.Clear(arr, 2, 5);
            for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadKey();
        }
    }
}
