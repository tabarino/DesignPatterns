using System;

namespace ChainOfResponsibilityPattern
{
    public class Authenticator : Handler
    {
        public Authenticator(Handler next) : base(next)
        {
        }

        public override bool DoHandle(HttpRequest request)
        {
            Console.WriteLine("Authentication");

            var isValid = (request.Username == "admin" && request.Password == "1234");

            // We have to return false to call the next handler in the chain
            return !isValid;
        }
    }
}
