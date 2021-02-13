using System;

namespace ObserverPattern
{
    public class DataSource : Subject
    {
        private int _value;

        public int Value
        {
            get => _value;
            set
            {
                _value = value;

                // Push Style
                //base.NotifyObservers(value);

                // Pull Style - It is more flexible, therefore is considered a better approach
                base.NotifyObservers();
            }
        }
    }
}
