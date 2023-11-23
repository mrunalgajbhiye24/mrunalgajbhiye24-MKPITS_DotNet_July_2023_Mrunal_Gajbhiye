using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace ArrayList_Another_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList ar = new ArrayList();
            ar.Add(123);
            ar.Add(234);
            ar.Add(567);
            ar.Add(987);
            foreach(object obj in ar)
            {
                Console.WriteLine("Student Roll No:- " + obj);
            }
            Console.WriteLine("Capacity:- " + ar.Capacity);
            Console.WriteLine("Count:- " + ar.Count);
            Console.ReadKey();
        }
    }
}
