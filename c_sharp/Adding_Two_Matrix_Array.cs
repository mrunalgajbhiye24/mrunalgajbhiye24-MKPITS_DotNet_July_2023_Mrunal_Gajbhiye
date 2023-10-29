using System;

namespace Adding_Two_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr1 = new int[2, 2];
            int[,] arr2 = new int[2, 2];
            int[,] arr3 = new int[2, 2];
            Console.WriteLine("Input elements in the first matrix :");
            for(int i=0;i<2;i++)
            {
                for(int j=0;j<2;j++)
                {
                    Console.Write("Enter Element {0},{1}: ", i, j);
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine();
            Console.WriteLine("Input elements in the first matrix :");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write("Enter Element {0},{1}: ", i, j);
                    arr2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Matrix 1: ");
            for(int i=0; i<2;i++)
            {
                Console.WriteLine();
                for (int j=0;j<2;j++)
                {
                    Console.Write("{0} \t",arr1[i, j]);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Matrix 2: ");
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 2; j++)
                {
                    Console.Write("{0} \t", arr2[i, j]);
                }
            }
            Console.WriteLine();
            Console.WriteLine("The Addition of two matrix: ");
            for(int i=0;i<2;i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    arr3[i, j] = arr1[i, j] + arr2[i, j];
                }
            }
            for(int i=0;i<2;i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(arr3[i, j]+"\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
