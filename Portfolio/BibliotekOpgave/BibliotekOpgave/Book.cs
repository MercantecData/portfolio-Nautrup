using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotekOpgave
{
    class Book
    {
        public string bookTitle;
        public string author;

        public Book(string bookTitle, string author)
        {
            this.bookTitle = bookTitle;
            this.author = author;
            numOfBooks += 1;
        }

        public void RentBook()
        {
            Console.WriteLine("{0} is rented!", bookTitle);
        }

        public void ReturnBook()
        {

        }
        static int numOfBooks = 0;
        public static int GetNumOfBooks()
        {
            return numOfBooks;
        }
    }
}
