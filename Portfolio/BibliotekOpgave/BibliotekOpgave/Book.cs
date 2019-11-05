using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotekOpgave
{
    class Book
    {
        public string bookTitle;
        public string author;
        static int numOfBooks = 0;

        public int maxLoanPeriod;
        public bool alreadyRented;

        public Book(string bookTitle, string author, int maxLoanPeriod = 10)
        {
            this.bookTitle = bookTitle;
            this.author = author;
            this.maxLoanPeriod = maxLoanPeriod;
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
                    Console.WriteLine("{0} is already rented out!",bookTitle);
                    return false;
                }
                else
                {
                    alreadyRented = true;
                    Console.WriteLine("{0} is rented by you", bookTitle);
                    return true;
                }
            }
        }


        public static int GetNumOfBooks()
        {
            return numOfBooks;
        }

    }
}
