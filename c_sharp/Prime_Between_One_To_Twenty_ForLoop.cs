using System;

namespace Cube
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prime No Between 1 and 20 are");
            Console.WriteLine("Prime Number: 2");
            int num ;
            int counter = 2;
            int flag = 0;


            for (num = 3; num <= 20; num++)
            {
                flag = 0;
                counter = 2;
                while (counter < num)
                {
                    
                    if (num % counter == 0)
                    {
                        flag = 1;
                        break;
                    }
                    counter++;
                }
                if (flag == 0)
                {
                    Console.WriteLine("Prime Number: {0} ", num);
                }
            }
            
            Console.ReadKey();

        }
    }
}