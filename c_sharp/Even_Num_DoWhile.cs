using System;

namespace Even_Num
{
    internal class Program
    {
        static void Main(string[]args)
        {
            int counter = 1;
            do
            {
                if (counter % 2 == 0)
                {
                    Console.WriteLine("{0} it is a Even NUmber", counter);
                }
                counter = counter + 1;
            } while (counter <= 100);
            Console.ReadKey();
        }
    }
}
