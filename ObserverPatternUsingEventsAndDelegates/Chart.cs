using System;

namespace ObserverPatternUsingEventsAndDelegates
{
    public class Chart
    {
        public void OnDataSourceUpdated(object source, DataSourceEventArgs args)
        {
            Console.WriteLine($"Chart got updated: {args.DataSource.Value}");
        }
    }
}
