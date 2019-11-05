using System;
using System.Collections.Generic;
using System.Linq;

namespace BibliotekOpgave
{
    class Program
    {
        static List<Book> book = new List<Book>();
        static Student admin = new Student("Jonas",1);
        static Book bookTest = new Book("Peter Plys","Horror");
        

        static void Main(string[] args)
        {
            LoginSystem();
            //LibraryMenu();
        }

        static void RentBookMethod()
        { 
            bookTest.RentBook(7);
        }

        static void ReturnBookMethod()
        {
            bookTest.ReturnBook();
        }

        static void LoginSystem()
        {
            Console.Write("Welcome, {0} \nWhat is your password? : ",admin.studentName);
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
                Console.Write("\nChoose your option : ");
                int input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:
                         //Add new book to the list
                        Console.WriteLine("No code yet");
                        break;
                    case 2:
                        //Rent a book code;
                        RentBookMethod();
                        break;
                    case 3:
                        //Return book code
                        ReturnBookMethod();
                        //Console.WriteLine("No code yet");
                        break;
                    case 4:
                        //search for a book code
                        SearchBook();
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
            book.Add(new Book("Anders And", "Horror"));
            book.Add(new Book("500 useless facts", "Comedie"));
            book.Add(new Book("Magic for dummies", "Sci-fi"));
            book.Add(new Book("How to drink water", "Dokumentation"));
            book.Add(new Book("How to drink water", "Adventure"));

            foreach (Book book in book)
            {
                Console.WriteLine("{0} | Genre: {1}", book.bookTitle,book.genre);
            }
            Console.WriteLine("\nTotal amount of books: {0}", Book.GetNumOfBooks());
        }

        static void SearchBook()
        {
            Console.Write("Search for book: ");
            string search = Console.ReadLine();
            foreach (var book in book)
            {
                if (book.bookTitle.Contains(search))
                {
                    Console.WriteLine(book + "WORKED!");
                }
                else
                {
                    Console.WriteLine(book + " was not found");
                }
            }
        }
        //func and met
    }
}
