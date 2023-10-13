using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eligible_To_vote
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.Write("Enter Your Age: ");
            age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18)
                Console.WriteLine("Congratulation! You are eligible for casting your vote");
            else
                Console.WriteLine("Sorry! You are not eligible for casting your vote");
            Console.ReadKey();
        }
    }
}
