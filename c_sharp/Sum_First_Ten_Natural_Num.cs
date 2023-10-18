using System;

namespace Sum_First_Natural_Num
{
    internal class Programs
    {
        static void Main(string[]args)
        {
            int counter = 1;
            int sum = 0;
            while(counter<=10)
            {
                sum += counter;
                counter++;
            }
            Console.WriteLine("The Sum of First Ten Natural Number is: " + sum);
            Console.ReadKey();
            
        }
    }
}