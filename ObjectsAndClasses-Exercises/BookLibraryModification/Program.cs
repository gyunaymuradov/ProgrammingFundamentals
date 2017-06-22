using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var myLibrary = new Library
            {
                Name = "Gyunay's Library",
                Books = new List<Book>()
            };
            for (int i = 0; i < n; i++)
            {
                var currentBook = ReadBook();
                myLibrary.Books.Add(currentBook);
            }

            var date = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);
            var booksReleaseDate = new Dictionary<string, DateTime>();

            foreach (Book book in myLibrary.Books)
            {
                booksReleaseDate[book.Title] = book.ReleaseDate;
            }

            foreach (var book in booksReleaseDate.OrderBy(a => a.Value).ThenBy(a => a.Key))
            {
                if (book.Value > date)
                {
                    Console.WriteLine($"{book.Key} -> {book.Value:dd.MM.yyyy}");
                }
            }
        }
        static Book ReadBook()
        {
            var tokens = Console.ReadLine().Split(' ').ToArray();
            return new Book
            {
                Title = tokens[0],
                Author = tokens[1],
                Publisher = tokens[2],
                ReleaseDate = DateTime.ParseExact(tokens[3], "dd.MM.yyyy", CultureInfo.InvariantCulture),
                ISBNNumber = tokens[4],
                Price = decimal.Parse(tokens[5])
            };
        }
    }

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string ISBNNumber { get; set; }
        public decimal Price { get; set; }
    }
    class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }
    }
}