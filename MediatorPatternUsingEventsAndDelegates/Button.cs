using System;

namespace MediatorPatternUsingEventsAndDelegates
{
    public class Button : UIControl
    {
        private bool _isEnabled;

        public bool IsEnabled
        {
            get => _isEnabled;
            set
            {
                _isEnabled = value;
                base.NotifyEventHandlers();
            }
        }
    }
}
