using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Having_Fields
{
    class Person
    {
        public string name;
        public string address;
    }
    class Employee : Person
    {
        public int empno;
        public int salary;
        public string designation;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.name = "Aditi";
            emp.address = "Beside laxmi Hotesl,Kharbi,Nagpur";
            emp.empno = 123;
            emp.salary = 80000;
            emp.designation = "Manager";
            Console.WriteLine("Employee Name:- " + emp.name);
            Console.WriteLine("Employee Address:- " + emp.address);
            Console.WriteLine("Employee Id:- " + emp.empno);
            Console.WriteLine("Employee Salary:- " + emp.salary);
            Console.WriteLine("Employee Designation:- " + emp.designation);
            Console.ReadKey();
        }
    }
}
