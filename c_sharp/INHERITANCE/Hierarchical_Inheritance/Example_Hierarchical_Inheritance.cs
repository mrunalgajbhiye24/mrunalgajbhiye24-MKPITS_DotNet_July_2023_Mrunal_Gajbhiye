using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchical_Inheritance
{
    class Person
    {
        public string name;
        public string address;
    }
    class Student:Person
    {
        public int rno;
        public int marks;
    }
    class Employee:Person
    {
        public int salary;
        public string designation;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.rno = 1;
            s.marks = 99;
            s.name = "Mrunal";
            s.address = "Nagpur";
            Console.WriteLine("------------[Student Details]--------------");
            Console.WriteLine("Student Roll No:- " + s.rno);
            Console.WriteLine("Student Marks:- " + s.marks);
            Console.WriteLine("Student Name:- " + s.name);
            Console.WriteLine("Student Address:- " + s.address);

            Console.WriteLine();
            Employee e = new Employee();
            e.name = "Purvi";
            e.address = "Mumbai";
            e.salary = 50000;
            e.designation = "Manager";
            Console.WriteLine("------------[Employee Details]--------------");
            Console.WriteLine("Employee Name:- " + e.name);
            Console.WriteLine("Employee Address:- " + e.address);
            Console.WriteLine("Employee Salary:- " + e.salary);
            Console.WriteLine("Employee Designation:- " + e.designation);
            Console.ReadKey();
        }
    }
}
