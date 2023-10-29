using System;

namespace _3_3_Matrix_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            int[,] arr = new int[3, 3];
            for(i=0;i<3;i++)
            {
               for(j=0;j<3;j++)
               {
                    Console.Write("Enter Element [{0},{1}] :",i, j);
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
               }
            }
            
            Console.WriteLine("The Matrix is: ");
            for (i = 0; i < 3; i++)
            {
                Console.WriteLine();
                for (j = 0; j < 3; j++)
                {
                    Console.Write(arr[i, j]+" ");
                }
            }
            Console.ReadKey();
        }
    }
}
