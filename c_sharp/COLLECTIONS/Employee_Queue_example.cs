using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Employee_Queue_example
{
    class Employee
    {
        public int empno;
        public string empname;
        public string designation;
        public int salary;

        public Employee(int empno,string empname,string designation,int salary)
        {
            this.empno = empno;
            this.empname = empname;
            this.designation = designation;
            this.salary = salary;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee(1, "Purvi", "Manager", 90000);
            Employee e2 = new Employee(2, "Shruti", "Clerk", 30000);
            Employee e3 = new Employee(3, "Mayuri", "Peon", 10000);

            Queue q = new Queue();
            q.Enqueue(e1);
            q.Enqueue(e2);
            q.Enqueue(e3);
            foreach(Employee e in q)
            {
                Console.WriteLine("Employee Id:- " + e.empno);
                Console.WriteLine("Employee Name:- " + e.empname);
                Console.WriteLine("Employee Designation:- " + e.designation);
                Console.WriteLine("Employee Salary:- " + e.salary);
                Console.WriteLine();
            }
            Employee r = (Employee)q.Dequeue();
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Item Deque:" + " " + r.empno + ":" + r.empname + ":" + r.designation + ":" + r.salary);
            Console.WriteLine("------------------------------------"); 
            Console.WriteLine("After Deque");
            foreach(Employee e in q)
            {
                Console.WriteLine("Employee Id:- " + e.empno);
                Console.WriteLine("Employee Name:- " + e.empname);
                Console.WriteLine("Employee Designation:- " + e.designation);
                Console.WriteLine("Employee Salary:- " + e.salary);
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
