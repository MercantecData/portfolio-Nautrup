using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotekOpgave
{
    class Book
    {
        private List<Book> books = new List<Book>();
        public string bookTitle;
        public string author;
        public string genre;
        static int numOfBooks = 0;

        public int maxLoanPeriod;
        public bool alreadyRented;
  

        public Book(string bookTitle, string genre, string author = "Unknown", int maxLoanPeriod = 10)
        {
            this.bookTitle = bookTitle;
            this.author = author;
            this.maxLoanPeriod = maxLoanPeriod;
            this.genre = genre;
            numOfBooks += 1;
        }

        public bool RentBook(int days)
        {
            if (days > maxLoanPeriod)
            {
                Console.WriteLine("The book cant be lend for more than {0} days",maxLoanPeriod);
                return false;
            }
            else
            {
                if (alreadyRented)
                {
                    Console.WriteLine("{0} is already rented!",bookTitle);
                    return false;
                }
                else
                {
                    Console.WriteLine("You have now rented {0}", bookTitle);
                    return true;
                }
            }
        }

        public bool ReturnBook()
        {
            
            if (maxLoanPeriod > 10)
            {
                Console.WriteLine("You didn't return {0} in time and recived a penalty charge of 1$", bookTitle);
                Console.Write("Write your student id for payment: ");
                return true;
            }
            else
            {
                Console.WriteLine("You have returned {0}", bookTitle);
                return false;
            }
        }

        
        public static int GetNumOfBooks()
        {
            return numOfBooks;
        }

    }
}
