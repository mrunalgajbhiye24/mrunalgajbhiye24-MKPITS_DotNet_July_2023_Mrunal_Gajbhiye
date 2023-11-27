using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> langs = new List<string>();
            langs.Add("Csharp");
            langs.Add("C#");
            langs.Add("Python");
            langs.Add("C++");
            langs.Add("Javascript");
            foreach (string s in langs)
            {
                Console.WriteLine(s);
            }

            

            Console.WriteLine("----------After Removing-----------");
            langs.Remove("Python");
            langs.Remove("C++");
            foreach (string s in langs)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("----------After Inserting----------");
            langs.Insert(3,"Haskell");
            foreach (string s in langs)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("----------After Sorting----------");
            langs.Sort();
            foreach(string s in langs)
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();
        }
    }
}
