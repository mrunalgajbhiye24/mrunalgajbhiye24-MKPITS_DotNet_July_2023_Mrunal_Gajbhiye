using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Example_Remove_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList ar = new ArrayList();
            ar.Add("Mrunal");
            ar.Add("Purvi");
            ar.Add("Rohini");
            ar.Add("Aditi");

            Console.WriteLine("ArrayList Collection Without Removing");
            foreach(object obj in ar)
            {
                Console.WriteLine("Student Name:- " + obj);
            }
            Console.WriteLine("-------------------------------------");
            ar.Remove("Purvi");
            Console.WriteLine("ArrayList Collection after Removing");
            foreach (object obj in ar)
            {
                Console.WriteLine("Student Name:- " + obj);
            }
            Console.WriteLine("-------------------------------------");
            ar.RemoveAt(2);
            Console.WriteLine("ArrayList Collection after RemovingAT from 1 Position");
            foreach (object obj in ar)
            {
                Console.WriteLine("Student Name:- " + obj);
            }
            Console.ReadKey();
        }
    }
}
