using System;

namespace Subject_Grade_Percentage
{
    internal class Program
    {
        static void Main(string[]args)
        {
            int marks,counter;
            float per,total=0;
            string grade=null;

            for(counter=1;counter<=5;counter++)
            {
                Console.Write("Enter 5 subject Marks: ");
                marks = Convert.ToInt32(Console.ReadLine());
                total += marks;
                
            }
            Console.WriteLine("Total: " + total);

            per = (total / 500.0f) * 100.0f;
            Console.WriteLine("Percentage: " + per);
            
            if (per >= 90)
            {
                grade = "A";
            }
            else if (per >= 75 && per < 90)
            {
                grade = "B";
            }
            else if (per >= 60 && per < 75)
            {
                grade = "C";
            }
            else if (per >= 40 && per <60 )
            {
                grade = "D";
            }
            else
            {
                grade = "Fail";
            }
            Console.WriteLine("Grade: " + grade);
            Console.ReadKey();

        }
    }
}