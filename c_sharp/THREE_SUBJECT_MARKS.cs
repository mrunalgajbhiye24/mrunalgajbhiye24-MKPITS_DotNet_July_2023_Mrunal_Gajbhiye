using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THREE_SUBJECT_MARKS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sub1, sub2, sub3, total;
            float per;
            string grade = null;
            Console.WriteLine("Enter 3 subject Marks :");
            sub1 = Convert.ToInt32(Console.ReadLine());
            sub2 = Convert.ToInt32(Console.ReadLine());
            sub3 = Convert.ToInt32(Console.ReadLine());
            total = sub1 + sub2 + sub3;

            per = (total / 300.0f) * 100.0f;

            if (per >= 90)
                grade = "distinction";
            else if (per >= 75 && per < 90)
                grade = "First class";
            else if (per >= 60 && per < 75)
                grade = "Second class";
            else
                grade = "fail";
            
            Console.WriteLine("total: {0},\n percentage: {1},\n grade: {2}", total, per , grade);
   
            Console.ReadKey();

        }
    }
}
