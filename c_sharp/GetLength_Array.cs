using System;

namespace Get_Length_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 6, 7 };
            int l = arr.GetLength(0);
            {
                Console.WriteLine("Length: " + l);
                Console.ReadKey();
            }
        }
    }
}
