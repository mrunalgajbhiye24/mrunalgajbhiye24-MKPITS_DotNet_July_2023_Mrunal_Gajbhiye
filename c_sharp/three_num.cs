using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace three_num
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, z,result, res;
            Console.WriteLine("Enter number 1");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 2");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 3");
            z = Convert.ToInt32(Console.ReadLine());
            result = (x + y) * z;
            res = (x * y) + (y * z);
            Console.WriteLine(" First total :"+result);
            Console.WriteLine("Second total :"+res);
            Console.ReadKey();


        }
    }
}
