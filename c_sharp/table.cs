using System;

namespace table_of_num
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int i;
            int result;
            Console.WriteLine("Enter number");
            num = Convert.ToInt32(Console.ReadLine());
            for(i=1;i<=10;i++)
            {
                result = num * i;
                Console.WriteLine(num + "*" + i + "=" +result);
            }
            Console.ReadKey();
        }
    }
}
