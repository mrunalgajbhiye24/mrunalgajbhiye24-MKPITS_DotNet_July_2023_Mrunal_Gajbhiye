using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Static_Constructor
{
    class Employee
    {
        static int employeeid;
        static string employeename;
        static string designation;
        static int salary;

        static Employee()
        {
            Console.WriteLine("Static Constructor is called");
            employeeid = 123;
            employeename = "Mrunal Gajbhiye";
            designation = "Manager";
            salary = 90000;
        }

        public static void display()
        {
            Console.WriteLine("Employee Id: " + employeeid);
            Console.WriteLine("Employee Name: " + employeename);
            Console.WriteLine("Employee Designation: " + designation);
            Console.WriteLine("Employee Salary: " + salary);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee.display();
            Console.ReadKey();
        }
    }
}
