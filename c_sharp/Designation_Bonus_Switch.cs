using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designation_Bonus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string designation;
            int bonus=0;
            Console.Write("Enter Designation (manager,clerk,peon): ");
            designation = Console.ReadLine();

            switch(designation)
            {
                case "manager":
                    bonus = 5000;
                    break;
                case "clerk":
                    bonus = 3000;
                    break;
                case "peon":
                    bonus = 1000;
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;
            }
            Console.WriteLine("Bonus: {0}", bonus);
            Console.ReadKey();
        }
    }
}
