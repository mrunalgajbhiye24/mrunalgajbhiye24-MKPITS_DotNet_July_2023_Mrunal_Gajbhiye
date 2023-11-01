using System;

namespace Employee_GetData_DisplayData_This
{
    class Employee
    {
        int emp_id;
        string emp_name;
        string emp_des;
        int emp_sal;

        public void getdata(int emp_id,string emp_name,string emp_des,int emp_sal)
        {
            this.emp_id = emp_id;
            this.emp_name = emp_name;
            this.emp_des = emp_des;
            this.emp_sal= emp_sal;
        }

        public void displaydata()
        {
            Console.WriteLine();
            Console.WriteLine("--Employee Details--");
            Console.WriteLine("Employee Id: " + emp_id);
            Console.WriteLine("Employee Name: " + emp_name);
            Console.WriteLine("Employee Designation: " + emp_des);
            Console.WriteLine("Employee Salary: " + emp_sal);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            Console.WriteLine("--Enter Employee Details--");
            int e_id;
            string e_name;
            string e_des;
            int e_sal;
            Console.Write("Enter Employee Id: ");
            e_id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Employee Name: ");
            e_name =Console.ReadLine();
            Console.Write("Enter Employee Designation: ");
            e_des = Console.ReadLine();
            Console.Write("Enter Employee Salary: ");
            e_sal= Convert.ToInt32(Console.ReadLine());
            emp.getdata(e_id,e_name,e_des,e_sal);
            emp.displaydata();
            Console.ReadKey();

        }
    }
}
