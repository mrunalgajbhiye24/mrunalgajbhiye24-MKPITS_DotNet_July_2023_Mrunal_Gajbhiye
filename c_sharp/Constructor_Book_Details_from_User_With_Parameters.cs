using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Details_From_User_with_Parameters
{
    class Book
    {
        int bookid;
        string title;
        string author;
        int price;

        public Book(int bookid, string title, string author, int price)
        {
            Console.WriteLine("--Details of Book--");
            this.bookid = bookid;
            this.title = title;
            this.author = author;
            this.price = price;

        }
        public void display()
        {
            Console.WriteLine("Book Id : " + bookid);
            Console.WriteLine("Book Title : " + title);
            Console.WriteLine("Book Author : " + author);
            Console.WriteLine("Book Price : " + price);

        }
    }




    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Bookid: ");
            int b1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Title: ");
            string t1 = Console.ReadLine();
            Console.Write("Enter Author: ");
            string a1 = Console.ReadLine();
            Console.Write("Enter Price: ");
            int p1 = Convert.ToInt32(Console.ReadLine());

            Book b2 = new Book(b1, t1, a1, p1); 
            b2.display();
            Console.ReadLine();
        }
    }
}
