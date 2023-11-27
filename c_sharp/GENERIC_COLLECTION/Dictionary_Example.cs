using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> di = new Dictionary<string, string>();
            di.Add("ge", "Germany");
            di.Add("in", "India");
            di.Add("us", "United State");
            di.Add("ru", "Russia");
            di.Add("po", "Poland");
            di.Add("af", "Africa");

            Console.WriteLine("Dictionary Has {0} items", di.Count);

            Console.WriteLine("----------------------------------");
            Console.WriteLine("Keys of the Dictionary");
            List<string> li = new List<string>(di.Keys);
            foreach(string s in li)
            {
                Console.WriteLine("{0}", s);
            }

            Console.WriteLine("----------------------------------");
            Console.WriteLine("Values of the Dictionary");
            List<string> val = new List<string>(di.Values);
            foreach(string s in val)
            {
                Console.WriteLine("{0}", s);
            }

            Console.WriteLine("----------------------------------");
            Console.WriteLine("Keys And Values of the Dictionary");
            foreach(KeyValuePair<string,string> kvp in di)
            {
                Console.WriteLine("Keys:- {0},Values:- {1}", kvp.Key, kvp.Value);
            }
            Console.ReadKey();
        }
    }
}
