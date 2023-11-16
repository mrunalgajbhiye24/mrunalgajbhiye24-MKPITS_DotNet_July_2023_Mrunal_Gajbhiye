using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Level_Inheritance_Protected_Employee
{
    class Employee
    {
        protected int salary;
    }
    class Programmer : Employee
    {
        public int bonus;

        public void getdata(int salary,int bonus)
        {
            this.salary = salary;
            this.bonus = bonus;
        }
        public void displaydata()
        {
            Console.WriteLine("Salary:- " + salary);
            Console.WriteLine("Bonus:- " + bonus);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Programmer p = new Programmer();
            p.getdata(90000, 3000);
            p.displaydata();
            Console.ReadKey();
        }
    }
}
