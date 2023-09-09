using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class Book : LibraryItem, ILoanable
    {
        public int Pages { get; set; }
        public string Publisher { get; set; }
        public int PublishYear { get; set; }
        public BookStatus Status { get; set; }

        public void CheckOut(Patron patron)
        {
            if (Status == BookStatus.Available)
            {
                Status = BookStatus.CheckedOut;
                patron.BorrowedBooks.Add(this);
            }
            else
            {
                Console.WriteLine("This book is not available for checkout.");
            }
        }

        public void Return(Patron patron)
        {
            if (Status == BookStatus.CheckedOut && patron.BorrowedBooks.Contains(this))
            {
                Status = BookStatus.Available;
                patron.BorrowedBooks.Remove(this);
            }
            else
            {
                Console.WriteLine("This book cannot be returned.");
            }
        }
    }
}
