using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_ExSix_Person
{
    abstract class Person
    {
        public abstract void display();

        public void showdata()
        {
            Console.WriteLine("Hello From Show Data");
        }
    }
    class Student:Person
    {
        public override void display()
        {
            Console.WriteLine("Hello From Display Data");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.display();
            s.showdata();
            Console.ReadKey();
        }
    }
}
