using System;


namespace Clone_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 99, 55 };
            int[] arr1 = new int[3];
            Array.Copy(arr, arr1, 3);
            for(int i=0;i<arr1.Length;i++)
            {
                Console.WriteLine(arr1[i]);
            }
            Console.ReadKey();
        }
    }
}
