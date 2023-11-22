using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sealed_Method
{
    class Person
    {
        public virtual void display()
        {
            Console.WriteLine("Hello From Person");
        }
    }
    class Student:Person
    {
        public string name;

        public sealed override void display()
        {
            Console.WriteLine("Hello");
        }
    }
    class Parttimestudent:Person
    {
        //error
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Parttimestudent p = new Parttimestudent();
            p.display();
            Console.ReadKey();
        }
    }
}
