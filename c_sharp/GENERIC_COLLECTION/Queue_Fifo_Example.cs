using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_FiFo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> msgs = new Queue<string>();

            msgs.Enqueue("Message 1");
            msgs.Enqueue("Message 2");
            msgs.Enqueue("Message 3");
            msgs.Enqueue("Message 4");
            msgs.Enqueue("Message 5");

            Console.WriteLine(msgs.Dequeue());

            Console.WriteLine(msgs.Peek());
            Console.WriteLine(msgs.Peek());

            Console.WriteLine();

            foreach (string msg in msgs)
            {
                Console.WriteLine(msg);
            }
            Console.ReadKey();
        }
    }
}
