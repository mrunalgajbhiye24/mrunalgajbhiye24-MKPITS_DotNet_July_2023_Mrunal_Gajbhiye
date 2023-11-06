using System;

namespace Student_Static_Field
{
    class Student
    {
        int rollno;
        string name, course;
        int fees;

        public void getdata()
        {
            rollno = 123;
            name = "Mrunal Gajbhiye";
            course = "DotNet";
            fees = 65000;
        }
        public void getdata(int rollno)
        {
            this.rollno = rollno;
        }
        public void getdata(int rollno,string name)
        {
            this.rollno = rollno;
            this.name = name;
        }
        public void getdata(int rollno,string name,string course)
        {
            this.rollno = rollno;
            this.name = name;
            this.course = course;
        }
        public void getdata(int rollno, string name, string course,int fees)
        {
            this.rollno = rollno;
            this.name = name;
            this.course = course;
            this.fees = fees;
        }
        public void display()
        {
            Console.WriteLine("Student Roll No: " + rollno);
            Console.WriteLine("Student Name: " + name);
            Console.WriteLine("Student Course: " + course);
            Console.WriteLine("Student Fees: " + fees);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student();
            stu.getdata();
            stu.display();

            Console.WriteLine();
            Console.WriteLine("-----Student 1 details-----");
            Student stu1 = new Student();
            stu1.getdata(123);
            stu1.display();

            Console.WriteLine();
            Console.WriteLine("-----Student 1 details-----");
            Student stu2 = new Student();
            stu2.getdata(123,"Mrunal");
            stu2.display();

            Console.WriteLine();
            Console.WriteLine("-----Student 1 details-----");
            Student stu3 = new Student();
            stu3.getdata(123, "Mrunal","DotNet");
            stu3.display();

            Console.WriteLine();
            Console.WriteLine("-----Student 1 details-----");
            Student stu4 = new Student();
            stu4.getdata(123, "Mrunal", "DotNet",65000);
            stu4.display();

            Console.ReadKey();
        }
    }
}
