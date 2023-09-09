using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class Patron
    {
        public string Name { get; set; }
        public string ContactInfo { get; set; }
        public List<Book> BorrowedBooks { get; set; }

        public bool ValidateContactInfo()
        {
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";
            string phonePattern = @"^\d{10}$";

            return Regex.IsMatch(ContactInfo, emailPattern) || Regex.IsMatch(ContactInfo, phonePattern);
        }
    }
}
