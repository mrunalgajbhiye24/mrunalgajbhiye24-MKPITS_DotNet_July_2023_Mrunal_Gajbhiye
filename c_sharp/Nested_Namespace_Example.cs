using System;
using First;
using First.Second;

namespace First
{
    public class Hello
    {
        public void sayhello()
        {
            Console.WriteLine("Hello Namespace");
        }
    }

    //creating a nested namespace
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
}

namespace Nested_Namespace_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hello h = new Hello();
            h.sayhello();
            Welcome w = new Welcome();
            w.saywelcome();
            Console.ReadKey();
        }
    }
}
