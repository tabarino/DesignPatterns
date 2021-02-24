using System;

namespace FacadePattern
{
    public class NotificationService
    {
        public void Send(string message, string target)
        {
            var server = new NotificationServer();
            var conn = server.Connect("127.0.0.1");
            var authToken = server.Authenticate("123", "key123");
            server.Send(authToken, new Message(message), target);
            conn.Disconnect();
        }
    }
}
