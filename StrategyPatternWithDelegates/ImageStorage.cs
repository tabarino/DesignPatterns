using System;

namespace StrategyPatternWithDelegates
{
    public class ImageStorage
    {
        public void Store(string fileName, Action<string> compressor, Action<string> filter)
        {
            compressor(fileName);
            filter(fileName);
        }
    }
}
