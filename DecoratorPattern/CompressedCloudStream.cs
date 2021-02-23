using System;

namespace DecoratorPattern
{
    public class CompressedCloudStream : Stream
    {
        private readonly Stream _stream;

        public CompressedCloudStream(Stream stream)
        {
            _stream = stream;
        }

        public void Write(string data)
        {
            var compressed = Compress(data);
            _stream.Write(compressed);
        }

        private string Compress(string data)
        {
            return data.Substring(0, 7);
        }
    }
}
