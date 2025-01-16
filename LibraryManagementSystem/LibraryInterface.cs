using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    internal interface LibraryInterface
    {
        void displaybooks();

        void addbooks(int bookID, string bookTitle, string bookAuthor);

        void borrowbooks(int bookID);

        void returnbooks(int bookID, string bookTitle, string bookAuthor);

        void availablebooks();
    }
}
