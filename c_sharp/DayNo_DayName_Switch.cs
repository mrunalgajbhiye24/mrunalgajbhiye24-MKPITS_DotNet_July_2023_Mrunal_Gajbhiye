using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayNo_DayName_Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dayno;
            Console.Write("Enter Dayno: ");
            dayno = Convert.ToInt32(Console.ReadLine());

            switch(dayno)
            {
                case 1:
                    Console.WriteLine("MONDAY");
                    break;
                case 2:
                    Console.WriteLine("TUESDAY");
                    break;
                case 3:
                    Console.WriteLine("WEDNESDAY");
                    break;
                case 4:
                    Console.WriteLine("THURSDAY");
                    break;
                case 5:
                    Console.WriteLine("FRIDAY");
                    break;
                case 6:
                    Console.WriteLine("SATURDAY");
                    break;
                case 7:
                    Console.WriteLine("SUNDAY");
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;

            }
            Console.ReadLine();

        }
    }
}
