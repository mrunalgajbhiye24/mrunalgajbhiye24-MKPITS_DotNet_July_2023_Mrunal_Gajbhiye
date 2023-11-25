using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Sorted_List_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList sl = new SortedList();
            sl.Add("1", "Zara Ali");
            sl.Add("2", "Abida Rehman");
            sl.Add("3", "Joe Holzner");
            sl.Add("4", "Noorat Fateh Ali");
            sl.Add("5", "Sohail Khan");

            if (sl.ContainsValue("Nuha Ali")) 
            {
                Console.WriteLine("This Student Name Is already in the list ");
            }
            else
            {
                sl.Add("6", "Nuha Ali");
            }
            ICollection key = sl.Keys;
            foreach(string s in key)
            {
                Console.WriteLine(s + ":" + sl[s]);
            }
            Console.ReadKey();
        }
    }
}
