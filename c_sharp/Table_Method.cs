using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Table_Method
{
    internal class Program
    {
        static int table(int num)
        {
            int cnt = 1;
            int res = 0;
            while(cnt<=10)
            {
                res = num * cnt;   
                Console.WriteLine(num + "*" + cnt + "=" + res);
                cnt++;
            }
            
            return res;
        }
        static void Main(string[] args)
        {
            int number;
            Console.Write("Enter Number: ");
            number = Convert.ToInt32(Console.ReadLine());
            int result = table(number);
            Console.ReadKey();
        }
    }
}
