using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Person
    {
        public string name;
    }
    class Student : Person
    {
        public int rno;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.rno = 123;
            s.name = "Purvi";
            Console.WriteLine("Student Roll No: " + s.rno);
            Console.WriteLine("Student Name: " + s.name);
            Console.ReadKey();
        }
    }
}
