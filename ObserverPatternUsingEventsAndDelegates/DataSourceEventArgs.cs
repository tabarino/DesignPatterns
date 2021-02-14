using System;

namespace ObserverPatternUsingEventsAndDelegates
{
    public class DataSourceEventArgs : EventArgs
    {
        public DataSource DataSource { get; set; }
    }
}
