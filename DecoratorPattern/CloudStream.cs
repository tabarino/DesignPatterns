using System;

namespace DecoratorPattern
{
    public class CloudStream : Stream
    {
        public void Write(string data)
        {
            Console.WriteLine($"Storing {data}");
        }
    }
}
