using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplication_Integer_Float
{
    class Calculate
    {
        public void  Multiply(int n1, int n2)
        {
            int res = n1 * n2;
            Console.WriteLine("Multiplication of 2 Integer: " + res);
        }
        public void Multiply(float n1, float n2)
        {
            float res = n1 * n2;
            Console.WriteLine("Multiplication of 2 Integer: " + res);
        }
    }
        internal class Program
        {
            static void Main(string[] args)
            {
            Calculate mul = new Calculate();
            mul.Multiply(4, 5);
            mul.Multiply(5.5f, 6.6f);
            Console.ReadKey();
            }
        }
}
