using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Out_of_Memory_Exception_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Bobby";
            string subject = "Mathematics";
            Console.WriteLine("Length of Name: " + name.Length);
            StringBuilder sb = new StringBuilder(name.Length, name.Length);
            try
            {
                Console.WriteLine(subject);
            }
            catch(OutOfMemoryException ee)
            {
                Console.WriteLine(ee.ToString());
            }
            Console.WriteLine("Bye");
            Console.ReadKey();
        }
    }
}
