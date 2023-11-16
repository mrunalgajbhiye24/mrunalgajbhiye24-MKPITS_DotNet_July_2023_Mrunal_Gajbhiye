using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Single_Level_Inheriting_Method
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
    class Student : Person
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
            Console.WriteLine("Roll No:- " + rno);
            Console.WriteLine("Marks:- " + marks);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.getpersondata("Rohini", "Mumbai");
            s.getstudentdata(123, 99);
            s.displaystudentdata();
            s.displaypersondata();
            Console.ReadKey();
        }
    }
}
