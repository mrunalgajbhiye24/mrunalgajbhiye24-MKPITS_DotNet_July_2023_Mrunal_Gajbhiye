using System;


namespace Ascending_Order_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[5];
            for (int i=0;i<5;i++)
            {
                Console.Write("Enter Element" + " " + i + ":");
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            int temp = 0;
            Console.WriteLine("Elements of array in sorted ascending order: ");
            for (int i = 0; i < 5; i++)
            {
                for(int j=i+1;j<5;j++)
                {
                    if (arr1[i] > arr1[j])
                    {
                        temp = arr1[i];
                        arr1[i] = arr1[j];
                        arr1[j] = temp;
                    }
                }
                Console.WriteLine( arr1[i]);

            }
            
            Console.ReadKey();
        }
    }
}
