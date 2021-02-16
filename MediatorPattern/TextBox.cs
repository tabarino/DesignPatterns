using System;

namespace MediatorPattern
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
                base._owner.Changed(this);
            } 
        }

        public TextBox(DialogBox owner) : base(owner)
        {
        }
    }
}
