using System;

namespace Natural_Num
{
    internal class Program
    {
        static void Main(string[]args)
        {
            int counter = 1;
            while(counter<=10)
            {
                Console.WriteLine("{0} is a Natural Number ", counter);
                counter++;
            }
            Console.ReadKey();
        }
    }
}