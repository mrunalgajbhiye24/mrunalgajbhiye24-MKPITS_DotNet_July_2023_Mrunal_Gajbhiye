using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int outercounter = 1; outercounter <= 3; outercounter++)
            {
                for (int innercounter = 1; innercounter <= outercounter; innercounter++)
                {
                    Console.Write(innercounter+  "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}

