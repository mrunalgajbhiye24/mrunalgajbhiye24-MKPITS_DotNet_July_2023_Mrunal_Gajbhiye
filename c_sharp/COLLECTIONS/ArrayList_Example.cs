using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Example_of_ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList ar = new ArrayList();
            ar.Add("Purvi");
            ar.Add("Rohini");
            ar.Add("Aditi");
            foreach(object obj in ar)
            {
                Console.WriteLine("Student Name:- " + obj);
            }
            Console.ReadKey();
        }
    }
}
