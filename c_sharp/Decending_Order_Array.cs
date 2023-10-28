using System;
using System.Globalization;
using System.Xml.Linq;

namespace Decending_Order_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            for(int i=0;i<5;i++)
            {
                Console.Write("Enter Element" + " " + i + ":");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();

            int temp = 0;
            Console.WriteLine("Elements of the array in sorted descending order:");
            for (int i = 0; i < 5; i++)
            {
                for(int j=i+1;j<5;j++)
                {
                    if (arr[i] < arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
                Console.WriteLine(arr[i] + " ");
            }
            Console.ReadLine();
        }
    }
}
