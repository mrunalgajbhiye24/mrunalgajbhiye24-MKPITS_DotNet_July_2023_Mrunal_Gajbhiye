using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_ArrayList
{
    internal class Program
    {
        class Employee
        {
            public int empno;
            public string empname;
            public int salary;
            public string designation;

            public Employee(int empno,string empname,int salary,string designation)
            {
                this.empno = empno;
                this.empname = empname;
                this.salary = salary;
                this.designation = designation;
            }
        }
        

        static void Main(string[] args)
        {
            ArrayList ar = new ArrayList();
            Employee e1 = new Employee(11, "Mrunal", 50000, "Manager");
            Employee e2 = new Employee(22, "Reeta", 30000, "Clerk");
            Employee e3 = new Employee(33, "Manisha", 15000, "Peon");

            ar.Add(e1);
            ar.Add(e2);
            ar.Add(e3);

            foreach(Employee e in ar)
            {
                Console.WriteLine("Employee Id:- " + e.empno);
                Console.WriteLine("Employee Name:- " + e.empname);
                Console.WriteLine("Employee Salary:- " + e.salary);
                Console.WriteLine("Employee Designation:- " + e.designation);
                Console.WriteLine("-------------------------------");
            }
            Console.ReadKey();
        }
    }
}
