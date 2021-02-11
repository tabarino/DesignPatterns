using System;

namespace StrategyPatternWithDelegates
{
    public class BlackAndWhiteFilter
    {
        public void Apply(string fileName)
        {
            Console.WriteLine("Applying B&W Filter");
        }
    }
}
