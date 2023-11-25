using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Stack_string_Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack s = new Stack();
            s.Push("Amar");
            s.Push("Ravi");
            s.Push("Antoni");
            foreach(string val in s)
            {
                Console.WriteLine("Name:- " + val);
            }
            Console.WriteLine("--------------------");
            s.Push("Ankita");
            Console.WriteLine("Last Item Added" +" "+ s.Peek());
            Console.WriteLine("After Peek method");
            foreach(string val in s)
            {
                Console.WriteLine("Name:- " + val);
            }
            Console.WriteLine("--------------------");
            Console.WriteLine("Last Item Added" + " " + s.Pop());
            Console.WriteLine("After Pop method");
            foreach (string val in s)
            {
                Console.WriteLine("Name:- " + val);
            }
            Console.ReadKey();
        }
    }
}
