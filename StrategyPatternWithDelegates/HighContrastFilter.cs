using System;

namespace StrategyPatternWithDelegates
{
    public class HighContrastFilter
    {
        public void Apply(string fileName)
        {
            Console.WriteLine("Applying High Contrast Filter");
        }
    }
}
