using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boolean
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boolean b = true;
            Console.WriteLine("value" + b);
            Console.WriteLine("enter true or false");
            b = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("boolean =" + b);
            Console.ReadKey();
        }
    }
}
