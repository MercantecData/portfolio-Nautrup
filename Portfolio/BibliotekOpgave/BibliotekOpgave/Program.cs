using System;
using System.Collections.Generic;

namespace BibliotekOpgave
{
     class Program
    {
        static List<Book> bookList = new List<Book>();

        static void Main(string[] args)
        {
            
        }

        static void LoginSystem()
        {
            Console.WriteLine("Welcome, what is your password? : ");
            string password = Console.ReadLine();
            if (password == "kode")
            {
                Console.Clear();
                LibraryMenu();
            }
            else
            {
                Console.WriteLine("Password was wrong");
            }
        }

        static void LibraryMenu()
        {
            Console.WriteLine("\nMenu\n" +
                "1. Add book\n" +
                "2. Rent a book\n" +
                "3. Return a book\n" +
                "4. Search for book\n" +
                "5. See all Books");
            while (true)
            {
                Console.Write("Choose your option : ");
                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        //AddBook(); Add new book to the list
                        break;
                    case 2:
                        //Rent a book code
                        break;
                    case 3:
                        //Return book code
                        break;
                    case 4:
                        //search for a book code
                        break;
                    case 5:
                        AllBooks(); // print all current books out
                        break;

                    default:
                        Console.WriteLine("Invalid option!");
                        break;
                }
            }
        }

        static void AllBooks()
        {
            Console.WriteLine();
            bookList.Add(new Book("Anders And", ""));
            bookList.Add(new Book("500 useless facts", ""));
            bookList.Add(new Book("Magic for dummies", ""));
            bookList.Add(new Book("How to drink water", ""));

            foreach (Book book in bookList)
            {
                Console.WriteLine(book.bookTitle);
            }
            Console.WriteLine("Total amount of books: {0}", Book.GetNumOfBooks());
        }
        //func and met
    }
}
