using System;

namespace Fabonacci_Series
{
    internal class Program
    {
        static void Main(string[]args)
        {
            int cnt=0;
            int num1 = 0;
            int num2 = 1;
            int add=0;

            while(cnt<=10)
            {
                Console.Write(add);
                num1 = num2;
                num2 = add;
                add = num1 + num2;
                cnt++;

            }
            
            Console.ReadKey();
        }

    }
}