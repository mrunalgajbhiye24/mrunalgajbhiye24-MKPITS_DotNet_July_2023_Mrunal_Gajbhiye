using System;
using System.Xml.Schema;

namespace Subject_Marks
{
    class Student
    {
        string name;
        int roll_no;
        int[] subjectmarks;
        public void getdata(string name,int roll_no,int[]  marks)
        {
            this.name = name;
            this.roll_no = roll_no;
            this.subjectmarks = marks;
        }
        public void displaydata()
        {
            Console.Write("Student Name: " + name+"\n");
            Console.Write("Student Roll_No: " + roll_no+"\n");
            int total = 0;
            for (int i=0;i<subjectmarks.Length;i++)
            {
                total= total + subjectmarks[i];
            }
            float avg = total / 3.0f;
            Console.WriteLine("Average: " + avg);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student();
            int[] marks= new int[5];
            string name;
            int rollno;

            Console.Write("Enter Name: ");
            name = Console.ReadLine();

            Console.Write("Enter Roll_No: ");
            rollno = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter 3 subject Marks: ");
            for(int i=0;i<3;i++)
            {
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }
            stu.getdata(name, rollno, marks);
            stu.displaydata();
            Console.ReadKey();
        }
    }
}
