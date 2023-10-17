using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_DAYS_Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month_name;
            Console.Write("Enter Month Name: ");
            month_name = Console.ReadLine();

            switch (month_name)
            {
                case "January":
                case "March":
                case "May":
                case "July":
                case "August":
                case "October":
                case "December":
                    Console.WriteLine("Month have 31 days");
                    break;
                case "February":
                case "April":
                case "June":
                case "September":
                case "November":
                    Console.WriteLine("Month have 30 Days");
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;
            }
            Console.ReadKey();
        }
    }
}
