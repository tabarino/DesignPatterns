using System;

namespace FacadePattern
{
    public class Message
    {
        private readonly string _content;

        public Message(string content)
        {
            _content = content;
        }
    }
}
