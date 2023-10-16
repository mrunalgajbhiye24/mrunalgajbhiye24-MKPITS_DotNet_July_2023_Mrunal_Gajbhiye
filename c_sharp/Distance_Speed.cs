using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distance_Speed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float dist, hr, min, sec, timesec;
            float metersec, km, miles;
            Console.Write("Enter Distance (Meters): ");
            dist = Convert.ToSingle(Console.ReadLine());

            Console.Write("Enter time (Hours): ");
            hr = Convert.ToSingle(Console.ReadLine());

            Console.Write("Enter time (minutes): ");
            min = Convert.ToSingle(Console.ReadLine());

            Console.Write("Enter time (seconds): ");
            sec = Convert.ToSingle(Console.ReadLine());

            timesec = (hr * 3600) + (min * 60) + sec; // time in seconds

            metersec = dist / timesec; // speed in meters/second

            km = (dist / 1000) / (timesec / 3600); // speed in km/hr

            miles = km / 1.60934f; // speed in miles/hr

            Console.WriteLine(" ");
            Console.WriteLine("Your speed in meters/sec is: " + metersec);
            Console.WriteLine("Your speed in km/h is: " + km);
            Console.WriteLine("Your speed in miles/h is: " + miles);
            Console.ReadKey();

        }
    }
}
