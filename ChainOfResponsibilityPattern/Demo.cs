using System;

namespace ChainOfResponsibilityPattern
{
    public class Demo
    {
        public static void Show()
        {
            var encryptor = new Encryptor(null);
            var compressor = new Compressor(encryptor);
            var logger = new Logger(compressor);
            var authenticator = new Authenticator(logger);
            var server = new WebServer(authenticator);
            server.Handle(new HttpRequest("admin", "1234"));
        }
    }
}
