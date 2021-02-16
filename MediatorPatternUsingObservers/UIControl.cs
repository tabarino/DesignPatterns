using System;
using System.Collections.Generic;

namespace MediatorPatternUsingObservers
{
    public abstract class UIControl
    {
        private IList<IEventHandler> _eventHandlers = new List<IEventHandler>();

        public void AddEventHandler(IEventHandler observer)
        {
            _eventHandlers.Add(observer);
        }

        protected void NotifyEventHandlers()
        {
            foreach (var eventHandler in _eventHandlers)
            {
                eventHandler.Handle();
            }
        }
    }
}
