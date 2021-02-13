using System;

namespace ObserverPattern
{
    public class SpreadSheet : IObserver
    {
        // Pull Style - It is more flexible, therefore is considered a better approach
        private readonly DataSource _dataSource;

        // Pull Style - It is more flexible, therefore is considered a better approach
        public SpreadSheet(DataSource dataSource)
        {
            _dataSource = dataSource;
        }

        // Push Style
        //public void Update(int value)
        //{
        //    Console.WriteLine($"Spreadsheet got notified: {value}");
        //}

        // Pull Style - It is more flexible, therefore is considered a better approach
        public void Update()
            {
                Console.WriteLine($"Spreadsheet got notified: {_dataSource.Value}");
            }
        }
}
