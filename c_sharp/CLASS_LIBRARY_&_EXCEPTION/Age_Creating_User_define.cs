using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_Creating_User_Define
{
    public class AgeException:ApplicationException
    {
        public AgeException(string message):base(message)
        {

        }
    }
    public class Age
    {
        int age=22;
        public void showdata()
        {
            if(age<=18)
            {
                throw new AgeException("Age Should be greater than 18");
            }
            else
            {
                Console.WriteLine("AgeException: "+age);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Age a = new Age();
            try
            {
                a.showdata();
            }
            catch (AgeException ae)
            {
                Console.WriteLine("Age: " + ae.Message);
            }
            Console.WriteLine("Bye");
            Console.ReadKey();
        }
    }
}
