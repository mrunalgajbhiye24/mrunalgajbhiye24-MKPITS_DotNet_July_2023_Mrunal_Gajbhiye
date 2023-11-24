using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Student_ArrayList
{
    class Student
    {
        public int rno;
        public string name;
        public Student(int rno, string name)
        {
            this.name = name;
            this.rno = rno;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(11, "Mrunal");
            Student s2 = new Student(22, "Ritu");
            Student s3 = new Student(33, "Aditi");

            ArrayList ar = new ArrayList();
            ar.Add(s1);
            ar.Add(s2);
            ar.Add(s3);
            foreach(Student s in ar)
            {
                Console.WriteLine("Student Roll No:- " + s.rno);
                Console.WriteLine("Student Name:- " + s.name);
            }
            Console.ReadKey();
        }
    }
}
