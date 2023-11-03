using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_BookId_Title_Author_Constructor
{
    class Book
    {
        int bookid;
        string title, author;
        int price;

        public Book()
        {
            bookid = 1;
            title = "Oracle";
            author = "James";
            price = 200;
        }

        public void display()
        {
            Console.WriteLine("Book Id: " + bookid);
            Console.WriteLine("Book Title: " + title);
            Console.WriteLine("Book Author: " + author);
            Console.WriteLine("Book Prize: " + price);
        }
    }
    internal class Program
    { 
        static void Main(string[] args)
        {
            Book b = new Book();
            b.display();
            Console.ReadKey();
        }
    }
}
