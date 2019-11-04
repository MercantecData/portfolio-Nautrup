using System;
using System.Collections.Generic;

namespace BibliotekOpgave
{
     class Program
    {
        static List<Book> bookList = new List<Book>();

        static void Main(string[] args)
        {
            LoginExample();
            //Test();   
        }

        static void AddBook()
        {
            Console.WriteLine("Book name : ");
            string bookInput = Console.ReadLine();
            bookList.Add(new Book(bookInput, 5));
        }

        static void LoginExample()
        {
            Console.WriteLine("Welcome, what is your password? : ");
            string password = Console.ReadLine();
            if (password == "kode")
            {
                Console.Clear();
                LibraryMenu();
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
                        AddBook();
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
                        AllBooks();
                        break;

                    default:
                        Console.WriteLine("Invalid option!");
                        break;
                }
            }
        }

        static void AllBooks()
        {
            bookList.Add(new Book("\nAnders And", 1));
            bookList.Add(new Book("500 useless facts", 2));
            bookList.Add(new Book("Magic for dummies", 3));
            bookList.Add(new Book("How to drink water\n", 4));

            foreach (Book book in bookList)
            {
                Console.WriteLine(book.bookTitle);
            }
        }
        //func and met
    }
}
