using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pre_increment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int j = ++i;
            Console.WriteLine("value of i: " + i );
            Console.WriteLine("value of j: " + j);
            Console.ReadKey();
        }
    }
}
