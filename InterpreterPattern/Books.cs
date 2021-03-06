using System;

namespace InterpreterPattern
{
    public class Books
    {
        public string Author { get; private set; }
        public string Title { get; private set; }

        public Books(string author, string title)
        {
            Author = author;
            Title = title;
        }

        public string GetAuthorAndTitle()
        {
            return $"{Title} by {Author}";
        }
    }
}
