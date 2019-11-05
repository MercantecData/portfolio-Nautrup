using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotekOpgave
{
    class Library
    {
        //public string libraryName;
        //public string libraryLocation;
        public List<Book> books = new List<Book>();
        
        public void AddBook(Book book)
        {
            books.Add(book);
        }

        
    }
}
