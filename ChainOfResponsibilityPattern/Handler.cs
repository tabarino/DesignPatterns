using System;

namespace ChainOfResponsibilityPattern
{
    public abstract class Handler
    {
        private Handler _next;

        public Handler(Handler next)
        {
            _next = next;
        }

        public abstract bool DoHandle(HttpRequest request);

        public void Handle(HttpRequest request)
        {
            if (DoHandle(request))
            {
                return;
            }

            if (_next != null)
            {
                _next.Handle(request);
            }
        }
    }
}
