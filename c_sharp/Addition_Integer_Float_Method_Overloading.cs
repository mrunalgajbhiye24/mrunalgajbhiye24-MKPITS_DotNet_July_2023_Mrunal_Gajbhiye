using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addition_Interger_Float
{
    class Calculate
    {
        public void addition(int n1,int n2)
        {
            int res = n1 + n2;
            Console.WriteLine("Addition Of 2 Integer: " + res);
        }
        public void addition(float n1,float n2)
        {
            float res = n1 + n2;
            Console.WriteLine("Addition of 2 Float Numbers: " + res);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculate cal = new Calculate();
            Console.WriteLine("Calling Addition of Integer Numbers");
            cal.addition(5, 9);

            Console.WriteLine();
            Console.WriteLine("Now calling Addition of Float Numbers");
            cal.addition(3.3f, 2.2f);

            Console.ReadKey();
        }
    }
}
