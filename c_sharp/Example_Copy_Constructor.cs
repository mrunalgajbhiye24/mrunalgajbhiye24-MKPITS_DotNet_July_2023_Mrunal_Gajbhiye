using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Copy_Constructor
{
    class Book
    {
        int bookid;
        string title;
        string author;
        int prize;

        public Book()
        {
            bookid = 1;
            title = "Java Script";
            author = "James Gosling";
            prize = 1000;
        }
        public Book(Book b2)
        {
            bookid = b2.bookid;
            title = b2.title;
            author = b2.author;
            prize = b2.prize;
        }
        public void display()
        {
            Console.WriteLine("Book Id: " + bookid);
            Console.WriteLine("Book Title: " + title);
            Console.WriteLine("Book Author: " + author);
            Console.WriteLine("Book Prize: " + prize);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book();
            Book b2 = new Book();
            Console.WriteLine("Book 1 Details: ");
            b1.display();

            Console.WriteLine();
            Console.WriteLine("Book 2 Details: ");
            b2.display();

            Console.ReadKey();
        }
    }
}
