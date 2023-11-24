using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Example_of_Sort_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList ar = new ArrayList();
            ar.Add("Mrunal");
            ar.Add("Aditi");
            ar.Add("Bhavika");
            Console.WriteLine("Array List Collection without sorting");

            foreach(object obj in ar)
            {
                Console.WriteLine("Student Name:- " + obj);
            }
            ar.Sort();
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Array List Collection with sorting");

            foreach (object obj in ar)
            {
                Console.WriteLine("Student Name:- " + obj);
            }
            Console.ReadKey();
        }
    }
}
