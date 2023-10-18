using System;

namespace Sum_First_Natural_Num
{
    internal class Programs
    {
        static void Main(string[] args)
        {
            int counter = 1;
            int sum = 0;
            float avg=0;
            while (counter <= 10)
            {
                sum += counter;
                avg = sum / 10f;
                counter++;
            }
            Console.WriteLine("The Sum of First Ten Natural Number is: " + sum);
            Console.WriteLine("The Average of First Ten Natural Number is: " + avg);
            Console.ReadKey();

        }
    }
}