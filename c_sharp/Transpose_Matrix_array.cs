using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transpose_Matrix_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            int[,] arr = new int[2, 2];
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    Console.Write("Enter Element [{0},{1}] :", i, j);
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("The Matrix is: ");
            for (i = 0; i < 2; i++)
            {
                Console.WriteLine();
                for (j = 0; j < 2; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("The Transpose of a matrix is :");
            for (i = 0; i < 2; i++)
            {
                Console.WriteLine();
                for (j = 0; j < 2; j++)
                {
                    Console.Write(arr[j,i] + " ");
                }
            }
            Console.ReadKey();
        }
    }
}
