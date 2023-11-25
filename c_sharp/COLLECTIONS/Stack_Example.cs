using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Stack_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack st = new Stack();
            st.Push('A');
            st.Push('B');
            st.Push('C');
            st.Push('D');
            st.Push('E');

            Console.WriteLine("Current Stack: ");
            foreach(char c in st)
            {
                Console.WriteLine(c + " ");
            }
            Console.WriteLine();

            st.Push('F');
            st.Push('G');
            Console.WriteLine("The Next Poppable Value in Stack:{0}", st.Peek());
            Console.WriteLine("Current Stack");
            foreach(char c in st)
            {
                Console.WriteLine(c + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Removing Values");
            st.Pop();
            st.Pop();
            st.Pop();

            Console.WriteLine("Current Stack");
            foreach(char c in st)
            {
                Console.WriteLine(c + " ");
            }
            Console.ReadKey();
        }
    }
}
