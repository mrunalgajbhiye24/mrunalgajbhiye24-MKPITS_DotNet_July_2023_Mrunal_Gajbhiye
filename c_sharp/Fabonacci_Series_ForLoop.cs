using System;

namespace Cube
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 1;
            int cnt;
            int add=0;

            for(cnt=0;cnt<=10;cnt++)
            {
                Console.Write(add);
                num1 = num2;
                num2 = add;
                add = num1 + num2;
            }
            Console.ReadKey();
        }
    }
}