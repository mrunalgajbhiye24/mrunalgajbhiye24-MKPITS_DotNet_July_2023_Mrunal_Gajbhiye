using System;

namespace Cube_Dowhile
{
    internal class Program
    {
        static void Main(string[]args)
        {
            int num;
            int counter = 1;
            int result = 0;

            Console.Write("Enter Number: ");
            num = Convert.ToInt32(Console.ReadLine());

            do
            {
                result = counter * counter * counter;
                Console.WriteLine("Number is : {0} and cube of the {1} is :{2}", counter, counter, result);
                counter++;
            } while (counter <= num);

            Console.ReadKey();
        }
    }
}