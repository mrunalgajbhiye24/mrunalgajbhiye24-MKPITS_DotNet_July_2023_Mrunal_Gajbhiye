using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dayno;
            string dayname;
            Console.Write("Enter Dayno: ");
            dayno = Convert.ToInt32(Console.ReadLine());

            if (dayno == 1)
                dayname = "Monday";
            else if (dayno == 2)
                dayname = "Tuesday";
            else if (dayno == 3)
                dayname = "Wednesday";
            else if (dayno == 4)
                dayname = "Thursday";
            else if (dayno == 5)
                dayname = "friday";
            else if (dayno == 6)
                dayname = "Saturday";
            else if (dayno == 7)
                dayname = "Sunday";
            else
                dayname = "invalid";
            Console.WriteLine("Day: " + dayname);
            Console.ReadKey();

        }
    }
}
