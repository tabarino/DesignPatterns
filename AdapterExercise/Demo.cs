using System;
using AdapterExercise.Gmail;

namespace AdapterExercise
{
    public class Demo
    {
        public static void Show()
        {
            var emailClient = new EmailClient();
            emailClient.AddProvider(new GmailAdapter(new GmailClient()));
            emailClient.DownloadEmails();
        }
    }
}
