using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Contain_More_One_Method
{
    class Book
    {
        public static int bookid;

        public static void display()
        {
            Console.WriteLine("Hello from Static Display Method");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Book.bookid = 1;
            Program p = new Program();
            p.Main();
            Console.WriteLine("Book Id: " + Book.bookid);
            Console.ReadKey();
        }

        void Main()
        {
            Console.WriteLine("Hello From Another Main Method");
        }
    }
    
}
