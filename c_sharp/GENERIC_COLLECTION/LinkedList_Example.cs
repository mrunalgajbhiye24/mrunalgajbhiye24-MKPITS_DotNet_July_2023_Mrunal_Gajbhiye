using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> li = new LinkedList<int>();
            li.AddLast(11);
            li.AddLast(12);
            li.AddLast(9);
            li.AddLast(23);
            li.AddLast(5);

            LinkedListNode<int> node = li.Find(5);
            li.AddBefore(node, 6);

            foreach(int i in li)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
