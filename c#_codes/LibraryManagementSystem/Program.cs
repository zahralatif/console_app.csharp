using System;

namespace LibraryManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            Book book1 = new Book
            {
                Title = "Book 1",
                Author = "Author 1",
                ISBN = "02468",
                Pages = 150,
                Publisher = "Publisher A",
                PublishYear = 2010,
                Status = BookStatus.Available
            };

            Book book2 = new Book
            {
                Title = "Book 2",
                Author = "Author 2",
                ISBN = "13579",
                Pages = 250,
                Publisher = "Publisher B",
                PublishYear = 2005,
                Status = BookStatus.Available
            };

            library.AddBook(book1);
            library.AddBook(book2);

            Patron patron1 = new Patron
            {
                Name = "Patron 1",
                ContactInfo = "patron1@example.com"
            };

            Patron patron2 = new Patron
            {
                Name = "Patron 2",
                ContactInfo = "patron2@example.com"
            };

            library.RegisterPatron(patron1);
            library.RegisterPatron(patron2);
            
        }
    }
}