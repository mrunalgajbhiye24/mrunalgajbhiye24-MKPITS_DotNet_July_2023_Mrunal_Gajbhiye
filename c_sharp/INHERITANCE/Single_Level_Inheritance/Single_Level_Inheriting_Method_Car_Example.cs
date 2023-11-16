using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Level_Inheriting_Method_Car
{
    class Car
    {
        public void start()
        {
            Console.WriteLine("Car is Started");
        }
    }
    class Swift:Car
    {
        public void stop()
        {
            Console.WriteLine("Car is Stop");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Swift s = new Swift();
            s.start();
            s.stop();
            Console.ReadKey();
        }
    }
}
