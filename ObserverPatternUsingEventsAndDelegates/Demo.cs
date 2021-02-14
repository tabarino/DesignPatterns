using System;

namespace ObserverPatternUsingEventsAndDelegates
{
    public class Demo
    {
        public static void Show()
        {
            var dataSource = new DataSource();
            var sheet1 = new SpreadSheet();
            var sheet2 = new SpreadSheet();
            var chart = new Chart();

            dataSource.DataSourceUpdated += sheet1.OnDataSourceUpdated;
            dataSource.DataSourceUpdated += sheet2.OnDataSourceUpdated;
            dataSource.DataSourceUpdated += chart.OnDataSourceUpdated;

            dataSource.Value = 1;
        }
    }
}
