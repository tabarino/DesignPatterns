using System;

namespace MediatorPatternUsingObservers
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
