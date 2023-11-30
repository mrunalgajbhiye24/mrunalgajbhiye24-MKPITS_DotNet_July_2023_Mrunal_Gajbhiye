using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Builder_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Purvi"+" ");
            sb.Append("Bhoyar");
            Console.WriteLine(sb.ToString());
            Console.WriteLine("Bye");
            Console.ReadKey();
        }
    }
}
