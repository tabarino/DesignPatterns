using System;

namespace MediatorPattern
{
    public class ListBox : UIControl
    {
        private string _selection;

        public string Selection
        { 
            get => _selection;
            set
            {
                _selection = value;
                base._owner.Changed(this);
            }
        }

        public ListBox(DialogBox owner) : base(owner)
        {
        }
    }
}
