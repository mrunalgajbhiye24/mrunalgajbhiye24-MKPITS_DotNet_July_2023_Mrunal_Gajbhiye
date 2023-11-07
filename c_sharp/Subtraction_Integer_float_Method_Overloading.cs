using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subtraction_Integer_Float
{
    class Calculate
    {
        public void subtraction(int n1,int n2)
        {
            int res = n1 - n2;
            Console.WriteLine("Subtraction of 2 Integer Parameters: " + res);
        }
        public void subtraction(float n1, float n2)
        {
            float res = n1 - n2;
            Console.WriteLine("Subtraction of 2 Float Parameters: " + res);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculate cal = new Calculate();
            cal.subtraction(4, 2);
            cal.subtraction(3.3f, 2.2f);
            Console.ReadKey();
        }
    }
}
