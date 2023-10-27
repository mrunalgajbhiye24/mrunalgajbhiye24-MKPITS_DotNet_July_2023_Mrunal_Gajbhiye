using System;

namespace Addition_2_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr1 = { { 5, 9 }, { 3, 4 } };
            int[,] arr2 = { { 5, 3}, { 6, 7} };
            int[,] arr3 = new int[2, 2];
            for(int r=0;r<2;r++)
            {
                for(int c=0;c<2;c++)
                {
                    arr3[r, c] = arr1[r, c] + arr2[r, c];
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
