using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    internal class LibraryClass : LibraryInterface
    {
        public int bookID;
        public string bookTitle;
        public string bookAuthor;
        public bool isAvailable;
        public string[] book = {
            "bookID : 1 | bookTitle : Wanderlove | bookAuthor : Kirsten hubbard   | isAvailable : true",
            "bookID : 2 | bookTitle : Incarnate  | bookAuthor : jodi Meadows      | isAvailable : true",
            "bookID : 3 | bookTitle : Boomerang  | bookAuthor : Maggie Stiefvater | isAvailable : true",
            "bookID : 4 | bookTitle : Roomies    | bookAuthor : Noelle August     | isAvailable : true",
            "bookID : 5 | bookTitle : Hunted     | bookAuthor : Christina Lauren  | isAvailable : true"
        };

        public LibraryClass()
        {
            Console.WriteLine("Welcome to the library");
            Console.WriteLine();
            Console.WriteLine("Displaying the books available.........");
            displaybooks();
        }

        public void addbooks(int bookID, string bookTitle, string bookAuthor)
        {
            Array.Resize(ref book, book.Length + 1);                    //through the internet
            book[book.Length - 1] = $"bookID : {bookID} | bookTitle : {bookTitle} | bookAuthor : {bookAuthor} | isAvailable : {true}";
            Console.WriteLine("Book added!");
        }
        
        public void availablebooks()
        {
            Console.WriteLine("Available books............");
            foreach (var book in book)
            {
                if (book.Contains($"isAvailable : {true}"))
                {
                    Console.WriteLine(book);
                }
            }
        }

        public void borrowbooks(int bookID)
        {
            try
            {
                for (int i = 0; i < book.Length; i++)
                {
                    if (book[i].Contains($"bookID : {bookID}"))
                    {
                        if (book[i].Contains($"isAvailable : {true}"))
                        {
                            book[i] = book[i].Replace($"isAvailable : {true}", $"isAvailable : {false}");
                            Console.WriteLine($"book number {bookID} is yours!");
                            displaybooks();
                        }
                        else
                        {
                            Console.WriteLine("Already Borrowed! Choose another.........");
                            availablebooks();
                            return;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void displaybooks()
        {
            foreach (var book in book)
            {
                Console.WriteLine(book);
            }
        }

        public void returnbooks(int bookID, string bookTitle, string bookAuthor)
        {
            try
            {
                this.bookID = bookID;
                this.bookTitle = bookTitle;
                this.bookAuthor = bookAuthor;
                for (int i = 0; i < book.Length; i++)
                {
                    if (book[i].Contains($"bookID : {bookID}"))
                    {
                        if (book[i].Contains($"isAvailable : {false}"))
                        {
                            book[i] = book[i].Replace($"isAvailable : {false}", $"isAvailable : {true}");
                            Console.WriteLine($"book number {bookID} returned!");
                            displaybooks();
                        }
                        else
                        {
                            Console.WriteLine("this book is not from our library! but still we adding....");
                        }
                    }
                }
                addbooks(bookID, bookTitle, bookAuthor);
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
