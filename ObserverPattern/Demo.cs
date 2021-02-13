using System;

namespace ObserverPattern
{
    public class Demo
    {
        public static void Show()
        {
            var dataSource = new DataSource();

            // Push Style
            //var sheet1 = new SpreadSheet();
            //var sheet2 = new SpreadSheet();
            //var chart = new Chart();

            // Pull Style - It is more flexible, therefore is considered a better approach
            var sheet1 = new SpreadSheet(dataSource);
            var sheet2 = new SpreadSheet(dataSource);
            var chart = new Chart(dataSource);

            dataSource.AddObserver(sheet1);
            dataSource.AddObserver(sheet2);
            dataSource.AddObserver(chart);

            dataSource.Value = 1;
        }
    }
}
