using System;

namespace StrategyPattern
{
    public class Demo
    {
        public static void Show()
        {
            var imageStorage = new ImageStorage(
                new JpegCompressor(),
                new BlackAndWhiteFilter()
            );

            imageStorage.Store("test.jpg");
        }
    }
}
