using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Level_Inheritance_Employee
{
    class Employee
    {
        public int salary;
    }
    class Programmer:Employee
    {
        public int bonus;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Programmer p = new Programmer();
            p.salary = 60000;
            p.bonus = 2000;
            Console.WriteLine("Employee Salary: " + p.salary);
            Console.WriteLine("Employee Bonus: " + p.bonus);
            Console.ReadKey();
        }
    }
}
