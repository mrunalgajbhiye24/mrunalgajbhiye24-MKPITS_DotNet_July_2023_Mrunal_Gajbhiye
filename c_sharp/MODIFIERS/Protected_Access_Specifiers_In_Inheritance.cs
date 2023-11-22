using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protected_Access_Specifiers_in_Inheritance
{
    class ProtectedTest
    {
        protected string name="Purvi";
        protected void msg(string msg)
        {
            Console.WriteLine("Hello" + " " + msg);
        }
    }
    class Program:ProtectedTest
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("Hello" + " " + p.name);
            p.msg("Ruhi Manekar");
            Console.ReadKey();
        }
    }
}
