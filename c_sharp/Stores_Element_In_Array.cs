using System;

namespace Stores_Element_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[10];
            for(int i=0;i<10;i++)
            {
                Console.Write("Enter Element"+ " "+ i + ":");
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 10; i++)
            {
                Console.Write( num[i]+" ");
            }
            Console.ReadKey();
        }
    }
}
