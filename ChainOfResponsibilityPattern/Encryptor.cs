using System;

namespace ChainOfResponsibilityPattern
{
    public class Encryptor : Handler
    {
        public Encryptor(Handler next) : base(next)
        {
        }

        public override bool DoHandle(HttpRequest request)
        {
            Console.WriteLine("Encryption");

            // We have to return false to call the next handler in the chain
            return false;
        }
    }
}
