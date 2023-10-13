using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMPLOYEE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int empno;
            string empname;
            int basicsalary;
            string designation;
            float bonus=0;
            float totalsalary;
            Console.WriteLine("Enter Empno: ");
            empno = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Empname: ");
            empname = Console.ReadLine();

            Console.WriteLine("Enter Basic Salary: ");
            basicsalary = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Designation(manager,clerk,peon): ");
            designation = Console.ReadLine();

            if (designation == "manager")
                bonus = 0.55f * basicsalary;
            else if (designation == "clerk")
                bonus = 0.25f * basicsalary;
            else if (designation == "peon")
                bonus = 0.10f * basicsalary;
            else
                Console.WriteLine("invalid designation");

            totalsalary = basicsalary + bonus;
            Console.WriteLine("Empno: {0}, \n Empname: {1},\n Designation: {2},\n Basicsalary: {3},\n Bonus: {4}, \n Totalsalary: {5}", empno, empname, designation, basicsalary, bonus, totalsalary);
            Console.ReadKey();


           
        }
    }
}
