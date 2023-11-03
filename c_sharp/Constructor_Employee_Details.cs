using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Details
{
    class Employee
    {
        int empno;
        string empname;
        string designation;
        int salary;

        public Employee()
        {
            empno = 1;
            empname = "Mrunal Gajbhiye";
            designation = "Manager";
            salary = 90000;
        }

        public void display()
        {
            Console.WriteLine("Employee No: " + empno);
            Console.WriteLine("Employee Name: " + empname);
            Console.WriteLine("Designation: " + designation);
            Console.WriteLine("Employee Salary: " + salary);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.display();
            Console.ReadKey();
        }
    }
}
