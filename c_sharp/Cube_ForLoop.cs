using System;
using System.Diagnostics.Metrics;

namespace Cube_ForLoop
{
    internal class Program
    {
        static void Main(string[]args)
        {
            int num,cnt,result=0;
            Console.Write("Enter Number: ");
            num = Convert.ToInt32(Console.ReadLine());
            for (cnt=1;cnt<=num;cnt++)
            {
                result = cnt * cnt * cnt;
                Console.WriteLine("Number is : {0} and cube of the {1} is :{2}", cnt, cnt, result);
            }
            
            Console.ReadKey();
            
        }
    }
}