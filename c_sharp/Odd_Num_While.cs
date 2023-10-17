using System;

namespace Odd_Num
{
    internal class Program
    {
        static void Main(string[]args)
        {
            int counter = 1;
            while(counter<=100)
            {
                if(counter%2!=0)
                {
                    Console.WriteLine("{0} is a Odd Number", counter);
                }
                counter = counter + 1;
            }
            Console.ReadKey();
        }
    }
}