using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Index_Out_Of_Range_Exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[3];
            arr[0] = 11;
            arr[1] = 22;
            arr[2] = 33;
            try
            {
                for(int i=0;i<=3;i++)
                {
                    Console.WriteLine("Array: " + arr[i]);
                }
            }
            catch(IndexOutOfRangeException ee)
            {
                Console.WriteLine(ee.ToString());
            }
            catch(Exception ee)
            {
                Console.WriteLine(ee.ToString());
            }
            finally
            {
                Console.WriteLine("Finally block is Executing");
            }
            Console.WriteLine("Bye");
            Console.ReadKey();
        }
    }
}
