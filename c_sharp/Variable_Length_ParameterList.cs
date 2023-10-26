using System;

namespace Variable_Length_ParameterList
{
    internal class Program
    {
        static int calculate(params int[]num)
        {
            int i, total = 0;
            for(i=0;i<num.Length;i++)
            {
                total = total + num[i];
            }
            return total;
        }
        static void Main(string[] args)
        {
            int result = calculate(1, 2, 3);
            Console.WriteLine("Total: " + result);
            Console.ReadKey();
        }
    }
}
