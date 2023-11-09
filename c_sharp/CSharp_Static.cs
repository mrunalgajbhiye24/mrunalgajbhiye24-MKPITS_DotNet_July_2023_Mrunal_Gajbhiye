using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Static
{
    class Book
    {
        public static int bookid;
        public static string title;
        public static string author;
        public static int publication_year;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Book.bookid = 1;
            Book.title = "Rich Dad Poor Dad";
            Book.author = "Robert";
            Book.publication_year = 2019;
            Console.WriteLine("Book Id: " + Book.bookid);
            Console.WriteLine("Book Title: " + Book.title);
            Console.WriteLine("Book Author: " + Book.author);
            Console.WriteLine("Book Publication Year: " + Book.publication_year);
            Console.ReadKey();
        }
    }
}
