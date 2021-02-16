using System;

namespace MediatorPattern
{
    public class UIControl
    {
        protected readonly DialogBox _owner;

        public UIControl(DialogBox owner)
        {
            _owner = owner;
        }
    }
}
