using System;
using System.Collections.Generic;

namespace AdapterExercise
{
    public class EmailClient
    {
        private IList<IEmailProvider> _emailProviders = new List<IEmailProvider>();

        public void AddProvider(IEmailProvider emailProvider)
        {
            _emailProviders.Add(emailProvider);
        }

        public void DownloadEmails()
        {
            foreach (var emailProvider in _emailProviders)
            {
                emailProvider.DownloadEmails();
            }
        }
    }
}
