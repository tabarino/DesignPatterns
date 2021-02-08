using System;

namespace IteratorPattern
{
    public interface Iterator<T>
    {
        T Current();

        bool HasNext();

        void Next();
    }
}
