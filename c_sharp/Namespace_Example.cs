using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    public class Hello
    {
        public void sayhello()
        {
            Console.WriteLine("Hello From First Namespace");
        }
    }
}
namespace Second
{
    public class Hello
    {
        public void sayhello()
        {
            Console.WriteLine("Hello from Second Namespace");
        }
    }
}
namespace Namespace_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            First.Hello h = new First.Hello();
            Second.Hello h1 = new Second.Hello();
            h.sayhello();
            h1.sayhello();
            Console.ReadKey();
        }
    }
}
