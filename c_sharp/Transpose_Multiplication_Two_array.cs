using System;

namespace Transpose_Multiplication_Two_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr1 = { { 3, 4 }, { 5, 6 } };
            int[,] arr2 = { { 2, 5 }, { 7, 9 } };
            int[,] arr3 = new int[2, 2];
            for (int r = 0; r < 2; r++)
            {
                for (int c = 0; c < 2; c++)
                {
                    arr3[r, c] = arr1[c, r] * arr2[r, c];
                }
            }
            for (int r = 0; r < 2; r++)
            {
                for (int c = 0; c < 2; c++)
                {
                    Console.Write(arr3[r, c] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
