using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internal_Access_Specifiers
{
    class Person
    {
        internal string name = "Amar";
        internal void msg(string msg)
        {
            Console.WriteLine("Hello" + " " + msg);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            Console.WriteLine("Hello" + " " + p.name);
            p.msg("Peter Decosta");
            Console.ReadKey();
        }
    }
}
