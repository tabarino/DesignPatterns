using System;

namespace InterpreterPattern
{
    public class Demo
    {
        public static void Show()
        {
            var bookList = new BookList();
            var book1 = new Books("Larry Truett", ".Net for Cats");
            var book2 = new Books("Taba Tabara", "MySQL for Cats");
            bookList.AddBook(book1);
            bookList.AddBook(book2);

            var interpreter = new Interpreter(bookList);

            Console.WriteLine("Test 1 - invalid request missing 'book'");
            Console.WriteLine(interpreter.Interpret("author 1"));
            Console.WriteLine();

            Console.WriteLine("Test 2 - valid book author request");
            Console.WriteLine(interpreter.Interpret("book author 1"));
            Console.WriteLine();

            Console.WriteLine("Test 3 - valid book title request");
            Console.WriteLine(interpreter.Interpret("book title 2"));
            Console.WriteLine();

            Console.WriteLine("Test 4 - valid book author title request");
            Console.WriteLine(interpreter.Interpret("book author title 1"));
            Console.WriteLine();

            Console.WriteLine("Test 5 - invalid request with invalid book number");
            Console.WriteLine(interpreter.Interpret("book title 3"));
            Console.WriteLine();

            Console.WriteLine("Test 6 - invalid request with no numeric book number");
            Console.WriteLine(interpreter.Interpret("book title one"));
            Console.WriteLine();
        }
    }
}
