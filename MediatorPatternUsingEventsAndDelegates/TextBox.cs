using System;

namespace MediatorPatternUsingEventsAndDelegates
{
    public class TextBox : UIControl
    {
        private string _content;

        public string Content
        {
            get => _content;
            set
            {
                _content = value;
                base.NotifyEventHandlers();
            } 
        }
    }
}
