using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Inventroy_Management_System
{
    public class Library
    {
        private Book[] books;
        private int bookCount;

        public Library(int capacity)
        {
            books = new Book[capacity];
            bookCount = 0;
        }

        public int TotalBooks
        {
            get { return bookCount; }
        }

        public void AddBook(Book book)
        {
            if (bookCount < books.Length)
            {
                books[bookCount] = book;
                bookCount++;
            }
            else
            {
                Console.WriteLine("Library is at full capacity, cannot add more books.");
            }
        }

        public void ShowAllBooks()
        {
            for (int i = 0; i < bookCount; i++)
            {
                books[i].ShowInfo();
            }
        }
    }
}
