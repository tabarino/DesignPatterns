using System;
using System.Collections.Generic;

namespace InterpreterPattern
{
    public class BookList
    {
        private IList<Books> _books = new List<Books>();
        public int BookCount { get; set; } = 0;

        public Books GetBook(int bookNumber)
        {
            if (bookNumber <= _books.Count)
            {
                return _books[bookNumber - 1];
            }

            return null;
        }

        public void AddBook(Books book)
        {
            _books.Add(book);
        }

        public void RemoveBook(Books book)
        {
            _books.Remove(book);
        }
    }
}
