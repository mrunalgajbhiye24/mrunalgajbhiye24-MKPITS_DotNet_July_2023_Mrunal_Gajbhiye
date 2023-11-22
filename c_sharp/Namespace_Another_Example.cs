using System;
using First;
using Second;

namespace First
{
    public class Hello
    {
        public void sayhello()
        {
            Console.WriteLine("Hello Namespace");
        }
    }
}
namespace Second
{
    public class Welcome
    {
        public void saywelcome()
        {
            Console.WriteLine("Welcome Namespace");
        }
    }
}
namespace Namespace_Another_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hello h = new Hello();
            Welcome w = new Welcome();
            h.sayhello();
            w.saywelcome();
            Console.ReadLine();
        }
    }
}
