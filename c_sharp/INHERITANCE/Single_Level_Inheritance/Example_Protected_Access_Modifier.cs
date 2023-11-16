using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Protected_Access_Modifier
{
    class Person
    {
        string name;
        string address;

        public void getpersondata(string name, string address)
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

        public void getstudentdata(int rno, int marks)
        {
            getpersondata("Rohini", "Mumbai");
            this.rno = rno;
            this.marks = marks;
        }
        public void displaystudentdata()
        {
            displaypersondata();
            Console.WriteLine("Roll No:- " + rno);
            Console.WriteLine("Marks:- " + marks);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.getstudentdata(123, 99);
            s.displaystudentdata();
            Console.ReadKey();
        }
    }
}
