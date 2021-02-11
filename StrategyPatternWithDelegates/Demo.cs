using System;

namespace StrategyPatternWithDelegates
{
    public class Demo
    {
        public static void Show()
        {
            var filter = new BlackAndWhiteFilter();
            Action<string> filterHandler = filter.Apply;

            var compressor = new JpegCompressor();
            Action<string> compressorHandler = compressor.Compress;

            var imageStorage = new ImageStorage();
            imageStorage.Store("test.jpg", filterHandler, compressorHandler);
        }
    }
}
