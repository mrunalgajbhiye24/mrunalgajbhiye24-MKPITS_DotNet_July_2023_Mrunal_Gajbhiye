using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLevel_Inheritance_Employee_Example
{
    class Person
    {
        string name;
        string address;

        public void getpersondata(string name,string address)
        {
            this.name = name;
            this.address = address;
        }
        public void displaypersondata()
        {
            Console.WriteLine("Employee Name:- " + name);
            Console.WriteLine("Employee Address:- " + address);
        }
    }

    class Employee: Person
    {
        int salary;
        string designation;

        public void getemployeedata(int salary,string designation)
        {
            this.salary = salary;
            this.designation = designation;
        }
        public void displayemployeedata()
        {
            Console.WriteLine("Employee Salary:- " + salary);
            Console.WriteLine("Employee Designation:- " + designation);
        }
    }
    class PartTimeEmployee:Employee
    {
        int no_of_hours;

        public void getparttimeemployeedata(int no_of_hours)
        {
            this.no_of_hours = no_of_hours;
        }
        public void displayparttimeemployeedata()
        {
            Console.WriteLine("No of Hours:- " + no_of_hours);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            PartTimeEmployee p = new PartTimeEmployee();
            p.getpersondata("Mrunal", "Nagpur");
            p.getemployeedata(20000, "Manager");
            p.getparttimeemployeedata(8);
            p.displaypersondata();
            p.displayemployeedata();
            p.displayparttimeemployeedata();
            Console.ReadKey();
        }
    }
}
