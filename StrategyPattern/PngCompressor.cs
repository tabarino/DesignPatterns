using System;

namespace StrategyPattern
{
    public class PngCompressor : Compressor
    {
        public void Compress(string fileName)
        {
            Console.WriteLine("Compressing using PNG");
        }
    }
}
