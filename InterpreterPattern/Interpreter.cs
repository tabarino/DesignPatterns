using System;

namespace InterpreterPattern
{
    public class Interpreter
    {
        private readonly BookList _bookList;

        public Interpreter(BookList bookList)
        {
            _bookList = bookList;
        }

        public string Interpret(string lookupReceived)
        {
            var lookup = lookupReceived.Split(' ');
            string result = null;

            if (lookup[0] == "book")
            {
                if (lookup[1] == "author")
                {
                    result = LookupAuthor(lookup);
                }

                if (lookup[1] == "title")
                {
                    result = LookupTitle(lookup);
                }
            }
            else
            {
                result = "Cannot process, can only process book author #, book title #, or book author title #";
            }

            return result;
        }

        private string LookupAuthor(string[] lookup)
        {
            var isNumeric = false;
            int bookNumber = 0;
            string result = null;

            isNumeric = int.TryParse(lookup[2], out bookNumber);
            if (isNumeric)
            {
                var book = _bookList.GetBook(bookNumber);
                if (book == null)
                {
                    result = $"Cannot process, there is no book # {bookNumber}!"; 
                }
                else 
                {
                    result = book.Author;
                }
            }
            else if (lookup[2] == "title")
            {
                isNumeric = int.TryParse(lookup[3], out bookNumber);
                if (isNumeric)
                {
                    var book = _bookList.GetBook(bookNumber);
                    if (book == null)
                    {
                        result = $"Cannot process, there is no book # {bookNumber}!";
                    }
                    else 
                    {
                        result = book.GetAuthorAndTitle();
                    }
                }
                else
                {
                    result = "Cannot process, book # must be numeric!";
                }
            }
            else
            {
                result = "Cannot process, book # must be numeric!";
            }

            return result;
        }

        private string LookupTitle(string[] lookup)
        {
            var isNumeric = false;
            int bookNumber = 0;
            string result = null;

            isNumeric = int.TryParse(lookup[2], out bookNumber);
            if (isNumeric)
            {
                var book = _bookList.GetBook(bookNumber);
                if (book == null)
                {
                    result = $"Cannot process, there is no book # {bookNumber}!";
                }
                else 
                {
                    result = book.Title;
                }
            }
            else 
            {
                result = "Cannot process, book # must be numeric!";
            }

            return result;
        }
    }
}
