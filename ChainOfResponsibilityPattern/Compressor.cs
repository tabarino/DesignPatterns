using System;

namespace ChainOfResponsibilityPattern
{
    public class Compressor : Handler
    {
        public Compressor(Handler next) : base(next)
        {
        }

        public override bool DoHandle(HttpRequest request)
        {
            Console.WriteLine("Compressing");

            // We have to return false to call the next handler in the chain
            return false;
        }
    }
}
