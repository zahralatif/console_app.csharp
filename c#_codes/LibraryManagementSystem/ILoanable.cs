using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public interface ILoanable
    {
        void CheckOut(Patron patron);
        void Return(Patron patron);
    }
}
