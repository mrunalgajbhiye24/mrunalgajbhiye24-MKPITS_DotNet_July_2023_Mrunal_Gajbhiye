using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace Protected_Internal_Access_Specifiers
{
    class Person
    {
        protected internal string name="Santosh Kumar";

        protected internal void msg(string msg)
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
