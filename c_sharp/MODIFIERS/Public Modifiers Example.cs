using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Public_Modifier_Example
{
    class Student
    {
        public int rno;
        public string name;

        public void displaydata()
        {
            Console.WriteLine("Student Roll No: " + rno);
            Console.WriteLine("Student Name: " + name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.rno = 123;
            s.name = "Mrunal";
            s.displaydata();
            Console.ReadKey();
        }
    }
}
