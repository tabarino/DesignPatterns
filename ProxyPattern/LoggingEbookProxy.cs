using System;

namespace ProxyPattern
{
    public class LoggingEbookProxy : IEbook
    {
        private readonly string _fileName;
        private Ebook _ebook;

        public string FileName => _fileName;

        public LoggingEbookProxy(string fileName)
        {
            _fileName = fileName;
        }

        public void Show()
        {
            if (_ebook == null)
            {
                _ebook = new Ebook(_fileName);
            }

            Console.WriteLine("Logging");
            _ebook.Show();
        }
    }
}
