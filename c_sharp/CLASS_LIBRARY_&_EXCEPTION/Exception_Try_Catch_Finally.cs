using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execution_Try_Catch_Finally
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int n;
            Console.Write("Enter Number 1:- ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Number 2:- ");
            n = Convert.ToInt32(Console.ReadLine());

            int res = 0;
            try
            {
                res = num / n;
            }
            catch
            {
                Console.WriteLine("Catch Block is Executing");
                Console.WriteLine("Cannot Divide by Zero");
            }
            finally
            {
                Console.WriteLine("Finally Block is Executing");
                Console.WriteLine("Result: " + res);
            }
            Console.WriteLine("Bye");
            Console.ReadKey();
        }
    }
}
