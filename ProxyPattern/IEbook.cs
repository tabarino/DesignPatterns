using System;

namespace ProxyPattern
{
    public interface IEbook
    {
        string FileName { get; }
        void Show();
    }
}
