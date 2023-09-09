using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class Library
    {
        private List<Book> availableBooks;
        private List<Patron> patrons;

        public Library()
        {
            availableBooks = new List<Book>();
            patrons = new List<Patron>();
        }

        public void AddBook(Book book)
        {
            availableBooks.Add(book);
        }

        public void RemoveBook(Book book)
        {
            availableBooks.Remove(book);
        }

        public void RegisterPatron(Patron patron)
        {
            patrons.Add(patron);
        }

        public void CheckOutBook(Patron patron, Book book)
        {
            if (patron.ValidateContactInfo())
            {
                book.CheckOut(patron);
            }
            else
            {
                Console.WriteLine("Invalid contact information.");
            }
        }

        public void ReturnBook(Patron patron, Book book)
        {
            book.Return(patron);
        }
    }

}
