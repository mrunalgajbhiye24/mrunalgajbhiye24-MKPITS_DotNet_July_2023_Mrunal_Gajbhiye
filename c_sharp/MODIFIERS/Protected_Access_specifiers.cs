using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protected_Access_Specifiers
{
    class Student
    {
        protected string name;
        public void getdata()
        {
            name = "Mrunal";
            Console.WriteLine("Student Name:- " + name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.getdata();
            Console.ReadKey();
        }
    }
}
