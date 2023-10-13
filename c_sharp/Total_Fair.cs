using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Total_Fair
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string origin;
            string destination;
            string date;
            int trainno;
            string Class;
            string pname,gender;
            int age;
            int total=0;
            Console.Write("Enter origin: ");
            origin = Console.ReadLine();

            Console.Write("Enter Destination: ");
            destination = Console.ReadLine();

            Console.Write("Enter Date: ");
            date =Console.ReadLine();

            Console.Write("Enter Train_no: ");
            trainno = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Class(Ac, Sleeper, General): ");
            Class = Console.ReadLine();

            Console.Write("Enter pname: ");
            pname = Console.ReadLine();

            Console.Write("Enter Gender: ");
            gender = Console.ReadLine();

            Console.Write("Enter Age: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("                         ");
            Console.WriteLine("--Details of Passenger--");
            Console.WriteLine("                         ");

            if (destination == "mumbai")
            {
                total = 1500;
            }
            else if (destination == "pune")
            {
                total = 1000;
            }
            else if (destination == "goa")
            {
                total = 10000;
            }
            else
            {
                Console.WriteLine("invalid");
            }

            Console.WriteLine("Total fair:"+total);

            Console.WriteLine("Origin: {0},\n Destination: {1},\n Date: {2},\n Train_no: {3},\nClass: {4},\n PName: {5},\n Gender: {6},\n Age: {7}", origin, destination, date, trainno, Class, pname, gender, age);
            Console.ReadKey();


        }
    }
}
