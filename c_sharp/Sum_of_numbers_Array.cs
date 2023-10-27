using System;

namespace Sum_of_Numbers_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[3];
            int sum = 0;
            for(int i=0;i<3;i++)
            {
                Console.Write("Enter Number: ");
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 3; i++)
            {
                sum = sum + num[i];
            }
            Console.WriteLine("Sum of array elements={0}", sum);
            Console.ReadKey();
        }
    }
}
