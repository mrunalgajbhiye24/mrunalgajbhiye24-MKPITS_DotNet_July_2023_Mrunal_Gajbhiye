using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Constructor
{
    class Book
    {
        static int bookid;
        static string title;
        static string author;

        static Book()
        {
            Console.WriteLine("Static Constructor is Called");
            bookid = 1;
            title = "Csharp";
            author = "Khan Sir";
        }
        public static void display()
        {
            Console.WriteLine("Bookid: " + bookid);
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Author: " + author);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Book.display();
            Console.ReadKey();
        }
    }
}
