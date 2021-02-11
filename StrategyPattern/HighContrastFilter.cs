using System;

namespace StrategyPattern
{
    public class HighContrastFilter : Filter
    {
        public void Apply(string fileName)
        {
            Console.WriteLine("Applying High Contrast Filter");
        }
    }
}
