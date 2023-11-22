using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_Example
{
    class Student
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.ID = "101";
            student.Name = "Purvi Bhoyar";
            student.Email = "purvi222@gmail.com";
            Console.WriteLine("ID:- " + student.ID);
            Console.WriteLine("Name:- " + student.Name);
            Console.WriteLine("Email:- " + student.Email);
            Console.ReadKey();
        }
    }
}
