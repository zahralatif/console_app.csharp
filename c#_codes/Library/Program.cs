using System;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            LibraryItem[] items = new LibraryItem[]
        {
            new Book { Title = "Incognito", PublicationYear = 2011, Author = "David Eagleman" },
            new DVD { Title = "Cartoon DVD", PublicationYear = 2005, Director = "Jane Smith" },
            new Magazine { Title = "Fashion Magazine", PublicationYear = 2020, IssueNumber = 210705 }
        };

            foreach (var item in items)
            {
                item.DisplayInfo();
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}