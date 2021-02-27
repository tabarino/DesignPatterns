using System;

namespace ProxyPattern
{
    public class Ebook : IEbook
    {
        private readonly string _fileName;

        public string FileName => _fileName;

        public Ebook(string fileName)
        {
            _fileName = fileName;
            Load();
        }

        public void Show()
        {
            Console.WriteLine($"Showing the ebook {FileName}");
        }

        private void Load()
        {
            Console.WriteLine($"Loading the ebook {FileName}");
        }
    }
}
