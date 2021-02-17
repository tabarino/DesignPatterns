using System;

namespace MediatorPatternUsingEventsAndDelegates
{
    public abstract class UIControl
    {
        public event EventHandler ArticlesEventHandlers;

        protected void NotifyEventHandlers()
        {
            OnArticlesEventHandlers();
        }

        protected virtual void OnArticlesEventHandlers()
        {
            if (ArticlesEventHandlers != null)
            {
                ArticlesEventHandlers(this, EventArgs.Empty);
            }
        }
    }
}
