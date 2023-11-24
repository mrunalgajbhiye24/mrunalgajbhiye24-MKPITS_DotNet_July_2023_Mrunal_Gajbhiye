using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Diagnostics.Eventing.Reader;

namespace HashList_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("1", "Zara Khan");
            ht.Add("2", "Alia Sheikh");
            ht.Add("3", "Shruti Khanna");
            ht.Add("4", "Joe Holzner");
            ht.Add("5", "Abida Rehman");

            if (ht.ContainsValue("Nuha Ali"))
            {
                Console.WriteLine("This Student Name is already in the list");
            }
            else
            {
                ht.Add("6", "Nuha Ali");
            }
            ICollection key = ht.Keys;
            foreach(string s in key)
            {
                Console.WriteLine(s + ":" + ht[s]);
            }
            Console.ReadKey();
        }
    }
}
