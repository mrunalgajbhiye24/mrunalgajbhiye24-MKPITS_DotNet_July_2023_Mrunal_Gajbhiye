using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Constructor_Destructor
{
    class Employee
    {
        public Employee()
        {
            Console.WriteLine("Constructor is Called");
        }
        ~Employee()
        {
            Console.WriteLine("Destructor is Called");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            Console.ReadKey();

            Employee emp1 = new Employee();
            Console.ReadKey();
        }
    }
}
