using System;

namespace StrategyPattern
{
    public class BlackAndWhiteFilter : Filter
    {
        public void Apply(string fileName)
        {
            Console.WriteLine("Applying B&W Filter");
        }
    }
}
