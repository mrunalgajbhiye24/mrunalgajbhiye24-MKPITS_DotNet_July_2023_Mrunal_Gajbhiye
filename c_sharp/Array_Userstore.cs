using System;

namespace Array_UserStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[3];
            for(int i=0;i<3;i++)
            {
                Console.Write("Enter Number: ");
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Num {0}={1}", i, num[i]);
            }
            Console.ReadKey();
        }
    }
}
