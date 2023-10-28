using System;

namespace Copy_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[3];
            int[] arr2 = new int[3];
            for (int i=0;i<3;i++)
            {
                Console.Write("Enter Number" + i+": ");
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            for (int i = 0; i < 3; i++)
            {
                arr2[i] = arr1[i];
            }
            Console.WriteLine("The elements stored in the first array are :");
            for(int i=0;i<3;i++)
            {
                Console.Write(arr1[i] +" ");
            }
            Console.WriteLine();

            Console.WriteLine("The elements copied into the second array are :");
            for(int i=0; i<3;i++)
            {
                Console.Write(arr2[i]+" ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
