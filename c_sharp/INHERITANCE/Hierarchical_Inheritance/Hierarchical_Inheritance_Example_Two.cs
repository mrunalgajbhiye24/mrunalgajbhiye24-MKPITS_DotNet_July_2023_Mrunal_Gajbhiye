using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Hierarchical_Inheritance_Example_Two
{
    class Person
    {
        string name;
        string address;
        
        public void getpersondata(string name,string address)
        {
            this.name = name;
            this.address = address;
        }
        public void displaypersondata()
        {
            Console.WriteLine("Name:- " + name);
            Console.WriteLine("Address:- " + address);
        }
    }
    class Student:Person
    {
        int rno;
        int marks;

        public void getstudentdata(int rno,int marks)
        {
            this.rno = rno;
            this.marks = marks;
        }
        public void displaystudentdata()
        {
            Console.WriteLine("RollNo:- " + rno);
            Console.WriteLine("Marks:- " + marks);
        }
    }
    class Employee : Person
    {
        int salary;
        string designation;

        public void getemployeedata(int salary, string designation)
        {
            this.salary = salary;
            this.designation = designation;
        }
        public void displayemployeedata()
        {
            Console.WriteLine("Salary:- " + salary);
            Console.WriteLine("Designation:- " + designation);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------[Student Details]-------------");
            Student s = new Student();
            s.getpersondata("Rohini", "Nagpur");
            s.getstudentdata(123, 78);
            s.displaypersondata();
            s.displaystudentdata();

            Console.WriteLine();
            Console.WriteLine("------------[Employee Details]-------------");
            Employee e = new Employee();
            e.getpersondata("Mrunal", "Pune");
            e.getemployeedata(90000, "Manager");
            e.displaypersondata();
            e.displayemployeedata();
            Console.ReadKey();
        }
    }
}
