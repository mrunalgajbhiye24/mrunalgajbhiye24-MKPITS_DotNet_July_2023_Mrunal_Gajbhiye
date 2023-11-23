using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Example_of_Insert_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList ar = new ArrayList();
            ar.Add(11);
            ar.Add(22);
            ar.Add(44);
            Console.WriteLine("ArrayList Collection Without Inserting");
            foreach(int i in ar)
            {
                Console.WriteLine("Student Roll No:- " + i);
            }
            ar.Insert(2, 33);
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("ArrayList Collection Adding Element At 2nd Position");
            foreach (int i in ar)
            {
                Console.WriteLine("Student Roll No:- " + i);
            }
            Console.ReadKey();
        }
    }
}
