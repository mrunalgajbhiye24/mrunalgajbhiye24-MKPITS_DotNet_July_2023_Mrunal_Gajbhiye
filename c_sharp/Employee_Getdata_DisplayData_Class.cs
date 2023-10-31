using System;

namespace Employee_Getdata_DisplayData
{
    class Employee
    {
        int emp_id;
        string emp_name;
        string emp_des;
        int emp_salary;

        public void getdata(int e_id, string e_name, string e_des, int e_sal)
        {
            emp_id = e_id;
            emp_name = e_name;
            emp_des = e_des;
            emp_salary = e_sal;
        }
        public void displaydata()
        {
            Console.Write("Employee Id: " + emp_id+"\n");
            Console.Write("Employee Name: " + emp_name+"\n");
            Console.Write("Employee Designation: " + emp_des+"\n");
            Console.Write("Employee Salary: " + emp_salary);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.getdata(569, "Mrunal", "Manager", 80000);
            emp.displaydata();
            Console.ReadLine();
        }
    }
}

