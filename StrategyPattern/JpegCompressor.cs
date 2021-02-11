using System;

namespace StrategyPattern
{
    public class JpegCompressor : Compressor
    {
        public void Compress(string fileName)
        {
            Console.WriteLine("Compressing using JPEG");
        }
    }
}
