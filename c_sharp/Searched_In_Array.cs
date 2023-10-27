using System;

namespace Find_Position_In_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 2, 3, 4, 5 };
            int usernum;
            int flag = 0;
            Console.Write("Number to be searched: ");
            usernum = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] == usernum)
                {
                    flag = 1;
                    break;
                }
            }
            if (flag == 1)
            {
                Console.WriteLine("Num {0} is Searched in array ", usernum);
            }
            else
            {
                Console.WriteLine("Num {0} is Not Searched in array ");
            }
            Console.ReadKey();
        }
    }
}
