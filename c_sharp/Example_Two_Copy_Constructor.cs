using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2_Copy_Constructor
{
    class Employee
    {
        private string name;
        private int age;

        public Employee(Employee emp)
        {
            name = emp.name;
            age = emp.age;
        }
        public Employee(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public string Details
        {
            get
            {
                return " The age of " + name + " is " + age.ToString();
            }
        }
    }

        internal class Program
        {
            static void Main(string[] args)
            {
            Employee emp1 = new Employee("Mrunal", 22); 
            Employee emp2 = new Employee(emp1); 
            Console.WriteLine(emp2.Details);
            Console.ReadLine();

        }
    }
}
