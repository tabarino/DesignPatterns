using System;

namespace MediatorPattern
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
                base._owner.Changed(this);
            }
        }

        public Button(DialogBox owner) : base(owner)
        {
        }
    }
}
