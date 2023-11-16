using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Level_Inheritance_Person_Example
{
    class Person
    {
        public string name;
        public string address;
    }
    class Student: Person
    {
        public int rno;
        public int age;
        public int marks;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student p = new Student();
            p.name = "Rohini";
            p.address = "Pl.No 115 Manewada";
            p.rno = 123;
            p.age = 22;
            p.marks = 99;
            Console.WriteLine("Student Name:- " + p.name);
            Console.WriteLine("Student Address:- " + p.address);
            Console.WriteLine("Student Roll No:- " + p.rno);
            Console.WriteLine("Student Age:- " + p.age);
            Console.WriteLine("Student Marks:- " + p.marks);
            Console.ReadKey();
        }
    }
}
