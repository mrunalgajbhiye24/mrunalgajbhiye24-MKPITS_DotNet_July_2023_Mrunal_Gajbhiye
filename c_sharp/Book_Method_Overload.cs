using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Method_OverLoad
{
    class Book
    {
        int bookid;
        string title, author;
        int price;

        public void getdata()
        {
            bookid = 1;
        }

        public void getdata(int bookid)
        {
            this.bookid = bookid;
        }

        public void getdata(int bookid,string title)
        {
            this.bookid = bookid;
            this.title = title;
        }
        public void getdata(int bookid,string title,string author)
        {
            this.bookid = bookid;
            this.title = title;
            this.author = author;
        }
        public void getdata(int bookid,string title,string author,int price)
        {
            this.bookid = bookid;
            this.title = title;
            this.author = author;
            this.price = price;
        }
        public void display()
        {
            Console.WriteLine("Book Id: " + bookid);
            Console.WriteLine("Book Title: " + title);
            Console.WriteLine("Book Author: " + author);
            Console.WriteLine("Book Price: " + price);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Book b = new Book();
            b.getdata();
            b.display();

            Console.WriteLine();
            Console.WriteLine("-----Book 1 Details-----");
            Book b1 = new Book();
            b1.getdata(111, "Csharp");
            b1.display();

            Console.WriteLine();
            Console.WriteLine("-----Book 1 Details-----");
            Book b2 = new Book();
            b2.getdata(111, "Csharp", "Muzhahid Khan");
            b2.display();

            Console.WriteLine();
            Console.WriteLine("-----Book 1 Details-----");
            Book b3 = new Book();
            b3.getdata(111, "Csharp", "Muzhahid Khan",90000);
            b3.display();

            Console.ReadKey();
        }
    }
}
