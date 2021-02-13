using System;

namespace ObserverPattern
{
    public class Chart : IObserver
    {
        // Pull Style - It is more flexible, therefore is considered a better approach
        private readonly DataSource _dataSource;

        // Pull Style - It is more flexible, therefore is considered a better approach
        public Chart(DataSource dataSource)
        {
            _dataSource = dataSource;
        }

        // Push Style
        //public void Update(int value)
        //{
        //    Console.WriteLine($"Chart got updated: {value}");
        //}

        // Pull Style - It is more flexible, therefore is considered a better approach
        public void Update()
        {
            Console.WriteLine($"Chart got updated: {_dataSource.Value}");
        }
    }
}
