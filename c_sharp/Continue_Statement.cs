using System;


namespace Continue_Statement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            while(true)
            {
                Console.WriteLine(num);
                num++;
                if (num<10)
                {
                    continue;
                }
                else
                {
                    break;
                }            
            }
            Console.ReadKey();
        }
    }
}
