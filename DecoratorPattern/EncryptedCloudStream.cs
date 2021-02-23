using System;
using System.Text;

namespace DecoratorPattern
{
    public class EncryptedCloudStream : Stream
    {
        private readonly Stream _stream;

        public EncryptedCloudStream(Stream stream)
        {
            _stream = stream;
        }

        public void Write(string data)
        {
            var encrypted = Encrypt(data);
            _stream.Write(encrypted);
        }

        private string Encrypt(string data)
        {
            var plainTextBytes = Encoding.UTF8.GetBytes(data);
            return Convert.ToBase64String(plainTextBytes);
        }
    }
}
