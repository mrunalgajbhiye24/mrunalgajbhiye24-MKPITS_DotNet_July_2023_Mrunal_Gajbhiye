using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Divide_By_Zero_Exception_Class
{
    class DivNumbers
    {
        int result = 0;
         public       DivNumbers()
        {
            result = 0;
        }
        public void division(int num1,int num2)
        {
            try
            {
                result = num1 / num2;
            }
            catch(DivideByZeroException ee)
            {
                Console.WriteLine("Except Caught: "+ee);
            }
            finally
            {
                Console.WriteLine("Result:{0} ", result);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            DivNumbers d = new DivNumbers();
            d.division(25, 0);
            Console.ReadKey();
        }
    }
}
