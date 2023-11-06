using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Book_Member_variable
{
    class Book
    {
        int bookid;
        string title, author;
        int price;

        public void getdata()
        {
            bookid = 1;
            title = "Rich Dad or Poor Dad";
            author = "Robert";
            price = 3000;
        }
        public void getdata(int bookid, string title, string author, int price)
        {
            this.bookid = bookid;
            this.title = title;
            this.author = author;
            this.price = price;
        }
        public void display()
        {
            Console.WriteLine("Book Id: " + bookid);
            Console.WriteLine("Book title: " + title);
            Console.WriteLine("Book Author: " + author);
            Console.WriteLine("Book Price: " + price);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("-------Book 1 Deatils-------");
            Book b = new Book();
            b.getdata();
            b.display();

            Console.WriteLine();
            Console.WriteLine("-------Book 2 Deatils-------");
            Book b1 = new Book();
            b1.getdata(234, "Oracle", "James", 2000);
            b1.display();

            Console.WriteLine();
            Console.WriteLine("-------Book 3 Deatils-------");
            Console.Write("Enter Book Id: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Book Title: ");
            string title = Console.ReadLine();

            Console.Write("Enter Book Author: ");
            string author = Console.ReadLine();

            Console.Write("Enter Book Price: ");
            int price =Convert.ToInt32( Console.ReadLine());

            Console.WriteLine();
            Book b2 = new Book();
            b2.getdata(id, title, author, price);
            b2.display();
            Console.ReadKey();
        }
    }
}
