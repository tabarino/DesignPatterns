using System;

namespace StrategyExercise
{
    public class ChatClient
    {
        private readonly Func<string, string> _encryptor;

        public ChatClient(Func<string, string> encryptor)
        {
            _encryptor = encryptor;
        }

        public void Send(string message)
        {
            var encryptedMessage = _encryptor(message);
            Console.WriteLine("Sending the encrypted message...");
        }
    }
}
