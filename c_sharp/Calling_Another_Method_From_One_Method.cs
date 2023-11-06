using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calling_Another_Method_From_One_Method
{
    class Book
    {
        int bookid;
        String title, author;
        int price;

        public void getdata()
        {
            bookid = 1;
            title = "Oracle";
            author = "James";
            price = 200;

        }
       
        public void getdata(int bookid)
        {
            this.bookid = bookid;
            getdata(bookid, "Html");

        }
        public void getdata(int bookid, String title)
        {
            this.bookid = bookid;
            this.title = title;
            getdata(bookid, title, "Amitabh");

        }
        public void getdata(int bookid, String title, String author)
        {
            this.bookid = bookid;
            this.title = title;
            this.author = author;
            getdata(bookid, title, author, 123);

        }
        public void getdata(int bookid, String title, String author, int price)
        {
            this.bookid = bookid;
            this.title = title;
            this.author = author;
            this.price = price;
        }
        public void display()
        {
            Console.WriteLine("Book id = " + bookid);
            Console.WriteLine("Book title = " + title);
            Console.WriteLine("Book author= " + author);
            Console.WriteLine("Price = " + price);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Book b = new Book();
            b.getdata(222);
            b.display();
            Console.ReadLine();

        }
    }
}
