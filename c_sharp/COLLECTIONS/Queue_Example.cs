using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Queue_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
            q.Enqueue("Amar");
            q.Enqueue("Shruti");
            q.Enqueue("Antoni");

            Console.WriteLine("Current Queue");
            foreach(string s in q)
            {
                Console.WriteLine(s + " ");
            }
            Console.WriteLine();
            q.Enqueue("Purvi");
            q.Enqueue("Himesh");
            Console.WriteLine("Current Queue");
            foreach(string s in q)
            {
                Console.WriteLine(s + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Removing Some Values");
            string st = (string)q.Dequeue();
            Console.WriteLine("The Removed Value:{0}", st);
            st= (string)q.Dequeue();
            Console.WriteLine("The removed value:{0}", st);
            Console.ReadKey();
        }
    }
}
