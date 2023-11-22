using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sealed_Class
{
    abstract class Person
    {
        public string name;
    }
    class Student:Person
    {
        public int rno;
    }
    sealed class ParttimeStudent : Student 
    {
        public int hours;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ParttimeStudent p = new ParttimeStudent();
            p.rno = 123;
            p.name = "Mrunal";
            p.hours = 5;
            Console.WriteLine("Student Roll No:- " + p.rno);
            Console.WriteLine("Student Name:- " + p.name);
            Console.WriteLine("Student Parttime Hours:- " + p.hours);
            Console.ReadKey();
        }
    }
}
