using System;

namespace StrategyExercise
{
    public class Demo
    {
        public static void Show()
        {
            var encrypt = new Des();
            Func<string, string> encryptHandler = encrypt.Encryptor;

            var chatClient = new ChatClient(encryptHandler);
            chatClient.Send("Hello World");
        }
    }
}
