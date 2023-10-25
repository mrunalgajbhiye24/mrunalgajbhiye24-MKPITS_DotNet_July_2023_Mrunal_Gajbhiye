using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass_q2_Name_WithParameter
{
    internal class Program
    {
        static void Person(string name)
        {
            Console.WriteLine("Welcome friend " + name + "\n" + "Have a Nice Day");
        }
        static void Main(string[] args)
        {
            string name;
            Console.Write("Enter Name: ");
            name = Convert.ToString(Console.ReadLine());
            Person(name);
            Console.ReadKey();
        }
    }
}
