using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Calling_One_Method_Another_Method
{
    class Book
    {
        string title, author;

        public void getdata(string title)
        {
            Console.WriteLine("Method With One Parameter");
            getdata(title, "Mrunal");
        }
        public void getdata(string title,string author)
        {
            Console.WriteLine("Methods with Two Parameter");
            this.title = title;
            this.author = author;
        }
        public void display()
        {
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Author: " + author);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Book b = new Book();
            b.getdata("HTML");
            b.display();

            Console.ReadKey();
        }
    }
}
