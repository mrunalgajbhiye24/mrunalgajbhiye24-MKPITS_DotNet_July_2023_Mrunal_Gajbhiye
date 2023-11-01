using System;
using System.Reflection;

namespace Book_Class
{
    class Book
    {
        string title;
        string author;
        int publication_year;
        
        public void getdata(string title,string author,int publication_year)
        {
            this.title = title;
            this.author = author;
            this.publication_year = publication_year;
            
        }
        public void displaydata()
        {
            Console.WriteLine("--Details of 3 Books--");
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Author: " + author);
            Console.WriteLine("Publication Year: " + publication_year);
            Console.WriteLine();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Book[] bookied = new Book[3];
            bookied[0] = new Book();
            bookied[1] = new Book();
            bookied[2] = new Book();

            string tit =null;
            string aut = null;
            int public_year = 0;

            for(int i=0;i<3;i++)
            {
                Console.Write("Enter Title: ");
                tit = Console.ReadLine();

                Console.Write("Enter Author: ");
                aut = Console.ReadLine();

                Console.Write("Enter Publication Year: ");
                public_year = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                bookied[i].getdata(tit, aut, public_year);
            }

            for (int i = 0; i < 3; i++)
            {
                bookied[i].displaydata();
            }
            Console.ReadKey();


        }
    }
}
