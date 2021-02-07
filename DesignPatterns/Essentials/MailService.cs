using System;

namespace DesignPatterns
{
    public class MailService
    {
        // Just expose methods that need to be accessed from other classes
        // In this example only SendEmail() needs to be public
        // This is called Abstraction

        public void SendEmail()
        {
            Connect();
            Authenticate();
            Console.WriteLine("Send Email");
            Disconnect();
        }

        private void Connect()
        {
            Console.WriteLine("Connect");
        }

        private void Authenticate()
        {
            Console.WriteLine("Authenticate");
        }

        private void Disconnect()
        {
            Console.WriteLine("Disconnect");
        }
    }
}
