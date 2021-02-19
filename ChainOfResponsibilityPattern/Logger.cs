using System;

namespace ChainOfResponsibilityPattern
{
    public class Logger : Handler
    {
        public Logger(Handler next) : base(next)
        {
        }

        public override bool DoHandle(HttpRequest request)
        {
            Console.WriteLine("Logging");

            // We have to return false to call the next handler in the chain
            return false;
        }
    }
}
