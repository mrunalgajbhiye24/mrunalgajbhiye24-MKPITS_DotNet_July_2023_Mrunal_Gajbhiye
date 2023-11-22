using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Public_Access_Specifiers
{
    class Person
    {
        public string name = "Mrunal Gajbhiye";
        public void msg(string msg)
        {
            Console.WriteLine("Hello"+" " +msg);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            Console.WriteLine("Hello" + " " + p.name);
            p.msg("Purvi Bhoyar");
            Console.ReadKey();
        }
    }
}
