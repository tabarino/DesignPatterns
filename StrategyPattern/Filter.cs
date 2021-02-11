using System;

namespace StrategyPattern
{
    public interface Filter
    {
        void Apply(string fileName);
    }
}
