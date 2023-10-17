using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_10_While
{
    internal class One_Ten
    {
        static void Main(string[] args)
        {
            int counter = 1;
            while (counter <= 10) 
            {
                Console.WriteLine(counter);
                counter++;
            }
            Console.ReadKey();
        }
    }
}
