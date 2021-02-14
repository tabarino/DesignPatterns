using System;

namespace ObserverPatternUsingEventsAndDelegates
{
    public class SpreadSheet
    {
        public void OnDataSourceUpdated(object source, DataSourceEventArgs args)
        {
            Console.WriteLine($"Spreadsheet got notified: {args.DataSource.Value}");
        }
    }
}
