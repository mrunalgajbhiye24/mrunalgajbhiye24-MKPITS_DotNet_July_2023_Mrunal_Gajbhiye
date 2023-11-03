using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Details_With_Parameters
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
            empname = "Mrunal";
            designation = "CEO";
            salary = 100000;
        }
        public Employee(int empno,string empname,string designation,int salary)
        {
            this.empno = empno;
            this.empname = empname;
            this.designation = designation;
            this.salary = salary;
        }
        public void display()
        {
            Console.WriteLine("Employee No: " + empno);
            Console.WriteLine("Employee Name: " + empname);
            Console.WriteLine("Employee Designation: " + designation);
            Console.WriteLine("Employee Salary: " + salary);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Details of Employee 1");
            Employee emp = new Employee();
            emp.display();

            Console.WriteLine();
            Console.WriteLine("Details of Employee 2");
            Employee emp1 = new Employee(2, "Purvi", "Manager", 90000);
            emp1.display();
            Console.ReadKey();
        }
    }
}
