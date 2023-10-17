using System;

namespace Even_num
{
    internal class Program
    {
        static void Main(string[]args)
        {
            int counter = 1;

            while(counter<=100)
            {
                if(counter % 2 == 0)
                {
                    Console.WriteLine("{0} is a Even Number",counter);
                }
                counter = counter + 1;
            }
            Console.ReadKey();
        }
    }
}


