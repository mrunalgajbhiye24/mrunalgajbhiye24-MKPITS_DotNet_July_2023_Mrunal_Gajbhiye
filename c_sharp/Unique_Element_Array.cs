using System;

namespace Unique_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[3];
            for(int i=0;i<3;i++)
            {
                Console.Write("Enter Element " + " " + i + " : ");
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();

            int cnt = 0;
            for (int i = 0; i < 3; i++)
            {
                cnt = 0;
                for(int j=0;j<3;j++)
                {
                    if(i!=j)
                    {
                        if (num[i] == num[j])
                        {
                            cnt++;
                            break;
                        }
                    }
                }
                if(cnt==0)
                {
                    Console.WriteLine("Unique Element is: " + num[i]);
                }
            }
            Console.ReadKey();
        }
    }
}
