using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Employee
    {
        public string empname { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.empname = "Purvi";
            Console.WriteLine("Employee Name:- " + emp.empname);
            Console.ReadKey();
        }
    }
}
