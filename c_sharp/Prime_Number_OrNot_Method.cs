using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Number_OrNot_Method
{
    internal class Program
    {
        static void prime(int num)
        {
            int cnt = 2;
            int flag = 0;
            while (cnt < num)
            {
                if (num % cnt == 0)
                {
                    flag = 1;
                    break;
                    
                }
                cnt++;
            }   
                if(flag==0)
                {
                    Console.WriteLine("It is a Prime Number");
                }
                else
                {
                    Console.WriteLine("It is not a Prime Number");
                }
            
        }
        static void Main(string[] args)
        {
            int number;
            Console.Write("Enter Number: ");
            number = Convert.ToInt32(Console.ReadLine());
            prime(number);
            Console.ReadKey();
        }
    }
}
