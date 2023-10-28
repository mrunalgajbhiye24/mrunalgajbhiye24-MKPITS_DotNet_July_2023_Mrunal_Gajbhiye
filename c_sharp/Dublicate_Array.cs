using System;

namespace Duplicate_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[3];
            int cnt = 0;
            for(int i=0;i<=2;i++)
            {
                Console.Write("Enter Number" + " " + i + " : ");
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i <= 2; i++)
            {
                for (int j = i + 1; j <= 2; j++)
                {
                    if (num[i] == num[j])
                    {
                        cnt++;
                        break;
                    }
                    
                }

            }
            Console.WriteLine("Total number of duplicate elements found in the array is : " + cnt);
            Console.ReadKey();
        }
    }
}
