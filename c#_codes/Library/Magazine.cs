using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Magazine : LibraryItem
    {
        public int IssueNumber { get; set; }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Issue Number: {IssueNumber}");
        }
    }
}
