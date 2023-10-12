using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byte_sbyte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //unsigned byte for positive no
            byte b = 25;
            Console.WriteLine("byte value" + b);
            Console.WriteLine("Enter byte");
            b = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("byte =" + b);

            //for negative as well as for positive no
            sbyte b1 = 23;
            Console.WriteLine("Sbyte value" + b1);
            Console.WriteLine("Enter sbyte");
            b1 = Convert.ToSByte(Console.ReadLine());
            Console.WriteLine("byte =" + b1);
            Console.ReadKey();

        }
    }
}
