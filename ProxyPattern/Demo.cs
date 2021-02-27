using System;

namespace ProxyPattern
{
    public class Demo
    {
        public static void Show()
        {
            var library = new Library();
            var fileNames = new string[] { "Book1", "Book2", "Book3" };

            foreach (var fileName in fileNames)
            {
                library.Add(new EbookProxy(fileName));
            }

            library.OpenEbook("Book1");
            library.OpenEbook("Book2");

            var logFileNames = new string[] { "BookLog1", "BookLog2", "BookLog3" };
            foreach (var logFileName in logFileNames)
            {
                library.Add(new LoggingEbookProxy(logFileName));
            }

            library.OpenEbook("BookLog1");
        }
    }
}
