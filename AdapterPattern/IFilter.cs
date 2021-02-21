using System;

namespace AdapterPattern
{
    public interface IFilter
    {
        void Apply(Image image);
    }
}
