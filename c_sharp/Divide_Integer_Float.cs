using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divide_Integer_Float
{
    class Calculate
    {
        public void divide(int n1, int n2)
        {
            int res = n1 / n2;
            Console.WriteLine("Multiplication of 2 Integer: " + res);
        }
        public void divide(float n1, float n2)
        {
            float res = n1 / n2;
            Console.WriteLine("Multiplication of 2 Integer: " + res);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculate cal = new Calculate();
            cal.divide(7 ,2);
            cal.divide(5.5f, 2.2f);
            Console.ReadKey();
        }
    }
}
