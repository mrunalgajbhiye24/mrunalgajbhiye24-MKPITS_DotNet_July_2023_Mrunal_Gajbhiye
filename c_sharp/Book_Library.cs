using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Library
{
    class Author
    {
        public string AuthorName { get; }

        public Author(string authorName)
        {
            AuthorName = authorName;
        }
    }

    class Book
    {
        public string Title { get; }
        public string ISBN { get; }
        public Author Author { get; }

        public Book(string title, string isbn, Author author)
        {
            Title = title;
            ISBN = isbn;
            Author = author;
        }

        public override string ToString()
        {
            return $"Title: {Title}, ISBN: {ISBN}, Author: {Author.AuthorName}";
        }
    }

    class Library
    {
        private List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine($"Book added to the library: {book}");
        }

        public void RemoveBook(string isbn)
        {
            Book bookToRemove = null;

            foreach (var book in books)
            {
                if (book.ISBN == isbn)
                {
                    bookToRemove = book;
                    break;
                }
            }

            if (bookToRemove != null)
            {
                books.Remove(bookToRemove);
                Console.WriteLine($"Book removed from the library: {bookToRemove}");
            }
            else
            {
                Console.WriteLine($"Book with ISBN {isbn} not found in the library.");
            }
        }

        public void DisplayBooks()
        {
            Console.WriteLine("Books in the library:");
            foreach (var book in books)
            {
                Console.WriteLine(book);
            }
            Console.WriteLine();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Create authors
            Author author1 = new Author("John Doe");
            Author author2 = new Author("Jane Smith");

            // Create books
            Book book1 = new Book("Introduction to C#", "123456", author1);
            Book book2 = new Book("Introduction to C#", "789012", author2);
            Book book3 = new Book("Advanced C#", "345678", author1);

            // Create library
            Library library = new Library();

            Console.WriteLine();
            // Add books to the library
            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);

            Console.WriteLine();
            Console.WriteLine("----------------------------------------");
            // Display books in the library
            library.DisplayBooks();

            Console.WriteLine("------Book Removed From the Library------");
            // Remove a book from the library
            library.RemoveBook("789012");

            Console.WriteLine();
            Console.WriteLine("-------Book Remains in the Library-------");
            // Display updated books in the library
            library.DisplayBooks();

            Console.ReadKey();
        }

    }
}

