using System;


namespace Even_Odd_Numbers_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[5];
            int[] arr2 = new int[5];
            int[] arr3 = new int[5];
            for(int i=0;i<5;i++)
            {
                Console.Write("Enter Element" + " " + i + ":");
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            int j = 0;
            int k = 0;

            for (int i = 0; i < 5; i++)
            {
                if (arr1[i]%2==0)
                {
                    arr2[j] = arr1[i];
                    j++;
                }
                else
                {
                    arr3[k] = arr1[i];
                    k++;
                }
            }
            for(int i=0;i<j;i++)
            {
                Console.WriteLine("Even Number: " + arr2[i]);
            }
            for (int i = 0; i < k; i++)
            {
                Console.WriteLine("Odd Number: " + arr3[i]);
            }
            Console.ReadKey();
        }
    }
}
