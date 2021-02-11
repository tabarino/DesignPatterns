using System;

namespace StrategyPatternWithDelegates
{
    public class JpegCompressor
    {
        public void Compress(string fileName)
        {
            Console.WriteLine("Compressing using JPEG");
        }
    }
}
