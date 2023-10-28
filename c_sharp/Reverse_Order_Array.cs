using System;
using System.CodeDom.Compiler;

namespace Reverse_Order_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[3];
            int temp;
            for(int i=0;i<3;i++)
            {
                Console.Write("Enter Number" + " " + i + ":");
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The values store into the array are:");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(num[i] +" ");
            }
            Console.WriteLine();
            Console.WriteLine("The values store into the array in reverse are :");
            for (int i = 2; i >= 0 ; i--)
            {
                Console.Write(num[i] + " " );
            }
            Console.ReadLine();
               
        }
    }
}
