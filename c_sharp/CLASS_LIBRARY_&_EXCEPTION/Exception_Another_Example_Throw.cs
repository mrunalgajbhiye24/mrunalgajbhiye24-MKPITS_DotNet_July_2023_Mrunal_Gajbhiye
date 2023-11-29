using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Another_Example_Throw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 0;
            try
            {
                Console.Write("Enter Age: ");
                age = Convert.ToInt32(Console.ReadLine());
                if (age < 18)
                {
                    throw new Exception("Age Should be greater or Equal to 18");
                }
            }
            catch (OverflowException ee)
            {
                Console.WriteLine(ee.ToString());
                Console.WriteLine("Enter Age 18 or greater than 18");
                age = Convert.ToInt32(Console.ReadLine());
            }
            finally
            {
                Console.WriteLine("Finally Block is executing");
                Console.WriteLine("Age: " + age);
            }
            Console.WriteLine("Bye");
            Console.ReadKey();
        }
    }
}
