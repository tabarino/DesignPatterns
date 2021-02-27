using System;

namespace ProxyPattern
{
    public class EbookProxy : IEbook
    {
        private readonly string _fileName;
        private Ebook _ebook;

        public string FileName => _fileName;

        public EbookProxy(string fileName)
        {
            _fileName = fileName;
        }

        public void Show()
        {
            if (_ebook == null)
            {
                _ebook = new Ebook(_fileName);
            }

            _ebook.Show();
        }
    }
}
