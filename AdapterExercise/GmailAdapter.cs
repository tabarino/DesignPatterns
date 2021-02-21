using System;
using AdapterExercise.Gmail;

namespace AdapterExercise
{
    public class GmailAdapter : IEmailProvider
    {
        private readonly GmailClient _client;

        public GmailAdapter(GmailClient client)
        {
            _client = client;
        }

        public void DownloadEmails()
        {
            _client.Connect();
            _client.GetEmails();
            _client.Disconnect();
        }
    }
}
