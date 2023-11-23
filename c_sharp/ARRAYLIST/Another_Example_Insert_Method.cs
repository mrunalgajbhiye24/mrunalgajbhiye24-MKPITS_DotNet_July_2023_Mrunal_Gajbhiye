using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Another_Example_Of_Insert_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList ar = new ArrayList();
            ar.Add("Mrunal");
            ar.Add("Purvi");
            ar.Add("Aditi");
            Console.WriteLine("ArrayList Collection Without Inserting");
            foreach(object obj in ar)
            {
                Console.WriteLine("Student Name:- " + obj);
            }
            ar.Insert(1, "Rohini");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("ArrayList Collection after Adding Element on 1st Position");
            foreach (object obj in ar)
            {
                Console.WriteLine("Student Name:- " + obj);
            }
            Console.ReadKey();
        }
    }
}
