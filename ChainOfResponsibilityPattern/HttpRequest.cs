using System;

namespace ChainOfResponsibilityPattern
{
    public class HttpRequest
    {
        private readonly string _username;
        private readonly string _password;

        public string Username => _username;
        public string Password => _password;

        public HttpRequest(string username, string password)
        {
            _username = username;
            _password = password;
        }
    }
}
