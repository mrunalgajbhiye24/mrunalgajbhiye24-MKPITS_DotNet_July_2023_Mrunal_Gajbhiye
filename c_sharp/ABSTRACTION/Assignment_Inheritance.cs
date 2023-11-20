using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Inheritance
{
    class Vehicle
    {
        public int make;
        public string model;
    }
    class Car:Vehicle
    {
        public int numdoors;
        public string fueltype;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            c.make = 1945;
            c.model = "Audi";
            c.numdoors = 4;
            c.fueltype = "Deisel";
            Console.WriteLine("Car Make:- " + c.make);
            Console.WriteLine("Car Model:- "+c.model);
            Console.WriteLine("Num of Doors in Car:- " + c.numdoors);
            Console.WriteLine("Fuel Type in Car:- " + c.fueltype);
            Console.ReadKey();
        }
    }
}
