using System;

namespace Find_Element_in_Array
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
            for(int i=0;i<num.Length;i++)
            {
                if (num[i]==usernum)
                {
                    flag = 1;
                    break;
                }
            }
            if(flag==1)
            {
                Console.WriteLine("Num {0} is Found in array ", usernum);
            }
            else
            {
                Console.WriteLine("Num {0} is Not Found in array ");
            }
            Console.ReadKey();
        }
    }
}
