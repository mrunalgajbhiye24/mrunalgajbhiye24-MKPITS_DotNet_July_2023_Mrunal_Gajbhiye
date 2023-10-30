using System;
using System.Globalization;

namespace Returning_Array_Method
{
    internal class Program
    {
        static int[] returnarray()
        {
            int[] num = { 4, 5, 6 };
            return num;
        }
       
        static void Main(string[] args)
        {
            int[] res = returnarray();
            for(int i=0;i<res.Length;i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadKey();
        }
    }
}
