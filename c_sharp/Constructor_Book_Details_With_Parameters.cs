using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Details_With_Parameters
{
    class Book
    {
        int bookid;
        string title, author;
        int prize;

        public Book()
        {
            bookid = 1;
            title = "Oracle";
            author = "James";
            prize = 500;
        }

        public Book(int bookid, string title, string author, int prize)
        {
            this.bookid = bookid;
            this.title = title;
            this.author = author;
            this.prize = prize;
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
            b1.display();

            Console.WriteLine();
            Book b2 = new Book(2, "Half Girlfriend", "Chetan Bhagat", 1000);
            b2.display();
            Console.ReadKey();
        }
    }
}
