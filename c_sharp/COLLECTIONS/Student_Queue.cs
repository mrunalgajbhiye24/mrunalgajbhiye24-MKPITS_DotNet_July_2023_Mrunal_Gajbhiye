using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Student_Queue
{
    class Student
    {
        public int rno;
        public string name;

        public Student(int rno,string name)
        {
            this.rno = rno;
            this.name = name;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(11, "Purvi");
            Student s2 = new Student(12, "Rohini");
            Student s3 = new Student(13, "Aditi");

            Queue q = new Queue();
            q.Enqueue(s1);
            q.Enqueue(s2);
            q.Enqueue(s3);
            foreach(Student s in q)
            {
                Console.WriteLine("Roll No:- " + s.rno);
                Console.WriteLine("Name:- " + s.name);
            }
            Console.WriteLine("--------------------------");
            Student r = (Student)q.Dequeue();
            Console.WriteLine("Item Deque:" + " "+ r.rno + ":" + r.name);
            Console.WriteLine("--------------------------");
            Console.WriteLine("After Deque");
            foreach(Student s in q)
            {
                Console.WriteLine("Roll No:- " + s.rno);
                Console.WriteLine("Name:- " + s.name);
            }
            Console.ReadKey();
        }
    }
}
